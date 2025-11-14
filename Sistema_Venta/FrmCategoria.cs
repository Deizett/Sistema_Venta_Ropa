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
    public partial class FrmCategoria : Form
    {
        private readonly CategoriaData categoriaData = new CategoriaData();
        private int idSeleccionado = 0;

        public FrmCategoria()
        {
            InitializeComponent();
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            CargarCategorias();
        }

        private void CargarCategorias()
        {
            try
            {
               
                dgvCategorias.AutoGenerateColumns = true;

          
                dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

              
                dgvCategorias.DataSource = categoriaData.Listar();

                
                if (dgvCategorias.Columns["IdCategoria"] != null)
                {
                    dgvCategorias.Columns["IdCategoria"].Visible = true;
                    dgvCategorias.Columns["IdCategoria"].Width = 50;
                    dgvCategorias.Columns["IdCategoria"].DisplayIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías: " + ex.Message);
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
                Categoria categoria = new Categoria
                {
                    Nombre = txtNombre.Text.Trim(),
                    Descripcion = txtDescripcion.Text.Trim()
                };

                bool ok = categoriaData.Insertar(categoria);
                if (ok)
                {
                    MessageBox.Show("Categoría registrada correctamente");
                    CargarCategorias();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al registrar la categoría");
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
                MessageBox.Show("Seleccione una categoría para editar");
                return;
            }

            Categoria categoria = new Categoria
            {
                IdCategoria = idSeleccionado,
                Nombre = txtNombre.Text.Trim(),
                Descripcion = txtDescripcion.Text.Trim()
            };

            if (categoriaData.Actualizar(categoria))
            {
                MessageBox.Show("Categoría actualizada correctamente");
                CargarCategorias();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al actualizar la categoría");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione una categoría para eliminar");
                return;
            }

            DialogResult dr = MessageBox.Show("¿Eliminar categoría seleccionada?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                if (categoriaData.Eliminar(idSeleccionado))
                {
                    MessageBox.Show("Categoría eliminada");
                    CargarCategorias();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al eliminar categoría");
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string texto = txtBuscar.Text.Trim();

            if (string.IsNullOrEmpty(texto))
            {
                CargarCategorias();
                return;
            }

            
            if (int.TryParse(texto, out int id))
            {
                var lista = categoriaData.Listar().Where(c => c.IdCategoria == id).ToList();
                dgvCategorias.DataSource = lista;
            }
            else
            {
               
                dgvCategorias.DataSource = categoriaData.BuscarPorNombre(texto);
            }
        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = dgvCategorias.Rows[e.RowIndex];

               
                idSeleccionado = Convert.ToInt32(row.Cells["IdCategoria"].Value);

                
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = row.Cells["Descripcion"].Value.ToString();
            }
        }

        private void LimpiarCampos()
        {
            idSeleccionado = 0;
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtBuscar.Clear();
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}