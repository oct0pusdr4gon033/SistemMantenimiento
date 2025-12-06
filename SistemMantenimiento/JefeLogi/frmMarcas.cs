using CapaEntidad.Equipo;
using CapaEntidad.Producto;
using CapaLogica.Equipo;
using CapaLogica.Producto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemMantenimiento.JefeLogi
{
    public partial class frmMarcas : Form
    {
        private int idSeleccionado = 0;
        private bool modoEdicion = false;

        public frmMarcas()
        {
            InitializeComponent();
            CargarMarcas();
            AsociarEventos();
        }

        private void AsociarEventos()
        {
            btnAgregar.Click += BtnAgregar_Click;
            btnBuscar.Click += BtnBuscar_Click;
            btnEliminar.Click += BtnEliminar_Click;
            btnEditar.Click += BtnEditar_Click;
            dgvMarcas.CellClick += DgvMarcas_CellClick;
        }

        private void CargarMarcas()
        {
            try
            {
                dgvMarcas.DataSource = logMarca_Producto.Instancia.ListarMarcas();
                if (dgvMarcas.Columns.Contains("id_marca"))
                    dgvMarcas.Columns["id_marca"].Visible = false;

                dgvMarcas.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar marcas: " + ex.Message);
            }
        }

        private void Limpiar()
        {
            txtNombreMarca.Clear();
            txtBuscarMarca.Clear();
            idSeleccionado = 0;
            modoEdicion = false;
            btnEditar.Text = "Habilitar Edición";
            btnAgregar.Text = "Agregar";
            CargarMarcas();
        }

        // Seleccionar fila para edición
        private void DgvMarcas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idSeleccionado = Convert.ToInt32(
                    dgvMarcas.CurrentRow.Cells["id_marca"].Value
                );

                txtNombreMarca.Text = dgvMarcas.CurrentRow.Cells["nombre_marca"].Value.ToString();
            }
        }

        // AGREGAR / GUARDAR
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombreMarca.Text))
                {
                    MessageBox.Show("Ingrese un nombre válido.");
                    return;
                }

                entMarca_Producto marca = new entMarca_Producto()
                {
                    id_marca = idSeleccionado,
                    nombre_marca = txtNombreMarca.Text.Trim()
                };

                if (!modoEdicion)
                {
                    // Registrar
                    logMarca_Producto.Instancia.RegistrarMarca(marca);
                    MessageBox.Show("Marca registrada correctamente.");
                }
                else
                {
                    // Editar
                    logMarca_Producto.Instancia.ActualizarMarca(marca);
                    MessageBox.Show("Marca actualizada.");
                }

                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // BUSCAR
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = txtBuscarMarca.Text.Trim().ToLower();

            var lista = logMarca_Producto.Instancia.ListarMarcas()
                .Where(m => m.nombre_marca.ToLower().Contains(filtro))
                .ToList();

            dgvMarcas.DataSource = lista;

            if (lista.Count == 0)
                MessageBox.Show("No se encontraron resultados.");
        }

        // ELIMINAR
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione una marca para eliminar.");
                return;
            }

            if (MessageBox.Show("¿Eliminar marca seleccionada?",
                "Confirmación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                logMarca_Producto.Instancia.EliminarMarca(idSeleccionado);
                MessageBox.Show("Marca eliminada.");
                Limpiar();
            }
        }

        // CAMBIAR A MODO EDICIÓN
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione una marca primero.");
                return;
            }

            modoEdicion = !modoEdicion;

            if (modoEdicion)
            {
                btnEditar.Text = "Cancelar";
                btnAgregar.Text = "Guardar Cambios";
            }
            else
            {
                Limpiar();
            }
        }
    }
}
