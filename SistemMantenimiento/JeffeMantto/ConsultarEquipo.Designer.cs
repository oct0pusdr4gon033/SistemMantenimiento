namespace SistemMantenimiento.JeffeMantto
{
    partial class ConsultarEquipo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_subtitulo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_titulo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl_marca_equipo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txb_valo_busqueda = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_tipo_filtro = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmb_tipo_filtro = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btn_buscar = new Guna.UI2.WinForms.Guna2Button();
            this.txb_editar = new Guna.UI2.WinForms.Guna2Button();
            this.flp_equipos_buscados = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_subtitulo);
            this.panel1.Controls.Add(this.lbl_titulo);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 83);
            this.panel1.TabIndex = 2;
            // 
            // lbl_subtitulo
            // 
            this.lbl_subtitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_subtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subtitulo.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_subtitulo.Location = new System.Drawing.Point(21, 45);
            this.lbl_subtitulo.Name = "lbl_subtitulo";
            this.lbl_subtitulo.Size = new System.Drawing.Size(243, 20);
            this.lbl_subtitulo.TabIndex = 1;
            this.lbl_subtitulo.Text = "Filta y busca tus equipos mas rapido";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.Teal;
            this.lbl_titulo.Location = new System.Drawing.Point(21, 12);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(168, 27);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Buscar Equipos";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.lbl_marca_equipo);
            this.guna2Panel1.Controls.Add(this.txb_valo_busqueda);
            this.guna2Panel1.Controls.Add(this.lbl_tipo_filtro);
            this.guna2Panel1.Controls.Add(this.cmb_tipo_filtro);
            this.guna2Panel1.Location = new System.Drawing.Point(12, 131);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(323, 149);
            this.guna2Panel1.TabIndex = 3;
            // 
            // lbl_marca_equipo
            // 
            this.lbl_marca_equipo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_marca_equipo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_marca_equipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.lbl_marca_equipo.Location = new System.Drawing.Point(6, 68);
            this.lbl_marca_equipo.Name = "lbl_marca_equipo";
            this.lbl_marca_equipo.Size = new System.Drawing.Size(105, 17);
            this.lbl_marca_equipo.TabIndex = 5;
            this.lbl_marca_equipo.Text = "Valor de Busqueda:";
            // 
            // txb_valo_busqueda
            // 
            this.txb_valo_busqueda.BackColor = System.Drawing.Color.Transparent;
            this.txb_valo_busqueda.BorderColor = System.Drawing.Color.Transparent;
            this.txb_valo_busqueda.BorderRadius = 10;
            this.txb_valo_busqueda.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_valo_busqueda.DefaultText = "";
            this.txb_valo_busqueda.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_valo_busqueda.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_valo_busqueda.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_valo_busqueda.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_valo_busqueda.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_valo_busqueda.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_valo_busqueda.ForeColor = System.Drawing.Color.Black;
            this.txb_valo_busqueda.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_valo_busqueda.Location = new System.Drawing.Point(6, 91);
            this.txb_valo_busqueda.Name = "txb_valo_busqueda";
            this.txb_valo_busqueda.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.txb_valo_busqueda.PlaceholderText = "";
            this.txb_valo_busqueda.SelectedText = "";
            this.txb_valo_busqueda.Size = new System.Drawing.Size(308, 36);
            this.txb_valo_busqueda.TabIndex = 4;
            // 
            // lbl_tipo_filtro
            // 
            this.lbl_tipo_filtro.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tipo_filtro.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipo_filtro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.lbl_tipo_filtro.Location = new System.Drawing.Point(3, 3);
            this.lbl_tipo_filtro.Name = "lbl_tipo_filtro";
            this.lbl_tipo_filtro.Size = new System.Drawing.Size(60, 17);
            this.lbl_tipo_filtro.TabIndex = 1;
            this.lbl_tipo_filtro.Text = "Tipo Filtro: ";
            // 
            // cmb_tipo_filtro
            // 
            this.cmb_tipo_filtro.BackColor = System.Drawing.Color.Transparent;
            this.cmb_tipo_filtro.BorderRadius = 10;
            this.cmb_tipo_filtro.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_tipo_filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo_filtro.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_tipo_filtro.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_tipo_filtro.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_tipo_filtro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_tipo_filtro.ItemHeight = 30;
            this.cmb_tipo_filtro.Items.AddRange(new object[] {
            "Marca de Equipo",
            "Tipo de Equipo",
            "Año de Fabricacion",
            "Buscar por Modelo"});
            this.cmb_tipo_filtro.Location = new System.Drawing.Point(3, 26);
            this.cmb_tipo_filtro.Name = "cmb_tipo_filtro";
            this.cmb_tipo_filtro.Size = new System.Drawing.Size(308, 36);
            this.cmb_tipo_filtro.TabIndex = 0;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Animated = true;
            this.btn_buscar.BackColor = System.Drawing.Color.Transparent;
            this.btn_buscar.BorderRadius = 10;
            this.btn_buscar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_buscar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_buscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_buscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_buscar.FillColor = System.Drawing.Color.DarkGray;
            this.btn_buscar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btn_buscar.Location = new System.Drawing.Point(71, 286);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.PressedColor = System.Drawing.Color.Transparent;
            this.btn_buscar.Size = new System.Drawing.Size(180, 45);
            this.btn_buscar.TabIndex = 4;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseWaitCursor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txb_editar
            // 
            this.txb_editar.Animated = true;
            this.txb_editar.BackColor = System.Drawing.Color.Transparent;
            this.txb_editar.BorderRadius = 10;
            this.txb_editar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.txb_editar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.txb_editar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.txb_editar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.txb_editar.FillColor = System.Drawing.Color.DarkGray;
            this.txb_editar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_editar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.txb_editar.Location = new System.Drawing.Point(71, 504);
            this.txb_editar.Name = "txb_editar";
            this.txb_editar.PressedColor = System.Drawing.Color.Transparent;
            this.txb_editar.Size = new System.Drawing.Size(180, 45);
            this.txb_editar.TabIndex = 6;
            this.txb_editar.Text = "Editar";
            // 
            // flp_equipos_buscados
            // 
            this.flp_equipos_buscados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flp_equipos_buscados.AutoScroll = true;
            this.flp_equipos_buscados.Location = new System.Drawing.Point(351, 13);
            this.flp_equipos_buscados.Name = "flp_equipos_buscados";
            this.flp_equipos_buscados.Size = new System.Drawing.Size(705, 670);
            this.flp_equipos_buscados.TabIndex = 8;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel2.Controls.Add(this.guna2TextBox1);
            this.guna2Panel2.Location = new System.Drawing.Point(12, 358);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(323, 106);
            this.guna2Panel2.TabIndex = 6;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(6, 14);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(33, 17);
            this.guna2HtmlLabel1.TabIndex = 5;
            this.guna2HtmlLabel1.Text = "Editar ";
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2TextBox1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2TextBox1.BorderRadius = 10;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(6, 38);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(308, 36);
            this.guna2TextBox1.TabIndex = 4;
            // 
            // ConsultarEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 767);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.flp_equipos_buscados);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txb_editar);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarEquipo";
            this.Text = "ConsultarEquipo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_titulo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_subtitulo;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_tipo_filtro;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_tipo_filtro;
        private Guna.UI2.WinForms.Guna2TextBox txb_valo_busqueda;
        private Guna.UI2.WinForms.Guna2Button btn_buscar;
        private Guna.UI2.WinForms.Guna2Button txb_editar;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_marca_equipo;
        private System.Windows.Forms.FlowLayoutPanel flp_equipos_buscados;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
    }
}