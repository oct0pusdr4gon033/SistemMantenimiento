namespace SistemMantenimiento.JefeLogi
{
    partial class Consultar_req
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.gbBusqueda = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblCodigo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtCodigo = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblFecha = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dtpFecha = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnBuscar = new Guna.UI2.WinForms.Guna2Button();
            this.gbCabecera = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblEmpleado = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtEmpleado = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCod = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtCodReq = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblFechaReq = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dtpFechaReq = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dgvDetalles = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel1.SuspendLayout();
            this.gbBusqueda.SuspendLayout();
            this.gbCabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.gbBusqueda);
            this.guna2Panel1.Controls.Add(this.gbCabecera);
            this.guna2Panel1.Controls.Add(this.dgvDetalles);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(950, 630);
            this.guna2Panel1.TabIndex = 0;
            // 
            // gbBusqueda
            // 
            this.gbBusqueda.Controls.Add(this.lblCodigo);
            this.gbBusqueda.Controls.Add(this.txtCodigo);
            this.gbBusqueda.Controls.Add(this.lblFecha);
            this.gbBusqueda.Controls.Add(this.dtpFecha);
            this.gbBusqueda.Controls.Add(this.btnBuscar);
            this.gbBusqueda.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gbBusqueda.ForeColor = System.Drawing.Color.Teal;
            this.gbBusqueda.Location = new System.Drawing.Point(25, 10);
            this.gbBusqueda.Name = "gbBusqueda";
            this.gbBusqueda.Size = new System.Drawing.Size(900, 90);
            this.gbBusqueda.TabIndex = 0;
            this.gbBusqueda.Text = "Buscar Requerimiento";
            // 
            // lblCodigo
            // 
            this.lblCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigo.Location = new System.Drawing.Point(30, 53);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(39, 15);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigo.DefaultText = "";
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCodigo.Location = new System.Drawing.Point(87, 48);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PlaceholderText = "";
            this.txtCodigo.SelectedText = "";
            this.txtCodigo.Size = new System.Drawing.Size(180, 31);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblFecha
            // 
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Location = new System.Drawing.Point(375, 53);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(36, 15);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.BorderRadius = 10;
            this.dtpFecha.Checked = true;
            this.dtpFecha.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtpFecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpFecha.Location = new System.Drawing.Point(431, 48);
            this.dtpFecha.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFecha.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(235, 31);
            this.dtpFecha.TabIndex = 3;
            this.dtpFecha.Value = new System.DateTime(2025, 12, 6, 2, 7, 14, 275);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BorderRadius = 8;
            this.btnBuscar.FillColor = System.Drawing.Color.Teal;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(754, 48);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(130, 31);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gbCabecera
            // 
            this.gbCabecera.Controls.Add(this.lblEmpleado);
            this.gbCabecera.Controls.Add(this.txtEmpleado);
            this.gbCabecera.Controls.Add(this.lblCod);
            this.gbCabecera.Controls.Add(this.txtCodReq);
            this.gbCabecera.Controls.Add(this.lblFechaReq);
            this.gbCabecera.Controls.Add(this.dtpFechaReq);
            this.gbCabecera.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gbCabecera.ForeColor = System.Drawing.Color.Teal;
            this.gbCabecera.Location = new System.Drawing.Point(25, 110);
            this.gbCabecera.Name = "gbCabecera";
            this.gbCabecera.Size = new System.Drawing.Size(900, 120);
            this.gbCabecera.TabIndex = 1;
            this.gbCabecera.Text = "Información del Requerimiento";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpleado.Location = new System.Drawing.Point(30, 66);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(53, 15);
            this.lblEmpleado.TabIndex = 0;
            this.lblEmpleado.Text = "Empleado:";
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmpleado.DefaultText = "";
            this.txtEmpleado.Enabled = false;
            this.txtEmpleado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmpleado.Location = new System.Drawing.Point(100, 61);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.PlaceholderText = "";
            this.txtEmpleado.SelectedText = "";
            this.txtEmpleado.Size = new System.Drawing.Size(200, 30);
            this.txtEmpleado.TabIndex = 1;
            // 
            // lblCod
            // 
            this.lblCod.BackColor = System.Drawing.Color.Transparent;
            this.lblCod.Location = new System.Drawing.Point(344, 66);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(39, 15);
            this.lblCod.TabIndex = 2;
            this.lblCod.Text = "Código:";
            // 
            // txtCodReq
            // 
            this.txtCodReq.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodReq.DefaultText = "";
            this.txtCodReq.Enabled = false;
            this.txtCodReq.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCodReq.Location = new System.Drawing.Point(407, 61);
            this.txtCodReq.Name = "txtCodReq";
            this.txtCodReq.PlaceholderText = "";
            this.txtCodReq.SelectedText = "";
            this.txtCodReq.Size = new System.Drawing.Size(167, 30);
            this.txtCodReq.TabIndex = 3;
            // 
            // lblFechaReq
            // 
            this.lblFechaReq.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaReq.Location = new System.Drawing.Point(600, 66);
            this.lblFechaReq.Name = "lblFechaReq";
            this.lblFechaReq.Size = new System.Drawing.Size(36, 15);
            this.lblFechaReq.TabIndex = 4;
            this.lblFechaReq.Text = "Fecha:";
            // 
            // dtpFechaReq
            // 
            this.dtpFechaReq.BorderRadius = 10;
            this.dtpFechaReq.Checked = true;
            this.dtpFechaReq.Enabled = false;
            this.dtpFechaReq.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtpFechaReq.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFechaReq.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpFechaReq.Location = new System.Drawing.Point(642, 61);
            this.dtpFechaReq.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFechaReq.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFechaReq.Name = "dtpFechaReq";
            this.dtpFechaReq.Size = new System.Drawing.Size(200, 36);
            this.dtpFechaReq.TabIndex = 5;
            this.dtpFechaReq.Value = new System.DateTime(2025, 12, 6, 2, 7, 14, 299);
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToAddRows = false;
            this.dgvDetalles.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvDetalles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalles.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDetalles.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDetalles.Location = new System.Drawing.Point(25, 240);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.RowHeadersVisible = false;
            this.dgvDetalles.Size = new System.Drawing.Size(900, 350);
            this.dgvDetalles.TabIndex = 2;
            this.dgvDetalles.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDetalles.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDetalles.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDetalles.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDetalles.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDetalles.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDetalles.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDetalles.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDetalles.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDetalles.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDetalles.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDetalles.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDetalles.ThemeStyle.HeaderStyle.Height = 23;
            this.dgvDetalles.ThemeStyle.ReadOnly = true;
            this.dgvDetalles.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDetalles.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDetalles.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDetalles.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDetalles.ThemeStyle.RowsStyle.Height = 22;
            this.dgvDetalles.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDetalles.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Consultar_req
            // 
            this.ClientSize = new System.Drawing.Size(950, 630);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Consultar_req";
            this.Text = "Consultar Requerimiento";
            this.guna2Panel1.ResumeLayout(false);
            this.gbBusqueda.ResumeLayout(false);
            this.gbBusqueda.PerformLayout();
            this.gbCabecera.ResumeLayout(false);
            this.gbCabecera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2GroupBox gbBusqueda;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCodigo;
        private Guna.UI2.WinForms.Guna2TextBox txtCodigo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblFecha;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFecha;
        private Guna.UI2.WinForms.Guna2Button btnBuscar;

        private Guna.UI2.WinForms.Guna2GroupBox gbCabecera;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblEmpleado;
        private Guna.UI2.WinForms.Guna2TextBox txtEmpleado;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCod;
        private Guna.UI2.WinForms.Guna2TextBox txtCodReq;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblFechaReq;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFechaReq;

        private Guna.UI2.WinForms.Guna2DataGridView dgvDetalles;
    }
}
