using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Venta.Models
{
    public class Pago
    {
        public int IdPago { get; set; }
        public int IdVenta { get; set; }
        public DateTime FechaPago { get; set; }
        public decimal Monto { get; set; }
        public string MetodoPago { get; set; }
        public string NumeroOperacion { get; set; }
        public string Observacion { get; set; }
        public string NumeroVenta { get; set; }
    }
}
