using System.Windows.Forms;

namespace SistemMantenimiento
{
    partial class Administrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrador));
            this.panelSuperior = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_rezise_max = new System.Windows.Forms.PictureBox();
            this.btn_minimizar = new System.Windows.Forms.PictureBox();
            this.btn_resize_min = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCargos = new Guna.UI2.WinForms.Guna2Button();
            this.btnEmpleados = new Guna.UI2.WinForms.Guna2Button();
            this.lblSubtitulo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTitulo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pbLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_rezise_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_resize_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.panelSideBar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.panelSuperior.Controls.Add(this.btn_rezise_max);
            this.panelSuperior.Controls.Add(this.btn_minimizar);
            this.panelSuperior.Controls.Add(this.btn_resize_min);
            this.panelSuperior.Controls.Add(this.btnCerrar);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1250, 45);
            this.panelSuperior.TabIndex = 0;
            this.panelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoverVentana);
            // 
            // btn_rezise_max
            // 
            this.btn_rezise_max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_rezise_max.Image = ((System.Drawing.Image)(resources.GetObject("btn_rezise_max.Image")));
            this.btn_rezise_max.Location = new System.Drawing.Point(1164, -1);
            this.btn_rezise_max.Name = "btn_rezise_max";
            this.btn_rezise_max.Size = new System.Drawing.Size(43, 45);
            this.btn_rezise_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_rezise_max.TabIndex = 1;
            this.btn_rezise_max.TabStop = false;
            this.btn_rezise_max.Click += new System.EventHandler(this.btn_rezise_max_Click);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizar.Image")));
            this.btn_minimizar.Location = new System.Drawing.Point(1120, 0);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(43, 45);
            this.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_minimizar.TabIndex = 0;
            this.btn_minimizar.TabStop = false;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // btn_resize_min
            // 
            this.btn_resize_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_resize_min.Image = ((System.Drawing.Image)(resources.GetObject("btn_resize_min.Image")));
            this.btn_resize_min.Location = new System.Drawing.Point(1163, -1);
            this.btn_resize_min.Name = "btn_resize_min";
            this.btn_resize_min.Size = new System.Drawing.Size(43, 45);
            this.btn_resize_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_resize_min.TabIndex = 2;
            this.btn_resize_min.TabStop = false;
            this.btn_resize_min.Visible = false;
            this.btn_resize_min.Click += new System.EventHandler(this.btn_resize_min_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1207, -1);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(43, 45);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panelSideBar
            // 
            this.panelSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.panelSideBar.Controls.Add(this.panel1);
            this.panelSideBar.Controls.Add(this.lblSubtitulo);
            this.panelSideBar.Controls.Add(this.lblTitulo);
            this.panelSideBar.Controls.Add(this.pbLogo);
            this.panelSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideBar.Location = new System.Drawing.Point(0, 45);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(260, 605);
            this.panelSideBar.TabIndex = 1;
            this.panelSideBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoverVentana);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCargos);
            this.panel1.Controls.Add(this.btnEmpleados);
            this.panel1.Location = new System.Drawing.Point(25, 180);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 100);
            this.panel1.TabIndex = 0;
            // 
            // btnCargos
            // 
            this.btnCargos.BorderRadius = 8;
            this.btnCargos.FillColor = System.Drawing.Color.Transparent;
            this.btnCargos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCargos.ForeColor = System.Drawing.Color.White;
            this.btnCargos.Location = new System.Drawing.Point(0, 50);
            this.btnCargos.Name = "btnCargos";
            this.btnCargos.Size = new System.Drawing.Size(210, 40);
            this.btnCargos.TabIndex = 0;
            this.btnCargos.Text = "Cargos";
            this.btnCargos.Click += new System.EventHandler(this.btnCargos_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.BorderRadius = 8;
            this.btnEmpleados.FillColor = System.Drawing.Color.Transparent;
            this.btnEmpleados.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEmpleados.ForeColor = System.Drawing.Color.White;
            this.btnEmpleados.Location = new System.Drawing.Point(0, 5);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(210, 40);
            this.btnEmpleados.TabIndex = 1;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitulo.ForeColor = System.Drawing.Color.LightGray;
            this.lblSubtitulo.Location = new System.Drawing.Point(90, 135);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(73, 15);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Panel Principal";
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(77, 110);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(105, 22);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Administrador";
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.ImageRotate = 0F;
            this.pbLogo.Location = new System.Drawing.Point(90, 20);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(80, 80);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 3;
            this.pbLogo.TabStop = false;
            // 
            // panelContenido
            // 
            this.panelContenido.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(260, 45);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(990, 605);
            this.panelContenido.TabIndex = 0;
            // 
            // Administrador
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1250, 650);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelSideBar);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Administrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            this.panelSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_rezise_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_resize_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.panelSideBar.ResumeLayout(false);
            this.panelSideBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelSuperior;
        private System.Windows.Forms.PictureBox btn_minimizar;
        private System.Windows.Forms.PictureBox btn_rezise_max;
        private System.Windows.Forms.PictureBox btn_resize_min;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel panelSideBar;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSubtitulo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitulo;
        private Guna.UI2.WinForms.Guna2PictureBox pbLogo;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnCargos;
        private Guna.UI2.WinForms.Guna2Button btnEmpleados;
    }
}