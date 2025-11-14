using Sistema_Venta.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Venta.Data
{
    public class ClienteData
    {
       
        public List<Cliente> Listar()
        {
            var lista = new List<Cliente>();
            using (SqlConnection con = Conexion.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Cliente", con);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Cliente
                    {
                        IdCliente = Convert.ToInt32(dr["IdCliente"]),
                        Nombre = dr["Nombre"].ToString(),
                        TipoDocumento = dr["TipoDocumento"].ToString(),
                        NumeroDocumento = dr["NumeroDocumento"].ToString(),
                        Direccion = dr["Direccion"].ToString(),
                        Telefono = dr["Telefono"].ToString(),
                        Email = dr["Email"].ToString(),
                        FechaCreacion = Convert.ToDateTime(dr["FechaCreacion"])
                    });
                }
            }
            return lista;
        }

      
        public bool Insertar(Cliente c)
        {
            using (SqlConnection con = Conexion.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(@"
                INSERT INTO Cliente (Nombre, TipoDocumento, NumeroDocumento, Direccion, Telefono, Email)
                VALUES (@Nombre, @TipoDocumento, @NumeroDocumento, @Direccion, @Telefono, @Email)", con);

                cmd.Parameters.AddWithValue("@Nombre", c.Nombre);
                cmd.Parameters.AddWithValue("@TipoDocumento", c.TipoDocumento);
                cmd.Parameters.AddWithValue("@NumeroDocumento", c.NumeroDocumento);
                cmd.Parameters.AddWithValue("@Direccion", c.Direccion);
                cmd.Parameters.AddWithValue("@Telefono", c.Telefono);
                cmd.Parameters.AddWithValue("@Email", c.Email);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

     
        public bool Actualizar(Cliente c)
        {
            using (SqlConnection con = Conexion.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(@"
                UPDATE Cliente SET
                    Nombre=@Nombre,
                    TipoDocumento=@TipoDocumento,
                    NumeroDocumento=@NumeroDocumento,
                    Direccion=@Direccion,
                    Telefono=@Telefono,
                    Email=@Email
                WHERE IdCliente=@IdCliente", con);

                cmd.Parameters.AddWithValue("@IdCliente", c.IdCliente);
                cmd.Parameters.AddWithValue("@Nombre", c.Nombre);
                cmd.Parameters.AddWithValue("@TipoDocumento", c.TipoDocumento);
                cmd.Parameters.AddWithValue("@NumeroDocumento", c.NumeroDocumento);
                cmd.Parameters.AddWithValue("@Direccion", c.Direccion);
                cmd.Parameters.AddWithValue("@Telefono", c.Telefono);
                cmd.Parameters.AddWithValue("@Email", c.Email);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

       
        public bool Eliminar(int idCliente)
        {
            using (SqlConnection con = Conexion.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Cliente WHERE IdCliente=@IdCliente", con);
                cmd.Parameters.AddWithValue("@IdCliente", idCliente);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        
        public List<Cliente> BuscarPorNombre(string nombre)
        {
            var lista = new List<Cliente>();
            using (SqlConnection con = Conexion.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Cliente WHERE Nombre LIKE @Nombre", con);
                cmd.Parameters.AddWithValue("@Nombre", "%" + nombre + "%");
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Cliente
                    {
                        IdCliente = Convert.ToInt32(dr["IdCliente"]),
                        Nombre = dr["Nombre"].ToString(),
                        Telefono = dr["Telefono"].ToString(),
                        Email = dr["Email"].ToString()
                    });
                }
            }
            return lista;
        }

       
        public List<Cliente> Buscar(string texto)
        {
            var lista = new List<Cliente>();

            using (SqlConnection con = Conexion.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "SELECT * FROM Cliente WHERE Nombre LIKE @texto OR NumeroDocumento LIKE @texto", con);
                cmd.Parameters.AddWithValue("@texto", "%" + texto + "%");

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new Cliente
                    {
                        IdCliente = Convert.ToInt32(dr["IdCliente"]),
                        Nombre = dr["Nombre"].ToString(),
                        TipoDocumento = dr["TipoDocumento"].ToString(),
                        NumeroDocumento = dr["NumeroDocumento"].ToString(),
                        Direccion = dr["Direccion"].ToString(),
                        Telefono = dr["Telefono"].ToString(),
                        Email = dr["Email"].ToString(),
                        FechaCreacion = Convert.ToDateTime(dr["FechaCreacion"])
                    });
                }
            }

            return lista;
        }
    }
}

