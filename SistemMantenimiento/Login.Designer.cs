namespace SistemMantenimiento
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel_derecho = new System.Windows.Forms.Panel();
            this.btn_minimizar = new System.Windows.Forms.PictureBox();
            this.btn_salir = new System.Windows.Forms.PictureBox();
            this.lbl_copy = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel_izquiero = new System.Windows.Forms.Panel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_titulo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel_login = new System.Windows.Forms.Panel();
            this.txb_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.txb_usuario = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_usuario = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_contraseña = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_ingresar = new Guna.UI2.WinForms.Guna2Button();
            this.panel_derecho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).BeginInit();
            this.panel_izquiero.SuspendLayout();
            this.panel_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_derecho
            // 
            this.panel_derecho.BackColor = System.Drawing.Color.Transparent;
            this.panel_derecho.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_derecho.BackgroundImage")));
            this.panel_derecho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_derecho.Controls.Add(this.btn_minimizar);
            this.panel_derecho.Controls.Add(this.btn_salir);
            this.panel_derecho.Controls.Add(this.lbl_copy);
            this.panel_derecho.ForeColor = System.Drawing.Color.Teal;
            this.panel_derecho.Location = new System.Drawing.Point(499, 0);
            this.panel_derecho.Name = "panel_derecho";
            this.panel_derecho.Size = new System.Drawing.Size(390, 462);
            this.panel_derecho.TabIndex = 1;
            this.panel_derecho.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_derecho_MouseDown);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_minimizar.BackgroundImage")));
            this.btn_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimizar.Location = new System.Drawing.Point(297, -1);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(46, 49);
            this.btn_minimizar.TabIndex = 3;
            this.btn_minimizar.TabStop = false;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_salir.BackgroundImage")));
            this.btn_salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salir.Location = new System.Drawing.Point(340, -1);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(50, 50);
            this.btn_salir.TabIndex = 2;
            this.btn_salir.TabStop = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // lbl_copy
            // 
            this.lbl_copy.BackColor = System.Drawing.Color.Transparent;
            this.lbl_copy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_copy.ForeColor = System.Drawing.Color.MintCream;
            this.lbl_copy.Location = new System.Drawing.Point(33, 436);
            this.lbl_copy.Name = "lbl_copy";
            this.lbl_copy.Size = new System.Drawing.Size(189, 15);
            this.lbl_copy.TabIndex = 1;
            this.lbl_copy.Text = "Copyright © 2025 Horus Systems";
            // 
            // panel_izquiero
            // 
            this.panel_izquiero.BackColor = System.Drawing.Color.White;
            this.panel_izquiero.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_izquiero.Controls.Add(this.guna2HtmlLabel2);
            this.panel_izquiero.Controls.Add(this.lbl_titulo);
            this.panel_izquiero.Controls.Add(this.panel_login);
            this.panel_izquiero.Controls.Add(this.btn_ingresar);
            this.panel_izquiero.ForeColor = System.Drawing.Color.Transparent;
            this.panel_izquiero.Location = new System.Drawing.Point(-4, -5);
            this.panel_izquiero.Name = "panel_izquiero";
            this.panel_izquiero.Size = new System.Drawing.Size(502, 468);
            this.panel_izquiero.TabIndex = 2;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.DarkGray;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(196, 54);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(126, 15);
            this.guna2HtmlLabel2.TabIndex = 6;
            this.guna2HtmlLabel2.Text = "Gestion de Mantenimiento";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbl_titulo.ForeColor = System.Drawing.Color.Teal;
            this.lbl_titulo.Location = new System.Drawing.Point(130, 17);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(288, 31);
            this.lbl_titulo.TabIndex = 6;
            this.lbl_titulo.Text = "Sistema de Mantenimiento";
            // 
            // panel_login
            // 
            this.panel_login.Controls.Add(this.txb_password);
            this.panel_login.Controls.Add(this.txb_usuario);
            this.panel_login.Controls.Add(this.lbl_usuario);
            this.panel_login.Controls.Add(this.lbl_contraseña);
            this.panel_login.Location = new System.Drawing.Point(59, 116);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(386, 207);
            this.panel_login.TabIndex = 3;
            this.panel_login.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_login_MouseDown);
            // 
            // txb_password
            // 
            this.txb_password.BorderRadius = 10;
            this.txb_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_password.DefaultText = "";
            this.txb_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_password.Location = new System.Drawing.Point(31, 145);
            this.txb_password.Name = "txb_password";
            this.txb_password.PlaceholderText = "";
            this.txb_password.SelectedText = "";
            this.txb_password.Size = new System.Drawing.Size(336, 36);
            this.txb_password.TabIndex = 7;
            // 
            // txb_usuario
            // 
            this.txb_usuario.BorderRadius = 10;
            this.txb_usuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_usuario.DefaultText = "";
            this.txb_usuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_usuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_usuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_usuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_usuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_usuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_usuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_usuario.Location = new System.Drawing.Point(31, 54);
            this.txb_usuario.Name = "txb_usuario";
            this.txb_usuario.PlaceholderText = "";
            this.txb_usuario.SelectedText = "";
            this.txb_usuario.Size = new System.Drawing.Size(336, 36);
            this.txb_usuario.TabIndex = 6;
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.BackColor = System.Drawing.Color.Transparent;
            this.lbl_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.ForeColor = System.Drawing.Color.Teal;
            this.lbl_usuario.Location = new System.Drawing.Point(31, 23);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(70, 22);
            this.lbl_usuario.TabIndex = 2;
            this.lbl_usuario.Text = "Usuario:";
            // 
            // lbl_contraseña
            // 
            this.lbl_contraseña.BackColor = System.Drawing.Color.Transparent;
            this.lbl_contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contraseña.ForeColor = System.Drawing.Color.Teal;
            this.lbl_contraseña.Location = new System.Drawing.Point(31, 114);
            this.lbl_contraseña.Name = "lbl_contraseña";
            this.lbl_contraseña.Size = new System.Drawing.Size(101, 22);
            this.lbl_contraseña.TabIndex = 1;
            this.lbl_contraseña.Text = "Contraseña:";
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.BackColor = System.Drawing.Color.Transparent;
            this.btn_ingresar.BorderColor = System.Drawing.Color.Transparent;
            this.btn_ingresar.BorderRadius = 15;
            this.btn_ingresar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ingresar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ingresar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ingresar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ingresar.FillColor = System.Drawing.Color.DarkGray;
            this.btn_ingresar.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ingresar.ForeColor = System.Drawing.Color.Teal;
            this.btn_ingresar.Location = new System.Drawing.Point(161, 355);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.PressedColor = System.Drawing.Color.Transparent;
            this.btn_ingresar.Size = new System.Drawing.Size(161, 50);
            this.btn_ingresar.TabIndex = 2;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 462);
            this.Controls.Add(this.panel_izquiero);
            this.Controls.Add(this.panel_derecho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "frm_Login";
            this.panel_derecho.ResumeLayout(false);
            this.panel_derecho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).EndInit();
            this.panel_izquiero.ResumeLayout(false);
            this.panel_izquiero.PerformLayout();
            this.panel_login.ResumeLayout(false);
            this.panel_login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_derecho;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_copy;
        private System.Windows.Forms.PictureBox btn_minimizar;
        private System.Windows.Forms.PictureBox btn_salir;
        private System.Windows.Forms.Panel panel_izquiero;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_titulo;
        private System.Windows.Forms.Panel panel_login;
        private Guna.UI2.WinForms.Guna2TextBox txb_password;
        private Guna.UI2.WinForms.Guna2TextBox txb_usuario;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_usuario;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_contraseña;
        private Guna.UI2.WinForms.Guna2Button btn_ingresar;
    }
}

