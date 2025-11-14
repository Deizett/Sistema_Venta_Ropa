using Sistema_Venta.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Venta.Data
{
    public class PagoData
    {
           
            public bool RegistrarPago(Pago pago)
            {
                using (SqlConnection con = Conexion.GetConnection())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"
                    INSERT INTO Pago (IdVenta, FechaPago, Monto, MetodoPago, NumeroOperacion, Observacion)
                    VALUES (@IdVenta, @FechaPago, @Monto, @MetodoPago, @NumeroOperacion, @Observacion)", con);

                    cmd.Parameters.AddWithValue("@IdVenta", pago.IdVenta);
                    cmd.Parameters.AddWithValue("@FechaPago", pago.FechaPago);
                    cmd.Parameters.AddWithValue("@Monto", pago.Monto);
                    cmd.Parameters.AddWithValue("@MetodoPago", pago.MetodoPago ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@NumeroOperacion", pago.NumeroOperacion ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Observacion", pago.Observacion ?? (object)DBNull.Value);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }

    
            public List<Pago> Listar()
            {
                var lista = new List<Pago>();

                using (SqlConnection con = Conexion.GetConnection())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"
                    SELECT P.*, V.Numero AS NumeroVenta
                    FROM Pago P
                    INNER JOIN Venta V ON P.IdVenta = V.IdVenta
                    ORDER BY P.FechaPago DESC", con);

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        lista.Add(new Pago
                        {
                            IdPago = Convert.ToInt32(dr["IdPago"]),
                            IdVenta = Convert.ToInt32(dr["IdVenta"]),
                            FechaPago = Convert.ToDateTime(dr["FechaPago"]),
                            Monto = Convert.ToDecimal(dr["Monto"]),
                            MetodoPago = dr["MetodoPago"] == DBNull.Value ? string.Empty : dr["MetodoPago"].ToString(),
                            NumeroOperacion = dr["NumeroOperacion"] == DBNull.Value ? string.Empty : dr["NumeroOperacion"].ToString(),
                            Observacion = dr["Observacion"] == DBNull.Value ? string.Empty : dr["Observacion"].ToString(),
                            NumeroVenta = dr["NumeroVenta"] == DBNull.Value ? string.Empty : dr["NumeroVenta"].ToString()
                        });
                    }
                }

                return lista;
            }


            public List<Pago> ObtenerPagosPorVenta(int idVenta)
            {
                var lista = new List<Pago>();

                using (SqlConnection con = Conexion.GetConnection())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"
                    SELECT * FROM Pago WHERE IdVenta = @IdVenta
                    ORDER BY FechaPago DESC", con);

                    cmd.Parameters.AddWithValue("@IdVenta", idVenta);
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        lista.Add(new Pago
                        {
                            IdPago = Convert.ToInt32(dr["IdPago"]),
                            IdVenta = Convert.ToInt32(dr["IdVenta"]),
                            FechaPago = Convert.ToDateTime(dr["FechaPago"]),
                            Monto = Convert.ToDecimal(dr["Monto"]),
                            MetodoPago = dr["MetodoPago"] == DBNull.Value ? string.Empty : dr["MetodoPago"].ToString(),
                            NumeroOperacion = dr["NumeroOperacion"] == DBNull.Value ? string.Empty : dr["NumeroOperacion"].ToString(),
                            Observacion = dr["Observacion"] == DBNull.Value ? string.Empty : dr["Observacion"].ToString()
                        });
                    }
                }

                return lista;
            }

            public bool Eliminar(int idPago)
            {
                using (SqlConnection con = Conexion.GetConnection())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Pago WHERE IdPago=@IdPago", con);
                    cmd.Parameters.AddWithValue("@IdPago", idPago);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }


