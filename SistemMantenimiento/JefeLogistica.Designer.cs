namespace SistemMantenimiento
{
    partial class JefeLogistica
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JefeLogistica));
            this.content_titulo = new System.Windows.Forms.Panel();
            this.pb_logo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbl_descripcion = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_title = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel_side_bar = new System.Windows.Forms.Panel();
            this.btn_requerimientos = new Guna.UI2.WinForms.Guna2Button();
            this.btn_proveedores = new Guna.UI2.WinForms.Guna2Button();
            this.btn_materiales = new Guna.UI2.WinForms.Guna2Button();
            this.btn_nota_salida = new Guna.UI2.WinForms.Guna2Button();
            this.btn_nota_ingreso = new Guna.UI2.WinForms.Guna2Button();
            this.btn_inicio = new Guna.UI2.WinForms.Guna2Button();
            this.panel_superio = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_rezise_max = new System.Windows.Forms.PictureBox();
            this.btn_resize_min = new System.Windows.Forms.PictureBox();
            this.btn_minimizar = new System.Windows.Forms.PictureBox();
            this.btn_salir = new System.Windows.Forms.PictureBox();
            this.panel_form_hijo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.content_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.panel_side_bar.SuspendLayout();
            this.panel_superio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_rezise_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_resize_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // content_titulo
            // 
            this.content_titulo.Controls.Add(this.pb_logo);
            this.content_titulo.Controls.Add(this.lbl_descripcion);
            this.content_titulo.Controls.Add(this.lbl_title);
            this.content_titulo.Location = new System.Drawing.Point(11, 14);
            this.content_titulo.Name = "content_titulo";
            this.content_titulo.Size = new System.Drawing.Size(249, 77);
            this.content_titulo.TabIndex = 2;
            // 
            // pb_logo
            // 
            this.pb_logo.AutoRoundedCorners = true;
            this.pb_logo.BackColor = System.Drawing.Color.Transparent;
            this.pb_logo.BorderRadius = 31;
            this.pb_logo.FillColor = System.Drawing.Color.Transparent;
            this.pb_logo.Image = ((System.Drawing.Image)(resources.GetObject("pb_logo.Image")));
            this.pb_logo.ImageRotate = 0F;
            this.pb_logo.Location = new System.Drawing.Point(18, 3);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(64, 64);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_logo.TabIndex = 2;
            this.pb_logo.TabStop = false;
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbl_descripcion.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_descripcion.Location = new System.Drawing.Point(108, 40);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(94, 15);
            this.lbl_descripcion.TabIndex = 1;
            this.lbl_descripcion.Text = "Sistema Integral";
            // 
            // lbl_title
            // 
            this.lbl_title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(108, 12);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(75, 22);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Logística";
            // 
            // panel_side_bar
            // 
            this.panel_side_bar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_side_bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.panel_side_bar.Controls.Add(this.panel1);
            this.panel_side_bar.Controls.Add(this.btn_inicio);
            this.panel_side_bar.Controls.Add(this.content_titulo);
            this.panel_side_bar.Location = new System.Drawing.Point(-2, -2);
            this.panel_side_bar.Name = "panel_side_bar";
            this.panel_side_bar.Size = new System.Drawing.Size(270, 562);
            this.panel_side_bar.TabIndex = 5;
            this.panel_side_bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_side_bar_MouseDown);
            // 
            // btn_requerimientos
            // 
            this.btn_requerimientos.BackColor = System.Drawing.Color.Transparent;
            this.btn_requerimientos.BorderColor = System.Drawing.Color.Transparent;
            this.btn_requerimientos.BorderRadius = 10;
            this.btn_requerimientos.FillColor = System.Drawing.Color.Transparent;
            this.btn_requerimientos.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_requerimientos.ForeColor = System.Drawing.Color.White;
            this.btn_requerimientos.Location = new System.Drawing.Point(3, 210);
            this.btn_requerimientos.Name = "btn_requerimientos";
            this.btn_requerimientos.Size = new System.Drawing.Size(202, 45);
            this.btn_requerimientos.TabIndex = 10;
            this.btn_requerimientos.Text = "Requerimientos";
            // 
            // btn_proveedores
            // 
            this.btn_proveedores.BackColor = System.Drawing.Color.Transparent;
            this.btn_proveedores.BorderColor = System.Drawing.Color.Transparent;
            this.btn_proveedores.BorderRadius = 10;
            this.btn_proveedores.FillColor = System.Drawing.Color.Transparent;
            this.btn_proveedores.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_proveedores.ForeColor = System.Drawing.Color.White;
            this.btn_proveedores.Location = new System.Drawing.Point(3, 159);
            this.btn_proveedores.Name = "btn_proveedores";
            this.btn_proveedores.Size = new System.Drawing.Size(202, 45);
            this.btn_proveedores.TabIndex = 9;
            this.btn_proveedores.Text = "Proveedores";
            // 
            // btn_materiales
            // 
            this.btn_materiales.BackColor = System.Drawing.Color.Transparent;
            this.btn_materiales.BorderColor = System.Drawing.Color.Transparent;
            this.btn_materiales.BorderRadius = 10;
            this.btn_materiales.FillColor = System.Drawing.Color.Transparent;
            this.btn_materiales.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_materiales.ForeColor = System.Drawing.Color.White;
            this.btn_materiales.Location = new System.Drawing.Point(3, 108);
            this.btn_materiales.Name = "btn_materiales";
            this.btn_materiales.Size = new System.Drawing.Size(202, 45);
            this.btn_materiales.TabIndex = 8;
            this.btn_materiales.Text = "Materiales";
            // 
            // btn_nota_salida
            // 
            this.btn_nota_salida.BackColor = System.Drawing.Color.Transparent;
            this.btn_nota_salida.BorderColor = System.Drawing.Color.Transparent;
            this.btn_nota_salida.BorderRadius = 10;
            this.btn_nota_salida.FillColor = System.Drawing.Color.Transparent;
            this.btn_nota_salida.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_nota_salida.ForeColor = System.Drawing.Color.White;
            this.btn_nota_salida.Location = new System.Drawing.Point(3, 57);
            this.btn_nota_salida.Name = "btn_nota_salida";
            this.btn_nota_salida.Size = new System.Drawing.Size(202, 45);
            this.btn_nota_salida.TabIndex = 7;
            this.btn_nota_salida.Text = "Nota de Salida";
            // 
            // btn_nota_ingreso
            // 
            this.btn_nota_ingreso.BackColor = System.Drawing.Color.Transparent;
            this.btn_nota_ingreso.BorderColor = System.Drawing.Color.Transparent;
            this.btn_nota_ingreso.BorderRadius = 10;
            this.btn_nota_ingreso.FillColor = System.Drawing.Color.Transparent;
            this.btn_nota_ingreso.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_nota_ingreso.ForeColor = System.Drawing.Color.White;
            this.btn_nota_ingreso.Location = new System.Drawing.Point(3, 6);
            this.btn_nota_ingreso.Name = "btn_nota_ingreso";
            this.btn_nota_ingreso.Size = new System.Drawing.Size(202, 45);
            this.btn_nota_ingreso.TabIndex = 6;
            this.btn_nota_ingreso.Text = "Nota de Ingreso";
            // 
            // btn_inicio
            // 
            this.btn_inicio.BackColor = System.Drawing.Color.Transparent;
            this.btn_inicio.BorderColor = System.Drawing.Color.Transparent;
            this.btn_inicio.BorderRadius = 10;
            this.btn_inicio.FillColor = System.Drawing.Color.Transparent;
            this.btn_inicio.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_inicio.ForeColor = System.Drawing.Color.White;
            this.btn_inicio.Location = new System.Drawing.Point(14, 130);
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.Size = new System.Drawing.Size(246, 45);
            this.btn_inicio.TabIndex = 5;
            this.btn_inicio.Text = "Inicio";
            // 
            // panel_superio
            // 
            this.panel_superio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_superio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.panel_superio.Controls.Add(this.btn_rezise_max);
            this.panel_superio.Controls.Add(this.btn_resize_min);
            this.panel_superio.Controls.Add(this.btn_minimizar);
            this.panel_superio.Controls.Add(this.btn_salir);
            this.panel_superio.Location = new System.Drawing.Point(268, 0);
            this.panel_superio.Name = "panel_superio";
            this.panel_superio.Size = new System.Drawing.Size(1120, 46);
            this.panel_superio.TabIndex = 6;
            this.panel_superio.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_superio_MouseDown);
            // 
            // btn_rezise_max
            // 
            this.btn_rezise_max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_rezise_max.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btn_rezise_max.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_rezise_max.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rezise_max.Image = ((System.Drawing.Image)(resources.GetObject("btn_rezise_max.Image")));
            this.btn_rezise_max.Location = new System.Drawing.Point(1030, 1);
            this.btn_rezise_max.Name = "btn_rezise_max";
            this.btn_rezise_max.Size = new System.Drawing.Size(43, 43);
            this.btn_rezise_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_rezise_max.TabIndex = 0;
            this.btn_rezise_max.TabStop = false;
            this.btn_rezise_max.Click += new System.EventHandler(this.btn_rezise_max_Click);
            // 
            // btn_resize_min
            // 
            this.btn_resize_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_resize_min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btn_resize_min.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_resize_min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_resize_min.Location = new System.Drawing.Point(1030, 1);
            this.btn_resize_min.Name = "btn_resize_min";
            this.btn_resize_min.Size = new System.Drawing.Size(43, 43);
            this.btn_resize_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_resize_min.TabIndex = 1;
            this.btn_resize_min.TabStop = false;
            this.btn_resize_min.Visible = false;
            this.btn_resize_min.Click += new System.EventHandler(this.btn_resize_min_Click);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btn_minimizar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizar.Image")));
            this.btn_minimizar.Location = new System.Drawing.Point(985, 1);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(43, 43);
            this.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_minimizar.TabIndex = 2;
            this.btn_minimizar.TabStop = false;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btn_salir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_salir.Image")));
            this.btn_salir.Location = new System.Drawing.Point(1075, 1);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(43, 43);
            this.btn_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_salir.TabIndex = 3;
            this.btn_salir.TabStop = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // panel_form_hijo
            // 
            this.panel_form_hijo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_form_hijo.Location = new System.Drawing.Point(275, 49);
            this.panel_form_hijo.Name = "panel_form_hijo";
            this.panel_form_hijo.Size = new System.Drawing.Size(1100, 479);
            this.panel_form_hijo.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_requerimientos);
            this.panel1.Controls.Add(this.btn_materiales);
            this.panel1.Controls.Add(this.btn_proveedores);
            this.panel1.Controls.Add(this.btn_nota_ingreso);
            this.panel1.Controls.Add(this.btn_nota_salida);
            this.panel1.Location = new System.Drawing.Point(29, 197);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 259);
            this.panel1.TabIndex = 0;
            // 
            // JefeLogistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 531);
            this.Controls.Add(this.panel_form_hijo);
            this.Controls.Add(this.panel_superio);
            this.Controls.Add(this.panel_side_bar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "JefeLogistica";
            this.Text = "JefeLogistica";
            this.Load += new System.EventHandler(this.JefeLogistica_Load);
            this.content_titulo.ResumeLayout(false);
            this.content_titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.panel_side_bar.ResumeLayout(false);
            this.panel_superio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_rezise_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_resize_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel content_titulo;
        private Guna.UI2.WinForms.Guna2PictureBox pb_logo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_descripcion;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_title;
        private System.Windows.Forms.Panel panel_side_bar;
        private Guna.UI2.WinForms.Guna2Panel panel_superio;
        private System.Windows.Forms.PictureBox btn_salir;
        private System.Windows.Forms.PictureBox btn_rezise_max;
        private System.Windows.Forms.PictureBox btn_minimizar;
        private System.Windows.Forms.PictureBox btn_resize_min;
        private Guna.UI2.WinForms.Guna2Button btn_inicio;
        private Guna.UI2.WinForms.Guna2Button btn_nota_ingreso;
        private Guna.UI2.WinForms.Guna2Button btn_nota_salida;
        private Guna.UI2.WinForms.Guna2Button btn_materiales;
        private Guna.UI2.WinForms.Guna2Button btn_proveedores;
        private Guna.UI2.WinForms.Guna2Button btn_requerimientos;
        private System.Windows.Forms.Panel panel_form_hijo;
        private System.Windows.Forms.Panel panel1;
    }
}
