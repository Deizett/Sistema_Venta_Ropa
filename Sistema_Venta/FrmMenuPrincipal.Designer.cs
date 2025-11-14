namespace Sistema_Venta
{
    partial class FrmMenuPrincipal
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
            menuPrincipal = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            mantenimientoToolStripMenuItem = new ToolStripMenuItem();
            productosToolStripMenuItem = new ToolStripMenuItem();
            categoriasToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            proveedoresToolStripMenuItem = new ToolStripMenuItem();
            ventaToolStripMenuItem = new ToolStripMenuItem();
            registrarToolStripMenuItem = new ToolStripMenuItem();
            consultarToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            reporteGeneralToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panelIzquierda = new Panel();
            panelDerecha = new Panel();
            panelBienvenida = new Panel();
            panelContenedor = new Panel();
            menuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelBienvenida.SuspendLayout();
            panelContenedor.SuspendLayout();
            SuspendLayout();
            // 
            // menuPrincipal
            // 
            menuPrincipal.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, mantenimientoToolStripMenuItem, ventaToolStripMenuItem, reportesToolStripMenuItem, ayudaToolStripMenuItem });
            menuPrincipal.Location = new Point(0, 0);
            menuPrincipal.Name = "menuPrincipal";
            menuPrincipal.Size = new Size(799, 24);
            menuPrincipal.TabIndex = 0;
            menuPrincipal.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            archivoToolStripMenuItem.Click += archivoToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(96, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // mantenimientoToolStripMenuItem
            // 
            mantenimientoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { productosToolStripMenuItem, categoriasToolStripMenuItem, clientesToolStripMenuItem, proveedoresToolStripMenuItem });
            mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            mantenimientoToolStripMenuItem.Size = new Size(101, 20);
            mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(139, 22);
            productosToolStripMenuItem.Text = "Productos";
            productosToolStripMenuItem.Click += productosToolStripMenuItem_Click;
            // 
            // categoriasToolStripMenuItem
            // 
            categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            categoriasToolStripMenuItem.Size = new Size(139, 22);
            categoriasToolStripMenuItem.Text = "Categorias";
            categoriasToolStripMenuItem.Click += categoriasToolStripMenuItem_Click;
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(139, 22);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // proveedoresToolStripMenuItem
            // 
            proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            proveedoresToolStripMenuItem.Size = new Size(139, 22);
            proveedoresToolStripMenuItem.Text = "Proveedores";
            proveedoresToolStripMenuItem.Click += proveedoresToolStripMenuItem_Click_1;
            // 
            // ventaToolStripMenuItem
            // 
            ventaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registrarToolStripMenuItem, consultarToolStripMenuItem });
            ventaToolStripMenuItem.Name = "ventaToolStripMenuItem";
            ventaToolStripMenuItem.Size = new Size(53, 20);
            ventaToolStripMenuItem.Text = "Ventas";
            ventaToolStripMenuItem.Click += ventaToolStripMenuItem_Click;
            // 
            // registrarToolStripMenuItem
            // 
            registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            registrarToolStripMenuItem.Size = new Size(125, 22);
            registrarToolStripMenuItem.Text = "Registrar";
            registrarToolStripMenuItem.Click += registrarToolStripMenuItem_Click;
            // 
            // consultarToolStripMenuItem
            // 
            consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            consultarToolStripMenuItem.Size = new Size(125, 22);
            consultarToolStripMenuItem.Text = "Consultar";
            consultarToolStripMenuItem.Click += consultarToolStripMenuItem_Click;
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { reporteGeneralToolStripMenuItem });
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(65, 20);
            reportesToolStripMenuItem.Text = "Reportes";
            reportesToolStripMenuItem.Click += reportesToolStripMenuItem_Click_1;
            // 
            // reporteGeneralToolStripMenuItem
            // 
            reporteGeneralToolStripMenuItem.Name = "reporteGeneralToolStripMenuItem";
            reporteGeneralToolStripMenuItem.Size = new Size(158, 22);
            reporteGeneralToolStripMenuItem.Text = "Reporte General";
            reporteGeneralToolStripMenuItem.Click += reporteGeneralToolStripMenuItem_Click;
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { acercaDeToolStripMenuItem });
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(53, 20);
            ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(135, 22);
            acercaDeToolStripMenuItem.Text = "Acerca de...";
            acercaDeToolStripMenuItem.Click += acercaDeToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.istockphoto_1345105967_170667a;
            pictureBox1.Location = new Point(38, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(386, 210);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(70, 216);
            label1.Name = "label1";
            label1.Size = new Size(324, 50);
            label1.TabIndex = 2;
            label1.Text = "\"MODA Y ESTILO\" ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(136, 271);
            label2.Name = "label2";
            label2.Size = new Size(206, 21);
            label2.TabIndex = 3;
            label2.Text = "Vestir bien es una actitud.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(0, 291);
            label3.Name = "label3";
            label3.Size = new Size(497, 42);
            label3.TabIndex = 4;
            label3.Text = "\r\n  Somos una tienda dedicada a ofrecer prendas modernas y de calidad,";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(11, 333);
            label4.Name = "label4";
            label4.Size = new Size(486, 42);
            label4.TabIndex = 5;
            label4.Text = "\r\npensadas para resaltar tu estilo propio y acompañarte en tu día a día.";
            // 
            // panelIzquierda
            // 
            panelIzquierda.BackColor = Color.FromArgb(14, 94, 111);
            panelIzquierda.Location = new Point(0, 0);
            panelIzquierda.Name = "panelIzquierda";
            panelIzquierda.Size = new Size(98, 482);
            panelIzquierda.TabIndex = 6;
            // 
            // panelDerecha
            // 
            panelDerecha.BackColor = Color.FromArgb(14, 94, 111);
            panelDerecha.Location = new Point(702, 0);
            panelDerecha.Name = "panelDerecha";
            panelDerecha.Size = new Size(98, 479);
            panelDerecha.TabIndex = 7;
            // 
            // panelBienvenida
            // 
            panelBienvenida.Controls.Add(pictureBox1);
            panelBienvenida.Controls.Add(label1);
            panelBienvenida.Controls.Add(label2);
            panelBienvenida.Controls.Add(label4);
            panelBienvenida.Controls.Add(label3);
            panelBienvenida.Location = new Point(151, 16);
            panelBienvenida.Name = "panelBienvenida";
            panelBienvenida.Size = new Size(516, 432);
            panelBienvenida.TabIndex = 8;
            panelBienvenida.Paint += panelBienvenida_Paint;
            // 
            // panelContenedor
            // 
            panelContenedor.Controls.Add(panelBienvenida);
            panelContenedor.Controls.Add(panelDerecha);
            panelContenedor.Controls.Add(panelIzquierda);
            panelContenedor.Location = new Point(0, 27);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(800, 482);
            panelContenedor.TabIndex = 9;
            panelContenedor.Paint += panelContenedor_Paint;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(799, 521);
            Controls.Add(panelContenedor);
            Controls.Add(menuPrincipal);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmMenuPrincipal";
            Text = "MENÚ PRINCIPAL";
            Load += FrmMenuPrincipal_Load;
            menuPrincipal.ResumeLayout(false);
            menuPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelBienvenida.ResumeLayout(false);
            panelBienvenida.PerformLayout();
            panelContenedor.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuPrincipal;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem mantenimientoToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripMenuItem categoriasToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem proveedoresToolStripMenuItem;
        private ToolStripMenuItem ventaToolStripMenuItem;
        private ToolStripMenuItem registrarToolStripMenuItem;
        private ToolStripMenuItem consultarToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private ToolStripMenuItem reporteGeneralToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panelIzquierda;
        private Panel panelDerecha;
        private Panel panelBienvenida;
        private Panel panelContenedor;
    }
}