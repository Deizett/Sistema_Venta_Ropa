using Sistema_Venta.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Venta.Data
{
    public class ProductoData
    {
          
            public List<Producto> Listar()
            {
                var lista = new List<Producto>();

                using (SqlConnection con = Conexion.GetConnection())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Producto", con);
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        lista.Add(new Producto
                        {
                            IdProducto = Convert.ToInt32(dr["IdProducto"]),
                            Codigo = dr["Codigo"].ToString(),
                            Nombre = dr["Nombre"].ToString(),
                            Descripcion = dr["Descripcion"].ToString(),
                            IdCategoria = Convert.ToInt32(dr["IdCategoria"]),
                            IdProveedor = Convert.ToInt32(dr["IdProveedor"]),
                            PrecioCompra = Convert.ToDecimal(dr["PrecioCompra"]),
                            PrecioVenta = Convert.ToDecimal(dr["PrecioVenta"]),
                            Stock = Convert.ToInt32(dr["Stock"]),
                            StockMinimo = Convert.ToInt32(dr["StockMinimo"]),
                            Activo = Convert.ToBoolean(dr["Activo"]),
                            FechaCreacion = Convert.ToDateTime(dr["FechaCreacion"])
                        });
                    }
                }

                return lista;
            }

           
            public bool Insertar(Producto p)
            {
                using (SqlConnection con = Conexion.GetConnection())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"
                    INSERT INTO Producto (Codigo, Nombre, Descripcion, IdCategoria, IdProveedor, PrecioCompra, PrecioVenta, Stock, StockMinimo, Activo)
                    VALUES (@Codigo, @Nombre, @Descripcion, @IdCategoria, @IdProveedor, @PrecioCompra, @PrecioVenta, @Stock, @StockMinimo, @Activo)", con);

                    cmd.Parameters.AddWithValue("@Codigo", p.Codigo);
                    cmd.Parameters.AddWithValue("@Nombre", p.Nombre);
                    cmd.Parameters.AddWithValue("@Descripcion", p.Descripcion);
                    cmd.Parameters.AddWithValue("@IdCategoria", p.IdCategoria);
                    cmd.Parameters.AddWithValue("@IdProveedor", p.IdProveedor);
                    cmd.Parameters.AddWithValue("@PrecioCompra", p.PrecioCompra);
                    cmd.Parameters.AddWithValue("@PrecioVenta", p.PrecioVenta);
                    cmd.Parameters.AddWithValue("@Stock", p.Stock);
                    cmd.Parameters.AddWithValue("@StockMinimo", p.StockMinimo);
                    cmd.Parameters.AddWithValue("@Activo", p.Activo);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }

            public bool Actualizar(Producto p)
            {
                using (SqlConnection con = Conexion.GetConnection())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"
                    UPDATE Producto SET 
                        Codigo=@Codigo,
                        Nombre=@Nombre,
                        Descripcion=@Descripcion,
                        IdCategoria=@IdCategoria,
                        IdProveedor=@IdProveedor,
                        PrecioCompra=@PrecioCompra,
                        PrecioVenta=@PrecioVenta,
                        Stock=@Stock,
                        StockMinimo=@StockMinimo,
                        Activo=@Activo
                    WHERE IdProducto=@IdProducto", con);

                    cmd.Parameters.AddWithValue("@IdProducto", p.IdProducto);
                    cmd.Parameters.AddWithValue("@Codigo", p.Codigo);
                    cmd.Parameters.AddWithValue("@Nombre", p.Nombre);
                    cmd.Parameters.AddWithValue("@Descripcion", p.Descripcion);
                    cmd.Parameters.AddWithValue("@IdCategoria", p.IdCategoria);
                    cmd.Parameters.AddWithValue("@IdProveedor", p.IdProveedor);
                    cmd.Parameters.AddWithValue("@PrecioCompra", p.PrecioCompra);
                    cmd.Parameters.AddWithValue("@PrecioVenta", p.PrecioVenta);
                    cmd.Parameters.AddWithValue("@Stock", p.Stock);
                    cmd.Parameters.AddWithValue("@StockMinimo", p.StockMinimo);
                    cmd.Parameters.AddWithValue("@Activo", p.Activo);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }

           
            public bool Eliminar(int idProducto)
            {
                using (SqlConnection con = Conexion.GetConnection())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Producto WHERE IdProducto=@IdProducto", con);
                    cmd.Parameters.AddWithValue("@IdProducto", idProducto);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }

            public List<Producto> BuscarPorNombre(string nombre)
            {
                var lista = new List<Producto>();

                using (SqlConnection con = Conexion.GetConnection())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Producto WHERE Nombre LIKE @Nombre", con);
                    cmd.Parameters.AddWithValue("@Nombre", "%" + nombre + "%");
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        lista.Add(new Producto
                        {
                            IdProducto = Convert.ToInt32(dr["IdProducto"]),
                            Codigo = dr["Codigo"].ToString(),
                            Nombre = dr["Nombre"].ToString(),
                            PrecioVenta = Convert.ToDecimal(dr["PrecioVenta"]),
                            Stock = Convert.ToInt32(dr["Stock"])
                        });
                    }
                }

                return lista;
            }
        }
    }

