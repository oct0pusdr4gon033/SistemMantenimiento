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
            AsociarEventos();
        }

        private void AsociarEventos()
        {
            dgvUnidades.CellClick += dgvUnidades_CellClick;
            btnAgregar.Click += BtnAgregar_Click;
            btnBuscar.Click += BtnBuscar_Click;
            btnEliminar.Click += BtnEliminar_Click;
            btnEditar.Click += BtnEditar_Click;
        }

        private void CargarUnidades()
        {
            dgvUnidades.DataSource = logUnidadMedida_Producto.Instancia.ListarUnidades();
            dgvUnidades.Columns["id_unidad"].Visible = false;
        }

        private void dgvUnidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (modoEdicion) return;

            if (e.RowIndex >= 0)
            {
                idSeleccionado = Convert.ToInt32(dgvUnidades.Rows[e.RowIndex].Cells["id_unidad"].Value);
                txtNombreUnidad.Text = dgvUnidades.Rows[e.RowIndex].Cells["nombre_unidad"].Value.ToString();
                txtAbreviatura.Text = dgvUnidades.Rows[e.RowIndex].Cells["abreviatura"].Value.ToString();
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            entUnidadMedida_Producto unidad = new entUnidadMedida_Producto
            {
                nombre_unidad = txtNombreUnidad.Text.Trim(),
                abreviatura = txtAbreviatura.Text.Trim()
            };

            MessageBox.Show(logUnidadMedida_Producto.Instancia.RegistrarUnidad(unidad));
            CargarUnidades();
            Limpiar();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = txtBuscarUnidad.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(filtro))
            {
                CargarUnidades();
                return;
            }

            var lista = logUnidadMedida_Producto.Instancia.ListarUnidades();
            dgvUnidades.DataSource = lista
                .Where(x => x.nombre_unidad.ToLower().Contains(filtro) ||
                            x.abreviatura.ToLower().Contains(filtro))
                .ToList();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado <= 0)
            {
                MessageBox.Show("Selecciona una unidad primero.");
                return;
            }

            if (!modoEdicion)
            {
                modoEdicion = true;
                btnEditar.Text = "Guardar";
                btnAgregar.Enabled = false;
                btnEliminar.Enabled = false;
            }
            else
            {
                entUnidadMedida_Producto unidad = new entUnidadMedida_Producto
                {
                    id_unidad = idSeleccionado,
                    nombre_unidad = txtNombreUnidad.Text.Trim(),
                    abreviatura = txtAbreviatura.Text.Trim()
                };

                MessageBox.Show(logUnidadMedida_Producto.Instancia.ActualizarUnidad(unidad));
                modoEdicion = false;
                btnEditar.Text = "Editar";
                btnAgregar.Enabled = true;
                btnEliminar.Enabled = true;

                CargarUnidades();
                Limpiar();
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado <= 0)
            {
                MessageBox.Show("Selecciona una unidad.");
                return;
            }

            if (MessageBox.Show("¿Seguro que deseas eliminar?",
                "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show(logUnidadMedida_Producto.Instancia.EliminarUnidad(idSeleccionado));
                CargarUnidades();
                Limpiar();
            }
        }

        private void Limpiar()
        {
            idSeleccionado = 0;
            txtNombreUnidad.Clear();
            txtAbreviatura.Clear();
            txtBuscarUnidad.Clear();
        }
    }
}
