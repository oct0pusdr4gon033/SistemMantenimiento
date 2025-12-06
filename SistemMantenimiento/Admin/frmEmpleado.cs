using CapaEntidad.Empleado;
using CapaLogica;
using CapaLogica.Empleado;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SistemMantenimiento.Admin
{
    public partial class frmEmpleado : Form
    {
        private int idSeleccionado = 0;

        public frmEmpleado()
        {
            InitializeComponent();
            this.Load += frmEmpleado_Load;

            dgvEmpleados.CellClick += dgvEmpleados_CellClick;
            btnNuevo.Click += btnNuevo_Click;
            btnAgregar.Click += btnAgregar_Click;
            btnEditar.Click += btnEditar_Click;
            btnGuardar.Click += btnGuardar_Click;
            btnCancelar.Click += btnCancelar_Click;
        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            CargarCargos();
            MostrarEmpleados();
            InicializarControles();
        }

        private void CargarCargos()
        {
            cmbCargo.DataSource = logCargo.Instancia.Listar();
            cmbCargo.DisplayMember = "nombre_cargo";
            cmbCargo.ValueMember = "id_cargo";
            cmbCargo.SelectedIndex = -1;
        }

        private void MostrarEmpleados()
        {
            dgvEmpleados.DataSource = logEmpleado.Instancia.Listar();
            dgvEmpleados.ClearSelection();

            if (dgvEmpleados.Columns["id_empleado"] != null)
                dgvEmpleados.Columns["id_empleado"].Visible = false;

            if (dgvEmpleados.Columns["id_cargo"] != null)
                dgvEmpleados.Columns["id_cargo"].Visible = false;

            // Mostrar el nombre del cargo traído desde el SP
            if (dgvEmpleados.Columns["cargo"] != null)
            {
                dgvEmpleados.Columns["cargo"].HeaderText = "Cargo";
                dgvEmpleados.Columns["cargo"].DisplayIndex = 3; // Ubicación visual en la tabla
            }
        }


        private void InicializarControles()
        {
            BloquearCampos();
            txtDni.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            cmbCargo.SelectedIndex = -1;

            btnAgregar.Enabled = false;
            btnEditar.Enabled = false;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnNuevo.Enabled = true;

            idSeleccionado = 0;
        }

        private void BloquearCampos()
        {
            txtDni.Enabled = false;
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtTelefono.Enabled = false;
            txtCorreo.Enabled = false;
            cmbCargo.Enabled = false;
        }

        private void HabilitarCampos()
        {
            txtDni.Enabled = true;
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtTelefono.Enabled = true;
            txtCorreo.Enabled = true;
            cmbCargo.Enabled = true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();

            txtDni.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            cmbCargo.SelectedIndex = -1;

            btnAgregar.Enabled = true;
            btnCancelar.Enabled = true;
            btnEditar.Enabled = false;
            btnGuardar.Enabled = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            entEmpleado emp = new entEmpleado
            {
                dni_empleado = txtDni.Text.Trim(),
                nombre_empleado = txtNombre.Text.Trim(),
                apellido_empleado = txtApellido.Text.Trim(),
                telf = txtTelefono.Text.Trim(),
                correo = txtCorreo.Text.Trim(),
                id_cargo = Convert.ToInt32(cmbCargo.SelectedValue)
            };

            logEmpleado.Instancia.Registrar(emp);
            MostrarEmpleados();
            InicializarControles();
        }

        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var fila = dgvEmpleados.Rows[e.RowIndex];

            idSeleccionado = Convert.ToInt32(fila.Cells["id_empleado"].Value);
            txtDni.Text = fila.Cells["dni_empleado"].Value.ToString();
            txtNombre.Text = fila.Cells["nombre_empleado"].Value.ToString();
            txtApellido.Text = fila.Cells["apellido_empleado"].Value.ToString();
            txtTelefono.Text = fila.Cells["telf"].Value.ToString();
            txtCorreo.Text = fila.Cells["correo"].Value.ToString();

            // Se sigue usando id_cargo aunque esté oculto
            cmbCargo.SelectedValue = fila.Cells["id_cargo"].Value;

            btnEditar.Enabled = true;
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado <= 0)
            {
                MessageBox.Show("Selecciona un empleado primero.");
                return;
            }

            HabilitarCampos();
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnAgregar.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            entEmpleado emp = new entEmpleado
            {
                id_empleado = idSeleccionado,
                dni_empleado = txtDni.Text.Trim(),
                nombre_empleado = txtNombre.Text.Trim(),
                apellido_empleado = txtApellido.Text.Trim(),
                telf = txtTelefono.Text.Trim(),
                correo = txtCorreo.Text.Trim(),
                id_cargo = Convert.ToInt32(cmbCargo.SelectedValue)
            };

            logEmpleado.Instancia.Editar(emp);

            MostrarEmpleados();
            InicializarControles();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            InicializarControles();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtDni.Text))
            {
                MessageBox.Show("Ingrese DNI.");
                return false;
            }
            if (cmbCargo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un cargo.");
                return false;
            }
            return true;
        }
    }
}
