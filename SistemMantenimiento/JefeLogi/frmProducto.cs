using CapaEntidad.Producto;
using CapaLogica.Producto;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemMantenimiento.JefeLogi
{
    public partial class frmProducto : Form
    {
        private int idSeleccionado = 0;

        public frmProducto()
        {
            InitializeComponent();
            this.Load += frmProducto_Load;
            guna2DataGridView1.CellClick += dgvProducto_CellClick;
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

            idSeleccionado = 0;
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
            txt_codigoProducto.Clear();
            txt_nombreProducto.Clear();
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
                cmb_marca.DataSource = logMarca_Producto.Instancia.ListarMarcas();
                cmb_marca.DisplayMember = "nombre_marca";
                cmb_marca.ValueMember = "id_marca";

                cmb_unidad.DataSource = logUnidadMedida_Producto.Instancia.ListarUnidades();
                cmb_unidad.DisplayMember = "abreviatura";
                cmb_unidad.ValueMember = "id_unidad";

                cmb_categoria.DataSource = logCategoria_Producto.Instancia.ListarCategorias();
                cmb_categoria.DisplayMember = "nombre_categoria";
                cmb_categoria.ValueMember = "id_categoria";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar combos: " + ex.Message);
            }
        }

        private void ListarProductos()
        {
            guna2DataGridView1.DataSource = logProducto.Instancia.ListarProductos();
            guna2DataGridView1.ClearSelection();

            guna2DataGridView1.Columns["id_producto"].Visible = false;
            guna2DataGridView1.Columns["id_marca"].Visible = false;
            guna2DataGridView1.Columns["id_unidad"].Visible = false;
            guna2DataGridView1.Columns["id_categoria"].Visible = false;

            AplicarSemaforoStock();
        }

        private void AplicarSemaforoStock()
        {
            foreach (DataGridViewRow fila in guna2DataGridView1.Rows)
            {
                if (fila.Cells["stock_actual"].Value == null) continue;

                decimal stock = Convert.ToDecimal(fila.Cells["stock_actual"].Value);
                float min = Convert.ToSingle(fila.Cells["stock_minimo"].Value);

                fila.DefaultCellStyle.BackColor = stock <= (decimal)min ?
                    Color.LightCoral : Color.White;
            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            LimpiarCampos();

            btn_agregar.Enabled = true;
            btn_cancelar.Enabled = true;
            btn_editar.Enabled = false;
            btn_guardarCambios.Enabled = false;
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

                string mensaje = logProducto.Instancia.RegistrarProducto(p);
                MessageBox.Show(mensaje);

                ListarProductos();
                InicializarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            idSeleccionado = Convert.ToInt32(guna2DataGridView1.Rows[e.RowIndex].Cells["id_producto"].Value);

            txt_codigoProducto.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["codigo_producto"].Value.ToString();
            txt_nombreProducto.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
            txt_stockActual.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["stock_actual"].Value.ToString();
            txt_stockMinimo.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["stock_minimo"].Value.ToString();

            cmb_marca.SelectedValue = guna2DataGridView1.Rows[e.RowIndex].Cells["id_marca"].Value;
            cmb_unidad.SelectedValue = guna2DataGridView1.Rows[e.RowIndex].Cells["id_unidad"].Value;
            cmb_categoria.SelectedValue = guna2DataGridView1.Rows[e.RowIndex].Cells["id_categoria"].Value;

            btn_editar.Enabled = true;
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado <= 0)
            {
                MessageBox.Show("Seleccione un producto primero.");
                return;
            }

            HabilitarCampos();
            btn_guardarCambios.Enabled = true;
            btn_cancelar.Enabled = true;
        }

        private void btn_guardarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                entProducto p = new entProducto
                {
                    id_producto = idSeleccionado,
                    codigo_producto = txt_codigoProducto.Text.Trim(),
                    nombre = txt_nombreProducto.Text.Trim(),
                    id_marca = Convert.ToInt32(cmb_marca.SelectedValue),
                    id_unidad = Convert.ToInt32(cmb_unidad.SelectedValue),
                    id_categoria = Convert.ToInt32(cmb_categoria.SelectedValue),
                    stock_actual = decimal.Parse(txt_stockActual.Text),
                    stock_minimo = float.Parse(txt_stockMinimo.Text)
                };

                string mensaje = logProducto.Instancia.ActualizarProducto(p);
                MessageBox.Show(mensaje);

                ListarProductos();
                InicializarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            InicializarFormulario();
        }
    }
}
