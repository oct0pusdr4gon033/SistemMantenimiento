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
            this.lbl_titulo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_subtitulo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.cmb_tipo_filtro = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbl_tipo_filtro = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txb_filtro = new Guna.UI2.WinForms.Guna2TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_buscar = new Guna.UI2.WinForms.Guna2Button();
            this.txb_editar = new Guna.UI2.WinForms.Guna2Button();
            this.btn_ver_plan = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_subtitulo);
            this.panel1.Controls.Add(this.lbl_titulo);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 83);
            this.panel1.TabIndex = 2;
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
            // lbl_subtitulo
            // 
            this.lbl_subtitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_subtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subtitulo.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_subtitulo.Location = new System.Drawing.Point(21, 45);
            this.lbl_subtitulo.Name = "lbl_subtitulo";
            this.lbl_subtitulo.Size = new System.Drawing.Size(235, 20);
            this.lbl_subtitulo.TabIndex = 1;
            this.lbl_subtitulo.Text = "Filta y busa tus equipos mas rapido";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.Controls.Add(this.txb_filtro);
            this.guna2Panel1.Controls.Add(this.lbl_tipo_filtro);
            this.guna2Panel1.Controls.Add(this.cmb_tipo_filtro);
            this.guna2Panel1.Location = new System.Drawing.Point(12, 102);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(435, 338);
            this.guna2Panel1.TabIndex = 3;
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
            "Fecha Ingreso",
            "Fecha Compra",
            ""});
            this.cmb_tipo_filtro.Location = new System.Drawing.Point(3, 26);
            this.cmb_tipo_filtro.Name = "cmb_tipo_filtro";
            this.cmb_tipo_filtro.Size = new System.Drawing.Size(308, 36);
            this.cmb_tipo_filtro.TabIndex = 0;
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
            // txb_filtro
            // 
            this.txb_filtro.BackColor = System.Drawing.Color.Transparent;
            this.txb_filtro.BorderColor = System.Drawing.Color.Transparent;
            this.txb_filtro.BorderRadius = 10;
            this.txb_filtro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_filtro.DefaultText = "";
            this.txb_filtro.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_filtro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_filtro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_filtro.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_filtro.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_filtro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_filtro.ForeColor = System.Drawing.Color.Black;
            this.txb_filtro.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_filtro.Location = new System.Drawing.Point(3, 88);
            this.txb_filtro.Name = "txb_filtro";
            this.txb_filtro.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.txb_filtro.PlaceholderText = "";
            this.txb_filtro.SelectedText = "";
            this.txb_filtro.Size = new System.Drawing.Size(308, 36);
            this.txb_filtro.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_buscar);
            this.flowLayoutPanel1.Controls.Add(this.txb_editar);
            this.flowLayoutPanel1.Controls.Add(this.btn_ver_plan);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(15, 446);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(376, 103);
            this.flowLayoutPanel1.TabIndex = 5;
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
            this.btn_buscar.Location = new System.Drawing.Point(3, 3);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.PressedColor = System.Drawing.Color.Transparent;
            this.btn_buscar.Size = new System.Drawing.Size(180, 45);
            this.btn_buscar.TabIndex = 4;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseWaitCursor = true;
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
            this.txb_editar.Location = new System.Drawing.Point(189, 3);
            this.txb_editar.Name = "txb_editar";
            this.txb_editar.PressedColor = System.Drawing.Color.Transparent;
            this.txb_editar.Size = new System.Drawing.Size(180, 45);
            this.txb_editar.TabIndex = 6;
            this.txb_editar.Text = "Editar";
            // 
            // btn_ver_plan
            // 
            this.btn_ver_plan.Animated = true;
            this.btn_ver_plan.BackColor = System.Drawing.Color.Transparent;
            this.btn_ver_plan.BorderRadius = 10;
            this.btn_ver_plan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ver_plan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ver_plan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ver_plan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ver_plan.FillColor = System.Drawing.Color.DarkGray;
            this.btn_ver_plan.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ver_plan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btn_ver_plan.Location = new System.Drawing.Point(3, 54);
            this.btn_ver_plan.Name = "btn_ver_plan";
            this.btn_ver_plan.PressedColor = System.Drawing.Color.Transparent;
            this.btn_ver_plan.Size = new System.Drawing.Size(180, 45);
            this.btn_ver_plan.TabIndex = 7;
            this.btn_ver_plan.Text = "Plan de Mantenimiento";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(6, 68);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(60, 17);
            this.guna2HtmlLabel1.TabIndex = 5;
            this.guna2HtmlLabel1.Text = "Tipo Filtro: ";
            // 
            // ConsultarEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1110, 767);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarEquipo";
            this.Text = "ConsultarEquipo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_titulo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_subtitulo;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_tipo_filtro;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_tipo_filtro;
        private Guna.UI2.WinForms.Guna2TextBox txb_filtro;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button btn_buscar;
        private Guna.UI2.WinForms.Guna2Button txb_editar;
        private Guna.UI2.WinForms.Guna2Button btn_ver_plan;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}