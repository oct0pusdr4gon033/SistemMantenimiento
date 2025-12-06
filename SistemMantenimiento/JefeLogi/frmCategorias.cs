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
            this.Load += FrmCategorias_Load;

            btnAgregar.Click += BtnAgregar_Click;
            btnBuscar.Click += BtnBuscar_Click;
            btnEditar.Click += BtnEditar_Click;
            btnEliminar.Click += BtnEliminar_Click;
            dgvCategorias.CellClick += DgvCategorias_CellClick;
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            ListarCategorias();
            dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategorias.MultiSelect = false;
        }

        private void ListarCategorias()
        {
            dgvCategorias.DataSource = logCategoria_Producto.Instancia.ListarCategorias();
            dgvCategorias.Columns["id_categoria"].Visible = false;
        }

        // Selección en tabla
        private void DgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idSeleccionado = Convert.ToInt32(dgvCategorias.CurrentRow.Cells["id_categoria"].Value);
                txtNombre.Text = dgvCategorias.CurrentRow.Cells["nombre_categoria"].Value.ToString();
            }
        }

        // AGREGAR
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (modoEdicion)
            {
                MessageBox.Show("Primero termina la edición antes de agregar.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese un nombre.");
                return;
            }

            entCategoria_Producto cat = new entCategoria_Producto
            {
                nombre_categoria = txtNombre.Text.Trim()
            };

            if (logCategoria_Producto.Instancia.RegistrarCategoria(cat))
            {
                Limpiar();
                ListarCategorias();
                MessageBox.Show("Categoría registrada.");
            }
        }

        // BUSCAR
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.Trim().ToLower();
            var lista = logCategoria_Producto.Instancia.ListarCategorias()
                        .Where(c => c.nombre_categoria.ToLower().Contains(filtro))
                        .ToList();

            dgvCategorias.DataSource = lista;
        }

        // EDITAR / GUARDAR
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
                btnEditar.Text = "Guardar";
                return;
            }

            entCategoria_Producto cat = new entCategoria_Producto
            {
                id_categoria = idSeleccionado,
                nombre_categoria = txtNombre.Text.Trim()
            };

            if (logCategoria_Producto.Instancia.ActualizarCategoria(cat))
            {
                MessageBox.Show("Actualizado correctamente.");
                Limpiar();
                ListarCategorias();
            }
        }

        // ELIMINAR
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione una categoría.");
                return;
            }

            if (MessageBox.Show("¿Eliminar categoría?", "Confirmar", MessageBoxButtons.YesNo)
                == DialogResult.Yes)
            {
                if (logCategoria_Producto.Instancia.EliminarCategoria(idSeleccionado))
                {
                    MessageBox.Show("Categoría eliminada.");
                    Limpiar();
                    ListarCategorias();
                }
            }
        }

        private void Limpiar()
        {
            txtNombre.Clear();
            idSeleccionado = 0;
            modoEdicion = false;
            btnEditar.Text = "Habilitar Edición";
        }
    }
}
