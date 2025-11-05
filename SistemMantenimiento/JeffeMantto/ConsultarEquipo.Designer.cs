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
            this.flp_equipos_buscados = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_editar = new Guna.UI2.WinForms.Guna2Button();
            this.btn_plan_mantto = new Guna.UI2.WinForms.Guna2Button();
            this.btn_historial = new Guna.UI2.WinForms.Guna2Button();
            this.btn_generar_ot = new Guna.UI2.WinForms.Guna2Button();
            this.panel_titulo_opciones = new System.Windows.Forms.Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel_opciones = new Guna.UI2.WinForms.Guna2Panel();
            this.lblEquipoSeleccionado = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel_form_hijo = new Guna.UI2.WinForms.Guna2Panel();
            this.panel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.panel_titulo_opciones.SuspendLayout();
            this.panel_opciones.SuspendLayout();
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
            this.guna2Panel1.Location = new System.Drawing.Point(12, 119);
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
            "Codigo de Flota",
            "Modelo de Equipo",
            "Año de Fabricacion",
            "Número de Serie"});
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
            // flp_equipos_buscados
            // 
            this.flp_equipos_buscados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flp_equipos_buscados.AutoScroll = true;
            this.flp_equipos_buscados.Location = new System.Drawing.Point(351, 13);
            this.flp_equipos_buscados.Name = "flp_equipos_buscados";
            this.flp_equipos_buscados.Size = new System.Drawing.Size(737, 670);
            this.flp_equipos_buscados.TabIndex = 8;
            // 
            // btn_editar
            // 
            this.btn_editar.Animated = true;
            this.btn_editar.BackColor = System.Drawing.Color.Transparent;
            this.btn_editar.BorderRadius = 10;
            this.btn_editar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_editar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_editar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_editar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_editar.FillColor = System.Drawing.Color.DarkGray;
            this.btn_editar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btn_editar.Location = new System.Drawing.Point(3, 3);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.PressedColor = System.Drawing.Color.Transparent;
            this.btn_editar.Size = new System.Drawing.Size(132, 45);
            this.btn_editar.TabIndex = 10;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseWaitCursor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click_1);
            // 
            // btn_plan_mantto
            // 
            this.btn_plan_mantto.Animated = true;
            this.btn_plan_mantto.BackColor = System.Drawing.Color.Transparent;
            this.btn_plan_mantto.BorderRadius = 10;
            this.btn_plan_mantto.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_plan_mantto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_plan_mantto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_plan_mantto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_plan_mantto.FillColor = System.Drawing.Color.DarkGray;
            this.btn_plan_mantto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_plan_mantto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btn_plan_mantto.Location = new System.Drawing.Point(170, 3);
            this.btn_plan_mantto.Name = "btn_plan_mantto";
            this.btn_plan_mantto.PressedColor = System.Drawing.Color.Transparent;
            this.btn_plan_mantto.Size = new System.Drawing.Size(132, 45);
            this.btn_plan_mantto.TabIndex = 11;
            this.btn_plan_mantto.Text = "Ver Plan Mantto";
            this.btn_plan_mantto.UseWaitCursor = true;
            // 
            // btn_historial
            // 
            this.btn_historial.Animated = true;
            this.btn_historial.BackColor = System.Drawing.Color.Transparent;
            this.btn_historial.BorderRadius = 10;
            this.btn_historial.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_historial.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_historial.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_historial.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_historial.FillColor = System.Drawing.Color.DarkGray;
            this.btn_historial.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_historial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btn_historial.Location = new System.Drawing.Point(170, 68);
            this.btn_historial.Name = "btn_historial";
            this.btn_historial.PressedColor = System.Drawing.Color.Transparent;
            this.btn_historial.Size = new System.Drawing.Size(132, 45);
            this.btn_historial.TabIndex = 12;
            this.btn_historial.Text = "Ver Historial";
            this.btn_historial.UseWaitCursor = true;
            // 
            // btn_generar_ot
            // 
            this.btn_generar_ot.Animated = true;
            this.btn_generar_ot.BackColor = System.Drawing.Color.Transparent;
            this.btn_generar_ot.BorderRadius = 10;
            this.btn_generar_ot.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_generar_ot.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_generar_ot.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_generar_ot.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_generar_ot.FillColor = System.Drawing.Color.DarkGray;
            this.btn_generar_ot.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generar_ot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btn_generar_ot.Location = new System.Drawing.Point(3, 68);
            this.btn_generar_ot.Name = "btn_generar_ot";
            this.btn_generar_ot.PressedColor = System.Drawing.Color.Transparent;
            this.btn_generar_ot.Size = new System.Drawing.Size(132, 45);
            this.btn_generar_ot.TabIndex = 13;
            this.btn_generar_ot.Text = "Generar OT";
            this.btn_generar_ot.UseWaitCursor = true;
            // 
            // panel_titulo_opciones
            // 
            this.panel_titulo_opciones.Controls.Add(this.guna2HtmlLabel1);
            this.panel_titulo_opciones.Controls.Add(this.guna2HtmlLabel2);
            this.panel_titulo_opciones.Location = new System.Drawing.Point(12, 367);
            this.panel_titulo_opciones.Name = "panel_titulo_opciones";
            this.panel_titulo_opciones.Size = new System.Drawing.Size(323, 83);
            this.panel_titulo_opciones.TabIndex = 3;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.DarkGray;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(6, 60);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(200, 20);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Realiza tus acciones favoritas";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Teal;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(6, 27);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(102, 27);
            this.guna2HtmlLabel2.TabIndex = 0;
            this.guna2HtmlLabel2.Text = "Opciones";
            // 
            // panel_opciones
            // 
            this.panel_opciones.Controls.Add(this.btn_historial);
            this.panel_opciones.Controls.Add(this.btn_generar_ot);
            this.panel_opciones.Controls.Add(this.btn_plan_mantto);
            this.panel_opciones.Controls.Add(this.btn_editar);
            this.panel_opciones.Location = new System.Drawing.Point(18, 482);
            this.panel_opciones.Name = "panel_opciones";
            this.panel_opciones.Size = new System.Drawing.Size(317, 123);
            this.panel_opciones.TabIndex = 10;
            // 
            // lblEquipoSeleccionado
            // 
            this.lblEquipoSeleccionado.BackColor = System.Drawing.Color.Transparent;
            this.lblEquipoSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipoSeleccionado.ForeColor = System.Drawing.Color.Gray;
            this.lblEquipoSeleccionado.Location = new System.Drawing.Point(18, 456);
            this.lblEquipoSeleccionado.Name = "lblEquipoSeleccionado";
            this.lblEquipoSeleccionado.Size = new System.Drawing.Size(164, 20);
            this.lblEquipoSeleccionado.TabIndex = 2;
            this.lblEquipoSeleccionado.Text = "Seleccione un equipo";
            // 
            // panel_form_hijo
            // 
            this.panel_form_hijo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_form_hijo.Location = new System.Drawing.Point(12, 5);
            this.panel_form_hijo.Name = "panel_form_hijo";
            this.panel_form_hijo.Size = new System.Drawing.Size(1086, 750);
            this.panel_form_hijo.TabIndex = 11;
            // 
            // ConsultarEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 767);
            this.Controls.Add(this.lblEquipoSeleccionado);
            this.Controls.Add(this.panel_opciones);
            this.Controls.Add(this.panel_titulo_opciones);
            this.Controls.Add(this.flp_equipos_buscados);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_form_hijo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarEquipo";
            this.Text = "ConsultarEquipo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.panel_titulo_opciones.ResumeLayout(false);
            this.panel_titulo_opciones.PerformLayout();
            this.panel_opciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_marca_equipo;
        private System.Windows.Forms.FlowLayoutPanel flp_equipos_buscados;
        private Guna.UI2.WinForms.Guna2Button btn_editar;
        private Guna.UI2.WinForms.Guna2Button btn_plan_mantto;
        private Guna.UI2.WinForms.Guna2Button btn_historial;
        private Guna.UI2.WinForms.Guna2Button btn_generar_ot;
        private System.Windows.Forms.Panel panel_titulo_opciones;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Panel panel_opciones;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblEquipoSeleccionado;
        private Guna.UI2.WinForms.Guna2Panel panel_form_hijo;
    }
}