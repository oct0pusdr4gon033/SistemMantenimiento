namespace SistemMantenimiento.JeffeMantto
{
    partial class frm_Inicio
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
            this.panel_perfil = new System.Windows.Forms.Panel();
            this.panel_bienvenidad = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lbl_bienvenida = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_fecha_bienvenida = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_usuario_bienvenida = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_rol_bienvenida = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.flp_panel_principal = new System.Windows.Forms.FlowLayoutPanel();
            this.flp_panel_kpi = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_bienvenidad.SuspendLayout();
            this.flp_panel_principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_perfil
            // 
            this.panel_perfil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_perfil.BackColor = System.Drawing.Color.Transparent;
            this.panel_perfil.Location = new System.Drawing.Point(686, 5);
            this.panel_perfil.Name = "panel_perfil";
            this.panel_perfil.Size = new System.Drawing.Size(100, 95);
            this.panel_perfil.TabIndex = 10;
            this.panel_perfil.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_perfil_Paint);
            // 
            // panel_bienvenidad
            // 
            this.panel_bienvenidad.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel_bienvenidad.BackColor = System.Drawing.Color.Transparent;
            this.panel_bienvenidad.Controls.Add(this.panel_perfil);
            this.panel_bienvenidad.Controls.Add(this.lbl_rol_bienvenida);
            this.panel_bienvenidad.Controls.Add(this.lbl_usuario_bienvenida);
            this.panel_bienvenidad.Controls.Add(this.lbl_fecha_bienvenida);
            this.panel_bienvenidad.Controls.Add(this.lbl_bienvenida);
            this.panel_bienvenidad.FillColor = System.Drawing.Color.White;
            this.panel_bienvenidad.Location = new System.Drawing.Point(3, 3);
            this.panel_bienvenidad.Name = "panel_bienvenidad";
            this.panel_bienvenidad.Radius = 15;
            this.panel_bienvenidad.ShadowColor = System.Drawing.Color.Black;
            this.panel_bienvenidad.Size = new System.Drawing.Size(1038, 107);
            this.panel_bienvenidad.TabIndex = 3;
            // 
            // lbl_bienvenida
            // 
            this.lbl_bienvenida.BackColor = System.Drawing.Color.Transparent;
            this.lbl_bienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bienvenida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.lbl_bienvenida.Location = new System.Drawing.Point(61, 22);
            this.lbl_bienvenida.Name = "lbl_bienvenida";
            this.lbl_bienvenida.Size = new System.Drawing.Size(393, 27);
            this.lbl_bienvenida.TabIndex = 1;
            this.lbl_bienvenida.Text = "Bienvenido al Sistema de Mantenimiento";
            // 
            // lbl_fecha_bienvenida
            // 
            this.lbl_fecha_bienvenida.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fecha_bienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_bienvenida.ForeColor = System.Drawing.Color.Gray;
            this.lbl_fecha_bienvenida.Location = new System.Drawing.Point(61, 55);
            this.lbl_fecha_bienvenida.Name = "lbl_fecha_bienvenida";
            this.lbl_fecha_bienvenida.Size = new System.Drawing.Size(119, 22);
            this.lbl_fecha_bienvenida.TabIndex = 4;
            this.lbl_fecha_bienvenida.Text = "Sistema Integral";
            // 
            // lbl_usuario_bienvenida
            // 
            this.lbl_usuario_bienvenida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_usuario_bienvenida.BackColor = System.Drawing.Color.Transparent;
            this.lbl_usuario_bienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario_bienvenida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.lbl_usuario_bienvenida.Location = new System.Drawing.Point(811, 22);
            this.lbl_usuario_bienvenida.Name = "lbl_usuario_bienvenida";
            this.lbl_usuario_bienvenida.Size = new System.Drawing.Size(48, 27);
            this.lbl_usuario_bienvenida.TabIndex = 8;
            this.lbl_usuario_bienvenida.Text = "User";
            // 
            // lbl_rol_bienvenida
            // 
            this.lbl_rol_bienvenida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_rol_bienvenida.BackColor = System.Drawing.Color.Transparent;
            this.lbl_rol_bienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rol_bienvenida.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_rol_bienvenida.Location = new System.Drawing.Point(814, 55);
            this.lbl_rol_bienvenida.Name = "lbl_rol_bienvenida";
            this.lbl_rol_bienvenida.Size = new System.Drawing.Size(27, 22);
            this.lbl_rol_bienvenida.TabIndex = 9;
            this.lbl_rol_bienvenida.Text = "Rol";
            // 
            // flp_panel_principal
            // 
            this.flp_panel_principal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flp_panel_principal.AutoScroll = true;
            this.flp_panel_principal.Controls.Add(this.panel_bienvenidad);
            this.flp_panel_principal.Controls.Add(this.flp_panel_kpi);
            this.flp_panel_principal.Location = new System.Drawing.Point(12, 6);
            this.flp_panel_principal.Name = "flp_panel_principal";
            this.flp_panel_principal.Size = new System.Drawing.Size(1104, 467);
            this.flp_panel_principal.TabIndex = 2;
            // 
            // flp_panel_kpi
            // 
            this.flp_panel_kpi.Location = new System.Drawing.Point(3, 116);
            this.flp_panel_kpi.Name = "flp_panel_kpi";
            this.flp_panel_kpi.Size = new System.Drawing.Size(1038, 304);
            this.flp_panel_kpi.TabIndex = 4;
            // 
            // frm_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 485);
            this.Controls.Add(this.flp_panel_principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.frm_Inicio_Load);
            this.panel_bienvenidad.ResumeLayout(false);
            this.panel_bienvenidad.PerformLayout();
            this.flp_panel_principal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_perfil;
        private Guna.UI2.WinForms.Guna2ShadowPanel panel_bienvenidad;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_rol_bienvenida;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_usuario_bienvenida;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_fecha_bienvenida;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_bienvenida;
        private System.Windows.Forms.FlowLayoutPanel flp_panel_principal;
        private System.Windows.Forms.FlowLayoutPanel flp_panel_kpi;
    }
}