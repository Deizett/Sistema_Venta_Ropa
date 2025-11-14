using Sistema_Venta.Data;
using Sistema_Venta.Models;
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
    public partial class FrmCliente : Form
    {
        private readonly ClienteData clienteData = new ClienteData();

        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            cboTipoDocumento.Items.AddRange(new object[] { "DNI", "RUC", "CE", "Pasaporte" });
            cboTipoDocumento.SelectedIndex = 0;
            CargarClientes();
        }

        private void CargarClientes()
        {
            dgvClientes.DataSource = clienteData.Listar();
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.ReadOnly = true;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (dgvClientes.Columns["FechaCreacion"] != null)
                dgvClientes.Columns["FechaCreacion"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente c = new Cliente
                {
                    Nombre = txtNombre.Text.Trim(),
                    TipoDocumento = cboTipoDocumento.SelectedItem.ToString(),
                    NumeroDocumento = txtNumeroDocumento.Text.Trim(),
                    Direccion = txtDireccion.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim(),
                    Email = txtEmail.Text.Trim()
                };

                if (clienteData.Insertar(c))
                {
                    MessageBox.Show("Cliente registrado correctamente");
                    CargarClientes();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al registrar cliente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdCliente.Text))
            {
                MessageBox.Show("Seleccione un cliente para editar");
                return;
            }

            Cliente c = new Cliente
            {
                IdCliente = Convert.ToInt32(txtIdCliente.Text),
                Nombre = txtNombre.Text.Trim(),
                TipoDocumento = cboTipoDocumento.SelectedItem.ToString(),
                NumeroDocumento = txtNumeroDocumento.Text.Trim(),
                Direccion = txtDireccion.Text.Trim(),
                Telefono = txtTelefono.Text.Trim(),
                Email = txtEmail.Text.Trim()
            };

            if (clienteData.Actualizar(c))
            {
                MessageBox.Show("Cliente actualizado correctamente");
                CargarClientes();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al actualizar cliente");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdCliente.Text))
            {
                MessageBox.Show("Seleccione un cliente para eliminar");
                return;
            }

            DialogResult dr = MessageBox.Show("¿Eliminar cliente seleccionado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                if (clienteData.Eliminar(Convert.ToInt32(txtIdCliente.Text)))
                {
                    MessageBox.Show("Cliente eliminado correctamente");
                    CargarClientes();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al eliminar cliente");
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string texto = txtBuscar.Text.Trim();
            if (string.IsNullOrEmpty(texto))
            {
                CargarClientes();
                return;
            }

            dgvClientes.DataSource = clienteData.Buscar(texto);
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvClientes.Rows[e.RowIndex];
                txtIdCliente.Text = row.Cells["IdCliente"].Value.ToString();
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                cboTipoDocumento.SelectedItem = row.Cells["TipoDocumento"].Value.ToString();
                txtNumeroDocumento.Text = row.Cells["NumeroDocumento"].Value.ToString();
                txtDireccion.Text = row.Cells["Direccion"].Value.ToString();
                txtTelefono.Text = row.Cells["Telefono"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
            }
        }

        private void LimpiarCampos()
        {
            txtIdCliente.Clear();
            txtNombre.Clear();
            cboTipoDocumento.SelectedIndex = 0;
            txtNumeroDocumento.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTipoDocumento_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
