using Sistema_Venta.Data;
using Sistema_Venta.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Venta
{
    public partial class FrmReporteGeneral : Form
    {
        private readonly VentaData ventaData = new VentaData();
        private List<Venta> listaVentas = new List<Venta>();

 
        private PrintDocument printDocument;
        private int printRowIndex = 0;
        private List<string[]> printRows = new List<string[]>();

        public FrmReporteGeneral()
        {
            InitializeComponent();
            Load += FrmReporteGeneral_Load;
        }

        private void FrmReporteGeneral_Load(object sender, EventArgs e)
        {
            try
            {
          
                dtpDesde.Value = DateTime.Now.AddMonths(-1);
                dtpHasta.Value = DateTime.Now;
                cboEstado.Items.Clear();
                cboEstado.Items.AddRange(new string[] { "Todos", "EMITIDA", "ANULADA" });
                cboEstado.SelectedIndex = 0;

             
                ConfigurarDgvReporte();
                CargarVentas();
                CalcularTotales();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar Reporte General: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        private void ConfigurarDgvReporte()
        {
            dgvReporteGeneral.Columns.Clear();
            dgvReporteGeneral.AutoGenerateColumns = false;
            dgvReporteGeneral.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReporteGeneral.MultiSelect = false;
            dgvReporteGeneral.AllowUserToAddRows = false;
            dgvReporteGeneral.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvReporteGeneral.Columns.Add("IdVenta", "ID");
            dgvReporteGeneral.Columns.Add("Fecha", "Fecha");
            dgvReporteGeneral.Columns.Add("Cliente", "Cliente");
            dgvReporteGeneral.Columns.Add("Comprobante", "Comprobante");
            dgvReporteGeneral.Columns.Add("Serie", "Serie");
            dgvReporteGeneral.Columns.Add("Numero", "Número");
            dgvReporteGeneral.Columns.Add("Total", "Total (S/)");
            dgvReporteGeneral.Columns.Add("Estado", "Estado");

           
            dgvReporteGeneral.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

       
        private void CargarVentas()
        {
            try
            {
                if (dgvReporteGeneral.Columns.Count == 0) ConfigurarDgvReporte();

                listaVentas = ventaData.Listar() ?? new List<Venta>();

                AplicarFiltrosYMostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener ventas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
        private void AplicarFiltrosYMostrar()
        {
            dgvReporteGeneral.Rows.Clear();

            DateTime desde = dtpDesde.Value.Date;
            DateTime hasta = dtpHasta.Value.Date.AddDays(1).AddSeconds(-1);
            string clienteFiltro = txtBuscarCliente.Text.Trim().ToLower();
            string estadoFiltro = cboEstado.SelectedItem?.ToString() ?? "Todos";

            var filtradas = listaVentas
                .Where(v => v.Fecha >= desde && v.Fecha <= hasta)
                .Where(v => string.IsNullOrEmpty(clienteFiltro) || (v.ClienteNombre ?? "").ToLower().Contains(clienteFiltro))
                .Where(v => estadoFiltro == "Todos" || (v.Estado ?? "").Equals(estadoFiltro, StringComparison.OrdinalIgnoreCase))
                .OrderByDescending(v => v.Fecha)
                .ToList();

            foreach (var v in filtradas)
            {
                dgvReporteGeneral.Rows.Add(
                    v.IdVenta,
                    v.Fecha.ToString("dd/MM/yyyy HH:mm"),
                    v.ClienteNombre ?? "",
                    $"{v.TipoComprobante ?? ""}",
                    v.Serie ?? "",
                    v.Numero != 0 ? v.Numero.ToString() : "",
                    v.Total.ToString("N2"),
                    v.Estado ?? ""
                );
            }

          
            if (this.Controls.Find("txtTotalRegistros", true).FirstOrDefault() is TextBox txtTotalReg)
                txtTotalReg.Text = filtradas.Count.ToString();

            CalcularTotales(filtradas);
        }


        private void CalcularTotales(List<Venta> filtradas = null)
        {
            var datos = filtradas ?? listaVentas;

            
            if (filtradas == null)
            {
             
                decimal sumTotal = 0;
                foreach (DataGridViewRow row in dgvReporteGeneral.Rows)
                {
                    if (row.Cells["Total"].Value != null && decimal.TryParse(row.Cells["Total"].Value.ToString(), out var tt))
                        sumTotal += tt;
                }
                datos = new List<Venta> { new Venta { Total = sumTotal } }; 
            }

            decimal totalSum = 0;
            if (filtradas != null)
                totalSum = filtradas.Sum(v => v.Total);
            else
                totalSum = datos.Sum(d => d.Total);

            decimal subtotal = totalSum / 1.18m;
            decimal igv = totalSum - subtotal;

           
            if (this.Controls.Find("txtSubtotal", true).FirstOrDefault() is TextBox txtSub)
                txtSub.Text = subtotal.ToString("N2");

            if (this.Controls.Find("txtIGV", true).FirstOrDefault() is TextBox txtIgv)
                txtIgv.Text = igv.ToString("N2");

            if (this.Controls.Find("txtTotalGeneral", true).FirstOrDefault() is TextBox txtTot)
                txtTot.Text = totalSum.ToString("N2");
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                AplicarFiltrosYMostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscarCliente.Clear();
            cboEstado.SelectedIndex = 0;
            dtpDesde.Value = DateTime.Now.AddMonths(-1);
            dtpHasta.Value = DateTime.Now;
            CargarVentas();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvReporteGeneral.Rows.Count == 0)
                {
                    MessageBox.Show("No hay datos para exportar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "CSV (delimitado por comas)|*.csv|Texto (*.txt)|*.txt";
                    sfd.FileName = $"ReporteVentas_{DateTime.Now:yyyyMMdd_HHmm}.csv";
                    if (sfd.ShowDialog() != DialogResult.OK) return;

                    var sb = new StringBuilder();

                  
                    var headers = dgvReporteGeneral.Columns.Cast<DataGridViewColumn>().Select(c => EscapeCsv(c.HeaderText));
                    sb.AppendLine(string.Join(",", headers));

                   
                    foreach (DataGridViewRow row in dgvReporteGeneral.Rows)
                    {
                        var cells = row.Cells.Cast<DataGridViewCell>().Select(c => EscapeCsv(c.Value?.ToString() ?? ""));
                        sb.AppendLine(string.Join(",", cells));
                    }

                    File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                    MessageBox.Show("Exportación completada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private string EscapeCsv(string s)
        {
            if (s.Contains("\"")) s = s.Replace("\"", "\"\"");
            if (s.Contains(",") || s.Contains("\n") || s.Contains("\"")) s = $"\"{s}\"";
            return s;
        }

  
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvReporteGeneral.Rows.Count == 0)
                {
                    MessageBox.Show("No hay datos para imprimir.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

             
                printRows.Clear();
                var header = dgvReporteGeneral.Columns.Cast<DataGridViewColumn>().Select(c => c.HeaderText).ToArray();
                printRows.Add(header);

                foreach (DataGridViewRow row in dgvReporteGeneral.Rows)
                {
                    var arr = row.Cells.Cast<DataGridViewCell>().Select(c => c.Value?.ToString() ?? "").ToArray();
                    printRows.Add(arr);
                }

                printRowIndex = 0;
                printDocument = new PrintDocument();
                printDocument.DefaultPageSettings.Landscape = true;
                printDocument.PrintPage += PrintDocument_PrintPage;

                using (PrintPreviewDialog preview = new PrintPreviewDialog())
                {
                    preview.Document = printDocument;
                    preview.Width = 1000;
                    preview.Height = 800;
                    preview.ShowDialog();
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al preparar impresión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            float y = e.MarginBounds.Top;
            float x = e.MarginBounds.Left;
            float lineHeight = new Font("Segoe UI", 9).GetHeight(e.Graphics) + 4;
            var fontHeader = new Font("Segoe UI", 10, FontStyle.Bold);
            var font = new Font("Segoe UI", 9);

            
            e.Graphics.DrawString("REPORTE GENERAL DE VENTAS", new Font("Segoe UI", 14, FontStyle.Bold), Brushes.Black, x, y);
            y += lineHeight * 2;

            var headers = printRows[0];
            float[] colWidths = new float[headers.Length];
           
            for (int i = 0; i < headers.Length; i++)
                colWidths[i] = e.MarginBounds.Width / headers.Length;

           
            for (int i = 0; i < headers.Length; i++)
            {
                e.Graphics.DrawString(headers[i], fontHeader, Brushes.Black, x + colWidths.Take(i).Sum(), y);
            }
            y += lineHeight;

          
            int fila = printRowIndex + 1;
            while (fila < printRows.Count)
            {
                var cols = printRows[fila];
                for (int c = 0; c < cols.Length; c++)
                {
                    e.Graphics.DrawString(cols[c], font, Brushes.Black, x + colWidths.Take(c).Sum(), y);
                }
                y += lineHeight;

              
                if (y + lineHeight > e.MarginBounds.Bottom)
                {
                    printRowIndex = fila;
                    e.HasMorePages = true;
                    return;
                }

                fila++;
            }

            printRowIndex = printRows.Count - 1;
            e.HasMorePages = false;
        }

        private void dgvReporteGeneral_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtpHasta_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpDesde_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
