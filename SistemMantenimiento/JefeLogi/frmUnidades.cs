using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad.Producto;
using CapaLogica.Producto;

namespace SistemMantenimiento.JefeLogi
{
    public partial class frmUnidades : Form
    {
        private int idSeleccionado = 0;
        private bool modoEdicion = false;

        public frmUnidades()
        {
            InitializeComponent();
            CargarUnidades();
            dgvUnidades.CellClick += dgvUnidades_CellClick;

            btnAgregar.Click += BtnAgregar_Click;
            btnBuscar.Click += BtnBuscar_Click;
            btnEliminar.Click += BtnEliminar_Click;
            btnEditar.Click += BtnEditar_Click;
        }

        // Cargar lista al iniciar
        private void CargarUnidades()
        {
            dgvUnidades.DataSource = logUnidadMedida_Producto.Instancia.ListarUnidades();
            dgvUnidades.Columns["id_unidad"].Visible = false;
        }

        // Selección del DataGrid
        private void dgvUnidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idSeleccionado = Convert.ToInt32(dgvUnidades.Rows[e.RowIndex].Cells["id_unidad"].Value);
                txtNombreUnidad.Text = dgvUnidades.Rows[e.RowIndex].Cells["nombre_unidad"].Value.ToString();
                txtAbreviatura.Text = dgvUnidades.Rows[e.RowIndex].Cells["abreviatura"].Value.ToString();
            }
        }

        // AGREGAR
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            entUnidadMedida_Producto unidad = new entUnidadMedida_Producto
            {
                nombre_unidad = txtNombreUnidad.Text.Trim(),
                abreviatura = txtAbreviatura.Text.Trim()
            };

            string mensaje = logUnidadMedida_Producto.Instancia.RegistrarUnidad(unidad);
            MessageBox.Show(mensaje);

            CargarUnidades();
            LimpiarCampos();
        }

        // BUSCAR
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = txtBuscarUnidad.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(filtro))
            {
                CargarUnidades();
                return;
            }

            var lista = logUnidadMedida_Producto.Instancia.ListarUnidades();
            dgvUnidades.DataSource = lista.FindAll(x =>
                x.nombre_unidad.ToLower().Contains(filtro) ||
                x.abreviatura.ToLower().Contains(filtro)
            );
        }

        // HABILITAR EDICIÓN
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado <= 0)
            {
                MessageBox.Show("Seleccione una unidad de la tabla primero.");
                return;
            }

            modoEdicion = !modoEdicion;
            btnAgregar.Enabled = !modoEdicion;
            btnEliminar.Enabled = !modoEdicion;

            btnEditar.Text = modoEdicion
                ? "Guardar Cambios"
                : "Habilitar Edición";

            if (!modoEdicion)
            {
                entUnidadMedida_Producto unidad = new entUnidadMedida_Producto
                {
                    id_unidad = idSeleccionado,
                    nombre_unidad = txtNombreUnidad.Text.Trim(),
                    abreviatura = txtAbreviatura.Text.Trim()
                };

                string mensaje = logUnidadMedida_Producto.Instancia.ActualizarUnidad(unidad);
                MessageBox.Show(mensaje);

                CargarUnidades();
                LimpiarCampos();
            }
        }

        // ELIMINAR
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado <= 0)
            {
                MessageBox.Show("Seleccione una unidad a eliminar.");
                return;
            }

            var confirm = MessageBox.Show("¿Seguro que desea eliminar esta unidad?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                string mensaje = logUnidadMedida_Producto.Instancia.EliminarUnidad(idSeleccionado);
                MessageBox.Show(mensaje);

                CargarUnidades();
                LimpiarCampos();
            }
        }

        // LIMPIAR INPUTS
        private void LimpiarCampos()
        {
            idSeleccionado = 0;
            txtNombreUnidad.Text = "";
            txtAbreviatura.Text = "";
            txtBuscarUnidad.Text = "";
        }
    }
}
