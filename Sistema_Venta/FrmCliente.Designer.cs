namespace Sistema_Venta
{
    partial class FrmCliente
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
            lblTitulo = new Label();
            lblTipoDoc = new Label();
            lblNumeroDoc = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            lblTelefono = new Label();
            lblEmail = new Label();
            lblDireccion = new Label();
            cboTipoDocumento = new ComboBox();
            txtDireccion = new TextBox();
            txtEmail = new TextBox();
            txtTelefono = new TextBox();
            txtIdCliente = new TextBox();
            txtNumeroDocumento = new TextBox();
            txtNombre = new TextBox();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            txtBuscar = new TextBox();
            label1 = new Label();
            btnBuscar = new Button();
            dgvClientes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(287, 25);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(212, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "GESTIÓN DE CLIENTES";
            // 
            // lblTipoDoc
            // 
            lblTipoDoc.AutoSize = true;
            lblTipoDoc.Font = new Font("Segoe UI", 11.25F);
            lblTipoDoc.Location = new Point(30, 72);
            lblTipoDoc.Name = "lblTipoDoc";
            lblTipoDoc.Size = new Size(94, 20);
            lblTipoDoc.TabIndex = 1;
            lblTipoDoc.Text = "Tipo de Doc.";
            // 
            // lblNumeroDoc
            // 
            lblNumeroDoc.AutoSize = true;
            lblNumeroDoc.Font = new Font("Segoe UI", 11.25F);
            lblNumeroDoc.Location = new Point(30, 110);
            lblNumeroDoc.Name = "lblNumeroDoc";
            lblNumeroDoc.Size = new Size(143, 20);
            lblNumeroDoc.TabIndex = 2;
            lblNumeroDoc.Text = "Nro. de Documento:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 11.25F);
            lblNombre.Location = new Point(30, 192);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 11.25F);
            lblApellido.Location = new Point(30, 151);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(25, 20);
            lblApellido.TabIndex = 4;
            lblApellido.Text = "Id:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 11.25F);
            lblTelefono.Location = new Point(29, 228);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(70, 20);
            lblTelefono.TabIndex = 5;
            lblTelefono.Text = "Teléfono:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 11.25F);
            lblEmail.Location = new Point(29, 266);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email:";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Segoe UI", 11.25F);
            lblDireccion.Location = new Point(29, 303);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(75, 20);
            lblDireccion.TabIndex = 7;
            lblDireccion.Text = "Dirección:";
            // 
            // cboTipoDocumento
            // 
            cboTipoDocumento.FormattingEnabled = true;
            cboTipoDocumento.Location = new Point(179, 69);
            cboTipoDocumento.Name = "cboTipoDocumento";
            cboTipoDocumento.Size = new Size(172, 23);
            cboTipoDocumento.TabIndex = 8;
            cboTipoDocumento.SelectedIndexChanged += cboTipoDocumento_SelectedIndexChanged;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(103, 300);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(172, 23);
            txtDireccion.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(103, 263);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(172, 23);
            txtEmail.TabIndex = 10;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(103, 229);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(172, 23);
            txtTelefono.TabIndex = 11;
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(103, 148);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(172, 23);
            txtIdCliente.TabIndex = 12;
            // 
            // txtNumeroDocumento
            // 
            txtNumeroDocumento.Location = new Point(179, 107);
            txtNumeroDocumento.Name = "txtNumeroDocumento";
            txtNumeroDocumento.Size = new Size(172, 23);
            txtNumeroDocumento.TabIndex = 14;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(103, 189);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(172, 23);
            txtNombre.TabIndex = 15;
            // 
            // btnNuevo
            // 
            btnNuevo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnNuevo.Location = new Point(25, 359);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(77, 48);
            btnNuevo.TabIndex = 16;
            btnNuevo.Text = "NUEVO";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnGuardar.Location = new Point(114, 359);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(86, 48);
            btnGuardar.TabIndex = 17;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnEditar.Location = new Point(210, 359);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(77, 48);
            btnEditar.TabIndex = 18;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnEliminar.Location = new Point(304, 359);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(77, 48);
            btnEliminar.TabIndex = 19;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(458, 74);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(319, 23);
            txtBuscar.TabIndex = 20;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(401, 77);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 21;
            label1.Text = "Buscar";
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnBuscar.Location = new Point(527, 123);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(141, 48);
            btnBuscar.TabIndex = 22;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(401, 189);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(376, 249);
            dgvClientes.TabIndex = 23;
            dgvClientes.CellContentClick += dgvClientes_CellClick;
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvClientes);
            Controls.Add(btnBuscar);
            Controls.Add(label1);
            Controls.Add(txtBuscar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(txtNombre);
            Controls.Add(txtNumeroDocumento);
            Controls.Add(txtIdCliente);
            Controls.Add(txtTelefono);
            Controls.Add(txtEmail);
            Controls.Add(txtDireccion);
            Controls.Add(cboTipoDocumento);
            Controls.Add(lblDireccion);
            Controls.Add(lblEmail);
            Controls.Add(lblTelefono);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblNumeroDoc);
            Controls.Add(lblTipoDoc);
            Controls.Add(lblTitulo);
            ForeColor = Color.Black;
            Name = "FrmCliente";
            Text = "FrmCliente";
            Load += FrmCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblTipoDoc;
        private Label lblNumeroDoc;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblTelefono;
        private Label lblEmail;
        private Label lblDireccion;
        private ComboBox cboTipoDocumento;
        private TextBox txtDireccion;
        private TextBox txtEmail;
        private TextBox txtTelefono;
        private TextBox txtIdCliente;
        private TextBox txtNumeroDocumento;
        private TextBox txtNombre;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnEliminar;
        private TextBox txtBuscar;
        private Label label1;
        private Button btnBuscar;
        private DataGridView dgvClientes;
    }
}