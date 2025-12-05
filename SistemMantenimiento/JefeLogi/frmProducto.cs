using CapaEntidad.Producto;
using CapaLogica.Producto;
using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemMantenimiento.JefeLogi
{
    public partial class frmProducto : Form
    {
        private bool cambiosPendientes = false;

        public frmProducto()
        {
            InitializeComponent();

            this.FormClosing += frmProducto_FormClosing;
            guna2DataGridView1.CellClick += dgvProducto_CellClick;
            this.Load += frmProducto_Load;
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            InicializarFormulario();
            CargarCombos();
            ListarProductos();
        }

        private void InicializarFormulario()
        {
            guna2GroupBox1.Enabled = false;

            btn_nuevo.Enabled = true;
            btn_agregar.Enabled = false;
            btn_editar.Enabled = false;
            btn_guardarCambios.Enabled = false;
            btn_cancelar.Enabled = false;

            cambiosPendientes = false;

            LimpiarCampos();
        }

        private void CargarCombos()
        {
            try
            {
                cmb_marca.DataSource = logProducto.Instancia.ListarMarcas();
                cmb_marca.DisplayMember = "nombre_marca";
                cmb_marca.ValueMember = "id_marca";
                cmb_marca.SelectedIndex = -1;

                cmb_unidad.DataSource = logProducto.Instancia.ListarUnidades();
                cmb_unidad.DisplayMember = "nombre_unidad";
                cmb_unidad.ValueMember = "id_unidad";
                cmb_unidad.SelectedIndex = -1;

                cmb_categoria.DataSource = logProducto.Instancia.ListarCategorias();
                cmb_categoria.DisplayMember = "nombre_categoria";
                cmb_categoria.ValueMember = "id_categoria";
                cmb_categoria.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar combos: " + ex.Message);
            }
        }

        private void ListarProductos()
        {
            try
            {
                guna2DataGridView1.DataSource = logProducto.Instancia.ListarProductos();
                guna2DataGridView1.ClearSelection();

                guna2DataGridView1.Columns["id_producto"].Visible = false;
                guna2DataGridView1.Columns["id_marca"].Visible = false;
                guna2DataGridView1.Columns["id_unidad"].Visible = false;
                guna2DataGridView1.Columns["id_categoria"].Visible = false;

                AplicarSemaforoStock();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar productos: " + ex.Message);
            }
        }

        private void AplicarSemaforoStock()
        {
            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                if (row.Cells["stock_actual"].Value == null) continue;

                decimal stock = Convert.ToDecimal(row.Cells["stock_actual"].Value);
                float min = Convert.ToSingle(row.Cells["stock_minimo"].Value);

                row.DefaultCellStyle.BackColor = (stock <= (decimal)min)
                    ? Color.LightCoral
                    : Color.White;
            }
        }

        private void LimpiarCampos()
        {
            txt_codigoProducto.Text = "";
            txt_nombreProducto.Text = "";
            txt_stockActual.Text = "0";
            txt_stockMinimo.Text = "0";
            cmb_marca.SelectedIndex = -1;
            cmb_unidad.SelectedIndex = -1;
            cmb_categoria.SelectedIndex = -1;
        }

        // ================== BOTONES ==================

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            guna2GroupBox1.Enabled = true;
            LimpiarCampos();

            btn_agregar.Enabled = true;
            btn_cancelar.Enabled = true;

            btn_nuevo.Enabled = false;
            btn_editar.Enabled = false;
            btn_guardarCambios.Enabled = false;

            cambiosPendientes = true;
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                entProducto p = new entProducto
                {
                    codigo_producto = txt_codigoProducto.Text.Trim(),
                    nombre = txt_nombreProducto.Text.Trim(),
                    id_marca = Convert.ToInt32(cmb_marca.SelectedValue),
                    id_unidad = Convert.ToInt32(cmb_unidad.SelectedValue),
                    id_categoria = Convert.ToInt32(cmb_categoria.SelectedValue),
                    stock_actual = decimal.Parse(txt_stockActual.Text),
                    stock_minimo = float.Parse(txt_stockMinimo.Text)
                };

                logProducto.Instancia.RegistrarProducto(p);
                ListarProductos();
                InicializarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar: " + ex.Message);
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            guna2GroupBox1.Enabled = true;
            cambiosPendientes = true;

            btn_guardarCambios.Enabled = true;
            btn_cancelar.Enabled = true;

            btn_nuevo.Enabled = false;
            btn_agregar.Enabled = false;
            btn_editar.Enabled = false;
        }

        private void btn_guardarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                if (guna2DataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione un producto primero.");
                    return;
                }

                int idProd = Convert.ToInt32(
                    guna2DataGridView1.SelectedRows[0].Cells["id_producto"].Value
                );

                entProducto p = new entProducto
                {
                    id_producto = idProd,
                    codigo_producto = txt_codigoProducto.Text.Trim(),
                    nombre = txt_nombreProducto.Text.Trim(),
                    id_marca = Convert.ToInt32(cmb_marca.SelectedValue),
                    id_unidad = Convert.ToInt32(cmb_unidad.SelectedValue),
                    id_categoria = Convert.ToInt32(cmb_categoria.SelectedValue),
                    stock_actual = decimal.Parse(txt_stockActual.Text),
                    stock_minimo = float.Parse(txt_stockMinimo.Text)
                };

                logProducto.Instancia.ActualizarProducto(p);
                ListarProductos();
                InicializarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar cambios: " + ex.Message);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            InicializarFormulario();
        }

        private void dgvProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txt_codigoProducto.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["codigo_producto"].Value.ToString();
            txt_nombreProducto.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
            txt_stockActual.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["stock_actual"].Value.ToString();
            txt_stockMinimo.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["stock_minimo"].Value.ToString();

            cmb_marca.SelectedValue = guna2DataGridView1.Rows[e.RowIndex].Cells["id_marca"].Value;
            cmb_unidad.SelectedValue = guna2DataGridView1.Rows[e.RowIndex].Cells["id_unidad"].Value;
            cmb_categoria.SelectedValue = guna2DataGridView1.Rows[e.RowIndex].Cells["id_categoria"].Value;

            btn_editar.Enabled = true;
        }

        private void frmProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cambiosPendientes)
            {
                if (MessageBox.Show("Tienes cambios sin guardar. ¿Salir?",
                    "Confirmar salida", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
