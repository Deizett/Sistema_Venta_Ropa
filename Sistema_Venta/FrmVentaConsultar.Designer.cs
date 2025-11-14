namespace Sistema_Venta
{
    partial class FrmVentaConsultar
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dtpHasta = new DateTimePicker();
            dtpDesde = new DateTimePicker();
            cboEstado = new ComboBox();
            txtBuscarCliente = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dgvVentas = new DataGridView();
            btnBuscar = new Button();
            btnRefrescar = new Button();
            dgvDetalleVenta = new DataGridView();
            btnCerrarDetalle = new Button();
            gbFiltros = new GroupBox();
            gbVentas = new GroupBox();
            btnExportar = new Button();
            btnAnularVenta = new Button();
            btnVerDetalle = new Button();
            gbDetalle = new GroupBox();
            txtTotalVenta = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVenta).BeginInit();
            gbVentas.SuspendLayout();
            gbDetalle.SuspendLayout();
            SuspendLayout();
            // 
            // dtpHasta
            // 
            dtpHasta.Font = new Font("Segoe UI", 9F);
            dtpHasta.Location = new Point(349, 56);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(208, 23);
            dtpHasta.TabIndex = 0;
            dtpHasta.ValueChanged += dtpHasta_ValueChanged;
            // 
            // dtpDesde
            // 
            dtpDesde.Font = new Font("Segoe UI", 9F);
            dtpDesde.Location = new Point(79, 56);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(207, 23);
            dtpDesde.TabIndex = 1;
            // 
            // cboEstado
            // 
            cboEstado.FormattingEnabled = true;
            cboEstado.Location = new Point(357, 96);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(121, 23);
            cboEstado.TabIndex = 2;
            // 
            // txtBuscarCliente
            // 
            txtBuscarCliente.Location = new Point(128, 98);
            txtBuscarCliente.Name = "txtBuscarCliente";
            txtBuscarCliente.Size = new Size(136, 23);
            txtBuscarCliente.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(19, 59);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 4;
            label1.Text = "Desde:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(294, 59);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 5;
            label2.Text = "Hasta:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(19, 99);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 6;
            label3.Text = "Buscar cliente:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(294, 99);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 7;
            label4.Text = "Estado:";
            // 
            // dgvVentas
            // 
            dgvVentas.BackgroundColor = Color.White;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvVentas.DefaultCellStyle = dataGridViewCellStyle1;
            dgvVentas.Location = new Point(20, 178);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.Size = new Size(574, 137);
            dgvVentas.TabIndex = 10;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBuscar.Location = new Point(579, 48);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(85, 43);
            btnBuscar.TabIndex = 11;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            btnBuscar.Enter += btnBuscar_Click;
            // 
            // btnRefrescar
            // 
            btnRefrescar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRefrescar.Location = new Point(677, 48);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(105, 43);
            btnRefrescar.TabIndex = 12;
            btnRefrescar.Text = "REFRESCAR";
            btnRefrescar.UseVisualStyleBackColor = true;
            btnRefrescar.Click += btnRefrescar_Click;
            btnRefrescar.Enter += btnRefrescar_Click;
            // 
            // dgvDetalleVenta
            // 
            dgvDetalleVenta.BackgroundColor = Color.White;
            dgvDetalleVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleVenta.Location = new Point(19, 363);
            dgvDetalleVenta.Name = "dgvDetalleVenta";
            dgvDetalleVenta.Size = new Size(575, 150);
            dgvDetalleVenta.TabIndex = 14;
            // 
            // btnCerrarDetalle
            // 
            btnCerrarDetalle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrarDetalle.Location = new Point(592, 81);
            btnCerrarDetalle.Name = "btnCerrarDetalle";
            btnCerrarDetalle.Size = new Size(106, 44);
            btnCerrarDetalle.TabIndex = 15;
            btnCerrarDetalle.Text = "OCULTAR";
            btnCerrarDetalle.UseVisualStyleBackColor = true;
            btnCerrarDetalle.Click += btnCerrarDetalle_Click;
            // 
            // gbFiltros
            // 
            gbFiltros.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            gbFiltros.Location = new Point(12, 19);
            gbFiltros.Name = "gbFiltros";
            gbFiltros.Size = new Size(776, 123);
            gbFiltros.TabIndex = 16;
            gbFiltros.TabStop = false;
            gbFiltros.Text = "FILTROS DE BÚSQUEDA";
            // 
            // gbVentas
            // 
            gbVentas.Controls.Add(btnExportar);
            gbVentas.Controls.Add(btnAnularVenta);
            gbVentas.Controls.Add(btnVerDetalle);
            gbVentas.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            gbVentas.Location = new Point(12, 155);
            gbVentas.Name = "gbVentas";
            gbVentas.Size = new Size(714, 169);
            gbVentas.TabIndex = 0;
            gbVentas.TabStop = false;
            gbVentas.Text = "LISTADO DE VENTAS";
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(598, 120);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(106, 37);
            btnExportar.TabIndex = 19;
            btnExportar.Text = "EXPORTAR";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // btnAnularVenta
            // 
            btnAnularVenta.Location = new Point(608, 71);
            btnAnularVenta.Name = "btnAnularVenta";
            btnAnularVenta.Size = new Size(85, 36);
            btnAnularVenta.TabIndex = 18;
            btnAnularVenta.Text = "ANULAR";
            btnAnularVenta.UseVisualStyleBackColor = true;
            btnAnularVenta.Click += btnAnularVenta_Click;
            // 
            // btnVerDetalle
            // 
            btnVerDetalle.Location = new Point(607, 22);
            btnVerDetalle.Name = "btnVerDetalle";
            btnVerDetalle.Size = new Size(85, 37);
            btnVerDetalle.TabIndex = 17;
            btnVerDetalle.Text = "DETALLE";
            btnVerDetalle.UseVisualStyleBackColor = true;
            btnVerDetalle.Click += btnVerDetalle_Click;
            // 
            // gbDetalle
            // 
            gbDetalle.Controls.Add(btnCerrarDetalle);
            gbDetalle.Controls.Add(txtTotalVenta);
            gbDetalle.Controls.Add(label5);
            gbDetalle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            gbDetalle.Location = new Point(12, 336);
            gbDetalle.Name = "gbDetalle";
            gbDetalle.Size = new Size(714, 250);
            gbDetalle.TabIndex = 0;
            gbDetalle.TabStop = false;
            gbDetalle.Text = "DETALLE DE VENTA SELECCIONADA";
            // 
            // txtTotalVenta
            // 
            txtTotalVenta.Location = new Point(141, 197);
            txtTotalVenta.Name = "txtTotalVenta";
            txtTotalVenta.Size = new Size(124, 29);
            txtTotalVenta.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 201);
            label5.Name = "label5";
            label5.Size = new Size(123, 21);
            label5.TabIndex = 17;
            label5.Text = "Total de Venta:";
            // 
            // FrmVentaConsultar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(800, 620);
            Controls.Add(dgvDetalleVenta);
            Controls.Add(btnRefrescar);
            Controls.Add(btnBuscar);
            Controls.Add(dgvVentas);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBuscarCliente);
            Controls.Add(cboEstado);
            Controls.Add(dtpDesde);
            Controls.Add(dtpHasta);
            Controls.Add(gbDetalle);
            Controls.Add(gbVentas);
            Controls.Add(gbFiltros);
            ForeColor = Color.Black;
            Name = "FrmVentaConsultar";
            Text = "FrmVentaConsultar";
            Load += FrmVentaConsultar_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVenta).EndInit();
            gbVentas.ResumeLayout(false);
            gbDetalle.ResumeLayout(false);
            gbDetalle.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpHasta;
        private DateTimePicker dtpDesde;
        private ComboBox cboEstado;
        private TextBox txtBuscarCliente;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dgvVentas;
        private Button btnBuscar;
        private Button btnRefrescar;
        private DataGridView dgvDetalleVenta;
        private Button btnCerrarDetalle;
        private GroupBox gbFiltros;
        private GroupBox gbVentas;
        private GroupBox gbDetalle;
        private Button btnExportar;
        private Button btnAnularVenta;
        private Button btnVerDetalle;
        private TextBox txtTotalVenta;
        private Label label5;
    }
}