using Sistema_Venta.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Venta.Data
{
    public class ProveedorData
    {
      
        public List<Proveedor> Listar()
        {
            var lista = new List<Proveedor>();
            using (SqlConnection con = Conexion.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Proveedor", con);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Proveedor
                    {
                        IdProveedor = Convert.ToInt32(dr["IdProveedor"]),
                        RazonSocial = dr["RazonSocial"].ToString(),
                        RUC = dr["RUC"].ToString(),
                        Direccion = dr["Direccion"].ToString(),
                        Telefono = dr["Telefono"].ToString(),
                        Email = dr["Email"].ToString(),
                        FechaCreacion = Convert.ToDateTime(dr["FechaCreacion"])
                    });
                }
            }
            return lista;
        }

        public bool Insertar(Proveedor p)
        {
            using (SqlConnection con = Conexion.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(@"
                    INSERT INTO Proveedor (RazonSocial, RUC, Direccion, Telefono, Email)
                    VALUES (@RazonSocial, @RUC, @Direccion, @Telefono, @Email)", con);

                cmd.Parameters.AddWithValue("@RazonSocial", p.RazonSocial);
                cmd.Parameters.AddWithValue("@RUC", p.RUC);
                cmd.Parameters.AddWithValue("@Direccion", p.Direccion);
                cmd.Parameters.AddWithValue("@Telefono", p.Telefono);
                cmd.Parameters.AddWithValue("@Email", p.Email);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

      
        public bool Actualizar(Proveedor p)
        {
            using (SqlConnection con = Conexion.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(@"
                    UPDATE Proveedor SET
                        RazonSocial=@RazonSocial,
                        RUC=@RUC,
                        Direccion=@Direccion,
                        Telefono=@Telefono,
                        Email=@Email
                    WHERE IdProveedor=@IdProveedor", con);

                cmd.Parameters.AddWithValue("@IdProveedor", p.IdProveedor);
                cmd.Parameters.AddWithValue("@RazonSocial", p.RazonSocial);
                cmd.Parameters.AddWithValue("@RUC", p.RUC);
                cmd.Parameters.AddWithValue("@Direccion", p.Direccion);
                cmd.Parameters.AddWithValue("@Telefono", p.Telefono);
                cmd.Parameters.AddWithValue("@Email", p.Email);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

       
        public bool Eliminar(int idProveedor)
        {
            using (SqlConnection con = Conexion.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Proveedor WHERE IdProveedor=@IdProveedor", con);
                cmd.Parameters.AddWithValue("@IdProveedor", idProveedor);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

       
        public List<Proveedor> Buscar(string texto)
        {
            var lista = new List<Proveedor>();
            using (SqlConnection con = Conexion.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(@"
                    SELECT * FROM Proveedor 
                    WHERE RazonSocial LIKE @Texto OR RUC LIKE @Texto", con);

                cmd.Parameters.AddWithValue("@Texto", "%" + texto + "%");
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Proveedor
                    {
                        IdProveedor = Convert.ToInt32(dr["IdProveedor"]),
                        RazonSocial = dr["RazonSocial"].ToString(),
                        RUC = dr["RUC"].ToString(),
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