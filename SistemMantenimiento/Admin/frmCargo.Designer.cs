using System.Windows.Forms;

namespace SistemMantenimiento.Admin
{
    partial class frmCargo
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
            components = new System.ComponentModel.Container();

            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.dgvCargos = new System.Windows.Forms.DataGridView();

            this.btnAgregar = new Guna.UI2.WinForms.Guna2Button();
            this.btnBuscar = new Guna.UI2.WinForms.Guna2Button();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditar = new Guna.UI2.WinForms.Guna2Button();
            this.btnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvCargos)).BeginInit();
            this.SuspendLayout();

            // Label Nombre
            this.lblNombre.AutoSize = true;
            this.lblNombre.Text = "Nombre del Cargo:";
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNombre.Location = new System.Drawing.Point(40, 40);

            // TextBox Nombre
            this.txtNombre.BorderRadius = 8;
            this.txtNombre.Size = new System.Drawing.Size(240, 32);
            this.txtNombre.Location = new System.Drawing.Point(40, 70);

            // Label Buscar
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Text = "Buscar Cargo:";
            this.lblBuscar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBuscar.Location = new System.Drawing.Point(40, 120);

            // TextBox Buscar
            this.txtBuscar.BorderRadius = 8;
            this.txtBuscar.Size = new System.Drawing.Size(240, 32);
            this.txtBuscar.Location = new System.Drawing.Point(40, 150);

            // Label Tabla
            this.lblCargo.AutoSize = true;
            this.lblCargo.Text = "Registro de Cargos:";
            this.lblCargo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCargo.Location = new System.Drawing.Point(40, 200);

            // DataGridView
            this.dgvCargos.Location = new System.Drawing.Point(40, 230);
            this.dgvCargos.Size = new System.Drawing.Size(500, 220);
            this.dgvCargos.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvCargos.ReadOnly = true;
            this.dgvCargos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvCargos.AllowUserToAddRows = false;
            this.dgvCargos.AllowUserToDeleteRows = false;

            // Botón Agregar
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.FillColor = System.Drawing.Color.FromArgb(0, 77, 77);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.BorderRadius = 10;
            this.btnAgregar.Size = new System.Drawing.Size(180, 40);
            this.btnAgregar.Location = new System.Drawing.Point(600, 60);

            // Botón Buscar
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.FillColor = System.Drawing.Color.FromArgb(0, 77, 77);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.BorderRadius = 10;
            this.btnBuscar.Size = new System.Drawing.Size(180, 40);
            this.btnBuscar.Location = new System.Drawing.Point(600, 110);

            // Botón Eliminar
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.FillColor = System.Drawing.Color.FromArgb(0, 77, 77);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.BorderRadius = 10;
            this.btnEliminar.Size = new System.Drawing.Size(180, 40);
            this.btnEliminar.Location = new System.Drawing.Point(600, 160);

            // Botón Editar
            this.btnEditar.Text = "Habilitar Edición";
            this.btnEditar.FillColor = System.Drawing.Color.FromArgb(0, 77, 77);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.BorderRadius = 10;
            this.btnEditar.Size = new System.Drawing.Size(180, 40);
            this.btnEditar.Location = new System.Drawing.Point(600, 210);

            // Botón Guardar
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.FillColor = System.Drawing.Color.FromArgb(0, 77, 77);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.BorderRadius = 10;
            this.btnGuardar.Size = new System.Drawing.Size(180, 40);
            this.btnGuardar.Location = new System.Drawing.Point(600, 260);

            // Botón Cancelar
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.FillColor = System.Drawing.Color.FromArgb(0, 77, 77);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.BorderRadius = 10;
            this.btnCancelar.Size = new System.Drawing.Size(180, 40);
            this.btnCancelar.Location = new System.Drawing.Point(600, 310);

            // Form
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.dgvCargos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);

            this.Font = new System.Drawing.Font("Segoe UI", 10F);

            ((System.ComponentModel.ISupportInitialize)(this.dgvCargos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private Guna.UI2.WinForms.Guna2TextBox txtNombre;
        private System.Windows.Forms.Label lblBuscar;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscar;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.DataGridView dgvCargos;
        private Guna.UI2.WinForms.Guna2Button btnAgregar;
        private Guna.UI2.WinForms.Guna2Button btnBuscar;
        private Guna.UI2.WinForms.Guna2Button btnEliminar;
        private Guna.UI2.WinForms.Guna2Button btnEditar;
        private Guna.UI2.WinForms.Guna2Button btnGuardar;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
    }
}
