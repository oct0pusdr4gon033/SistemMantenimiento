namespace SistemMantenimiento.Admin
{
    partial class frmEmpleado
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.gbDatos = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblTitulo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblSubtitulo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblDni = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtDni = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNombre = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblApellido = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtApellido = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTelefono = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtTelefono = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCorreo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtCorreo = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCargo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbCargo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnNuevo = new Guna.UI2.WinForms.Guna2Button();
            this.btnAgregar = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditar = new Guna.UI2.WinForms.Guna2Button();
            this.btnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.dgvEmpleados = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel1.SuspendLayout();
            this.gbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.gbDatos);
            this.guna2Panel1.Controls.Add(this.dgvEmpleados);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(950, 630);
            this.guna2Panel1.TabIndex = 0;
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.lblTitulo);
            this.gbDatos.Controls.Add(this.lblSubtitulo);
            this.gbDatos.Controls.Add(this.lblDni);
            this.gbDatos.Controls.Add(this.txtDni);
            this.gbDatos.Controls.Add(this.lblNombre);
            this.gbDatos.Controls.Add(this.txtNombre);
            this.gbDatos.Controls.Add(this.lblApellido);
            this.gbDatos.Controls.Add(this.txtApellido);
            this.gbDatos.Controls.Add(this.lblTelefono);
            this.gbDatos.Controls.Add(this.txtTelefono);
            this.gbDatos.Controls.Add(this.lblCorreo);
            this.gbDatos.Controls.Add(this.txtCorreo);
            this.gbDatos.Controls.Add(this.lblCargo);
            this.gbDatos.Controls.Add(this.cmbCargo);
            this.gbDatos.Controls.Add(this.btnNuevo);
            this.gbDatos.Controls.Add(this.btnAgregar);
            this.gbDatos.Controls.Add(this.btnEditar);
            this.gbDatos.Controls.Add(this.btnGuardar);
            this.gbDatos.Controls.Add(this.btnCancelar);
            this.gbDatos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gbDatos.ForeColor = System.Drawing.Color.Teal;
            this.gbDatos.Location = new System.Drawing.Point(30, 20);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(900, 260);
            this.gbDatos.TabIndex = 0;
            this.gbDatos.Text = "Datos del Empleado";
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.Teal;
            this.lblTitulo.Location = new System.Drawing.Point(330, 5);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(246, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Agregar Nuevo Empleado";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitulo.ForeColor = System.Drawing.Color.Gray;
            this.lblSubtitulo.Location = new System.Drawing.Point(356, 41);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(176, 15);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Gestiona los datos de tus empleados";
            // 
            // lblDni
            // 
            this.lblDni.BackColor = System.Drawing.Color.Transparent;
            this.lblDni.Location = new System.Drawing.Point(40, 70);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(25, 15);
            this.lblDni.TabIndex = 2;
            this.lblDni.Text = "DNI:";
            // 
            // txtDni
            // 
            this.txtDni.BorderRadius = 8;
            this.txtDni.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDni.DefaultText = "";
            this.txtDni.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDni.Location = new System.Drawing.Point(120, 65);
            this.txtDni.Name = "txtDni";
            this.txtDni.PlaceholderText = "";
            this.txtDni.SelectedText = "";
            this.txtDni.Size = new System.Drawing.Size(220, 30);
            this.txtDni.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Location = new System.Drawing.Point(40, 110);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(43, 15);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderRadius = 8;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.DefaultText = "";
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombre.Location = new System.Drawing.Point(120, 105);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "";
            this.txtNombre.SelectedText = "";
            this.txtNombre.Size = new System.Drawing.Size(220, 30);
            this.txtNombre.TabIndex = 5;
            // 
            // lblApellido
            // 
            this.lblApellido.BackColor = System.Drawing.Color.Transparent;
            this.lblApellido.Location = new System.Drawing.Point(40, 150);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(43, 15);
            this.lblApellido.TabIndex = 6;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtApellido
            // 
            this.txtApellido.BorderRadius = 8;
            this.txtApellido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellido.DefaultText = "";
            this.txtApellido.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtApellido.Location = new System.Drawing.Point(120, 145);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.PlaceholderText = "";
            this.txtApellido.SelectedText = "";
            this.txtApellido.Size = new System.Drawing.Size(220, 30);
            this.txtApellido.TabIndex = 7;
            // 
            // lblTelefono
            // 
            this.lblTelefono.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefono.Location = new System.Drawing.Point(380, 115);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(48, 15);
            this.lblTelefono.TabIndex = 10;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BorderRadius = 8;
            this.txtTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefono.DefaultText = "";
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTelefono.Location = new System.Drawing.Point(450, 110);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PlaceholderText = "";
            this.txtTelefono.SelectedText = "";
            this.txtTelefono.Size = new System.Drawing.Size(220, 30);
            this.txtTelefono.TabIndex = 11;
            // 
            // lblCorreo
            // 
            this.lblCorreo.BackColor = System.Drawing.Color.Transparent;
            this.lblCorreo.Location = new System.Drawing.Point(40, 190);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(37, 15);
            this.lblCorreo.TabIndex = 12;
            this.lblCorreo.Text = "Correo:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BorderRadius = 8;
            this.txtCorreo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCorreo.DefaultText = "";
            this.txtCorreo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCorreo.Location = new System.Drawing.Point(120, 185);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.PlaceholderText = "";
            this.txtCorreo.SelectedText = "";
            this.txtCorreo.Size = new System.Drawing.Size(550, 30);
            this.txtCorreo.TabIndex = 13;
            // 
            // lblCargo
            // 
            this.lblCargo.BackColor = System.Drawing.Color.Transparent;
            this.lblCargo.Location = new System.Drawing.Point(380, 70);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(34, 15);
            this.lblCargo.TabIndex = 8;
            this.lblCargo.Text = "Cargo:";
            // 
            // cmbCargo
            // 
            this.cmbCargo.BackColor = System.Drawing.Color.Transparent;
            this.cmbCargo.BorderRadius = 8;
            this.cmbCargo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCargo.FocusedColor = System.Drawing.Color.Empty;
            this.cmbCargo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCargo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbCargo.ItemHeight = 30;
            this.cmbCargo.Location = new System.Drawing.Point(450, 65);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(220, 36);
            this.cmbCargo.TabIndex = 9;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BorderRadius = 10;
            this.btnNuevo.FillColor = System.Drawing.Color.Teal;
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(720, 60);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(150, 35);
            this.btnNuevo.TabIndex = 14;
            this.btnNuevo.Text = "Nuevo";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BorderRadius = 10;
            this.btnAgregar.FillColor = System.Drawing.Color.Teal;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(720, 100);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(150, 35);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "Agregar";
            // 
            // btnEditar
            // 
            this.btnEditar.BorderRadius = 10;
            this.btnEditar.FillColor = System.Drawing.Color.Teal;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(720, 140);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(150, 35);
            this.btnEditar.TabIndex = 16;
            this.btnEditar.Text = "Editar";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BorderRadius = 10;
            this.btnGuardar.FillColor = System.Drawing.Color.Teal;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(720, 180);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(150, 35);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar Cambios";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BorderRadius = 10;
            this.btnCancelar.FillColor = System.Drawing.Color.Teal;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(720, 220);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 35);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            // 
            // dgvEmpleados
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvEmpleados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmpleados.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEmpleados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvEmpleados.Location = new System.Drawing.Point(30, 297);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.RowHeadersVisible = false;
            this.dgvEmpleados.Size = new System.Drawing.Size(900, 300);
            this.dgvEmpleados.TabIndex = 1;
            this.dgvEmpleados.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvEmpleados.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvEmpleados.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvEmpleados.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvEmpleados.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvEmpleados.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvEmpleados.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvEmpleados.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvEmpleados.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEmpleados.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dgvEmpleados.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvEmpleados.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEmpleados.ThemeStyle.HeaderStyle.Height = 23;
            this.dgvEmpleados.ThemeStyle.ReadOnly = true;
            this.dgvEmpleados.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvEmpleados.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEmpleados.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dgvEmpleados.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvEmpleados.ThemeStyle.RowsStyle.Height = 22;
            this.dgvEmpleados.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvEmpleados.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // frmEmpleado
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(950, 630);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmpleado";
            this.Text = "Empleado";
            this.guna2Panel1.ResumeLayout(false);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2GroupBox gbDatos;
        private Guna.UI2.WinForms.Guna2DataGridView dgvEmpleados;

        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitulo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSubtitulo;

        private Guna.UI2.WinForms.Guna2HtmlLabel lblDni;
        private Guna.UI2.WinForms.Guna2TextBox txtDni;

        private Guna.UI2.WinForms.Guna2HtmlLabel lblNombre;
        private Guna.UI2.WinForms.Guna2TextBox txtNombre;

        private Guna.UI2.WinForms.Guna2HtmlLabel lblApellido;
        private Guna.UI2.WinForms.Guna2TextBox txtApellido;

        private Guna.UI2.WinForms.Guna2HtmlLabel lblTelefono;
        private Guna.UI2.WinForms.Guna2TextBox txtTelefono;

        private Guna.UI2.WinForms.Guna2HtmlLabel lblCorreo;
        private Guna.UI2.WinForms.Guna2TextBox txtCorreo;

        private Guna.UI2.WinForms.Guna2HtmlLabel lblCargo;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCargo;

        private Guna.UI2.WinForms.Guna2Button btnNuevo;
        private Guna.UI2.WinForms.Guna2Button btnAgregar;
        private Guna.UI2.WinForms.Guna2Button btnEditar;
        private Guna.UI2.WinForms.Guna2Button btnGuardar;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
    }
}
