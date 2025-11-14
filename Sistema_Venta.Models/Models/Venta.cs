using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Venta.Models
{
    public class Venta
    {
        public int IdVenta { get; set; }
        public DateTime Fecha { get; set; }
        public int? IdCliente { get; set; }
        public int IdUsuario { get; set; }
        public string TipoComprobante { get; set; }
        public string Serie { get; set; }
        public int Numero { get; set; }
        public decimal Total { get; set; }
        public string Estado { get; set; }
        public string Observaciones { get; set; }
        public string ClienteNombre { get; set; }    
        public string UsuarioNombre { get; set; }     
        public string NumeroVenta { get; set; }
    }
}
