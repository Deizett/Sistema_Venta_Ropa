using Sistema_Venta.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Venta.Data
{
    public class UsuarioData
    {
          
            public List<Usuario> Listar()
            {
                var lista = new List<Usuario>();

                using (SqlConnection con = Conexion.GetConnection())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Usuario", con);
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        lista.Add(new Usuario
                        {
                            IdUsuario = Convert.ToInt32(dr["IdUsuario"]),
                            UsuarioNombre = dr["Usuario"].ToString(),
                            PasswordHash = dr["PasswordHash"].ToString(),
                            NombreCompleto = dr["NombreCompleto"].ToString(),
                            IdRol = Convert.ToInt32(dr["IdRol"]),
                            Email = dr["Email"].ToString(),
                            Activo = Convert.ToBoolean(dr["Activo"]),
                            FechaCreacion = Convert.ToDateTime(dr["FechaCreacion"])
                        });
                    }
                }

                return lista;
            }

        
            public bool Insertar(Usuario u)
            {
                using (SqlConnection con = Conexion.GetConnection())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"
                    INSERT INTO Usuario (Usuario, PasswordHash, NombreCompleto, IdRol, Email, Activo)
                    VALUES (@Usuario, @PasswordHash, @NombreCompleto, @IdRol, @Email, @Activo)", con);

                    cmd.Parameters.AddWithValue("@Usuario", u.UsuarioNombre);
                    cmd.Parameters.AddWithValue("@PasswordHash", u.PasswordHash);
                    cmd.Parameters.AddWithValue("@NombreCompleto", u.NombreCompleto);
                    cmd.Parameters.AddWithValue("@IdRol", u.IdRol);
                    cmd.Parameters.AddWithValue("@Email", u.Email);
                    cmd.Parameters.AddWithValue("@Activo", u.Activo);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }

        
            public bool Actualizar(Usuario u)
            {
                using (SqlConnection con = Conexion.GetConnection())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"
                    UPDATE Usuario SET 
                        Usuario=@Usuario,
                        PasswordHash=@PasswordHash,
                        NombreCompleto=@NombreCompleto,
                        IdRol=@IdRol,
                        Email=@Email,
                        Activo=@Activo
                    WHERE IdUsuario=@IdUsuario", con);

                    cmd.Parameters.AddWithValue("@IdUsuario", u.IdUsuario);
                    cmd.Parameters.AddWithValue("@Usuario", u.UsuarioNombre);
                    cmd.Parameters.AddWithValue("@PasswordHash", u.PasswordHash);
                    cmd.Parameters.AddWithValue("@NombreCompleto", u.NombreCompleto);
                    cmd.Parameters.AddWithValue("@IdRol", u.IdRol);
                    cmd.Parameters.AddWithValue("@Email", u.Email);
                    cmd.Parameters.AddWithValue("@Activo", u.Activo);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }

            public bool Eliminar(int idUsuario)
            {
                using (SqlConnection con = Conexion.GetConnection())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Usuario WHERE IdUsuario=@IdUsuario", con);
                    cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }

           
            public List<Usuario> BuscarPorNombre(string nombre)
            {
                var lista = new List<Usuario>();

                using (SqlConnection con = Conexion.GetConnection())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Usuario WHERE NombreCompleto LIKE @Nombre", con);
                    cmd.Parameters.AddWithValue("@Nombre", "%" + nombre + "%");
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        lista.Add(new Usuario
                        {
                            IdUsuario = Convert.ToInt32(dr["IdUsuario"]),
                            UsuarioNombre = dr["Usuario"].ToString(),
                            NombreCompleto = dr["NombreCompleto"].ToString(),
                            Email = dr["Email"].ToString(),
                            Activo = Convert.ToBoolean(dr["Activo"])
                        });
                    }
                }

                return lista;
            }

            public Usuario Login(string usuario, string password)
            {
                using (SqlConnection con = Conexion.GetConnection())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"
                    SELECT * FROM Usuario 
                    WHERE Usuario = @Usuario AND PasswordHash = @Password AND Activo = 1", con);

                    cmd.Parameters.AddWithValue("@Usuario", usuario);
                    cmd.Parameters.AddWithValue("@Password", password);

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        return new Usuario
                        {
                            IdUsuario = Convert.ToInt32(dr["IdUsuario"]),
                            UsuarioNombre = dr["Usuario"].ToString(),
                            NombreCompleto = dr["NombreCompleto"].ToString(),
                            IdRol = Convert.ToInt32(dr["IdRol"]),
                            Email = dr["Email"].ToString(),
                            Activo = Convert.ToBoolean(dr["Activo"])
                        };
                    }
                }
                return null; 
            }
        }
    }


