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
    public partial class frmCategorias : Form
    {
        private int idSeleccionado = 0;
        private bool modoEdicion = false;

        public frmCategorias()
        {
            InitializeComponent();
            ListarCategorias();
            ConfigurarEventos();
        }

        private void ConfigurarEventos()
        {
            btnAgregar.Click += BtnAgregar_Click;
            btnBuscar.Click += BtnBuscar_Click;
            btnEliminar.Click += BtnEliminar_Click;
            btnEditar.Click += BtnEditar_Click;
            dgvCategorias.CellClick += DgvCategorias_CellClick;
        }

        private void ListarCategorias()
        {
            try
            {
                dgvCategorias.DataSource = logCategoria_Producto.Instancia.ListarCategorias();
                dgvCategorias.Columns["id_categoria"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías: " + ex.Message);
            }
        }

        // Selección en DataGrid
        private void DgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvCategorias.CurrentRow != null)
            {
                idSeleccionado = Convert.ToInt32(dgvCategorias.CurrentRow.Cells["id_categoria"].Value);
                txtNombre.Text = dgvCategorias.CurrentRow.Cells["nombre_categoria"].Value.ToString();
            }
        }

        // AGREGAR
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (modoEdicion)
                {
                    MessageBox.Show("Estás en modo edición, desactiva para agregar uno nuevo.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("Debe ingresar un nombre.");
                    return;
                }

                entCategoria_Producto cat = new entCategoria_Producto()
                {
                    nombre_categoria = txtNombre.Text.Trim()
                };

                if (logCategoria_Producto.Instancia.RegistrarCategoria(cat))
                {
                    MessageBox.Show("Categoría registrada correctamente.");
                    txtNombre.Clear();
                    ListarCategorias();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // BUSCAR
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string busqueda = txtBuscar.Text.Trim().ToLower();
                var lista = logCategoria_Producto.Instancia.ListarCategorias();

                dgvCategorias.DataSource = lista.FindAll(c =>
                    c.nombre_categoria.ToLower().Contains(busqueda)
                );
            }
            catch
            {
                MessageBox.Show("Error al buscar.");
            }
        }

        // HABILITAR EDICIÓN / GUARDAR
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione una categoría primero.");
                return;
            }

            if (!modoEdicion)
            {
                modoEdicion = true;
                btnEditar.Text = "Guardar Cambios";
                txtNombre.Focus();
            }
            else
            {
                try
                {
                    entCategoria_Producto cat = new entCategoria_Producto()
                    {
                        id_categoria = idSeleccionado,
                        nombre_categoria = txtNombre.Text.Trim()
                    };

                    if (logCategoria_Producto.Instancia.ActualizarCategoria(cat))
                    {
                        MessageBox.Show("Categoría actualizada correctamente.");
                        modoEdicion = false;
                        btnEditar.Text = "Habilitar Edición";
                        idSeleccionado = 0;
                        txtNombre.Clear();
                        ListarCategorias();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar: " + ex.Message);
                }
            }
        }

        // ELIMINAR
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione una categoría para eliminar.");
                return;
            }

            if (MessageBox.Show("¿Seguro que deseas eliminar?", "Confirmar",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (logCategoria_Producto.Instancia.EliminarCategoria(idSeleccionado))
                {
                    MessageBox.Show("Categoría eliminada correctamente.");
                    idSeleccionado = 0;
                    txtNombre.Clear();
                    ListarCategorias();
                }
            }
        }
    }
}
