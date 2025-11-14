namespace Sistema_Venta
{
    partial class FrmReporteGeneral
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnLimpiar = new Button();
            btnImprimir = new Button();
            btnFiltrar = new Button();
            btnExportar = new Button();
            dtpHasta = new DateTimePicker();
            dtpDesde = new DateTimePicker();
            txtBuscarCliente = new TextBox();
            dgvReporteGeneral = new DataGridView();
            groupBox1 = new GroupBox();
            cboEstado = new ComboBox();
            groupBox2 = new GroupBox();
            txtTotalGeneral = new TextBox();
            txtIGV = new TextBox();
            txtSubtotal = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvReporteGeneral).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(33, 48);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 0;
            label1.Text = "Fecha desde:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(369, 31);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "Hasta:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(33, 90);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 2;
            label3.Text = "Cliente:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.Location = new Point(203, 90);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 3;
            label4.Text = "Estado:";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnLimpiar.Location = new Point(130, 129);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 48);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnImprimir.Location = new Point(314, 112);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(83, 48);
            btnImprimir.TabIndex = 5;
            btnImprimir.Text = "IMPRIMIR";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnFiltrar.Location = new Point(33, 129);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(75, 48);
            btnFiltrar.TabIndex = 6;
            btnFiltrar.Text = "FILTRAR";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // btnExportar
            // 
            btnExportar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnExportar.Location = new Point(225, 129);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(85, 48);
            btnExportar.TabIndex = 7;
            btnExportar.Text = "EXPORTAR";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // dtpHasta
            // 
            dtpHasta.Font = new Font("Segoe UI", 9.75F);
            dtpHasta.Location = new Point(425, 29);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(236, 25);
            dtpHasta.TabIndex = 8;
            dtpHasta.ValueChanged += dtpHasta_ValueChanged;
            // 
            // dtpDesde
            // 
            dtpDesde.Font = new Font("Segoe UI", 9.75F);
            dtpDesde.Location = new Point(118, 29);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(235, 25);
            dtpDesde.TabIndex = 9;
            dtpDesde.ValueChanged += dtpDesde_ValueChanged;
            // 
            // txtBuscarCliente
            // 
            txtBuscarCliente.Font = new Font("Segoe UI", 9.75F);
            txtBuscarCliente.Location = new Point(94, 87);
            txtBuscarCliente.Name = "txtBuscarCliente";
            txtBuscarCliente.Size = new Size(100, 25);
            txtBuscarCliente.TabIndex = 11;
            // 
            // dgvReporteGeneral
            // 
            dgvReporteGeneral.BackgroundColor = Color.White;
            dgvReporteGeneral.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvReporteGeneral.DefaultCellStyle = dataGridViewCellStyle1;
            dgvReporteGeneral.Location = new Point(6, 26);
            dgvReporteGeneral.Name = "dgvReporteGeneral";
            dgvReporteGeneral.Size = new Size(557, 130);
            dgvReporteGeneral.TabIndex = 12;
            dgvReporteGeneral.CellContentClick += dgvReporteGeneral_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboEstado);
            groupBox1.Controls.Add(dtpHasta);
            groupBox1.Controls.Add(dtpDesde);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnImprimir);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 17);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(748, 179);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "REPORTE GENERAL DE VENTAS";
            // 
            // cboEstado
            // 
            cboEstado.Font = new Font("Segoe UI", 9.75F);
            cboEstado.FormattingEnabled = true;
            cboEstado.Location = new Point(253, 71);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(121, 25);
            cboEstado.TabIndex = 14;
            cboEstado.SelectedIndexChanged += cboEstado_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtTotalGeneral);
            groupBox2.Controls.Add(txtIGV);
            groupBox2.Controls.Add(txtSubtotal);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(dgvReporteGeneral);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 217);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(614, 270);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "LISTA DE VENTA";
            // 
            // txtTotalGeneral
            // 
            txtTotalGeneral.Font = new Font("Segoe UI", 9.75F);
            txtTotalGeneral.Location = new Point(124, 227);
            txtTotalGeneral.Name = "txtTotalGeneral";
            txtTotalGeneral.Size = new Size(100, 25);
            txtTotalGeneral.TabIndex = 14;
            // 
            // txtIGV
            // 
            txtIGV.Font = new Font("Segoe UI", 9.75F);
            txtIGV.Location = new Point(245, 177);
            txtIGV.Name = "txtIGV";
            txtIGV.Size = new Size(100, 25);
            txtIGV.TabIndex = 15;
            // 
            // txtSubtotal
            // 
            txtSubtotal.Font = new Font("Segoe UI", 9.75F);
            txtSubtotal.Location = new Point(92, 175);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(100, 25);
            txtSubtotal.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F);
            label5.Location = new Point(18, 176);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 14;
            label5.Text = "Subtotal:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F);
            label6.Location = new Point(204, 177);
            label6.Name = "label6";
            label6.Size = new Size(35, 20);
            label6.TabIndex = 15;
            label6.Text = "IGV:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F);
            label7.Location = new Point(18, 227);
            label7.Name = "label7";
            label7.Size = new Size(100, 20);
            label7.TabIndex = 16;
            label7.Text = "Total General:";
            // 
            // FrmReporteGeneral
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(800, 633);
            Controls.Add(groupBox2);
            Controls.Add(txtBuscarCliente);
            Controls.Add(btnExportar);
            Controls.Add(btnFiltrar);
            Controls.Add(btnLimpiar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            ForeColor = Color.Black;
            Name = "FrmReporteGeneral";
            Text = "FrmReporteGeneral";
            Load += FrmReporteGeneral_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReporteGeneral).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnLimpiar;
        private Button btnImprimir;
        private Button btnFiltrar;
        private Button btnExportar;
        private DateTimePicker dtpHasta;
        private DateTimePicker dtpDesde;
        private TextBox txtBuscarCliente;
        private DataGridView dgvReporteGeneral;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtTotalGeneral;
        private TextBox txtIGV;
        private TextBox txtSubtotal;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox cboEstado;
    }
}