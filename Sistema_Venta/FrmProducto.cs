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
    public partial class FrmProducto : Form
    {
        private readonly ProductoData productoData = new ProductoData();
        private readonly CategoriaData categoriaData = new CategoriaData();
        private readonly ProveedorData proveedorData = new ProveedorData();

        private bool isEditing = false;
        private int idProductoActual = 0;

        public FrmProducto()
        {
            InitializeComponent();
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            CargarCombos();
            CargarProductos();
        }


        private void CargarCombos()
        {
            try
            {
                cboCategoria.DataSource = categoriaData.Listar();
                cboCategoria.DisplayMember = "Nombre";
                cboCategoria.ValueMember = "IdCategoria";

                cboProveedor.DataSource = proveedorData.Listar();
                cboProveedor.DisplayMember = "RazonSocial";
                cboProveedor.ValueMember = "IdProveedor";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar combos: " + ex.Message);
            }
        }

        private void CargarProductos()
        {
            try
            {
                dgvProductos.DataSource = productoData.Listar();

            
                if (dgvProductos.Columns["IdProducto"] != null)
                {
                    dgvProductos.Columns["IdProducto"].Visible = true;
                    dgvProductos.Columns["IdProducto"].DisplayIndex = 0; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            isEditing = false;
            idProductoActual = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("El nombre del producto es obligatorio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Producto p = new Producto
                {
                    Codigo = txtCodigo.Text.Trim(),
                    Nombre = txtNombre.Text.Trim(),
                    Descripcion = txtDescripcion.Text.Trim(),
                    IdCategoria = Convert.ToInt32(cboCategoria.SelectedValue),
                    IdProveedor = Convert.ToInt32(cboProveedor.SelectedValue),
                    PrecioCompra = Convert.ToDecimal(txtPrecioCompra.Text),
                    PrecioVenta = Convert.ToDecimal(txtPrecioVenta.Text),
                    Stock = Convert.ToInt32(txtStock.Text),
                    StockMinimo = Convert.ToInt32(txtStockMinimo.Text),
                    Activo = true
                };

                bool resultado;
                if (isEditing)
                {
                    p.IdProducto = idProductoActual;
                    resultado = productoData.Actualizar(p);
                }
                else
                {
                    resultado = productoData.Insertar(p);
                }

                if (resultado)
                {
                    MessageBox.Show("Producto guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarProductos();
                    LimpiarCampos();
                    isEditing = false;
                    idProductoActual = 0;
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un producto para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            isEditing = true;
            idProductoActual = Convert.ToInt32(dgvProductos.CurrentRow.Cells["IdProducto"].Value);

            txtCodigo.Text = dgvProductos.CurrentRow.Cells["Codigo"].Value.ToString();
            txtNombre.Text = dgvProductos.CurrentRow.Cells["Nombre"].Value.ToString();
            txtDescripcion.Text = dgvProductos.CurrentRow.Cells["Descripcion"].Value.ToString();
            cboCategoria.SelectedValue = Convert.ToInt32(dgvProductos.CurrentRow.Cells["IdCategoria"].Value);
            cboProveedor.SelectedValue = Convert.ToInt32(dgvProductos.CurrentRow.Cells["IdProveedor"].Value);
            txtPrecioCompra.Text = dgvProductos.CurrentRow.Cells["PrecioCompra"].Value.ToString();
            txtPrecioVenta.Text = dgvProductos.CurrentRow.Cells["PrecioVenta"].Value.ToString();
            txtStock.Text = dgvProductos.CurrentRow.Cells["Stock"].Value.ToString();
            txtStockMinimo.Text = dgvProductos.CurrentRow.Cells["StockMinimo"].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un producto para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dgvProductos.CurrentRow.Cells["IdProducto"].Value);
            var confirm = MessageBox.Show("¿Seguro que deseas eliminar este producto?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                bool ok = productoData.Eliminar(id);
                if (ok)
                {
                    MessageBox.Show("Producto eliminado correctamente.", "Éxito");
                    CargarProductos();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el producto.", "Error");
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string texto = txtNombre.Text.Trim();
            if (string.IsNullOrEmpty(texto))
            {
                CargarProductos();
            }
            else
            {
                dgvProductos.DataSource = productoData.BuscarPorNombre(texto);
            }
        }


        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvProductos.CurrentRow != null)
            {
                DataGridViewRow row = dgvProductos.Rows[e.RowIndex];
                txtCodigo.Text = row.Cells["Codigo"].Value.ToString();
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = row.Cells["Descripcion"].Value.ToString();
                cboCategoria.SelectedValue = row.Cells["IdCategoria"].Value;
                cboProveedor.SelectedValue = row.Cells["IdProveedor"].Value;
                txtPrecioCompra.Text = row.Cells["PrecioCompra"].Value.ToString();
                txtPrecioVenta.Text = row.Cells["PrecioVenta"].Value.ToString();
                txtStock.Text = row.Cells["Stock"].Value.ToString();
                txtStockMinimo.Text = row.Cells["StockMinimo"].Value.ToString();
            }
        }

        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtPrecioCompra.Clear();
            txtPrecioVenta.Clear();
            txtStock.Clear();
            txtStockMinimo.Clear();
            cboCategoria.SelectedIndex = -1;
            cboProveedor.SelectedIndex = -1;
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecioCompra_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecioVenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStockMinimo_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}