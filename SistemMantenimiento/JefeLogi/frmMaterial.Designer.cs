using System.Drawing;
using System.Windows.Forms;

namespace SistemMantenimiento.JefeLogi
{
    partial class frmMaterial
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_titulo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_subtitulo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.groupBoxDatos = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblId = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtId = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCodigo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtCodigo = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNombre = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDescripcion = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtDescripcion = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCategoria = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cboCategoria = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblUnidad = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cboUnidad = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblClasificacion = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cboClasificacion = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblStockActual = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtStockActual = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblStockMinimo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtStockMinimo = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPrecio = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtPrecio = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCriticidad = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cboCriticidad = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnNuevo = new Guna.UI2.WinForms.Guna2Button();
            this.btnAgregar = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditar = new Guna.UI2.WinForms.Guna2Button();
            this.btnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeshabilitar = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.dgvMateriales = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBoxDatos.SuspendLayout();
            this.panelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriales)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbl_titulo);
            this.panel1.Controls.Add(this.lbl_subtitulo);
            this.panel1.Location = new System.Drawing.Point(350, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 50);
            this.panel1.TabIndex = 0;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbl_titulo.ForeColor = System.Drawing.Color.Teal;
            this.lbl_titulo.Location = new System.Drawing.Point(80, 5);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(278, 27);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Mantenedor de Materiales";
            // 
            // lbl_subtitulo
            // 
            this.lbl_subtitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_subtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbl_subtitulo.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_subtitulo.Location = new System.Drawing.Point(150, 30);
            this.lbl_subtitulo.Name = "lbl_subtitulo";
            this.lbl_subtitulo.Size = new System.Drawing.Size(159, 20);
            this.lbl_subtitulo.TabIndex = 1;
            this.lbl_subtitulo.Text = "Gestiona tus materiales";
            // 
            // groupBoxDatos
            // 
            this.groupBoxDatos.BorderRadius = 10;
            this.groupBoxDatos.Controls.Add(this.lblId);
            this.groupBoxDatos.Controls.Add(this.txtId);
            this.groupBoxDatos.Controls.Add(this.lblCodigo);
            this.groupBoxDatos.Controls.Add(this.txtCodigo);
            this.groupBoxDatos.Controls.Add(this.lblNombre);
            this.groupBoxDatos.Controls.Add(this.txtNombre);
            this.groupBoxDatos.Controls.Add(this.lblDescripcion);
            this.groupBoxDatos.Controls.Add(this.txtDescripcion);
            this.groupBoxDatos.Controls.Add(this.lblCategoria);
            this.groupBoxDatos.Controls.Add(this.cboCategoria);
            this.groupBoxDatos.Controls.Add(this.lblUnidad);
            this.groupBoxDatos.Controls.Add(this.cboUnidad);
            this.groupBoxDatos.Controls.Add(this.lblClasificacion);
            this.groupBoxDatos.Controls.Add(this.cboClasificacion);
            this.groupBoxDatos.Controls.Add(this.lblStockActual);
            this.groupBoxDatos.Controls.Add(this.txtStockActual);
            this.groupBoxDatos.Controls.Add(this.lblStockMinimo);
            this.groupBoxDatos.Controls.Add(this.txtStockMinimo);
            this.groupBoxDatos.Controls.Add(this.lblPrecio);
            this.groupBoxDatos.Controls.Add(this.txtPrecio);
            this.groupBoxDatos.Controls.Add(this.lblCriticidad);
            this.groupBoxDatos.Controls.Add(this.cboCriticidad);
            this.groupBoxDatos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBoxDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.groupBoxDatos.Location = new System.Drawing.Point(40, 70);
            this.groupBoxDatos.Name = "groupBoxDatos";
            this.groupBoxDatos.Size = new System.Drawing.Size(1000, 340);
            this.groupBoxDatos.TabIndex = 1;
            this.groupBoxDatos.Text = "Datos del Material";
            // 
            // lblId
            // 
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.Location = new System.Drawing.Point(25, 50);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(17, 15);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";
            // 
            // txtId
            // 
            this.txtId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtId.DefaultText = "";
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtId.Location = new System.Drawing.Point(150, 40);
            this.txtId.Name = "txtId";
            this.txtId.PlaceholderText = "";
            this.txtId.ReadOnly = true;
            this.txtId.SelectedText = "";
            this.txtId.Size = new System.Drawing.Size(200, 36);
            this.txtId.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigo.Location = new System.Drawing.Point(25, 100);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(39, 15);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigo.DefaultText = "";
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCodigo.Location = new System.Drawing.Point(150, 90);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PlaceholderText = "";
            this.txtCodigo.SelectedText = "";
            this.txtCodigo.Size = new System.Drawing.Size(200, 36);
            this.txtCodigo.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Location = new System.Drawing.Point(25, 150);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(43, 15);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.DefaultText = "";
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombre.Location = new System.Drawing.Point(150, 140);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "";
            this.txtNombre.SelectedText = "";
            this.txtNombre.Size = new System.Drawing.Size(200, 36);
            this.txtNombre.TabIndex = 5;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcion.Location = new System.Drawing.Point(25, 200);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(62, 15);
            this.lblDescripcion.TabIndex = 6;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescripcion.DefaultText = "";
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDescripcion.Location = new System.Drawing.Point(150, 190);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.PlaceholderText = "";
            this.txtDescripcion.SelectedText = "";
            this.txtDescripcion.Size = new System.Drawing.Size(200, 36);
            this.txtDescripcion.TabIndex = 7;
            // 
            // lblCategoria
            // 
            this.lblCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoria.Location = new System.Drawing.Point(25, 250);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(53, 15);
            this.lblCategoria.TabIndex = 8;
            this.lblCategoria.Text = "Categoría:";
            // 
            // cboCategoria
            // 
            this.cboCategoria.BackColor = System.Drawing.Color.Transparent;
            this.cboCategoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FocusedColor = System.Drawing.Color.Empty;
            this.cboCategoria.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboCategoria.ItemHeight = 30;
            this.cboCategoria.Location = new System.Drawing.Point(150, 240);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(200, 36);
            this.cboCategoria.TabIndex = 9;
            // 
            // lblUnidad
            // 
            this.lblUnidad.BackColor = System.Drawing.Color.Transparent;
            this.lblUnidad.Location = new System.Drawing.Point(400, 50);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(40, 15);
            this.lblUnidad.TabIndex = 10;
            this.lblUnidad.Text = "Unidad:";
            // 
            // cboUnidad
            // 
            this.cboUnidad.BackColor = System.Drawing.Color.Transparent;
            this.cboUnidad.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnidad.FocusedColor = System.Drawing.Color.Empty;
            this.cboUnidad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboUnidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboUnidad.ItemHeight = 30;
            this.cboUnidad.Location = new System.Drawing.Point(520, 40);
            this.cboUnidad.Name = "cboUnidad";
            this.cboUnidad.Size = new System.Drawing.Size(180, 36);
            this.cboUnidad.TabIndex = 11;
            // 
            // lblClasificacion
            // 
            this.lblClasificacion.BackColor = System.Drawing.Color.Transparent;
            this.lblClasificacion.Location = new System.Drawing.Point(400, 100);
            this.lblClasificacion.Name = "lblClasificacion";
            this.lblClasificacion.Size = new System.Drawing.Size(65, 15);
            this.lblClasificacion.TabIndex = 12;
            this.lblClasificacion.Text = "Clasificación:";
            // 
            // cboClasificacion
            // 
            this.cboClasificacion.BackColor = System.Drawing.Color.Transparent;
            this.cboClasificacion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboClasificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClasificacion.FocusedColor = System.Drawing.Color.Empty;
            this.cboClasificacion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboClasificacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboClasificacion.ItemHeight = 30;
            this.cboClasificacion.Location = new System.Drawing.Point(520, 90);
            this.cboClasificacion.Name = "cboClasificacion";
            this.cboClasificacion.Size = new System.Drawing.Size(180, 36);
            this.cboClasificacion.TabIndex = 13;
            // 
            // lblStockActual
            // 
            this.lblStockActual.BackColor = System.Drawing.Color.Transparent;
            this.lblStockActual.Location = new System.Drawing.Point(400, 150);
            this.lblStockActual.Name = "lblStockActual";
            this.lblStockActual.Size = new System.Drawing.Size(67, 15);
            this.lblStockActual.TabIndex = 14;
            this.lblStockActual.Text = "Stock Actual:";
            // 
            // txtStockActual
            // 
            this.txtStockActual.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStockActual.DefaultText = "";
            this.txtStockActual.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtStockActual.Location = new System.Drawing.Point(520, 140);
            this.txtStockActual.Name = "txtStockActual";
            this.txtStockActual.PlaceholderText = "";
            this.txtStockActual.SelectedText = "";
            this.txtStockActual.Size = new System.Drawing.Size(180, 36);
            this.txtStockActual.TabIndex = 15;
            // 
            // lblStockMinimo
            // 
            this.lblStockMinimo.BackColor = System.Drawing.Color.Transparent;
            this.lblStockMinimo.Location = new System.Drawing.Point(400, 200);
            this.lblStockMinimo.Name = "lblStockMinimo";
            this.lblStockMinimo.Size = new System.Drawing.Size(72, 15);
            this.lblStockMinimo.TabIndex = 16;
            this.lblStockMinimo.Text = "Stock Mínimo:";
            // 
            // txtStockMinimo
            // 
            this.txtStockMinimo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStockMinimo.DefaultText = "";
            this.txtStockMinimo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtStockMinimo.Location = new System.Drawing.Point(520, 190);
            this.txtStockMinimo.Name = "txtStockMinimo";
            this.txtStockMinimo.PlaceholderText = "";
            this.txtStockMinimo.SelectedText = "";
            this.txtStockMinimo.Size = new System.Drawing.Size(180, 36);
            this.txtStockMinimo.TabIndex = 17;
            // 
            // lblPrecio
            // 
            this.lblPrecio.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecio.Location = new System.Drawing.Point(400, 250);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(83, 15);
            this.lblPrecio.TabIndex = 18;
            this.lblPrecio.Text = "Precio Promedio:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecio.DefaultText = "";
            this.txtPrecio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrecio.Location = new System.Drawing.Point(520, 240);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.PlaceholderText = "";
            this.txtPrecio.SelectedText = "";
            this.txtPrecio.Size = new System.Drawing.Size(180, 36);
            this.txtPrecio.TabIndex = 19;
            // 
            // lblCriticidad
            // 
            this.lblCriticidad.BackColor = System.Drawing.Color.Transparent;
            this.lblCriticidad.Location = new System.Drawing.Point(750, 50);
            this.lblCriticidad.Name = "lblCriticidad";
            this.lblCriticidad.Size = new System.Drawing.Size(49, 15);
            this.lblCriticidad.TabIndex = 20;
            this.lblCriticidad.Text = "Criticidad:";
            // 
            // cboCriticidad
            // 
            this.cboCriticidad.BackColor = System.Drawing.Color.Transparent;
            this.cboCriticidad.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboCriticidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriticidad.FocusedColor = System.Drawing.Color.Empty;
            this.cboCriticidad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboCriticidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboCriticidad.ItemHeight = 30;
            this.cboCriticidad.Location = new System.Drawing.Point(840, 40);
            this.cboCriticidad.Name = "cboCriticidad";
            this.cboCriticidad.Size = new System.Drawing.Size(120, 36);
            this.cboCriticidad.TabIndex = 21;
            // 
            // panelBotones
            // 
            this.panelBotones.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelBotones.Controls.Add(this.btnNuevo);
            this.panelBotones.Controls.Add(this.btnAgregar);
            this.panelBotones.Controls.Add(this.btnEditar);
            this.panelBotones.Controls.Add(this.btnGuardar);
            this.panelBotones.Controls.Add(this.btnDeshabilitar);
            this.panelBotones.Controls.Add(this.btnCancelar);
            this.panelBotones.Location = new System.Drawing.Point(817, 170);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(183, 187);
            this.panelBotones.TabIndex = 2;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BorderRadius = 10;
            this.btnNuevo.FillColor = System.Drawing.Color.LightSeaGreen;
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(15, 10);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(150, 23);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click_1);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BorderRadius = 10;
            this.btnAgregar.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(15, 39);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(150, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // btnEditar
            // 
            this.btnEditar.BorderRadius = 10;
            this.btnEditar.FillColor = System.Drawing.Color.SteelBlue;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(15, 68);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(150, 23);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BorderRadius = 10;
            this.btnGuardar.FillColor = System.Drawing.Color.CadetBlue;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(15, 97);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(150, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.BorderRadius = 10;
            this.btnDeshabilitar.FillColor = System.Drawing.Color.IndianRed;
            this.btnDeshabilitar.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnDeshabilitar.ForeColor = System.Drawing.Color.White;
            this.btnDeshabilitar.Location = new System.Drawing.Point(15, 126);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(150, 23);
            this.btnDeshabilitar.TabIndex = 4;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BorderRadius = 10;
            this.btnCancelar.FillColor = System.Drawing.Color.Gray;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(15, 153);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvMateriales
            // 
            this.dgvMateriales.AllowUserToAddRows = false;
            this.dgvMateriales.AllowUserToDeleteRows = false;
            this.dgvMateriales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMateriales.BackgroundColor = System.Drawing.Color.White;
            this.dgvMateriales.Location = new System.Drawing.Point(40, 430);
            this.dgvMateriales.Name = "dgvMateriales";
            this.dgvMateriales.ReadOnly = true;
            this.dgvMateriales.RowHeadersVisible = false;
            this.dgvMateriales.Size = new System.Drawing.Size(1000, 269);
            this.dgvMateriales.TabIndex = 3;
            this.dgvMateriales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMateriales_CellClick);
            // 
            // frmMaterial
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 760);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBoxDatos);
            this.Controls.Add(this.dgvMateriales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMaterial";
            this.Text = "frmMaterial";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxDatos.ResumeLayout(false);
            this.groupBoxDatos.PerformLayout();
            this.panelBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_titulo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_subtitulo;
        private Guna.UI2.WinForms.Guna2GroupBox groupBoxDatos;
        private Panel panelBotones;
        private DataGridView dgvMateriales;
        private Guna.UI2.WinForms.Guna2Button btnNuevo;
        private Guna.UI2.WinForms.Guna2Button btnAgregar;
        private Guna.UI2.WinForms.Guna2Button btnEditar;
        private Guna.UI2.WinForms.Guna2Button btnGuardar;
        private Guna.UI2.WinForms.Guna2Button btnDeshabilitar;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblId, lblCodigo, lblNombre, lblDescripcion,
            lblCategoria, lblUnidad, lblClasificacion, lblStockActual,
            lblStockMinimo, lblPrecio, lblCriticidad;
        private Guna.UI2.WinForms.Guna2TextBox txtId, txtCodigo, txtNombre, txtDescripcion,
            txtStockActual, txtStockMinimo, txtPrecio;
        private Guna.UI2.WinForms.Guna2ComboBox cboCategoria, cboUnidad, cboClasificacion, cboCriticidad;
    }
}
