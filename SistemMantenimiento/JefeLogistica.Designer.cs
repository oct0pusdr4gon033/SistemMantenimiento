using System.Windows.Forms;

namespace SistemMantenimiento
{
    partial class JefeLogistica
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JefeLogistica));
            this.panel_side_bar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_inicio = new Guna.UI2.WinForms.Guna2Button();
            this.btn_nota_ingreso = new Guna.UI2.WinForms.Guna2Button();
            this.btn_nota_salida = new Guna.UI2.WinForms.Guna2Button();
            this.btn_producto = new Guna.UI2.WinForms.Guna2Button();
            this.flp_sub_menu_productos = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_proveedores = new Guna.UI2.WinForms.Guna2Button();
            this.btn_requerimientos = new Guna.UI2.WinForms.Guna2Button();
            this.content_titulo = new System.Windows.Forms.Panel();
            this.pb_logo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbl_descripcion = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_title = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel_superio = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_rezise_max = new System.Windows.Forms.PictureBox();
            this.btn_resize_min = new System.Windows.Forms.PictureBox();
            this.btn_minimizar = new System.Windows.Forms.PictureBox();
            this.btn_salir = new System.Windows.Forms.PictureBox();
            this.panel_form_hijo = new System.Windows.Forms.Panel();
            this.panel_side_bar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.content_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.panel_superio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_rezise_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_resize_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_side_bar
            // 
            this.panel_side_bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.panel_side_bar.Controls.Add(this.panel1);
            this.panel_side_bar.Controls.Add(this.content_titulo);
            this.panel_side_bar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_side_bar.Location = new System.Drawing.Point(0, 46);
            this.panel_side_bar.Name = "panel_side_bar";
            this.panel_side_bar.Size = new System.Drawing.Size(270, 584);
            this.panel_side_bar.TabIndex = 1;
            this.panel_side_bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_side_bar_MouseDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_inicio);
            this.panel1.Controls.Add(this.btn_nota_ingreso);
            this.panel1.Controls.Add(this.btn_nota_salida);
            this.panel1.Controls.Add(this.btn_producto);
            this.panel1.Controls.Add(this.flp_sub_menu_productos);
            this.panel1.Controls.Add(this.btn_proveedores);
            this.panel1.Controls.Add(this.btn_requerimientos);
            this.panel1.Location = new System.Drawing.Point(25, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 472);
            this.panel1.TabIndex = 0;
            // 
            // btn_inicio
            // 
            this.btn_inicio.FillColor = System.Drawing.Color.Transparent;
            this.btn_inicio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_inicio.ForeColor = System.Drawing.Color.White;
            this.btn_inicio.Location = new System.Drawing.Point(-44, 3);
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.Size = new System.Drawing.Size(209, 40);
            this.btn_inicio.TabIndex = 6;
            this.btn_inicio.Text = "Inicio";
            // 
            // btn_nota_ingreso
            // 
            this.btn_nota_ingreso.FillColor = System.Drawing.Color.Transparent;
            this.btn_nota_ingreso.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_nota_ingreso.ForeColor = System.Drawing.Color.White;
            this.btn_nota_ingreso.Location = new System.Drawing.Point(-8, 44);
            this.btn_nota_ingreso.Name = "btn_nota_ingreso";
            this.btn_nota_ingreso.Size = new System.Drawing.Size(209, 40);
            this.btn_nota_ingreso.TabIndex = 5;
            this.btn_nota_ingreso.Text = "Nota de Ingreso";
            // 
            // btn_nota_salida
            // 
            this.btn_nota_salida.FillColor = System.Drawing.Color.Transparent;
            this.btn_nota_salida.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_nota_salida.ForeColor = System.Drawing.Color.White;
            this.btn_nota_salida.Location = new System.Drawing.Point(-11, 90);
            this.btn_nota_salida.Name = "btn_nota_salida";
            this.btn_nota_salida.Size = new System.Drawing.Size(209, 40);
            this.btn_nota_salida.TabIndex = 4;
            this.btn_nota_salida.Text = "Nota de Salida";
            // 
            // btn_producto
            // 
            this.btn_producto.FillColor = System.Drawing.Color.Transparent;
            this.btn_producto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_producto.ForeColor = System.Drawing.Color.White;
            this.btn_producto.Location = new System.Drawing.Point(-22, 129);
            this.btn_producto.Name = "btn_producto";
            this.btn_producto.Size = new System.Drawing.Size(209, 40);
            this.btn_producto.TabIndex = 3;
            this.btn_producto.Text = "Producto ▼";
            this.btn_producto.Click += new System.EventHandler(this.btn_producto_Click);
            // 
            // flp_sub_menu_productos
            // 
            this.flp_sub_menu_productos.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flp_sub_menu_productos.Location = new System.Drawing.Point(6, 175);
            this.flp_sub_menu_productos.Name = "flp_sub_menu_productos";
            this.flp_sub_menu_productos.Padding = new System.Windows.Forms.Padding(20, 5, 0, 5);
            this.flp_sub_menu_productos.Size = new System.Drawing.Size(209, 174);
            this.flp_sub_menu_productos.TabIndex = 7;
            this.flp_sub_menu_productos.Visible = false;
            // 
            // btn_proveedores
            // 
            this.btn_proveedores.FillColor = System.Drawing.Color.Transparent;
            this.btn_proveedores.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_proveedores.ForeColor = System.Drawing.Color.White;
            this.btn_proveedores.Location = new System.Drawing.Point(-13, 355);
            this.btn_proveedores.Name = "btn_proveedores";
            this.btn_proveedores.Size = new System.Drawing.Size(209, 40);
            this.btn_proveedores.TabIndex = 2;
            this.btn_proveedores.Text = "Proveedores";
            // 
            // btn_requerimientos
            // 
            this.btn_requerimientos.FillColor = System.Drawing.Color.Transparent;
            this.btn_requerimientos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_requerimientos.ForeColor = System.Drawing.Color.White;
            this.btn_requerimientos.Location = new System.Drawing.Point(-2, 401);
            this.btn_requerimientos.Name = "btn_requerimientos";
            this.btn_requerimientos.Size = new System.Drawing.Size(209, 40);
            this.btn_requerimientos.TabIndex = 1;
            this.btn_requerimientos.Text = "Requerimientos";
            // 
            // content_titulo
            // 
            this.content_titulo.Controls.Add(this.pb_logo);
            this.content_titulo.Controls.Add(this.lbl_descripcion);
            this.content_titulo.Controls.Add(this.lbl_title);
            this.content_titulo.Location = new System.Drawing.Point(11, 14);
            this.content_titulo.Name = "content_titulo";
            this.content_titulo.Size = new System.Drawing.Size(249, 77);
            this.content_titulo.TabIndex = 7;
            // 
            // pb_logo
            // 
            this.pb_logo.Image = ((System.Drawing.Image)(resources.GetObject("pb_logo.Image")));
            this.pb_logo.ImageRotate = 0F;
            this.pb_logo.Location = new System.Drawing.Point(15, 7);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(64, 64);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_logo.TabIndex = 4;
            this.pb_logo.TabStop = false;
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_descripcion.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbl_descripcion.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_descripcion.Location = new System.Drawing.Point(108, 39);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(86, 15);
            this.lbl_descripcion.TabIndex = 3;
            this.lbl_descripcion.Text = "Sistema Integral";
            // 
            // lbl_title
            // 
            this.lbl_title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(108, 7);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(71, 23);
            this.lbl_title.TabIndex = 2;
            this.lbl_title.Text = "Logística";
            // 
            // panel_superio
            // 
            this.panel_superio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.panel_superio.Controls.Add(this.btn_rezise_max);
            this.panel_superio.Controls.Add(this.btn_resize_min);
            this.panel_superio.Controls.Add(this.btn_minimizar);
            this.panel_superio.Controls.Add(this.btn_salir);
            this.panel_superio.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_superio.Location = new System.Drawing.Point(0, 0);
            this.panel_superio.Name = "panel_superio";
            this.panel_superio.Size = new System.Drawing.Size(1256, 46);
            this.panel_superio.TabIndex = 2;
            this.panel_superio.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_superio_MouseDown);
            // 
            // btn_rezise_max
            // 
            this.btn_rezise_max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_rezise_max.Image = ((System.Drawing.Image)(resources.GetObject("btn_rezise_max.Image")));
            this.btn_rezise_max.Location = new System.Drawing.Point(1169, 1);
            this.btn_rezise_max.Name = "btn_rezise_max";
            this.btn_rezise_max.Size = new System.Drawing.Size(43, 45);
            this.btn_rezise_max.TabIndex = 1;
            this.btn_rezise_max.TabStop = false;
            this.btn_rezise_max.Click += new System.EventHandler(this.btn_rezise_max_Click);
            // 
            // btn_resize_min
            // 
            this.btn_resize_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_resize_min.Image = ((System.Drawing.Image)(resources.GetObject("btn_resize_min.Image")));
            this.btn_resize_min.Location = new System.Drawing.Point(1169, 1);
            this.btn_resize_min.Name = "btn_resize_min";
            this.btn_resize_min.Size = new System.Drawing.Size(43, 45);
            this.btn_resize_min.TabIndex = 3;
            this.btn_resize_min.TabStop = false;
            this.btn_resize_min.Visible = false;
            this.btn_resize_min.Click += new System.EventHandler(this.btn_resize_min_Click);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizar.Image")));
            this.btn_minimizar.Location = new System.Drawing.Point(1125, 2);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(43, 45);
            this.btn_minimizar.TabIndex = 0;
            this.btn_minimizar.TabStop = false;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_salir.Image")));
            this.btn_salir.Location = new System.Drawing.Point(1212, 2);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(43, 45);
            this.btn_salir.TabIndex = 2;
            this.btn_salir.TabStop = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // panel_form_hijo
            // 
            this.panel_form_hijo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_form_hijo.Location = new System.Drawing.Point(270, 46);
            this.panel_form_hijo.Name = "panel_form_hijo";
            this.panel_form_hijo.Size = new System.Drawing.Size(986, 584);
            this.panel_form_hijo.TabIndex = 0;
            // 
            // JefeLogistica
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1256, 630);
            this.Controls.Add(this.panel_form_hijo);
            this.Controls.Add(this.panel_side_bar);
            this.Controls.Add(this.panel_superio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "JefeLogistica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JefeLogistica";
            this.Load += new System.EventHandler(this.JefeLogistica_Load);
            this.panel_side_bar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.content_titulo.ResumeLayout(false);
            this.content_titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.panel_superio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_rezise_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_resize_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_side_bar;
        private System.Windows.Forms.Panel panel_form_hijo;
        private Guna.UI2.WinForms.Guna2Panel panel_superio;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btn_inicio;
        private Guna.UI2.WinForms.Guna2Button btn_nota_ingreso;
        private Guna.UI2.WinForms.Guna2Button btn_nota_salida;
        private Guna.UI2.WinForms.Guna2Button btn_producto;
        private Guna.UI2.WinForms.Guna2Button btn_proveedores;
        private Guna.UI2.WinForms.Guna2Button btn_requerimientos;
        private System.Windows.Forms.FlowLayoutPanel flp_sub_menu_productos;
        private System.Windows.Forms.Panel content_titulo;
        private Guna.UI2.WinForms.Guna2PictureBox pb_logo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_descripcion;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_title;
        private System.Windows.Forms.PictureBox btn_minimizar;
        private System.Windows.Forms.PictureBox btn_rezise_max;
        private System.Windows.Forms.PictureBox btn_salir;
        private System.Windows.Forms.PictureBox btn_resize_min;
    }
}