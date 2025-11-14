using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Venta
{
    public partial class FrmMenuVendedor : Form
    {
        public FrmMenuVendedor()
        {
            InitializeComponent();
        }

        private Form formularioActivo = null;

        private void AbrirFormulario(Form formulario)
        {
            // Cerrar formulario activo si lo hay
            if (formularioActivo != null)
                formularioActivo.Close();

            formularioActivo = formulario;

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            this.Controls.Add(formulario);
            formulario.BringToFront();
            formulario.Show();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmVentaRegistrar());
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmVentaConsultar());
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                var resultado = MessageBox.Show(
                    "¿Seguro que deseas salir del sistema?",
                    "Confirmación de salida",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (resultado == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }

        private void FrmMenuVendedor_Load(object sender, EventArgs e)
        {

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmAcercaDe());
        }
    }

}
