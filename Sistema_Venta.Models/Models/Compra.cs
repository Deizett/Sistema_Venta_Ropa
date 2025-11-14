using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Venta.Models
{
    public class Compra
    {
        public int IdCompra { get; set; }
        public DateTime Fecha { get; set; }
        public int? IdProveedor { get; set; }
        public decimal Total { get; set; }
        public string Observaciones { get; set; }
        public string ProveedorNombre { get; set; }  
    }
}
