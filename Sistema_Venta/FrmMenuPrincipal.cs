using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sistema_Venta
{
    public partial class FrmMenuPrincipal : Form
    {
        private Form formularioActivo = null;
        public FrmMenuPrincipal()
        {
            InitializeComponent();
            IsMdiContainer = true;

        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            this.Text = "Sistema de Ventas e Inventario - Tienda de Ropa";
        }


        private void AbrirFormulario(Form formulario)
        {

            panelBienvenida.Visible = false;
            panelIzquierda.Visible = false;
            panelDerecha.Visible = false;


            if (formularioActivo != null)
                formularioActivo.Close();

            formularioActivo = formulario;


            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;


            panelContenedor.Controls.Clear();
            panelContenedor.Controls.Add(formulario);
            formulario.BringToFront();
            formulario.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmProducto());
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmCategoria());
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmCliente());
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmProveedor());
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Módulo Ventas próximamente...");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void FrmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            var resultado = MessageBox.Show(
                "¿Deseas salir del sistema?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.No)
            {
                e.Cancel = true;
            }


        }

        private void proveedoresToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmProveedor());
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmVentaRegistrar());
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmVentaConsultar());
        }

        private void reporteGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmReporteGeneral());
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmReporteGeneral());
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmAcercaDe());
        }

        private void reportesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void panelBienvenida_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}