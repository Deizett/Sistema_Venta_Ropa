namespace Sistema_Venta
{
    partial class FrmVentaRegistrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cboCliente = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            dtpFecha = new DateTimePicker();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            cboTipoComprobante = new ComboBox();
            txtSerie = new TextBox();
            txtNumero = new TextBox();
            txtUsuario = new TextBox();
            gbDatosVenta = new GroupBox();
            gbProductos = new GroupBox();
            btnAgregar = new Button();
            txtDescuento = new TextBox();
            nudCantidad = new NumericUpDown();
            txtPrecioUnitario = new TextBox();
            cboProducto = new ComboBox();
            gbTotales = new GroupBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            label14 = new Label();
            dgvDetalleVenta = new DataGridView();
            label13 = new Label();
            txtTotal = new TextBox();
            txtIGV = new TextBox();
            txtSubTotal = new TextBox();
            gbDatosVenta.SuspendLayout();
            gbProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            gbTotales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVenta).BeginInit();
            SuspendLayout();
            // 
            // cboCliente
            // 
            cboCliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboCliente.FormattingEnabled = true;
            cboCliente.Location = new Point(108, 44);
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(230, 25);
            cboCliente.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(32, 47);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 1;
            label1.Text = "Cliente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(32, 88);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 2;
            label2.Text = "Fecha:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(32, 166);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 3;
            label3.Text = "Serie:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.Location = new Point(32, 479);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 4;
            label4.Text = "Subtotal:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F);
            label5.Location = new Point(32, 517);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 5;
            label5.Text = "IGV (18%):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F);
            label6.Location = new Point(32, 555);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 6;
            label6.Text = "TOTAL:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F);
            label7.Location = new Point(32, 130);
            label7.Name = "label7";
            label7.Size = new Size(159, 20);
            label7.TabIndex = 7;
            label7.Text = "Tipo de Comprobante:";
            // 
            // dtpFecha
            // 
            dtpFecha.CalendarFont = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFecha.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFecha.Location = new Point(108, 85);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(244, 25);
            dtpFecha.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F);
            label8.Location = new Point(32, 199);
            label8.Name = "label8";
            label8.Size = new Size(63, 20);
            label8.TabIndex = 9;
            label8.Text = "Número";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F);
            label9.Location = new Point(32, 234);
            label9.Name = "label9";
            label9.Size = new Size(62, 20);
            label9.TabIndex = 10;
            label9.Text = "Usuario:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F);
            label10.Location = new Point(406, 85);
            label10.Name = "label10";
            label10.Size = new Size(110, 20);
            label10.TabIndex = 11;
            label10.Text = "Precio Unitario:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F);
            label11.Location = new Point(406, 120);
            label11.Name = "label11";
            label11.Size = new Size(72, 20);
            label11.TabIndex = 12;
            label11.Text = "Cantidad:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11.25F);
            label12.Location = new Point(406, 52);
            label12.Name = "label12";
            label12.Size = new Size(72, 20);
            label12.TabIndex = 13;
            label12.Text = "Producto:";
            // 
            // cboTipoComprobante
            // 
            cboTipoComprobante.Font = new Font("Segoe UI", 9.75F);
            cboTipoComprobante.FormattingEnabled = true;
            cboTipoComprobante.Location = new Point(172, 115);
            cboTipoComprobante.Name = "cboTipoComprobante";
            cboTipoComprobante.Size = new Size(172, 25);
            cboTipoComprobante.TabIndex = 14;
            // 
            // txtSerie
            // 
            txtSerie.Font = new Font("Segoe UI", 9.75F);
            txtSerie.Location = new Point(197, 164);
            txtSerie.Name = "txtSerie";
            txtSerie.Size = new Size(172, 25);
            txtSerie.TabIndex = 15;
            // 
            // txtNumero
            // 
            txtNumero.Font = new Font("Segoe UI", 9.75F);
            txtNumero.Location = new Point(172, 185);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(172, 25);
            txtNumero.TabIndex = 16;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 9.75F);
            txtUsuario.Location = new Point(172, 220);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(172, 25);
            txtUsuario.TabIndex = 17;
            // 
            // gbDatosVenta
            // 
            gbDatosVenta.Controls.Add(cboTipoComprobante);
            gbDatosVenta.Controls.Add(txtNumero);
            gbDatosVenta.Controls.Add(txtUsuario);
            gbDatosVenta.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbDatosVenta.Location = new Point(25, 12);
            gbDatosVenta.Name = "gbDatosVenta";
            gbDatosVenta.Size = new Size(356, 256);
            gbDatosVenta.TabIndex = 18;
            gbDatosVenta.TabStop = false;
            gbDatosVenta.Text = "DATOS GENERALES";
            // 
            // gbProductos
            // 
            gbProductos.Controls.Add(btnAgregar);
            gbProductos.Controls.Add(txtDescuento);
            gbProductos.Controls.Add(nudCantidad);
            gbProductos.Controls.Add(txtPrecioUnitario);
            gbProductos.Controls.Add(cboProducto);
            gbProductos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbProductos.Location = new Point(398, 12);
            gbProductos.Name = "gbProductos";
            gbProductos.Size = new Size(297, 237);
            gbProductos.TabIndex = 0;
            gbProductos.TabStop = false;
            gbProductos.Text = "SECCIÓN DE PRODUCTOS";
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(83, 177);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(122, 51);
            btnAgregar.TabIndex = 21;
            btnAgregar.Text = "AGREGAR PRODUCTO";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregarProducto_Click;
            // 
            // txtDescuento
            // 
            txtDescuento.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            txtDescuento.Location = new Point(124, 140);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(100, 25);
            txtDescuento.TabIndex = 21;
            // 
            // nudCantidad
            // 
            nudCantidad.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudCantidad.Location = new Point(123, 105);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(120, 25);
            nudCantidad.TabIndex = 21;
            // 
            // txtPrecioUnitario
            // 
            txtPrecioUnitario.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrecioUnitario.Location = new Point(124, 70);
            txtPrecioUnitario.Name = "txtPrecioUnitario";
            txtPrecioUnitario.Size = new Size(120, 25);
            txtPrecioUnitario.TabIndex = 21;
            // 
            // cboProducto
            // 
            cboProducto.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboProducto.FormattingEnabled = true;
            cboProducto.Location = new Point(124, 35);
            cboProducto.Name = "cboProducto";
            cboProducto.Size = new Size(159, 25);
            cboProducto.TabIndex = 22;
            cboProducto.SelectedIndexChanged += cboProducto_SelectedIndexChanged;
            // 
            // gbTotales
            // 
            gbTotales.Controls.Add(btnGuardar);
            gbTotales.Controls.Add(btnCancelar);
            gbTotales.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbTotales.Location = new Point(25, 445);
            gbTotales.Name = "gbTotales";
            gbTotales.Size = new Size(381, 152);
            gbTotales.TabIndex = 0;
            gbTotales.TabStop = false;
            gbTotales.Text = "RESUMEN";
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnGuardar.Location = new Point(258, 34);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(109, 44);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "GUARDAR VENTA";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardarVenta_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnCancelar.Location = new Point(258, 87);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(109, 43);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "CANCELAR VENTA";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelarVenta_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 11.25F);
            label14.Location = new Point(406, 155);
            label14.Name = "label14";
            label14.Size = new Size(79, 20);
            label14.TabIndex = 20;
            label14.Text = "Descuento";
            // 
            // dgvDetalleVenta
            // 
            dgvDetalleVenta.BackgroundColor = Color.White;
            dgvDetalleVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleVenta.Location = new Point(25, 318);
            dgvDetalleVenta.Name = "dgvDetalleVenta";
            dgvDetalleVenta.Size = new Size(644, 112);
            dgvDetalleVenta.TabIndex = 21;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(25, 289);
            label13.Name = "label13";
            label13.Size = new Size(275, 21);
            label13.TabIndex = 22;
            label13.Text = "LISTA DE PRODUCTOS AGREGADOS";
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI", 9.75F);
            txtTotal.Location = new Point(114, 551);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(158, 25);
            txtTotal.TabIndex = 2;
            // 
            // txtIGV
            // 
            txtIGV.Font = new Font("Segoe UI", 9.75F);
            txtIGV.Location = new Point(113, 515);
            txtIGV.Name = "txtIGV";
            txtIGV.Size = new Size(158, 25);
            txtIGV.TabIndex = 3;
            // 
            // txtSubTotal
            // 
            txtSubTotal.Font = new Font("Segoe UI", 9.75F);
            txtSubTotal.Location = new Point(113, 476);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.Size = new Size(158, 25);
            txtSubTotal.TabIndex = 4;
            // 
            // FrmVentaRegistrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(723, 611);
            Controls.Add(txtTotal);
            Controls.Add(txtIGV);
            Controls.Add(txtSubTotal);
            Controls.Add(label13);
            Controls.Add(dgvDetalleVenta);
            Controls.Add(label14);
            Controls.Add(txtSerie);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(dtpFecha);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cboCliente);
            Controls.Add(gbDatosVenta);
            Controls.Add(gbProductos);
            Controls.Add(gbTotales);
            ForeColor = Color.Black;
            Name = "FrmVentaRegistrar";
            Text = "FrmVentaRegistrar";
            Load += FrmVentaRegistrar_Load_1;
            gbDatosVenta.ResumeLayout(false);
            gbDatosVenta.PerformLayout();
            gbProductos.ResumeLayout(false);
            gbProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            gbTotales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVenta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboCliente;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DateTimePicker dtpFecha;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private ComboBox cboTipoComprobante;
        private TextBox txtSerie;
        private TextBox txtNumero;
        private TextBox txtUsuario;
        private GroupBox gbDatosVenta;
        private GroupBox gbProductos;
        private GroupBox gbTotales;
        private Label label14;
        private Button btnAgregar;
        private TextBox txtDescuento;
        private NumericUpDown nudCantidad;
        private TextBox txtPrecioUnitario;
        private ComboBox cboProducto;
        private Button btnGuardar;
        private Button btnCancelar;
        private DataGridView dgvDetalleVenta;
        private Label label13;
        private TextBox txtTotal;
        private TextBox txtIGV;
        private TextBox txtSubTotal;
    }
}