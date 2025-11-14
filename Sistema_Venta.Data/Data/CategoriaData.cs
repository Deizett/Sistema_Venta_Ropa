using Sistema_Venta.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Venta.Data
{
    public class CategoriaData
    {
       
        public List<Categoria> Listar()
        {
            var lista = new List<Categoria>();
            using (SqlConnection con = Conexion.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Categoria", con);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Categoria
                    {
                        IdCategoria = Convert.ToInt32(dr["IdCategoria"]),
                        Nombre = dr["Nombre"].ToString(),
                        Descripcion = dr["Descripcion"].ToString(),
                        FechaCreacion = Convert.ToDateTime(dr["FechaCreacion"])
                    });
                }
            }
            return lista;
        }

       
        public bool Insertar(Categoria c)
        {
            using (SqlConnection con = Conexion.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(@"
                    INSERT INTO Categoria (Nombre, Descripcion)
                    VALUES (@Nombre, @Descripcion)", con);

                cmd.Parameters.AddWithValue("@Nombre", c.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", c.Descripcion);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

     
        public bool Actualizar(Categoria c)
        {
            using (SqlConnection con = Conexion.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(@"
                    UPDATE Categoria SET
                        Nombre=@Nombre,
                        Descripcion=@Descripcion
                    WHERE IdCategoria=@IdCategoria", con);

                cmd.Parameters.AddWithValue("@IdCategoria", c.IdCategoria);
                cmd.Parameters.AddWithValue("@Nombre", c.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", c.Descripcion);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

      
        public bool Eliminar(int idCategoria)
        {
            using (SqlConnection con = Conexion.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Categoria WHERE IdCategoria=@IdCategoria", con);
                cmd.Parameters.AddWithValue("@IdCategoria", idCategoria);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

       
        public List<Categoria> BuscarPorNombre(string nombre)
        {
            var lista = new List<Categoria>();
            using (SqlConnection con = Conexion.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Categoria WHERE Nombre LIKE @Nombre", con);
                cmd.Parameters.AddWithValue("@Nombre", "%" + nombre + "%");
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Categoria
                    {
                        IdCategoria = Convert.ToInt32(dr["IdCategoria"]),
                        Nombre = dr["Nombre"].ToString(),
                        Descripcion = dr["Descripcion"].ToString(),
                        FechaCreacion = Convert.ToDateTime(dr["FechaCreacion"]) 
                    });
                }
            }
            return lista;
        }
    }
}
