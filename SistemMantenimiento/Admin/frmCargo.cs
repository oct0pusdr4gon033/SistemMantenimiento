using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad.Empleado;
using CapaLogica.Empleado;

namespace SistemMantenimiento.Admin
{
    public partial class frmCargo : Form
    {
        private int idSeleccionado = 0;
        private bool editando = false;

        public frmCargo()
        {
            InitializeComponent();
            this.Load += frmCargo_Load;

            dgvCargos.CellClick += dgvCargos_CellClick;

            btnAgregar.Click += btnAgregar_Click;
            btnEditar.Click += btnEditar_Click;
            btnGuardar.Click += btnGuardar_Click;
            btnEliminar.Click += btnEliminar_Click;
            btnCancelar.Click += btnCancelar_Click;
            btnBuscar.Click += btnBuscar_Click;
        }

        private void frmCargo_Load(object sender, EventArgs e)
        {
            ConfigurarDGV();
            InicializarFormulario();
            MostrarCargos();
        }

        private void ConfigurarDGV()
        {
            dgvCargos.ReadOnly = true;
            dgvCargos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCargos.MultiSelect = false;
        }

        private void InicializarFormulario()
        {
            txtNombre.Clear();
            txtBuscar.Clear();

            btnAgregar.Enabled = true;
            btnEditar.Enabled = false;
            btnGuardar.Enabled = false;
            btnEliminar.Enabled = false;
            btnCancelar.Enabled = false;

            txtNombre.Enabled = false;
            idSeleccionado = 0;
            editando = false;
        }

        private void HabilitarEdicion()
        {
            txtNombre.Enabled = true;
            txtNombre.Focus();
        }

        private void MostrarCargos()
        {
            var lista = logCargo.Instancia.Listar();
            dgvCargos.DataSource = lista;

            if (dgvCargos.Columns.Contains("id_cargo"))
                dgvCargos.Columns["id_cargo"].Visible = false;

            dgvCargos.ClearSelection();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            editando = false;
            idSeleccionado = 0;
            HabilitarEdicion();
            txtNombre.Clear();

            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void dgvCargos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            idSeleccionado = Convert.ToInt32(dgvCargos.Rows[e.RowIndex].Cells["id_cargo"].Value);
            txtNombre.Text = dgvCargos.Rows[e.RowIndex].Cells["nombre_cargo"].Value.ToString();

            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnAgregar.Enabled = false;
            btnGuardar.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado <= 0)
            {
                MessageBox.Show("Seleccione un cargo primero.");
                return;
            }

            editando = true;
            HabilitarEdicion();

            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnEliminar.Enabled = false;
            btnAgregar.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese un nombre válido.");
                return;
            }

            entCargo cargo = new entCargo()
            {
                id_cargo = idSeleccionado,
                nombre_cargo = txtNombre.Text.Trim()
            };

            string rpta = editando
                ? logCargo.Instancia.Editar(cargo)
                : logCargo.Instancia.Insertar(cargo);

            MessageBox.Show(rpta);
            MostrarCargos();
            InicializarFormulario();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado <= 0)
            {
                MessageBox.Show("Seleccione un cargo primero.");
                return;
            }

            if (MessageBox.Show("¿Seguro que deseas eliminar este cargo?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string rpta = logCargo.Instancia.Eliminar(idSeleccionado);
                MessageBox.Show(rpta);
                MostrarCargos();
                InicializarFormulario();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(filtro))
            {
                MostrarCargos();
                return;
            }

            var lista = logCargo.Instancia.Listar()
                .Where(c => c.nombre_cargo.ToLower().Contains(filtro))
                .ToList();

            dgvCargos.DataSource = lista;

            if (lista.Count == 0)
                MessageBox.Show("Sin coincidencias.");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            InicializarFormulario();
        }
    }
}
