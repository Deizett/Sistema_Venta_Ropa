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
    public partial class FrmVentaConsultar : Form
    {
        private readonly VentaData ventaData = new VentaData();
        private List<Venta> listaVentas = new List<Venta>();

        public FrmVentaConsultar()
        {
            InitializeComponent();
            Load += FrmVentaConsultar_Load;
        }

  
        private void FrmVentaConsultar_Load(object sender, EventArgs e)
        {
            try
            {
              
                dtpDesde.Value = DateTime.Now.AddDays(-30);
                dtpHasta.Value = DateTime.Now;

                cboEstado.Items.AddRange(new string[] { "Todos", "EMITIDA", "ANULADA" });
                cboEstado.SelectedIndex = 0;

                
                ConfigurarDgvVentas();
                InicializarDetalle();

              
                CargarVentas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el formulario: " + ex.Message);
            }
        }

     
        private void ConfigurarDgvVentas()
        {
            dgvVentas.Columns.Clear();
            dgvVentas.AutoGenerateColumns = false;

            dgvVentas.Columns.Add("IdVenta", "ID");
            dgvVentas.Columns.Add("Fecha", "Fecha");
            dgvVentas.Columns.Add("Cliente", "Cliente");
            dgvVentas.Columns.Add("Comprobante", "Comprobante");
            dgvVentas.Columns.Add("Total", "Total (S/)");
            dgvVentas.Columns.Add("Estado", "Estado");

            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

  
        private void InicializarDetalle()
        {
            dgvDetalleVenta.Columns.Clear();
            dgvDetalleVenta.AutoGenerateColumns = false;

            dgvDetalleVenta.Columns.Add("Producto", "Producto");
            dgvDetalleVenta.Columns.Add("Cantidad", "Cantidad");
            dgvDetalleVenta.Columns.Add("PrecioUnitario", "Precio Unitario");
            dgvDetalleVenta.Columns.Add("Descuento", "Descuento");
            dgvDetalleVenta.Columns.Add("Subtotal", "Subtotal");

            dgvDetalleVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CargarVentas()
        {
            if (dgvVentas.Columns.Count == 0)
                ConfigurarDgvVentas();

            dgvVentas.Rows.Clear();
            listaVentas = ventaData.Listar();

            DateTime desde = dtpDesde.Value.Date;
            DateTime hasta = dtpHasta.Value.Date.AddDays(1).AddSeconds(-1);
            string clienteFiltro = txtBuscarCliente.Text.Trim().ToLower();
            string estadoFiltro = cboEstado.SelectedItem.ToString();

            var filtradas = listaVentas
                .Where(v => v.Fecha >= desde && v.Fecha <= hasta)
                .Where(v => string.IsNullOrEmpty(clienteFiltro) || v.ClienteNombre.ToLower().Contains(clienteFiltro))
                .Where(v => estadoFiltro == "Todos" || v.Estado.Equals(estadoFiltro, StringComparison.OrdinalIgnoreCase))
                .ToList();

            foreach (var v in filtradas)
            {
                dgvVentas.Rows.Add(v.IdVenta, v.Fecha.ToShortDateString(), v.ClienteNombre,
                    v.TipoComprobante, v.Total.ToString("N2"), v.Estado);
            }
        }

 
     
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarVentas();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            txtBuscarCliente.Clear();
            cboEstado.SelectedIndex = 0;
            dtpDesde.Value = DateTime.Now.AddDays(-30);
            dtpHasta.Value = DateTime.Now;
            CargarVentas();
        }

    
        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            if (dgvVentas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una venta para ver el detalle.");
                return;
            }

            int idVenta = Convert.ToInt32(dgvVentas.CurrentRow.Cells["IdVenta"].Value);
            var detalles = ventaData.ObtenerDetalles(idVenta);

            dgvDetalleVenta.Rows.Clear();

            foreach (var d in detalles)
            {
                dgvDetalleVenta.Rows.Add(d.ProductoNombre, d.Cantidad, d.PrecioUnitario.ToString("N2"),
                    d.Descuento.ToString("N2"), ((d.Cantidad * d.PrecioUnitario) - d.Descuento).ToString("N2"));
            }
        }


        private void btnAnularVenta_Click(object sender, EventArgs e)
        {
            if (dgvVentas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una venta para anular.");
                return;
            }

            int idVenta = Convert.ToInt32(dgvVentas.CurrentRow.Cells["IdVenta"].Value);
            string estado = dgvVentas.CurrentRow.Cells["Estado"].Value.ToString();

            if (estado == "ANULADA")
            {
                MessageBox.Show("Esta venta ya está anulada.");
                return;
            }

            var result = MessageBox.Show("¿Desea anular esta venta?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (ventaData.AnularVenta(idVenta))
                    {
                        MessageBox.Show("Venta anulada correctamente.");
                        CargarVentas();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al anular la venta: " + ex.Message);
                }
            }
        }

 
        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (dgvVentas.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.");
                return;
            }

            SaveFileDialog save = new SaveFileDialog
            {
                Filter = "Archivo CSV|*.csv",
                Title = "Exportar Ventas"
            };

            if (save.ShowDialog() == DialogResult.OK)
            {
                using (var writer = new System.IO.StreamWriter(save.FileName))
                {
                    writer.WriteLine("ID,Fecha,Cliente,Comprobante,Total,Estado");

                    foreach (DataGridViewRow row in dgvVentas.Rows)
                    {
                        var values = row.Cells.Cast<DataGridViewCell>().Select(c => c.Value?.ToString());
                        writer.WriteLine(string.Join(",", values));
                    }
                }

                MessageBox.Show("Archivo exportado correctamente.");
            }
        }


        private void btnCerrarDetalle_Click(object sender, EventArgs e)
        {
            dgvDetalleVenta.Rows.Clear();
        }

        private void dtpHasta_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}