using System.Windows.Forms;

namespace SistemMantenimiento.JefeLogi
{
    partial class frmCategorias
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
            this.lblArea = new System.Windows.Forms.Label();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();

            this.btnAgregar = new Guna.UI2.WinForms.Guna2Button();
            this.btnBuscar = new Guna.UI2.WinForms.Guna2Button();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditar = new Guna.UI2.WinForms.Guna2Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.SuspendLayout();

            // Label Nombre
            this.lblNombre.AutoSize = true;
            this.lblNombre.Text = "Nombre de Categoría:";
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNombre.Location = new System.Drawing.Point(40, 40);

            // TextBox Nombre
            this.txtNombre.BorderRadius = 8;
            this.txtNombre.Size = new System.Drawing.Size(240, 32);
            this.txtNombre.Location = new System.Drawing.Point(40, 70);

            // Label Buscar
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Text = "Buscar Categoría:";
            this.lblBuscar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBuscar.Location = new System.Drawing.Point(40, 120);

            // TextBox Buscar
            this.txtBuscar.BorderRadius = 8;
            this.txtBuscar.Size = new System.Drawing.Size(240, 32);
            this.txtBuscar.Location = new System.Drawing.Point(40, 150);

            // Label Tabla
            this.lblArea.AutoSize = true;
            this.lblArea.Text = "Registro de Categorías:";
            this.lblArea.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblArea.Location = new System.Drawing.Point(40, 200);

            // DataGridView
            this.dgvCategorias.Location = new System.Drawing.Point(40, 230);
            this.dgvCategorias.Size = new System.Drawing.Size(500, 220);
            this.dgvCategorias.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvCategorias.ReadOnly = true;
            this.dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

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


            // Form
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.dgvCategorias);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);

            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void ConfigurarBoton(Guna.UI2.WinForms.Guna2Button boton, string texto, int x, int y)
        {
            boton.Text = texto;
            boton.FillColor = System.Drawing.Color.FromArgb(0, 77, 77);
            boton.ForeColor = System.Drawing.Color.White;
            boton.BorderRadius = 10;
            boton.Size = new System.Drawing.Size(180, 40);
            boton.Location = new System.Drawing.Point(x, y);
        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private Guna.UI2.WinForms.Guna2TextBox txtNombre;
        private System.Windows.Forms.Label lblBuscar;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscar;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private Guna.UI2.WinForms.Guna2Button btnAgregar;
        private Guna.UI2.WinForms.Guna2Button btnBuscar;
        private Guna.UI2.WinForms.Guna2Button btnEliminar;
        private Guna.UI2.WinForms.Guna2Button btnEditar;
    }
}
