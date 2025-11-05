namespace SistemMantenimiento.JefeLogi.Proveedores
{
    partial class frmProveedor
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mantenimientoDBDataSet = new SistemMantenimiento.MantenimientoDBDataSet();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btn_cancelar = new Guna.UI2.WinForms.Guna2Button();
            this.btn_desahabilitar = new Guna.UI2.WinForms.Guna2Button();
            this.btn_guardarCambios = new Guna.UI2.WinForms.Guna2Button();
            this.btn_editar = new Guna.UI2.WinForms.Guna2Button();
            this.txt_diasCredito = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_nuevo = new Guna.UI2.WinForms.Guna2Button();
            this.btn_agregar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2CheckBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.txt_TelefContacto = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_nombreContacto = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_direccion = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_correo = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmb_tipoproveedor = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_Telefono = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_RUC = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_RazonSocial = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_subtitulo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_titulo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.proveedorTableAdapter = new SistemMantenimiento.MantenimientoDBDataSetTableAdapters.ProveedorTableAdapter();
            this.mantenimientoDBDataSet1 = new SistemMantenimiento.MantenimientoDBDataSet1();
            this.proveedorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.proveedorTableAdapter1 = new SistemMantenimiento.MantenimientoDBDataSet1TableAdapters.ProveedorTableAdapter();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoDBDataSet)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.guna2DataGridView1);
            this.guna2Panel1.Controls.Add(this.guna2GroupBox1);
            this.guna2Panel1.Controls.Add(this.panel1);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 1);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1104, 764);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 15;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(25, 508);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.Size = new System.Drawing.Size(1018, 219);
            this.guna2DataGridView1.TabIndex = 4;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 15;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellClick);
            // 
            // proveedorBindingSource
            // 
            this.proveedorBindingSource.DataMember = "Proveedor";
            this.proveedorBindingSource.DataSource = this.mantenimientoDBDataSet;
            // 
            // mantenimientoDBDataSet
            // 
            this.mantenimientoDBDataSet.DataSetName = "MantenimientoDBDataSet";
            this.mantenimientoDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.btn_cancelar);
            this.guna2GroupBox1.Controls.Add(this.btn_desahabilitar);
            this.guna2GroupBox1.Controls.Add(this.btn_guardarCambios);
            this.guna2GroupBox1.Controls.Add(this.btn_editar);
            this.guna2GroupBox1.Controls.Add(this.txt_diasCredito);
            this.guna2GroupBox1.Controls.Add(this.btn_nuevo);
            this.guna2GroupBox1.Controls.Add(this.btn_agregar);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel9);
            this.guna2GroupBox1.Controls.Add(this.guna2CheckBox1);
            this.guna2GroupBox1.Controls.Add(this.txt_TelefContacto);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel8);
            this.guna2GroupBox1.Controls.Add(this.txt_nombreContacto);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel7);
            this.guna2GroupBox1.Controls.Add(this.txt_direccion);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel6);
            this.guna2GroupBox1.Controls.Add(this.txt_correo);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel5);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel4);
            this.guna2GroupBox1.Controls.Add(this.cmb_tipoproveedor);
            this.guna2GroupBox1.Controls.Add(this.txt_Telefono);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel3);
            this.guna2GroupBox1.Controls.Add(this.txt_RUC);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2GroupBox1.Controls.Add(this.txt_RazonSocial);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(43, 105);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(1000, 373);
            this.guna2GroupBox1.TabIndex = 3;
            this.guna2GroupBox1.Text = "Agregar Proveedores";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Animated = true;
            this.btn_cancelar.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancelar.BorderRadius = 10;
            this.btn_cancelar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_cancelar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_cancelar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_cancelar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_cancelar.FillColor = System.Drawing.Color.DarkGray;
            this.btn_cancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_cancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btn_cancelar.Location = new System.Drawing.Point(792, 307);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.PressedColor = System.Drawing.Color.Transparent;
            this.btn_cancelar.Size = new System.Drawing.Size(180, 45);
            this.btn_cancelar.TabIndex = 24;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btn_desahabilitar
            // 
            this.btn_desahabilitar.Animated = true;
            this.btn_desahabilitar.BackColor = System.Drawing.Color.Transparent;
            this.btn_desahabilitar.BorderRadius = 10;
            this.btn_desahabilitar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_desahabilitar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_desahabilitar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_desahabilitar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_desahabilitar.FillColor = System.Drawing.Color.DarkGray;
            this.btn_desahabilitar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_desahabilitar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btn_desahabilitar.Location = new System.Drawing.Point(792, 257);
            this.btn_desahabilitar.Name = "btn_desahabilitar";
            this.btn_desahabilitar.PressedColor = System.Drawing.Color.Transparent;
            this.btn_desahabilitar.Size = new System.Drawing.Size(180, 45);
            this.btn_desahabilitar.TabIndex = 23;
            this.btn_desahabilitar.Text = "Deshabilitar";
            this.btn_desahabilitar.Click += new System.EventHandler(this.btn_desahabilitar_Click);
            // 
            // btn_guardarCambios
            // 
            this.btn_guardarCambios.Animated = true;
            this.btn_guardarCambios.BackColor = System.Drawing.Color.Transparent;
            this.btn_guardarCambios.BorderRadius = 10;
            this.btn_guardarCambios.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_guardarCambios.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_guardarCambios.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_guardarCambios.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_guardarCambios.FillColor = System.Drawing.Color.DarkGray;
            this.btn_guardarCambios.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_guardarCambios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btn_guardarCambios.Location = new System.Drawing.Point(792, 206);
            this.btn_guardarCambios.Name = "btn_guardarCambios";
            this.btn_guardarCambios.PressedColor = System.Drawing.Color.Transparent;
            this.btn_guardarCambios.Size = new System.Drawing.Size(180, 45);
            this.btn_guardarCambios.TabIndex = 22;
            this.btn_guardarCambios.Text = "Guardar Cambios";
            this.btn_guardarCambios.Click += new System.EventHandler(this.btn_guardarCambios_Click);
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
            this.btn_editar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_editar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btn_editar.Location = new System.Drawing.Point(792, 155);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.PressedColor = System.Drawing.Color.Transparent;
            this.btn_editar.Size = new System.Drawing.Size(180, 45);
            this.btn_editar.TabIndex = 21;
            this.btn_editar.Text = "Editar";
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // txt_diasCredito
            // 
            this.txt_diasCredito.BackColor = System.Drawing.Color.Transparent;
            this.txt_diasCredito.BorderColor = System.Drawing.Color.Transparent;
            this.txt_diasCredito.BorderRadius = 10;
            this.txt_diasCredito.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_diasCredito.DefaultText = "";
            this.txt_diasCredito.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_diasCredito.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_diasCredito.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_diasCredito.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_diasCredito.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_diasCredito.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_diasCredito.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_diasCredito.Location = new System.Drawing.Point(568, 248);
            this.txt_diasCredito.Name = "txt_diasCredito";
            this.txt_diasCredito.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.txt_diasCredito.PlaceholderText = "";
            this.txt_diasCredito.SelectedText = "";
            this.txt_diasCredito.Size = new System.Drawing.Size(178, 39);
            this.txt_diasCredito.TabIndex = 20;
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Animated = true;
            this.btn_nuevo.BackColor = System.Drawing.Color.Transparent;
            this.btn_nuevo.BorderRadius = 10;
            this.btn_nuevo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_nuevo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_nuevo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_nuevo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_nuevo.FillColor = System.Drawing.Color.DarkGray;
            this.btn_nuevo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_nuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btn_nuevo.Location = new System.Drawing.Point(792, 51);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.PressedColor = System.Drawing.Color.Transparent;
            this.btn_nuevo.Size = new System.Drawing.Size(180, 45);
            this.btn_nuevo.TabIndex = 19;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Animated = true;
            this.btn_agregar.BackColor = System.Drawing.Color.Transparent;
            this.btn_agregar.BorderRadius = 10;
            this.btn_agregar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_agregar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_agregar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_agregar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_agregar.FillColor = System.Drawing.Color.DarkGray;
            this.btn_agregar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btn_agregar.Location = new System.Drawing.Point(792, 104);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.PressedColor = System.Drawing.Color.Transparent;
            this.btn_agregar.Size = new System.Drawing.Size(180, 45);
            this.btn_agregar.TabIndex = 18;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(420, 260);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(86, 17);
            this.guna2HtmlLabel9.TabIndex = 17;
            this.guna2HtmlLabel9.Text = "Días de Crédito: ";
            // 
            // guna2CheckBox1
            // 
            this.guna2CheckBox1.AutoSize = true;
            this.guna2CheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox1.CheckedState.BorderRadius = 0;
            this.guna2CheckBox1.CheckedState.BorderThickness = 0;
            this.guna2CheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox1.Location = new System.Drawing.Point(686, 322);
            this.guna2CheckBox1.Name = "guna2CheckBox1";
            this.guna2CheckBox1.Size = new System.Drawing.Size(60, 19);
            this.guna2CheckBox1.TabIndex = 16;
            this.guna2CheckBox1.Text = "Activo";
            this.guna2CheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox1.UncheckedState.BorderRadius = 0;
            this.guna2CheckBox1.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // txt_TelefContacto
            // 
            this.txt_TelefContacto.BackColor = System.Drawing.Color.Transparent;
            this.txt_TelefContacto.BorderColor = System.Drawing.Color.Transparent;
            this.txt_TelefContacto.BorderRadius = 10;
            this.txt_TelefContacto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TelefContacto.DefaultText = "";
            this.txt_TelefContacto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_TelefContacto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_TelefContacto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TelefContacto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TelefContacto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TelefContacto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TelefContacto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TelefContacto.Location = new System.Drawing.Point(568, 182);
            this.txt_TelefContacto.Name = "txt_TelefContacto";
            this.txt_TelefContacto.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.txt_TelefContacto.PlaceholderText = "";
            this.txt_TelefContacto.SelectedText = "";
            this.txt_TelefContacto.Size = new System.Drawing.Size(178, 39);
            this.txt_TelefContacto.TabIndex = 15;
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(420, 195);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(140, 17);
            this.guna2HtmlLabel8.TabIndex = 14;
            this.guna2HtmlLabel8.Text = "N° Telefono del Contacto: ";
            // 
            // txt_nombreContacto
            // 
            this.txt_nombreContacto.BackColor = System.Drawing.Color.Transparent;
            this.txt_nombreContacto.BorderColor = System.Drawing.Color.Transparent;
            this.txt_nombreContacto.BorderRadius = 10;
            this.txt_nombreContacto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nombreContacto.DefaultText = "";
            this.txt_nombreContacto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_nombreContacto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_nombreContacto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nombreContacto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nombreContacto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nombreContacto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_nombreContacto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nombreContacto.Location = new System.Drawing.Point(568, 120);
            this.txt_nombreContacto.Name = "txt_nombreContacto";
            this.txt_nombreContacto.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.txt_nombreContacto.PlaceholderText = "";
            this.txt_nombreContacto.SelectedText = "";
            this.txt_nombreContacto.Size = new System.Drawing.Size(178, 39);
            this.txt_nombreContacto.TabIndex = 13;
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(420, 131);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(120, 17);
            this.guna2HtmlLabel7.TabIndex = 12;
            this.guna2HtmlLabel7.Text = "Nombre del Contacto: ";
            // 
            // txt_direccion
            // 
            this.txt_direccion.BackColor = System.Drawing.Color.Transparent;
            this.txt_direccion.BorderColor = System.Drawing.Color.Transparent;
            this.txt_direccion.BorderRadius = 10;
            this.txt_direccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_direccion.DefaultText = "";
            this.txt_direccion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_direccion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_direccion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_direccion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_direccion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_direccion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_direccion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_direccion.Location = new System.Drawing.Point(568, 57);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.txt_direccion.PlaceholderText = "";
            this.txt_direccion.SelectedText = "";
            this.txt_direccion.Size = new System.Drawing.Size(178, 39);
            this.txt_direccion.TabIndex = 11;
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(420, 68);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(57, 17);
            this.guna2HtmlLabel6.TabIndex = 10;
            this.guna2HtmlLabel6.Text = "Dirección: ";
            // 
            // txt_correo
            // 
            this.txt_correo.BackColor = System.Drawing.Color.Transparent;
            this.txt_correo.BorderColor = System.Drawing.Color.Transparent;
            this.txt_correo.BorderRadius = 10;
            this.txt_correo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_correo.DefaultText = "";
            this.txt_correo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_correo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_correo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_correo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_correo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_correo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_correo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_correo.Location = new System.Drawing.Point(156, 313);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.txt_correo.PlaceholderText = "";
            this.txt_correo.SelectedText = "";
            this.txt_correo.Size = new System.Drawing.Size(200, 39);
            this.txt_correo.TabIndex = 9;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(24, 322);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(41, 17);
            this.guna2HtmlLabel5.TabIndex = 8;
            this.guna2HtmlLabel5.Text = "Correo: ";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(24, 260);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(86, 17);
            this.guna2HtmlLabel4.TabIndex = 7;
            this.guna2HtmlLabel4.Text = "N° de Telefono: ";
            // 
            // cmb_tipoproveedor
            // 
            this.cmb_tipoproveedor.BackColor = System.Drawing.Color.Transparent;
            this.cmb_tipoproveedor.BorderRadius = 10;
            this.cmb_tipoproveedor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_tipoproveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipoproveedor.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_tipoproveedor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_tipoproveedor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_tipoproveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_tipoproveedor.ItemHeight = 30;
            this.cmb_tipoproveedor.Items.AddRange(new object[] {
            "Caterpillar (CAT)",
            "Komatsu",
            "Volvo",
            "JCB",
            "Liebherr"});
            this.cmb_tipoproveedor.Location = new System.Drawing.Point(156, 188);
            this.cmb_tipoproveedor.Name = "cmb_tipoproveedor";
            this.cmb_tipoproveedor.Size = new System.Drawing.Size(200, 36);
            this.cmb_tipoproveedor.TabIndex = 6;
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.BackColor = System.Drawing.Color.Transparent;
            this.txt_Telefono.BorderColor = System.Drawing.Color.Transparent;
            this.txt_Telefono.BorderRadius = 10;
            this.txt_Telefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Telefono.DefaultText = "";
            this.txt_Telefono.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Telefono.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Telefono.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Telefono.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Telefono.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Telefono.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Telefono.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Telefono.Location = new System.Drawing.Point(156, 250);
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.txt_Telefono.PlaceholderText = "";
            this.txt_Telefono.SelectedText = "";
            this.txt_Telefono.Size = new System.Drawing.Size(200, 39);
            this.txt_Telefono.TabIndex = 5;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(24, 197);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(103, 17);
            this.guna2HtmlLabel3.TabIndex = 4;
            this.guna2HtmlLabel3.Text = "Tipo de proveedor: ";
            // 
            // txt_RUC
            // 
            this.txt_RUC.BackColor = System.Drawing.Color.Transparent;
            this.txt_RUC.BorderColor = System.Drawing.Color.Transparent;
            this.txt_RUC.BorderRadius = 10;
            this.txt_RUC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_RUC.DefaultText = "";
            this.txt_RUC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_RUC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_RUC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_RUC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_RUC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_RUC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_RUC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_RUC.Location = new System.Drawing.Point(156, 119);
            this.txt_RUC.Name = "txt_RUC";
            this.txt_RUC.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.txt_RUC.PlaceholderText = "";
            this.txt_RUC.SelectedText = "";
            this.txt_RUC.Size = new System.Drawing.Size(200, 39);
            this.txt_RUC.TabIndex = 3;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(24, 132);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(91, 17);
            this.guna2HtmlLabel2.TabIndex = 2;
            this.guna2HtmlLabel2.Text = "Numero de RUC:";
            // 
            // txt_RazonSocial
            // 
            this.txt_RazonSocial.BackColor = System.Drawing.Color.Transparent;
            this.txt_RazonSocial.BorderColor = System.Drawing.Color.Transparent;
            this.txt_RazonSocial.BorderRadius = 10;
            this.txt_RazonSocial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_RazonSocial.DefaultText = "";
            this.txt_RazonSocial.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_RazonSocial.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_RazonSocial.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_RazonSocial.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_RazonSocial.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_RazonSocial.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_RazonSocial.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_RazonSocial.Location = new System.Drawing.Point(156, 57);
            this.txt_RazonSocial.Name = "txt_RazonSocial";
            this.txt_RazonSocial.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.txt_RazonSocial.PlaceholderText = "";
            this.txt_RazonSocial.SelectedText = "";
            this.txt_RazonSocial.Size = new System.Drawing.Size(200, 39);
            this.txt_RazonSocial.TabIndex = 1;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(24, 68);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(126, 17);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Nombre del Proveedor: ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_subtitulo);
            this.panel1.Controls.Add(this.lbl_titulo);
            this.panel1.Location = new System.Drawing.Point(271, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 68);
            this.panel1.TabIndex = 2;
            // 
            // lbl_subtitulo
            // 
            this.lbl_subtitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_subtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subtitulo.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_subtitulo.Location = new System.Drawing.Point(139, 36);
            this.lbl_subtitulo.Name = "lbl_subtitulo";
            this.lbl_subtitulo.Size = new System.Drawing.Size(176, 20);
            this.lbl_subtitulo.TabIndex = 1;
            this.lbl_subtitulo.Text = "Gestiona tus Proveedores";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.Teal;
            this.lbl_titulo.Location = new System.Drawing.Point(90, 3);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(275, 27);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Agregar Nuevo Proveedor";
            this.lbl_titulo.Click += new System.EventHandler(this.lbl_titulo_Click);
            // 
            // proveedorTableAdapter
            // 
            this.proveedorTableAdapter.ClearBeforeFill = true;
            // 
            // mantenimientoDBDataSet1
            // 
            this.mantenimientoDBDataSet1.DataSetName = "MantenimientoDBDataSet1";
            this.mantenimientoDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proveedorBindingSource1
            // 
            this.proveedorBindingSource1.DataMember = "Proveedor";
            this.proveedorBindingSource1.DataSource = this.mantenimientoDBDataSet1;
            // 
            // proveedorTableAdapter1
            // 
            this.proveedorTableAdapter1.ClearBeforeFill = true;
            // 
            // frmProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 767);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProveedor";
            this.Text = "AgregarPro";
            this.Load += new System.EventHandler(this.AgregarPro_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoDBDataSet)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_subtitulo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_titulo;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txt_RazonSocial;
        private Guna.UI2.WinForms.Guna2TextBox txt_Telefono;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox txt_RUC;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_tipoproveedor;
        private Guna.UI2.WinForms.Guna2TextBox txt_correo;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2TextBox txt_direccion;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2TextBox txt_nombreContacto;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2TextBox txt_TelefContacto;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox1;
        private Guna.UI2.WinForms.Guna2Button btn_editar;
        private Guna.UI2.WinForms.Guna2TextBox txt_diasCredito;
        private Guna.UI2.WinForms.Guna2Button btn_nuevo;
        private Guna.UI2.WinForms.Guna2Button btn_agregar;
        private Guna.UI2.WinForms.Guna2Button btn_guardarCambios;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private MantenimientoDBDataSet mantenimientoDBDataSet;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private MantenimientoDBDataSetTableAdapters.ProveedorTableAdapter proveedorTableAdapter;
        private Guna.UI2.WinForms.Guna2Button btn_cancelar;
        private Guna.UI2.WinForms.Guna2Button btn_desahabilitar;
        private MantenimientoDBDataSet1 mantenimientoDBDataSet1;
        private System.Windows.Forms.BindingSource proveedorBindingSource1;
        private MantenimientoDBDataSet1TableAdapters.ProveedorTableAdapter proveedorTableAdapter1;
    }
}