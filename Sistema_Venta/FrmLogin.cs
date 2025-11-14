using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Venta.Data;
using Sistema_Venta.Models;

namespace Sistema_Venta
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        UsuarioData usuarioData = new UsuarioData();

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string user = txtUsuario.Text.Trim();
            string pass = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Ingrese usuario y contraseña", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Usuario u = usuarioData.Login(user, pass);

            if (u != null)
            {
                // VALIDA EL ROL
                if (u.IdRol == 1)  // ADMINISTRADOR
                {
                    FrmMenuPrincipal frm = new FrmMenuPrincipal();
                    frm.Show();
                    this.Hide();
                }
                else if (u.IdRol == 2) // VENDEDOR
                {
                    FrmMenuVendedor frm = new FrmMenuVendedor();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Rol no reconocido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
