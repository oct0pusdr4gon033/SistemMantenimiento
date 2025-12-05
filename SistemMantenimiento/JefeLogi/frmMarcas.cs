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
            dgvMarcas.DataSource = logMarca_Producto.Instancia.ListarMarcas();
            dgvMarcas.Columns["id_marca"].Visible = false;
        }

        // Seleccionar fila para editar
        private void DgvMarcas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idSeleccionado = Convert.ToInt32(dgvMarcas.CurrentRow.Cells["id_marca"].Value);
                txtNombreMarca.Text = dgvMarcas.CurrentRow.Cells["nombre_marca"].Value.ToString();
            }
        }

        // AGREGAR / ACTUALIZAR
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!modoEdicion)
                {
                    entMarca_Producto m = new entMarca_Producto
                    {
                        nombre_marca = txtNombreMarca.Text.Trim()
                    };

                    if (logMarca_Producto.Instancia.RegistrarMarca(m))
                        MessageBox.Show("Marca registrada correctamente 👌");

                }
                else
                {
                    entMarca_Producto m = new entMarca_Producto
                    {
                        id_marca = idSeleccionado,
                        nombre_marca = txtNombreMarca.Text.Trim()
                    };

                    if (logMarca_Producto.Instancia.ActualizarMarca(m))
                        MessageBox.Show("Marca actualizada correctamente ✨");

                    modoEdicion = false;
                    btnEditar.Text = "Habilitar Edición";
                }

                txtNombreMarca.Clear();
                CargarMarcas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // BUSCAR
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = txtBuscarMarca.Text.Trim().ToLower();

            List<entMarca_Producto> lista = logMarca_Producto.Instancia.ListarMarcas();
            dgvMarcas.DataSource = lista.FindAll(
                x => x.nombre_marca.ToLower().Contains(filtro)
            );
        }

        // ELIMINAR
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione una marca primero ⚠️");
                return;
            }

            if (MessageBox.Show("¿Eliminar marca seleccionada?",
                "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (logMarca_Producto.Instancia.EliminarMarca(idSeleccionado))
                {
                    MessageBox.Show("Marca eliminada correctamente 🗑️");
                    txtNombreMarca.Clear();
                    idSeleccionado = 0;
                    CargarMarcas();
                }
            }
        }

        // Habilitar edición
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Selecciona una marca para editar 😒");
                return;
            }

            modoEdicion = !modoEdicion;
            btnEditar.Text = modoEdicion ? "Cancelar Edición" : "Habilitar Edición";
        }
    }
}
