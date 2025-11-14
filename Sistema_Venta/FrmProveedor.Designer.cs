namespace Sistema_Venta
{
    partial class FrmProveedor
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
            txtBuscar = new TextBox();
            txtEmail = new TextBox();
            txtTelefono = new TextBox();
            txtRazonSocial = new TextBox();
            txtRUC = new TextBox();
            txtDireccion = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dgvProveedores = new DataGridView();
            btnNuevo = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnGuardar = new Button();
            btnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            SuspendLayout();
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(624, 64);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(144, 23);
            txtBuscar.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(130, 174);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(144, 23);
            txtEmail.TabIndex = 1;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(130, 126);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(144, 23);
            txtTelefono.TabIndex = 2;
            // 
            // txtRazonSocial
            // 
            txtRazonSocial.Location = new Point(130, 35);
            txtRazonSocial.Name = "txtRazonSocial";
            txtRazonSocial.Size = new Size(144, 23);
            txtRazonSocial.TabIndex = 3;
            // 
            // txtRUC
            // 
            txtRUC.Location = new Point(383, 64);
            txtRUC.Name = "txtRUC";
            txtRUC.Size = new Size(144, 23);
            txtRUC.TabIndex = 4;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(130, 80);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(144, 23);
            txtDireccion.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(30, 34);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 6;
            label1.Text = "Razón Social:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(340, 66);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 7;
            label2.Text = "RUC:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(30, 79);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 8;
            label3.Text = "Dirección:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.Location = new Point(30, 125);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 9;
            label4.Text = "Teléfono:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F);
            label5.Location = new Point(30, 174);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 10;
            label5.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F);
            label6.Location = new Point(566, 66);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 11;
            label6.Text = "Buscar:";
            // 
            // dgvProveedores
            // 
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedores.Location = new Point(329, 144);
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.Size = new Size(448, 273);
            dgvProveedores.TabIndex = 12;
            dgvProveedores.CellClick += dgvProveedores_CellClick;
            // 
            // btnNuevo
            // 
            btnNuevo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnNuevo.Location = new Point(53, 244);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(80, 58);
            btnNuevo.TabIndex = 13;
            btnNuevo.Text = "NUEVO";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnEliminar.Location = new Point(182, 317);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(80, 58);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnEditar.Location = new Point(53, 317);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(80, 58);
            btnEditar.TabIndex = 15;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnGuardar.Location = new Point(182, 244);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(80, 58);
            btnGuardar.TabIndex = 16;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(667, 97);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 37);
            btnBuscar.TabIndex = 17;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // FrmProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBuscar);
            Controls.Add(btnGuardar);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(btnNuevo);
            Controls.Add(dgvProveedores);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDireccion);
            Controls.Add(txtRUC);
            Controls.Add(txtRazonSocial);
            Controls.Add(txtTelefono);
            Controls.Add(txtEmail);
            Controls.Add(txtBuscar);
            ForeColor = Color.Black;
            Name = "FrmProveedor";
            Text = "FrmProveedor";
            Load += FrmProveedor_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBuscar;
        private TextBox txtEmail;
        private TextBox txtTelefono;
        private TextBox txtRazonSocial;
        private TextBox txtRUC;
        private TextBox txtDireccion;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridView dgvProveedores;
        private Button btnNuevo;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnGuardar;
        private Button btnBuscar;
    }
}