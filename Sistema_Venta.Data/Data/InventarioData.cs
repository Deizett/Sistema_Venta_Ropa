using Sistema_Venta.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Venta.Data
{
    public class InventarioData

        {
  
            public List<InventarioMovimiento> Listar()
            {
                var lista = new List<InventarioMovimiento>();

                using (SqlConnection con = Conexion.GetConnection())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"
                    SELECT IM.*, P.Nombre AS ProductoNombre
                    FROM InventarioMovimiento IM
                    INNER JOIN Producto P ON IM.IdProducto = P.IdProducto
                    ORDER BY IM.Fecha DESC", con);

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        lista.Add(new InventarioMovimiento
                        {
                            IdMovimiento = Convert.ToInt32(dr["IdMovimiento"]),
                            IdProducto = Convert.ToInt32(dr["IdProducto"]),
                            Fecha = Convert.ToDateTime(dr["Fecha"]),
                            TipoMovimiento = dr["TipoMovimiento"].ToString(),
                            Cantidad = Convert.ToInt32(dr["Cantidad"]),
                            StockAntes = Convert.ToInt32(dr["StockAntes"]),
                            StockDespues = Convert.ToInt32(dr["StockDespues"]),
                            ReferenciaTipo = dr["ReferenciaTipo"] == DBNull.Value ? string.Empty : dr["ReferenciaTipo"].ToString(),
                            ReferenciaId = dr["ReferenciaId"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ReferenciaId"]),
                            Observacion = dr["Observacion"] == DBNull.Value ? string.Empty : dr["Observacion"].ToString(),
                            ProductoNombre = dr["ProductoNombre"].ToString()
                        });
                    }
                }

                return lista;
            }

          
            public List<InventarioMovimiento> ListarPorProducto(int idProducto)
            {
                var lista = new List<InventarioMovimiento>();

                using (SqlConnection con = Conexion.GetConnection())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"
                    SELECT IM.*, P.Nombre AS ProductoNombre
                    FROM InventarioMovimiento IM
                    INNER JOIN Producto P ON IM.IdProducto = P.IdProducto
                    WHERE IM.IdProducto = @IdProducto
                    ORDER BY IM.Fecha DESC", con);

                    cmd.Parameters.AddWithValue("@IdProducto", idProducto);

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        lista.Add(new InventarioMovimiento
                        {
                            IdMovimiento = Convert.ToInt32(dr["IdMovimiento"]),
                            IdProducto = Convert.ToInt32(dr["IdProducto"]),
                            Fecha = Convert.ToDateTime(dr["Fecha"]),
                            TipoMovimiento = dr["TipoMovimiento"].ToString(),
                            Cantidad = Convert.ToInt32(dr["Cantidad"]),
                            StockAntes = Convert.ToInt32(dr["StockAntes"]),
                            StockDespues = Convert.ToInt32(dr["StockDespues"]),
                            ReferenciaTipo = dr["ReferenciaTipo"] == DBNull.Value ? string.Empty : dr["ReferenciaTipo"].ToString(),
                            ReferenciaId = dr["ReferenciaId"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ReferenciaId"]),
                            Observacion = dr["Observacion"] == DBNull.Value ? string.Empty : dr["Observacion"].ToString(),
                            ProductoNombre = dr["ProductoNombre"].ToString()
                        });
                    }
                }

                return lista;
            }

       
            public bool InsertarMovimiento(InventarioMovimiento mov)
            {
                using (SqlConnection con = Conexion.GetConnection())
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand(@"
                    INSERT INTO InventarioMovimiento 
                    (IdProducto, Fecha, TipoMovimiento, Cantidad, StockAntes, StockDespues, ReferenciaTipo, ReferenciaId, Observacion)
                    VALUES 
                    (@IdProducto, @Fecha, @TipoMovimiento, @Cantidad, @StockAntes, @StockDespues, @ReferenciaTipo, @ReferenciaId, @Observacion)", con);

                    cmd.Parameters.AddWithValue("@IdProducto", mov.IdProducto);
                    cmd.Parameters.AddWithValue("@Fecha", mov.Fecha);
                    cmd.Parameters.AddWithValue("@TipoMovimiento", mov.TipoMovimiento);
                    cmd.Parameters.AddWithValue("@Cantidad", mov.Cantidad);
                    cmd.Parameters.AddWithValue("@StockAntes", mov.StockAntes);
                    cmd.Parameters.AddWithValue("@StockDespues", mov.StockDespues);
                    cmd.Parameters.AddWithValue("@ReferenciaTipo", mov.ReferenciaTipo ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@ReferenciaId", mov.ReferenciaId);
                    cmd.Parameters.AddWithValue("@Observacion", mov.Observacion ?? (object)DBNull.Value);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }


