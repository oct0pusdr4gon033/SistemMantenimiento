using CapaEntidad.EntLogistica;
using CapaLogica.Proveedor;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SistemMantenimiento.JefeLogi.Proveedores
{
    public partial class frmProveedor : Form
    {
        private logProveedor objLogica = new logProveedor();
        private string estadoFormulario = "inicial";
        public frmProveedor()
        {
            InitializeComponent();
        }

        private void lbl_titulo_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AgregarPro_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'mantenimientoDBDataSet1.Proveedor' Puede moverla o quitarla según sea necesario.
            this.proveedorTableAdapter1.Fill(this.mantenimientoDBDataSet1.Proveedor);
            ListarProveedores();
            ConfigurarEstado("inicial");
            HabilitarControles(false);

        }

        private void guna2Button1_Click(object sender, EventArgs e)//este es cancelar solo q hice doble click y se guardo asi
        {
            estadoFormulario = "inicial";
            HabilitarControles(false);
            LimpiarControles();
            ConfigurarEstado("inicial");
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            estadoFormulario = "nuevo";
            HabilitarControles(true);
            LimpiarControles();
            ConfigurarEstado("nuevo");
            // Asegúrate que tu control se llame 'txtRUC'
            txt_RUC.Focus();

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
               entProveedor pro= new entProveedor();
        
       

                // --- ¡IMPORTANTE! Revisa que los nombres de control coincidan ---
                pro.ruc = txt_RUC.Text.Trim();
                pro.razon_social = txt_RazonSocial.Text.Trim();
                pro.tipo_proveedor = cmb_tipoproveedor.Text; // Asumiendo que es un ComboBox
                pro.telefono = txt_Telefono.Text.Trim();
                pro.correo = txt_correo.Text.Trim();
                pro.direccion = txt_direccion.Text.Trim();
                pro.contacto_nombre = txt_nombreContacto.Text.Trim();
                pro.contacto_telefono = txt_TelefContacto.Text.Trim();

                int.TryParse(txt_diasCredito.Text, out int dias);
                pro.dias_credito = dias;

                pro.activo = guna2CheckBox1.Checked;
                // --- Fin de controles ---

                // 2. Llamamos a la lógica para agregar
                bool agregado = logProveedor.Instancia.AgregarProveedor(pro);

                if (agregado)
                {
                    MessageBox.Show("Proveedor agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // 3. Reseteamos el formulario
                    ListarProveedores();
                    ConfigurarEstado("inicial");
                    HabilitarControles(false);
                    LimpiarControles();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            // Asegúrate que tu DataGridView se llame 'dgvProveedores'
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                estadoFormulario = "editar";
                ConfigurarEstado("editar");
                HabilitarControles(true);
                txt_RUC.Enabled = false;
                txt_RazonSocial.Focus();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un proveedor de la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btn_guardarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                entProveedor pro = new entProveedor();
                pro.ruc = txt_RUC.Text.Trim();
                pro.razon_social = txt_RazonSocial.Text.Trim();
                pro.tipo_proveedor = cmb_tipoproveedor.Text;
                pro.telefono = txt_Telefono.Text.Trim();
                pro.correo = txt_correo.Text.Trim();
                pro.direccion = txt_direccion.Text.Trim();
                pro.contacto_nombre = txt_nombreContacto.Text.Trim();
                pro.contacto_telefono = txt_TelefContacto.Text.Trim();
                int.TryParse(txt_diasCredito.Text, out int dias);
                pro.dias_credito = dias;
                pro.activo = guna2CheckBox1.Checked;

                bool editado = logProveedor.Instancia.EditarProveedor(pro);

                if (editado)
                {
                    MessageBox.Show("Proveedor actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListarProveedores();
                    ConfigurarEstado("inicial");
                    HabilitarControles(false);
                    LimpiarControles();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_desahabilitar_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                var respuesta = MessageBox.Show("¿Está seguro de que desea deshabilitar este proveedor?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    try
                    {
                        string ruc = guna2DataGridView1.CurrentRow.Cells["ruc"].Value.ToString();
                        bool eliminado = logProveedor.Instancia.EliminarProveedor(ruc);

                        if (eliminado)
                        {
                            MessageBox.Show("Proveedor deshabilitado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ListarProveedores();
                            LimpiarControles();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un proveedor de la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Nos aseguramos de que no sea el header y que el estado sea "inicial"
            if (e.RowIndex >= 0 && estadoFormulario == "inicial")
            {
                DataGridViewRow row = guna2DataGridView1.Rows[e.RowIndex];

                // Llenamos los controles
                txt_RUC.Text = row.Cells["ruc"].Value?.ToString() ?? "";
                txt_RazonSocial.Text = row.Cells["razon_social"].Value?.ToString() ?? "";
                cmb_tipoproveedor.Text = row.Cells["tipo_proveedor"].Value?.ToString() ?? "";
                txt_Telefono.Text = row.Cells["telefono"].Value?.ToString() ?? "";
                txt_correo.Text = row.Cells["correo"].Value?.ToString() ?? "";
                txt_direccion.Text = row.Cells["direccion"].Value?.ToString() ?? "";
                txt_nombreContacto.Text = row.Cells["contacto_nombre"].Value?.ToString() ?? "";
                txt_TelefContacto.Text = row.Cells["contacto_telefono"].Value?.ToString() ?? "";
                txt_diasCredito.Text = row.Cells["dias_credito"].Value?.ToString() ?? "0";
                guna2CheckBox1.Checked = Convert.ToBoolean(row.Cells["activo"].Value);
            }
        }
        private void ListarProveedores()
        {
            try
            {
                // 1. Limpiar y refrescar
                // Asegúrate que tu DataGridView se llame 'dgvProveedores'
                guna2DataGridView1.DataSource = null; 
                List<entProveedor> lista = logProveedor.Instancia.ListarProveedores();
                guna2DataGridView1.DataSource = lista;
                guna2DataGridView1.Refresh();
                guna2DataGridView1.ClearSelection();

                // 2. Ocultar columnas
                string[] ocultas = { "creado_en" }; // Columnas de la *entidad* que no quieres ver
                foreach (string col in ocultas)
                {
                    if (guna2DataGridView1.Columns.Contains(col))
                    {
                        guna2DataGridView1  .Columns[col].Visible = false;
                    }
                }

                // 3. Renombrar Headers
                if (guna2DataGridView1.Columns.Contains("ruc"))
                    guna2DataGridView1.Columns["ruc"].HeaderText = "RUC";
                if (guna2DataGridView1.Columns.Contains("razon_social"))
                    guna2DataGridView1.Columns["razon_social"].HeaderText = "Razón Social";
                if (guna2DataGridView1.Columns.Contains("tipo_proveedor"))
                    guna2DataGridView1.Columns["tipo_proveedor"].HeaderText = "Tipo";
                if (guna2DataGridView1.Columns.Contains("telefono"))
                    guna2DataGridView1.Columns["telefono"].HeaderText = "Teléfono";
                if (guna2DataGridView1.Columns.Contains("correo"))
                    guna2DataGridView1.Columns["correo"].HeaderText = "Correo";
                if (guna2DataGridView1.Columns.Contains("direccion"))
                    guna2DataGridView1.Columns["direccion"].HeaderText = "Dirección";
                if (guna2DataGridView1.Columns.Contains("contacto_nombre"))
                    guna2DataGridView1.Columns["contacto_nombre"].HeaderText = "Contacto";
                if (guna2DataGridView1.Columns.Contains("contacto_telefono"))
                    guna2DataGridView1.Columns["contacto_telefono"].HeaderText = "Tel. Contacto";
                if (guna2DataGridView1.Columns.Contains("dias_credito"))
                    guna2DataGridView1.Columns["dias_credito"].HeaderText = "Días Crédito";
                if (guna2DataGridView1.Columns.Contains("activo"))
                    guna2DataGridView1.Columns["activo"].HeaderText = "Activo";

                // 4. Aplicar Estilos (como los de tu compañero)
                guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                guna2DataGridView1.ScrollBars = ScrollBars.Both;
                guna2DataGridView1.EnableHeadersVisualStyles = false;
                guna2DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal;
                guna2DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                guna2DataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                guna2DataGridView1.DefaultCellStyle.SelectionBackColor = Color.PaleTurquoise;
                guna2DataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
                guna2DataGridView1.GridColor = Color.LightGray;
            }
            catch (Exception ex)
            {
                string errorReal = ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show(errorReal, "Error al listar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void HabilitarControles(bool habilitar)
        {
            // --- ¡IMPORTANTE! Revisa que los nombres de control coincidan ---
            txt_RUC.Enabled = habilitar;
            txt_RazonSocial.Enabled = habilitar;
            cmb_tipoproveedor.Enabled = habilitar;
            txt_Telefono.Enabled = habilitar;
            txt_correo.Enabled = habilitar;
            txt_direccion.Enabled = habilitar;
            txt_nombreContacto.Enabled = habilitar;
            txt_TelefContacto.Enabled = habilitar;
            txt_diasCredito.Enabled = habilitar;
            guna2CheckBox1.Enabled = habilitar;
        }

        private void LimpiarControles()
        {
            // --- ¡IMPORTANTE! Revisa que los nombres de control coincidan ---
            txt_RUC.Text = "";
            txt_RazonSocial.Text = "";
            cmb_tipoproveedor.SelectedIndex = -1; // Limpia ComboBox
            txt_Telefono.Text = "";
            txt_correo.Text = "";
            txt_direccion.Text = "";
            txt_nombreContacto.Text = "";
            txt_TelefContacto.Text = "";
            txt_diasCredito.Text = "0";
            guna2CheckBox1.Checked = true;
        }

        private void ConfigurarEstado(string estado)
        {
            // --- ¡IMPORTANTE! Revisa que los nombres de tus botones coincidan ---
            switch (estado)
            {
                case "inicial":
                    btn_nuevo.Visible = true;
                    btn_editar.Visible = true;
                    btn_desahabilitar.Visible = true;
                    btn_agregar.Visible = false;
                    btn_guardarCambios.Visible = false;
                    btn_cancelar.Visible = false; // Cancelar
                    break;
                case "nuevo":
                    btn_nuevo.Visible = false;
                    btn_editar.Visible = false;
                    btn_desahabilitar.Visible = false;
                    btn_agregar.Visible = true;
                    btn_guardarCambios.Visible = false;
                    btn_cancelar.Visible = true; // Cancelar
                    break;
                case "editar":
                    btn_nuevo.Visible = false;
                    btn_editar.Visible = false;
                    btn_desahabilitar.Visible = false;
                    btn_agregar.Visible = false;
                    btn_guardarCambios.Visible = true;
                    btn_cancelar.Visible = true; // Cancelar
                    break;
            }
        }
    }
}
