using Sistema_Venta.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Venta.Data
{
    public class CompraData
    {
            
            public bool RegistrarCompra(Compra compra, List<DetalleCompra> detalles)
            {
                bool exito = false;

                using (SqlConnection con = Conexion.GetConnection())
                {
                    con.Open();
                    SqlTransaction tx = con.BeginTransaction();

                    try
                    {
         
                        SqlCommand cmdCompra = new SqlCommand(@"
                        INSERT INTO Compra (Fecha, IdProveedor, Total, Observaciones)
                        OUTPUT INSERTED.IdCompra
                        VALUES (@Fecha, @IdProveedor, @Total, @Observaciones)", con, tx);

                        cmdCompra.Parameters.AddWithValue("@Fecha", compra.Fecha);
                        cmdCompra.Parameters.AddWithValue("@IdProveedor", (object)compra.IdProveedor ?? DBNull.Value);
                        cmdCompra.Parameters.AddWithValue("@Total", compra.Total);
                        cmdCompra.Parameters.AddWithValue("@Observaciones", compra.Observaciones ?? (object)DBNull.Value);

                        int idCompra = Convert.ToInt32(cmdCompra.ExecuteScalar());

                    
                        foreach (var d in detalles)
                        {
                            SqlCommand cmdDet = new SqlCommand(@"
                            INSERT INTO DetalleCompra (IdCompra, IdProducto, Cantidad, PrecioUnitario)
                            VALUES (@IdCompra, @IdProducto, @Cantidad, @PrecioUnitario)", con, tx);

                            cmdDet.Parameters.AddWithValue("@IdCompra", idCompra);
                            cmdDet.Parameters.AddWithValue("@IdProducto", d.IdProducto);
                            cmdDet.Parameters.AddWithValue("@Cantidad", d.Cantidad);
                            cmdDet.Parameters.AddWithValue("@PrecioUnitario", d.PrecioUnitario);
                            cmdDet.ExecuteNonQuery();

                        
                            SqlCommand cmdStock = new SqlCommand(@"
                            UPDATE Producto
                            SET Stock = Stock + @Cantidad
                            WHERE IdProducto = @IdProducto", con, tx);

                            cmdStock.Parameters.AddWithValue("@Cantidad", d.Cantidad);
                            cmdStock.Parameters.AddWithValue("@IdProducto", d.IdProducto);
                            cmdStock.ExecuteNonQuery();

                            SqlCommand cmdInv = new SqlCommand(@"
                            INSERT INTO InventarioMovimiento (IdProducto, TipoMovimiento, Cantidad, StockAntes, StockDespues, ReferenciaTipo, ReferenciaId, Observacion)
                            SELECT @IdProducto, 'ENTRADA', @Cantidad, 
                                   (Stock - @Cantidad), Stock, 'COMPRA', @IdCompra, 'Entrada por compra'
                            FROM Producto WHERE IdProducto=@IdProducto", con, tx);

                            cmdInv.Parameters.AddWithValue("@IdProducto", d.IdProducto);
                            cmdInv.Parameters.AddWithValue("@Cantidad", d.Cantidad);
                            cmdInv.Parameters.AddWithValue("@IdCompra", idCompra);
                            cmdInv.ExecuteNonQuery();
                        }

                        tx.Commit();
                        exito = true;
                    }
                    catch (Exception)
                    {
                        tx.Rollback();
                        throw;
                    }
                }

                return exito;
            }

          
            public List<Compra> Listar()
            {
                var lista = new List<Compra>();

                using (SqlConnection con = Conexion.GetConnection())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"
                    SELECT C.*, P.RazonSocial AS ProveedorNombre
                    FROM Compra C
                    LEFT JOIN Proveedor P ON C.IdProveedor = P.IdProveedor
                    ORDER BY C.Fecha DESC", con);

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        lista.Add(new Compra
                        {
                            IdCompra = Convert.ToInt32(dr["IdCompra"]),
                            Fecha = Convert.ToDateTime(dr["Fecha"]),
                            IdProveedor = dr["IdProveedor"] == DBNull.Value ? null : Convert.ToInt32(dr["IdProveedor"]),
                            Total = Convert.ToDecimal(dr["Total"]),
                            Observaciones = dr["Observaciones"].ToString(),
                            ProveedorNombre = dr["ProveedorNombre"].ToString()
                        });
                    }
                }

                return lista;
            }

     
            public List<DetalleCompra> ObtenerDetalles(int idCompra)
            {
                var lista = new List<DetalleCompra>();

                using (SqlConnection con = Conexion.GetConnection())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"
                    SELECT DC.*, P.Nombre AS ProductoNombre
                    FROM DetalleCompra DC
                    INNER JOIN Producto P ON DC.IdProducto = P.IdProducto
                    WHERE IdCompra = @IdCompra", con);

                    cmd.Parameters.AddWithValue("@IdCompra", idCompra);
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        lista.Add(new DetalleCompra
                        {
                            IdDetalleCompra = Convert.ToInt32(dr["IdDetalleCompra"]),
                            IdCompra = Convert.ToInt32(dr["IdCompra"]),
                            IdProducto = Convert.ToInt32(dr["IdProducto"]),
                            Cantidad = Convert.ToInt32(dr["Cantidad"]),
                            PrecioUnitario = Convert.ToDecimal(dr["PrecioUnitario"]),
                            ProductoNombre = dr["ProductoNombre"].ToString()
                        });
                    }
                }

                return lista;
            }

           
            public bool Eliminar(int idCompra)
            {
                using (SqlConnection con = Conexion.GetConnection())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Compra WHERE IdCompra=@IdCompra", con);
                    cmd.Parameters.AddWithValue("@IdCompra", idCompra);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }

