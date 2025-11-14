using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Sistema_Venta.Data
{
    public class Conexion
    {
        
        private static string cadena = "Data Source=LAPTOP-I445MRJ9;Initial Catalog=Sistema_Ventas;User ID=sa;Password=Jhasthin4";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(cadena);
        }
    }

}
