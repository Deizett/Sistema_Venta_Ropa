namespace Sistema_Venta
{
    partial class FrmLogin
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
            btnIngresar = new Button();
            txtPassword = new TextBox();
            txtUsuario = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(89, 72);
            label1.Name = "label1";
            label1.Size = new Size(172, 37);
            label1.TabIndex = 0;
            label1.Text = "Iniciar Sesión";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(25, 160);
            label2.Name = "label2";
            label2.Size = new Size(81, 25);
            label2.TabIndex = 1;
            label2.Text = "Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F);
            label3.Location = new Point(25, 232);
            label3.Name = "label3";
            label3.Size = new Size(112, 25);
            label3.TabIndex = 2;
            label3.Text = "Contraseña:";
            // 
            // btnIngresar
            // 
            btnIngresar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIngresar.Location = new Point(131, 320);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(99, 46);
            btnIngresar.TabIndex = 3;
            btnIngresar.Text = "Login";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(143, 233);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(182, 23);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(143, 162);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(182, 23);
            txtUsuario.TabIndex = 5;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(14, 94, 111);
            panel1.Controls.Add(pictureBox1);
            panel1.ForeColor = Color.PaleGoldenrod;
            panel1.Location = new Point(387, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(415, 453);
            panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LOGO;
            pictureBox1.Location = new Point(2, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(412, 367);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(txtUsuario);
            Controls.Add(txtPassword);
            Controls.Add(btnIngresar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "FrmLogin";
            Text = "FrmLogin";
            Load += FrmLogin_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnIngresar;
        private TextBox txtPassword;
        private TextBox txtUsuario;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}