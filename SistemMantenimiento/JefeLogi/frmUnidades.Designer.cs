namespace SistemMantenimiento.JefeLogi
{
    partial class frmUnidades
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombreUnidad;
        private System.Windows.Forms.Label lblAbreviatura;
        private System.Windows.Forms.Label lblBuscarUnidad;
        private System.Windows.Forms.Label lblListado;

        private Guna.UI2.WinForms.Guna2TextBox txtNombreUnidad;
        private Guna.UI2.WinForms.Guna2TextBox txtAbreviatura;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscarUnidad;

        private System.Windows.Forms.DataGridView dgvUnidades;

        private Guna.UI2.WinForms.Guna2Button btnAgregar;
        private Guna.UI2.WinForms.Guna2Button btnBuscar;
        private Guna.UI2.WinForms.Guna2Button btnEliminar;
        private Guna.UI2.WinForms.Guna2Button btnEditar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombreUnidad = new System.Windows.Forms.Label();
            this.lblAbreviatura = new System.Windows.Forms.Label();
            this.lblBuscarUnidad = new System.Windows.Forms.Label();
            this.lblListado = new System.Windows.Forms.Label();

            this.txtNombreUnidad = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAbreviatura = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBuscarUnidad = new Guna.UI2.WinForms.Guna2TextBox();

            this.dgvUnidades = new System.Windows.Forms.DataGridView();

            this.btnAgregar = new Guna.UI2.WinForms.Guna2Button();
            this.btnBuscar = new Guna.UI2.WinForms.Guna2Button();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditar = new Guna.UI2.WinForms.Guna2Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvUnidades)).BeginInit();
            this.SuspendLayout();

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(0, 77, 77);
            this.lblTitulo.Location = new System.Drawing.Point(40, 20);
            this.lblTitulo.Text = "Mantenimiento de Unidades";

            // lblNombreUnidad
            this.lblNombreUnidad.AutoSize = true;
            this.lblNombreUnidad.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNombreUnidad.Location = new System.Drawing.Point(40, 80);
            this.lblNombreUnidad.Text = "Nombre de Unidad:";

            // txtNombreUnidad
            this.txtNombreUnidad.Location = new System.Drawing.Point(40, 105);
            this.txtNombreUnidad.Size = new System.Drawing.Size(250, 35);

            // lblAbreviatura
            this.lblAbreviatura.AutoSize = true;
            this.lblAbreviatura.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAbreviatura.Location = new System.Drawing.Point(40, 150);
            this.lblAbreviatura.Text = "Abreviatura:";

            // txtAbreviatura
            this.txtAbreviatura.Location = new System.Drawing.Point(40, 175);
            this.txtAbreviatura.Size = new System.Drawing.Size(250, 35);

            // lblBuscarUnidad
            this.lblBuscarUnidad.AutoSize = true;
            this.lblBuscarUnidad.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBuscarUnidad.Location = new System.Drawing.Point(40, 225);
            this.lblBuscarUnidad.Text = "Buscar Unidad:";

            // txtBuscarUnidad
            this.txtBuscarUnidad.Location = new System.Drawing.Point(40, 250);
            this.txtBuscarUnidad.Size = new System.Drawing.Size(250, 35);

            // lblListado
            this.lblListado.AutoSize = true;
            this.lblListado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblListado.Location = new System.Drawing.Point(40, 310);
            this.lblListado.Text = "Listado de Unidades:";

            // dgvUnidades
            this.dgvUnidades.Location = new System.Drawing.Point(40, 335);
            this.dgvUnidades.Size = new System.Drawing.Size(400, 150);
            this.dgvUnidades.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvUnidades.AllowUserToAddRows = false;
            this.dgvUnidades.ReadOnly = true;

            // btnAgregar
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.FillColor = System.Drawing.Color.FromArgb(0, 77, 77);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.BorderRadius = 10;
            this.btnAgregar.Size = new System.Drawing.Size(180, 40);
            this.btnAgregar.Location = new System.Drawing.Point(500, 105);

            // btnBuscar
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.FillColor = System.Drawing.Color.FromArgb(0, 77, 77);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.BorderRadius = 10;
            this.btnBuscar.Size = new System.Drawing.Size(180, 40);
            this.btnBuscar.Location = new System.Drawing.Point(500, 150);

            // btnEliminar
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.FillColor = System.Drawing.Color.FromArgb(0, 77, 77);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.BorderRadius = 10;
            this.btnEliminar.Size = new System.Drawing.Size(180, 40);
            this.btnEliminar.Location = new System.Drawing.Point(500, 195);

            // btnEditar
            this.btnEditar.Text = "Habilitar Edición";
            this.btnEditar.FillColor = System.Drawing.Color.FromArgb(0, 77, 77);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.BorderRadius = 10;
            this.btnEditar.Size = new System.Drawing.Size(180, 40);
            this.btnEditar.Location = new System.Drawing.Point(500, 240);

            // Form
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(760, 520);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblNombreUnidad);
            this.Controls.Add(this.txtNombreUnidad);
            this.Controls.Add(this.lblAbreviatura);
            this.Controls.Add(this.txtAbreviatura);
            this.Controls.Add(this.lblBuscarUnidad);
            this.Controls.Add(this.txtBuscarUnidad);
            this.Controls.Add(this.lblListado);
            this.Controls.Add(this.dgvUnidades);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);

            this.Text = "frmUnidades";

            ((System.ComponentModel.ISupportInitialize)(this.dgvUnidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
    }
}
