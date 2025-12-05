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
            BloquearCampos();
            LimpiarCampos();

            btn_nuevo.Enabled = true;
            btn_agregar.Enabled = false;
            btn_editar.Enabled = false;
            btn_guardarCambios.Enabled = false;
            btn_cancelar.Enabled = false;

            cambiosPendientes = false;
        }

        private void BloquearCampos()
        {
            txt_codigoProducto.Enabled = false;
            txt_nombreProducto.Enabled = false;
            txt_stockActual.Enabled = false;
            txt_stockMinimo.Enabled = false;
            cmb_marca.Enabled = false;
            cmb_unidad.Enabled = false;
            cmb_categoria.Enabled = false;
        }

        private void HabilitarCampos()
        {
            txt_codigoProducto.Enabled = true;
            txt_nombreProducto.Enabled = true;
            txt_stockActual.Enabled = true;
            txt_stockMinimo.Enabled = true;
            cmb_marca.Enabled = true;
            cmb_unidad.Enabled = true;
            cmb_categoria.Enabled = true;
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

        private void CargarCombos()
        {
            try
            {
                cmb_marca.DataSource = logProducto.Instancia.ListarMarcas();
                cmb_marca.DisplayMember = "nombre_marca";
                cmb_marca.ValueMember = "id_marca";
                cmb_marca.SelectedIndex = -1;

                cmb_unidad.DataSource = logProducto.Instancia.ListarUnidades();
                cmb_unidad.DisplayMember = "abreviatura";
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

                guna2DataGridView1.Columns["codigo_producto"].HeaderText = "Código";
                guna2DataGridView1.Columns["nombre"].HeaderText = "Producto";
                guna2DataGridView1.Columns["stock_actual"].HeaderText = "Stock Actual";
                guna2DataGridView1.Columns["stock_minimo"].HeaderText = "Stock Mínimo";
                guna2DataGridView1.Columns["nombre_marca"].HeaderText = "Marca";
                guna2DataGridView1.Columns["unidad_abreviatura"].HeaderText = "U.M.";
                guna2DataGridView1.Columns["nombre_categoria"].HeaderText = "Categoría";

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

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            LimpiarCampos();
            btn_agregar.Enabled = true;
            btn_cancelar.Enabled = true;
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
            HabilitarCampos();
            btn_guardarCambios.Enabled = true;
            btn_cancelar.Enabled = true;
            btn_agregar.Enabled = false;
            cambiosPendientes = true;
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

                int idProd = Convert.ToInt32(guna2DataGridView1.SelectedRows[0].Cells["id_producto"].Value);

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
