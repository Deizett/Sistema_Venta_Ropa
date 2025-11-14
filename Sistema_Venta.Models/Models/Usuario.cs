using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Venta.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string UsuarioNombre { get; set; }
        public string PasswordHash { get; set; }
        public string NombreCompleto { get; set; }
        public int IdRol { get; set; }
        public string Email { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
