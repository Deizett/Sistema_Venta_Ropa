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
    public partial class FrmVentaRegistrar : Form
    {
        private readonly VentaData ventaData = new VentaData();
        private readonly ProductoData productoData = new ProductoData();
        private readonly ClienteData clienteData = new ClienteData();

        private List<Producto> listaProductos = new List<Producto>();
        private List<DetalleVenta> listaDetalles = new List<DetalleVenta>();

        public FrmVentaRegistrar()
        {
            InitializeComponent();
            Load += FrmVentaRegistrar_Load; 
        }

  
        private void FrmVentaRegistrar_Load(object sender, EventArgs e)
        {
            try
            {
                CargarClientes();
                CargarProductos();
                CargarTipoComprobante();
                InicializarDetalle();
                CargarProductosExistentesEnDetalle();

                dtpFecha.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos iniciales:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarClientes()
        {
            var clientes = clienteData.Listar();

            if (clientes.Count == 0)
            {
                MessageBox.Show("No hay clientes registrados en el sistema.");
                return;
            }

            cboCliente.DataSource = clientes;
            cboCliente.DisplayMember = "Nombre";
            cboCliente.ValueMember = "IdCliente";
            cboCliente.SelectedIndex = -1;
        }

        private void CargarProductos()
        {
            listaProductos = productoData.Listar();

            if (listaProductos.Count == 0)
            {
                MessageBox.Show("No hay productos registrados.");
                return;
            }

            cboProducto.DataSource = listaProductos;
            cboProducto.DisplayMember = "Nombre";
            cboProducto.ValueMember = "IdProducto";
            cboProducto.SelectedIndex = -1;
        }

        private void CargarTipoComprobante()
        {
            cboTipoComprobante.Items.Clear();
            cboTipoComprobante.Items.Add("BOLETA");
            cboTipoComprobante.Items.Add("FACTURA");
            cboTipoComprobante.Items.Add("TICKET");
            cboTipoComprobante.SelectedIndex = 0;
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

     
        private void CargarProductosExistentesEnDetalle()
        {
            listaDetalles.Clear();

            foreach (var p in listaProductos)
            {
                listaDetalles.Add(new DetalleVenta
                {
                    IdProducto = p.IdProducto,
                    Cantidad = 0, // cantidad aún no vendida
                    PrecioUnitario = p.PrecioVenta,
                    Descuento = 0
                });
            }

            RefrescarDetalle();
            CalcularTotales();
        }

     
        private void cboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProducto.SelectedItem is Producto p)
                txtPrecioUnitario.Text = p.PrecioVenta.ToString("N2");
        }

     
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (cboProducto.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un producto válido.");
                return;
            }

            var producto = (Producto)cboProducto.SelectedItem;
            int cantidad = (int)nudCantidad.Value;
            decimal precio = decimal.TryParse(txtPrecioUnitario.Text, out var p) ? p : 0;
            decimal descuento = decimal.TryParse(txtDescuento.Text, out var d) ? d : 0;

            if (cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida.");
                return;
            }

            var existente = listaDetalles.FirstOrDefault(x => x.IdProducto == producto.IdProducto);
            if (existente != null)
            {
                existente.Cantidad += cantidad;
            }
            else
            {
                listaDetalles.Add(new DetalleVenta
                {
                    IdProducto = producto.IdProducto,
                    Cantidad = cantidad,
                    PrecioUnitario = precio,
                    Descuento = descuento
                });
            }

            RefrescarDetalle();
            CalcularTotales();
        }

   
        private void RefrescarDetalle()
        {
            dgvDetalleVenta.Rows.Clear();

            foreach (var d in listaDetalles)
            {
                var producto = listaProductos.FirstOrDefault(p => p.IdProducto == d.IdProducto);
                string nombre = producto != null ? producto.Nombre : "(Desconocido)";
                decimal subtotal = (d.Cantidad * d.PrecioUnitario) - d.Descuento;

                dgvDetalleVenta.Rows.Add(nombre, d.Cantidad, d.PrecioUnitario.ToString("N2"),
                    d.Descuento.ToString("N2"), subtotal.ToString("N2"));
            }
        }

     
        private void CalcularTotales()
        {
            decimal total = listaDetalles.Sum(d => (d.Cantidad * d.PrecioUnitario) - d.Descuento);
            decimal subtotal = total / 1.18m;
            decimal igv = total - subtotal;

            txtSubTotal.Text = subtotal.ToString("N2");
            txtIGV.Text = igv.ToString("N2");
            txtTotal.Text = total.ToString("N2");
        }


        private void btnGuardarVenta_Click(object sender, EventArgs e)
        {
            if (cboCliente.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un cliente.");
                return;
            }

            if (listaDetalles.Count == 0 || listaDetalles.All(d => d.Cantidad == 0))
            {
                MessageBox.Show("Debe agregar al menos un producto con cantidad mayor a 0.");
                return;
            }

            var venta = new Venta
            {
                Fecha = dtpFecha.Value,
                IdCliente = (int)cboCliente.SelectedValue,
                IdUsuario = 1, 
                TipoComprobante = cboTipoComprobante.Text,
                Serie = txtSerie.Text,
                Numero = int.TryParse(txtNumero.Text, out var num) ? num : 0,
                Total = decimal.TryParse(txtTotal.Text, out var tot) ? tot : 0,
                Estado = "EMITIDA"
            };

            try
            {
                bool ok = ventaData.RegistrarVenta(venta, listaDetalles);
                if (ok)
                {
                    MessageBox.Show("Venta registrada correctamente.");
                    LimpiarTodo();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar la venta.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar venta: " + ex.Message);
            }
        }

        private void btnCancelarVenta_Click(object sender, EventArgs e)
        {
            LimpiarTodo();
        }


        private void LimpiarTodo()
        {
            cboCliente.SelectedIndex = -1;
            cboProducto.SelectedIndex = -1;
            txtPrecioUnitario.Clear();
            txtDescuento.Clear();
            nudCantidad.Value = 1;
            listaDetalles.Clear();
            RefrescarDetalle();
            CalcularTotales();
        }

        private void FrmVentaRegistrar_Load_1(object sender, EventArgs e)
        {

        }
    }
}