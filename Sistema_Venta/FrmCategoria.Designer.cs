namespace Sistema_Venta
{
    partial class FrmCategoria
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNombre = new TextBox();
            txtBuscar = new TextBox();
            txtDescripcion = new TextBox();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnBuscar = new Button();
            dgvCategorias = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(325, 29);
            label1.Name = "label1";
            label1.Size = new Size(127, 25);
            label1.TabIndex = 0;
            label1.Text = "CATEGORIAS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(29, 81);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(29, 137);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 2;
            label3.Text = "Descripción:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.Location = new Point(29, 191);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 3;
            label4.Text = "Buscar:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(124, 81);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(116, 23);
            txtNombre.TabIndex = 4;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(124, 190);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(116, 23);
            txtBuscar.TabIndex = 5;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(124, 134);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(116, 23);
            txtDescripcion.TabIndex = 6;
            txtDescripcion.TextChanged += txtDescripcion_TextChanged;
            // 
            // btnNuevo
            // 
            btnNuevo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnNuevo.Location = new Point(310, 81);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(98, 51);
            btnNuevo.TabIndex = 7;
            btnNuevo.Text = "NUEVO";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnGuardar.Location = new Point(451, 81);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(98, 51);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnEditar.Location = new Point(310, 160);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(98, 51);
            btnEditar.TabIndex = 9;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnEliminar.Location = new Point(451, 162);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(98, 51);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnBuscar.Location = new Point(585, 119);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(98, 51);
            btnBuscar.TabIndex = 11;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgvCategorias
            // 
            dgvCategorias.BackgroundColor = Color.White;
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Location = new Point(12, 243);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.Size = new Size(776, 195);
            dgvCategorias.TabIndex = 12;
            dgvCategorias.CellContentClick += dgvCategorias_CellClick;
            // 
            // FrmCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvCategorias);
            Controls.Add(btnBuscar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(txtDescripcion);
            Controls.Add(txtBuscar);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.Black;
            Name = "FrmCategoria";
            Text = "FrmCategoria";
            Load += FrmCategoria_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNombre;
        private TextBox txtBuscar;
        private TextBox txtDescripcion;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnBuscar;
        private DataGridView dgvCategorias;
    }
}