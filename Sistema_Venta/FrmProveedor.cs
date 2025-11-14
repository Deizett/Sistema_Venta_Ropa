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
    public partial class FrmProveedor : Form
    {
        private readonly ProveedorData proveedorData = new ProveedorData();
        private int idSeleccionado = 0;

        public FrmProveedor()
        {
            InitializeComponent();
        }

        private void FrmProveedor_Load(object sender, EventArgs e)
        {
            CargarProveedores();
        }

        private void CargarProveedores()
        {
            try
            {
                dgvProveedores.AutoGenerateColumns = true;
                dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvProveedores.DataSource = proveedorData.Listar();

                if (dgvProveedores.Columns["IdProveedor"] != null)
                {
                    dgvProveedores.Columns["IdProveedor"].Visible = true;
                    dgvProveedores.Columns["IdProveedor"].Width = 50;
                    dgvProveedores.Columns["IdProveedor"].DisplayIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar proveedores: " + ex.Message);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var proveedor = new Proveedor
                {
                    RazonSocial = txtRazonSocial.Text.Trim(),
                    RUC = txtRUC.Text.Trim(),
                    Direccion = txtDireccion.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim(),
                    Email = txtEmail.Text.Trim()
                };

                if (proveedorData.Insertar(proveedor))
                {
                    MessageBox.Show("Proveedor registrado correctamente");
                    CargarProveedores();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al registrar el proveedor");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un proveedor para editar");
                return;
            }

            var proveedor = new Proveedor
            {
                IdProveedor = idSeleccionado,
                RazonSocial = txtRazonSocial.Text.Trim(),
                RUC = txtRUC.Text.Trim(),
                Direccion = txtDireccion.Text.Trim(),
                Telefono = txtTelefono.Text.Trim(),
                Email = txtEmail.Text.Trim()
            };

            if (proveedorData.Actualizar(proveedor))
            {
                MessageBox.Show("Proveedor actualizado correctamente");
                CargarProveedores();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al actualizar el proveedor");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un proveedor para eliminar");
                return;
            }

            DialogResult dr = MessageBox.Show("¿Eliminar proveedor seleccionado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                if (proveedorData.Eliminar(idSeleccionado))
                {
                    MessageBox.Show("Proveedor eliminado");
                    CargarProveedores();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al eliminar proveedor");
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string texto = txtBuscar.Text.Trim();

            if (string.IsNullOrEmpty(texto))
            {
                CargarProveedores();
                return;
            }

            dgvProveedores.DataSource = proveedorData.Buscar(texto);
        }

        private void dgvProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProveedores.Rows[e.RowIndex];
                idSeleccionado = Convert.ToInt32(row.Cells["IdProveedor"].Value);
                txtRazonSocial.Text = row.Cells["RazonSocial"].Value.ToString();
                txtRUC.Text = row.Cells["RUC"].Value.ToString();
                txtDireccion.Text = row.Cells["Direccion"].Value.ToString();
                txtTelefono.Text = row.Cells["Telefono"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
            }
        }

        private void LimpiarCampos()
        {
            idSeleccionado = 0;
            txtRazonSocial.Clear();
            txtRUC.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtBuscar.Clear();
        }

        private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}