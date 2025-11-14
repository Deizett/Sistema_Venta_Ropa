namespace Sistema_Venta
{
    partial class FrmProducto
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
            dgvProductos = new DataGridView();
            txtPrecioCompra = new TextBox();
            txtPrecioVenta = new TextBox();
            txtCodigo = new TextBox();
            txtStock = new TextBox();
            txtNombre = new TextBox();
            txtStockMinimo = new TextBox();
            txtDescripcion = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            cboCategoria = new ComboBox();
            cboProveedor = new ComboBox();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnBuscar = new Button();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(12, 262);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(766, 176);
            dgvProductos.TabIndex = 0;
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.Location = new Point(163, 183);
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.Size = new Size(100, 23);
            txtPrecioCompra.TabIndex = 1;
            txtPrecioCompra.TextChanged += txtPrecioCompra_TextChanged;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(163, 220);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(100, 23);
            txtPrecioVenta.TabIndex = 2;
            txtPrecioVenta.TextChanged += txtPrecioVenta_TextChanged;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(163, 67);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 3;
            txtCodigo.TextChanged += txtCodigo_TextChanged;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(392, 61);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(100, 23);
            txtStock.TabIndex = 4;
            txtStock.TextChanged += txtStock_TextChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(163, 105);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 5;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // txtStockMinimo
            // 
            txtStockMinimo.Location = new Point(392, 99);
            txtStockMinimo.Name = "txtStockMinimo";
            txtStockMinimo.Size = new Size(100, 23);
            txtStockMinimo.TabIndex = 6;
            txtStockMinimo.TextChanged += txtStockMinimo_TextChanged;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(163, 142);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(100, 23);
            txtDescripcion.TabIndex = 7;
            txtDescripcion.TextChanged += txtDescripcion_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(26, 67);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 8;
            label1.Text = "Código:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(26, 104);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 9;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(26, 142);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 10;
            label3.Text = "Descripción:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.Location = new Point(26, 184);
            label4.Name = "label4";
            label4.Size = new Size(131, 20);
            label4.TabIndex = 11;
            label4.Text = "Precio de Compra:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F);
            label5.Location = new Point(26, 220);
            label5.Name = "label5";
            label5.Size = new Size(115, 20);
            label5.TabIndex = 12;
            label5.Text = "Precio de Venta:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F);
            label6.Location = new Point(286, 66);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 13;
            label6.Text = "Stock:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F);
            label7.Location = new Point(286, 100);
            label7.Name = "label7";
            label7.Size = new Size(103, 20);
            label7.TabIndex = 14;
            label7.Text = "Stock Minimo:";
            // 
            // cboCategoria
            // 
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(523, 63);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(121, 23);
            cboCategoria.TabIndex = 15;
            cboCategoria.SelectedIndexChanged += cboCategoria_SelectedIndexChanged;
            // 
            // cboProveedor
            // 
            cboProveedor.FormattingEnabled = true;
            cboProveedor.Location = new Point(661, 62);
            cboProveedor.Name = "cboProveedor";
            cboProveedor.Size = new Size(121, 23);
            cboProveedor.TabIndex = 16;
            cboProveedor.SelectedIndexChanged += cboProveedor_SelectedIndexChanged;
            // 
            // btnNuevo
            // 
            btnNuevo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnNuevo.Location = new Point(396, 156);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(86, 47);
            btnNuevo.TabIndex = 17;
            btnNuevo.Text = "NUEVO";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnGuardar.Location = new Point(304, 156);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(86, 47);
            btnGuardar.TabIndex = 18;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnEditar.Location = new Point(488, 156);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(86, 50);
            btnEditar.TabIndex = 19;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnEliminar.Location = new Point(671, 156);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(86, 50);
            btnEliminar.TabIndex = 20;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(579, 156);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(86, 50);
            btnBuscar.TabIndex = 21;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(273, 20);
            label8.Name = "label8";
            label8.Size = new Size(240, 25);
            label8.TabIndex = 22;
            label8.Text = "GESTIÓN DE PRODUCTOS";
            // 
            // FrmProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(btnBuscar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(cboProveedor);
            Controls.Add(cboCategoria);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDescripcion);
            Controls.Add(txtStockMinimo);
            Controls.Add(txtNombre);
            Controls.Add(txtStock);
            Controls.Add(txtCodigo);
            Controls.Add(txtPrecioVenta);
            Controls.Add(txtPrecioCompra);
            Controls.Add(dgvProductos);
            ForeColor = Color.Black;
            Name = "FrmProducto";
            Text = "FrmProducto";
            Load += FrmProducto_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductos;
        private TextBox txtPrecioCompra;
        private TextBox txtPrecioVenta;
        private TextBox txtCodigo;
        private TextBox txtStock;
        private TextBox txtNombre;
        private TextBox txtStockMinimo;
        private TextBox txtDescripcion;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox cboCategoria;
        private ComboBox cboProveedor;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnBuscar;
        private Label label8;
    }
}