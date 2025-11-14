using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Venta.Models
{
    public class InventarioMovimiento
    {
        public int IdMovimiento { get; set; }
        public int IdProducto { get; set; }
        public DateTime Fecha { get; set; }
        public string TipoMovimiento { get; set; } 
        public int Cantidad { get; set; }
        public int StockAntes { get; set; }
        public int StockDespues { get; set; }
        public string ReferenciaTipo { get; set; }
        public int? ReferenciaId { get; set; }
        public string Observacion { get; set; }
        public string ProductoNombre { get; set; }
    }
}
