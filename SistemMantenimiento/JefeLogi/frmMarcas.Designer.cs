namespace SistemMantenimiento.JefeLogi
{
    partial class frmMarcas
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombreMarca;
        private Guna.UI2.WinForms.Guna2TextBox txtNombreMarca;
        private System.Windows.Forms.Label lblBuscarMarca;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscarMarca;
        private System.Windows.Forms.Label lblListado;
        private System.Windows.Forms.DataGridView dgvMarcas;

        private Guna.UI2.WinForms.Guna2Button btnAgregar;
        private Guna.UI2.WinForms.Guna2Button btnBuscar;
        private Guna.UI2.WinForms.Guna2Button btnEliminar;
        private Guna.UI2.WinForms.Guna2Button btnEditar;

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
            this.components = new System.ComponentModel.Container();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombreMarca = new System.Windows.Forms.Label();
            this.txtNombreMarca = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblBuscarMarca = new System.Windows.Forms.Label();
            this.txtBuscarMarca = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblListado = new System.Windows.Forms.Label();
            this.dgvMarcas = new System.Windows.Forms.DataGridView();

            this.btnAgregar = new Guna.UI2.WinForms.Guna2Button();
            this.btnBuscar = new Guna.UI2.WinForms.Guna2Button();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditar = new Guna.UI2.WinForms.Guna2Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            this.SuspendLayout();

            // TÍTULO DEL FORM
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(0, 77, 77);
            this.lblTitulo.Location = new System.Drawing.Point(40, 20);
            this.lblTitulo.Text = "Mantenimiento de Marcas";

            // Nombre Marca
            this.lblNombreMarca.AutoSize = true;
            this.lblNombreMarca.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNombreMarca.Location = new System.Drawing.Point(40, 80);
            this.lblNombreMarca.Text = "Nombre de Marca:";

            this.txtNombreMarca.Location = new System.Drawing.Point(40, 105);
            this.txtNombreMarca.Size = new System.Drawing.Size(250, 35);

            // Buscar Marca
            this.lblBuscarMarca.AutoSize = true;
            this.lblBuscarMarca.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBuscarMarca.Location = new System.Drawing.Point(40, 160);
            this.lblBuscarMarca.Text = "Buscar Marca:";

            this.txtBuscarMarca.Location = new System.Drawing.Point(40, 185);
            this.txtBuscarMarca.Size = new System.Drawing.Size(250, 35);

            // DataGrid
            this.lblListado.AutoSize = true;
            this.lblListado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblListado.Location = new System.Drawing.Point(40, 240);
            this.lblListado.Text = "Listado de Marcas:";

            this.dgvMarcas.Location = new System.Drawing.Point(40, 270);
            this.dgvMarcas.Size = new System.Drawing.Size(400, 150);
            this.dgvMarcas.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvMarcas.AllowUserToAddRows = false;
            this.dgvMarcas.ReadOnly = true;

            // Botones CRUD
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.FillColor = System.Drawing.Color.FromArgb(0, 77, 77);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.BorderRadius = 10;
            this.btnAgregar.Size = new System.Drawing.Size(180, 40);
            this.btnAgregar.Location = new System.Drawing.Point(500, 105);

            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.FillColor = System.Drawing.Color.FromArgb(0, 77, 77);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.BorderRadius = 10;
            this.btnBuscar.Size = new System.Drawing.Size(180, 40);
            this.btnBuscar.Location = new System.Drawing.Point(500, 155);

            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.FillColor = System.Drawing.Color.FromArgb(0, 77, 77);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.BorderRadius = 10;
            this.btnEliminar.Size = new System.Drawing.Size(180, 40);
            this.btnEliminar.Location = new System.Drawing.Point(500, 205);

            this.btnEditar.Text = "Habilitar Edición";
            this.btnEditar.FillColor = System.Drawing.Color.FromArgb(0, 77, 77);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.BorderRadius = 10;
            this.btnEditar.Size = new System.Drawing.Size(180, 40);
            this.btnEditar.Location = new System.Drawing.Point(500, 255);

            // Agregar controles al Form
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblNombreMarca);
            this.Controls.Add(this.txtNombreMarca);
            this.Controls.Add(this.lblBuscarMarca);
            this.Controls.Add(this.txtBuscarMarca);
            this.Controls.Add(this.lblListado);
            this.Controls.Add(this.dgvMarcas);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);

            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(720, 450);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Text = "frmMarcas";

            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
    }
}
