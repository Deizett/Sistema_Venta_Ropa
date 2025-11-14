using Sistema_Venta.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sistema_Venta.Data
{


    public class VentaData
    {
       
        public bool RegistrarVenta(Venta venta, List<DetalleVenta> detalles)
        {
            bool exito = false;

            using (SqlConnection con = Conexion.GetConnection())
            {
                con.Open();
                SqlTransaction tx = con.BeginTransaction();

                try
                {
                    
                    SqlCommand cmdVenta = new SqlCommand(@"
                    INSERT INTO Venta (Fecha, IdCliente, IdUsuario, TipoComprobante, Serie, Numero, Total, Estado)
                    OUTPUT INSERTED.IdVenta
                    VALUES (@Fecha, @IdCliente, @IdUsuario, @TipoComprobante, @Serie, @Numero, @Total, @Estado)", con, tx);

                    cmdVenta.Parameters.AddWithValue("@Fecha", venta.Fecha);
                    cmdVenta.Parameters.AddWithValue("@IdCliente", (object)venta.IdCliente ?? DBNull.Value);
                    cmdVenta.Parameters.AddWithValue("@IdUsuario", venta.IdUsuario);
                    cmdVenta.Parameters.AddWithValue("@TipoComprobante", venta.TipoComprobante);
                    cmdVenta.Parameters.AddWithValue("@Serie", (object)venta.Serie ?? DBNull.Value);
                    cmdVenta.Parameters.AddWithValue("@Numero", venta.Numero);
                    cmdVenta.Parameters.AddWithValue("@Total", venta.Total);
                    cmdVenta.Parameters.AddWithValue("@Estado", venta.Estado);

                    int idVenta = Convert.ToInt32(cmdVenta.ExecuteScalar());

                   
                    foreach (var d in detalles)
                    {
                        SqlCommand cmdDet = new SqlCommand(@"
                        INSERT INTO DetalleVenta (IdVenta, IdProducto, Cantidad, PrecioUnitario, Descuento)
                        VALUES (@IdVenta, @IdProducto, @Cantidad, @PrecioUnitario, @Descuento)", con, tx);

                        cmdDet.Parameters.AddWithValue("@IdVenta", idVenta);
                        cmdDet.Parameters.AddWithValue("@IdProducto", d.IdProducto);
                        cmdDet.Parameters.AddWithValue("@Cantidad", d.Cantidad);
                        cmdDet.Parameters.AddWithValue("@PrecioUnitario", d.PrecioUnitario);
                        cmdDet.Parameters.AddWithValue("@Descuento", d.Descuento);
                        cmdDet.ExecuteNonQuery();

                        
                        SqlCommand cmdStock = new SqlCommand(@"
                        UPDATE Producto
                        SET Stock = Stock - @Cantidad
                        WHERE IdProducto = @IdProducto", con, tx);

                        cmdStock.Parameters.AddWithValue("@Cantidad", d.Cantidad);
                        cmdStock.Parameters.AddWithValue("@IdProducto", d.IdProducto);
                        cmdStock.ExecuteNonQuery();
                    }

                    tx.Commit();
                    exito = true;
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    throw new Exception("Error al registrar la venta: " + ex.Message);
                }
            }

            return exito;
        }

        
        public List<Venta> Listar()
        {
            var lista = new List<Venta>();
            using (SqlConnection con = Conexion.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(@"
                SELECT V.*, C.Nombre AS ClienteNombre, U.NombreCompleto AS UsuarioNombre
                FROM Venta V
                LEFT JOIN Cliente C ON V.IdCliente = C.IdCliente
                INNER JOIN Usuario U ON V.IdUsuario = U.IdUsuario
                ORDER BY V.Fecha DESC", con);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Venta
                    {
                        IdVenta = Convert.ToInt32(dr["IdVenta"]),
                        Fecha = Convert.ToDateTime(dr["Fecha"]),
                        TipoComprobante = dr["TipoComprobante"].ToString(),
                        Serie = dr["Serie"] != DBNull.Value ? dr["Serie"].ToString() : "",
                        Numero = dr["Numero"] != DBNull.Value ? Convert.ToInt32(dr["Numero"]) : 0,
                        Total = Convert.ToDecimal(dr["Total"]),
                        Estado = dr["Estado"].ToString(),
                        ClienteNombre = dr["ClienteNombre"] != DBNull.Value ? dr["ClienteNombre"].ToString() : "",
                        UsuarioNombre = dr["UsuarioNombre"].ToString()
                    });
                }
            }
            return lista;
        }

        
        public List<DetalleVenta> ObtenerDetalles(int idVenta)
        {
            var lista = new List<DetalleVenta>();

            using (SqlConnection con = Conexion.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(@"
                SELECT DV.*, P.Nombre AS ProductoNombre
                FROM DetalleVenta DV
                INNER JOIN Producto P ON DV.IdProducto = P.IdProducto
                WHERE IdVenta = @IdVenta", con);

                cmd.Parameters.AddWithValue("@IdVenta", idVenta);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new DetalleVenta
                    {
                        IdDetalleVenta = Convert.ToInt32(dr["IdDetalleVenta"]),
                        IdVenta = Convert.ToInt32(dr["IdVenta"]),
                        IdProducto = Convert.ToInt32(dr["IdProducto"]),
                        Cantidad = Convert.ToInt32(dr["Cantidad"]),
                        PrecioUnitario = Convert.ToDecimal(dr["PrecioUnitario"]),
                        Descuento = Convert.ToDecimal(dr["Descuento"]),
                        ProductoNombre = dr["ProductoNombre"].ToString()
                    });
                }
            }

            return lista;
        }

       
        public bool AnularVenta(int idVenta)
        {
            using (SqlConnection con = Conexion.GetConnection())
            {
                con.Open();
                SqlTransaction tx = con.BeginTransaction();

                try
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Venta SET Estado='ANULADA' WHERE IdVenta=@IdVenta", con, tx);
                    cmd.Parameters.AddWithValue("@IdVenta", idVenta);
                    cmd.ExecuteNonQuery();

                    SqlCommand cmdDetalles = new SqlCommand("SELECT IdProducto, Cantidad FROM DetalleVenta WHERE IdVenta=@IdVenta", con, tx);
                    cmdDetalles.Parameters.AddWithValue("@IdVenta", idVenta);
                    SqlDataReader dr = cmdDetalles.ExecuteReader();

                    var detalles = new List<(int IdProducto, int Cantidad)>();
                    while (dr.Read())
                        detalles.Add((Convert.ToInt32(dr["IdProducto"]), Convert.ToInt32(dr["Cantidad"])));
                    dr.Close();

                    foreach (var d in detalles)
                    {
                        SqlCommand cmdStock = new SqlCommand(@"
                        UPDATE Producto
                        SET Stock = Stock + @Cantidad
                        WHERE IdProducto=@IdProducto", con, tx);

                        cmdStock.Parameters.AddWithValue("@Cantidad", d.Cantidad);
                        cmdStock.Parameters.AddWithValue("@IdProducto", d.IdProducto);
                        cmdStock.ExecuteNonQuery();
                    }

                    tx.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    throw new Exception("Error al anular venta: " + ex.Message);
                }

            }
        }

    }
}

