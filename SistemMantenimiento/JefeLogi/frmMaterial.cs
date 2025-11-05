using CapaEntidad.Material;
using CapaLogica.Material;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemMantenimiento.JefeLogi
{
    public partial class frmMaterial : Form
    {
        public bool cambiosPendientes { get; private set; } = false;

        public frmMaterial()
        {
            InitializeComponent();
            this.Load += frmMaterial_Load;
            this.FormClosing += frmMaterial_FormClosing; // 👈 para detectar salida

            // Detectar cambios en todos los TextBox
            foreach (Control c in groupBoxDatos.Controls)
            {
                if (c is TextBox txt)
                    txt.TextChanged += (s, e) => cambiosPendientes = true;
                if (c is ComboBox cbo)
                    cbo.SelectedIndexChanged += (s, e) => cambiosPendientes = true;
            }
        }

        private void frmMaterial_Load(object sender, EventArgs e)
        {
            InicializarFormulario();
            CargarCombos();
            var lista = logMaterial.Instancia.ListarMateriales();
            MessageBox.Show($"Se cargaron {lista.Count} materiales.");
            ListarMateriales();
        }


        private void InicializarFormulario()
        {
            txtId.Enabled = false;
            groupBoxDatos.Enabled = false;

            btnNuevo.Enabled = true;
            btnNuevo.FillColor = Color.LightSkyBlue;

            btnAgregar.Enabled = false;
            btnEditar.Enabled = false;
            btnGuardar.Enabled = false;
            btnDeshabilitar.Enabled = false;
            btnCancelar.Enabled = false;

            btnAgregar.FillColor = Color.Gainsboro;
            btnEditar.FillColor = Color.Gainsboro;
            btnGuardar.FillColor = Color.Gainsboro;
            btnDeshabilitar.FillColor = Color.Gainsboro;
            btnCancelar.FillColor = Color.Gainsboro;
        }

        private void CargarCombos()
        {
            try
            {
                cboCategoria.DataSource = logMaterial.Instancia.ListarCategorias();
                cboCategoria.DisplayMember = "NombreCategoria";
                cboCategoria.ValueMember = "IdCategoria";

                cboUnidad.DataSource = logMaterial.Instancia.ListarUnidades();
                cboUnidad.DisplayMember = "NombreUnidad";
                cboUnidad.ValueMember = "IdUnidad";

                cboClasificacion.DataSource = logMaterial.Instancia.ListarClasificaciones();
                cboClasificacion.DisplayMember = "NombreClasificacion";
                cboClasificacion.ValueMember = "IdClasificacion";

                cboCriticidad.Items.Clear();
                cboCriticidad.Items.AddRange(new string[] { "ALTA", "MEDIA", "BAJA" });
                cboCriticidad.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar combos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarMateriales()
        {
            try
            {
                dgvMateriales.DataSource = null;
                var lista = logMaterial.Instancia.ListarMateriales();
                dgvMateriales.DataSource = lista;

                dgvMateriales.Refresh();
                dgvMateriales.ClearSelection();

                string[] ocultas = { "IdMaterial", "IdCategoria", "IdClasificacion", "IdUnidad", "CreadoEn", "UltimoCosto" };
                foreach (string col in ocultas)
                    if (dgvMateriales.Columns.Contains(col))
                        dgvMateriales.Columns[col].Visible = false;

                if (dgvMateriales.Columns.Contains("CodigoMaterial"))
                    dgvMateriales.Columns["CodigoMaterial"].HeaderText = "Código";
                if (dgvMateriales.Columns.Contains("Nombre"))
                    dgvMateriales.Columns["Nombre"].HeaderText = "Nombre";
                if (dgvMateriales.Columns.Contains("Descripcion"))
                    dgvMateriales.Columns["Descripcion"].HeaderText = "Descripción";
                if (dgvMateriales.Columns.Contains("StockActual"))
                    dgvMateriales.Columns["StockActual"].HeaderText = "Stock Actual";
                if (dgvMateriales.Columns.Contains("StockMinimo"))
                    dgvMateriales.Columns["StockMinimo"].HeaderText = "Stock Mínimo";
                if (dgvMateriales.Columns.Contains("StockMaximo"))
                    dgvMateriales.Columns["StockMaximo"].HeaderText = "Stock Máximo";
                if (dgvMateriales.Columns.Contains("PrecioPromedio"))
                    dgvMateriales.Columns["PrecioPromedio"].HeaderText = "Precio Promedio";
                if (dgvMateriales.Columns.Contains("Criticidad"))
                    dgvMateriales.Columns["Criticidad"].HeaderText = "Criticidad";
                if (dgvMateriales.Columns.Contains("Activo"))
                    dgvMateriales.Columns["Activo"].HeaderText = "Estado";
                if (dgvMateriales.Columns.Contains("NombreCategoria"))
                    dgvMateriales.Columns["NombreCategoria"].HeaderText = "Categoría";
                if (dgvMateriales.Columns.Contains("NombreClasificacion"))
                    dgvMateriales.Columns["NombreClasificacion"].HeaderText = "Clasificación";
                if (dgvMateriales.Columns.Contains("NombreUnidad"))
                    dgvMateriales.Columns["NombreUnidad"].HeaderText = "Unidad";

                dgvMateriales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                dgvMateriales.ScrollBars = ScrollBars.Both;
                dgvMateriales.EnableHeadersVisualStyles = false;
                dgvMateriales.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal;
                dgvMateriales.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvMateriales.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                dgvMateriales.DefaultCellStyle.SelectionBackColor = Color.PaleTurquoise;
                dgvMateriales.DefaultCellStyle.SelectionForeColor = Color.Black;
                dgvMateriales.GridColor = Color.LightGray;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar materiales: " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            // Vaciar campos de texto
            txtId.Text = "";
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtStockActual.Text = "0";
            txtStockMinimo.Text = "0";
            txtPrecio.Text = "0.00";
            cboCategoria.SelectedIndex = -1;
            cboUnidad.SelectedIndex = -1;
            cboClasificacion.SelectedIndex = -1;
            cboCriticidad.SelectedIndex = 1; 
            dgvMateriales.ClearSelection();
        }


        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            groupBoxDatos.Enabled = true;
            LimpiarCampos();

            if (dgvMateriales.Rows.Count > 0)
            {
                int maxId = 0;
                foreach (DataGridViewRow fila in dgvMateriales.Rows)
                {
                    if (fila.Cells["IdMaterial"]?.Value != null && int.TryParse(fila.Cells["IdMaterial"].Value.ToString(), out int valor))
                    {
                        if (valor > maxId)
                            maxId = valor;
                    }
                }
                txtId.Text = (maxId + 1).ToString();
            }
            else
            {
                txtId.Text = "1";
            }

            btnAgregar.Enabled = true;
            btnAgregar.FillColor = Color.MediumSeaGreen;

            btnEditar.Enabled = false;
            btnGuardar.Enabled = false;
            btnDeshabilitar.Enabled = false;

            btnEditar.FillColor = Color.Gainsboro;
            btnGuardar.FillColor = Color.Gainsboro;
            btnDeshabilitar.FillColor = Color.Gainsboro;

            btnCancelar.Enabled = true;
            btnCancelar.FillColor = Color.IndianRed;
        }


        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            try
            {
                entMaterial nuevo = new entMaterial
                {
                    CodigoMaterial = txtCodigo.Text.Trim(),
                    Nombre = txtNombre.Text.Trim(),
                    Descripcion = txtDescripcion.Text.Trim(),
                    IdCategoria = (int)cboCategoria.SelectedValue,
                    IdClasificacion = (int)cboClasificacion.SelectedValue,
                    IdUnidad = (int)cboUnidad.SelectedValue,
                    StockActual = decimal.Parse(txtStockActual.Text),
                    StockMinimo = decimal.Parse(txtStockMinimo.Text),
                    PrecioPromedio = decimal.Parse(txtPrecio.Text),
                    Criticidad = cboCriticidad.Text,
                    Activo = true
                };

                logMaterial.Instancia.RegistrarMaterial(nuevo);
                MessageBox.Show("✅ Material registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 🔹 LIMPIAR Y DESBLOQUEAR FORMULARIO
                LimpiarCampos();
                groupBoxDatos.Enabled = false;

                // 🔹 ACTUALIZAR GRID AUTOMÁTICAMENTE
                ListarMateriales(); // <-- asegúrate que este método vuelve a llenar el DGV con los datos actualizados

                btnAgregar.Enabled = false;
                btnNuevo.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar material: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            groupBoxDatos.Enabled = true;
            btnGuardar.Enabled = true;
            btnGuardar.FillColor = Color.MediumAquamarine;
            btnAgregar.Enabled = btnEditar.Enabled = btnDeshabilitar.Enabled = false;

            btnAgregar.FillColor = btnEditar.FillColor = btnDeshabilitar.FillColor = Color.Gainsboro;
            btnCancelar.Enabled = true;
            btnCancelar.FillColor = Color.IndianRed;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                entMaterial mat = new entMaterial
                {
                    IdMaterial = int.Parse(txtId.Text),
                    CodigoMaterial = txtCodigo.Text.Trim(),
                    Nombre = txtNombre.Text.Trim(),
                    Descripcion = txtDescripcion.Text.Trim(),
                    IdCategoria = Convert.ToInt32(cboCategoria.SelectedValue),
                    IdClasificacion = Convert.ToInt32(cboClasificacion.SelectedValue),
                    IdUnidad = Convert.ToInt32(cboUnidad.SelectedValue),
                    StockActual = decimal.Parse(txtStockActual.Text),
                    StockMinimo = decimal.Parse(txtStockMinimo.Text),
                    PrecioPromedio = decimal.Parse(txtPrecio.Text),
                    Criticidad = cboCriticidad.Text,
                    Activo = true
                };

                if (logMaterial.Instancia.ActualizarMaterial(mat))
                {
                    MessageBox.Show("✅ Cambios guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 🔹 Refrescar datos inmediatamente
                    ListarMateriales();

                    // 🔹 Limpiar y bloquear campos
                    LimpiarCampos();
                    groupBoxDatos.Enabled = false;

                    // 🔹 Desactivar el botón Guardar y volver al estado normal
                    InicializarFormulario();

                    // 🔹 Asegurarse de limpiar cualquier selección previa
                    dgvMateriales.ClearSelection();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar los cambios. Verifica los datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar cambios: " + ex.Message);
            }
            cambiosPendientes = false;

        }


        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Seleccione un material antes de deshabilitarlo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show(
                "¿Está seguro de deshabilitar este material?",
                "Confirmar acción",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dr == DialogResult.Yes)
            {
                try
                {
                    int idMaterial = Convert.ToInt32(txtId.Text);
                    logMaterial.Instancia.DeshabilitarMaterial(idMaterial);

                    MessageBox.Show("✅ Material deshabilitado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 🔹 Refrescar tabla
                    ListarMateriales();
                    LimpiarCampos();
                    groupBoxDatos.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al deshabilitar material: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            groupBoxDatos.Enabled = false;
            InicializarFormulario();
            dgvMateriales.ClearSelection();
            cambiosPendientes = false;

        }

        private void dgvMateriales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                groupBoxDatos.Enabled = false;

                txtId.Text = dgvMateriales.Rows[e.RowIndex].Cells["IdMaterial"].Value.ToString();
                txtCodigo.Text = dgvMateriales.Rows[e.RowIndex].Cells["CodigoMaterial"].Value.ToString();
                txtNombre.Text = dgvMateriales.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = dgvMateriales.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();
                txtStockActual.Text = dgvMateriales.Rows[e.RowIndex].Cells["StockActual"].Value.ToString();
                txtStockMinimo.Text = dgvMateriales.Rows[e.RowIndex].Cells["StockMinimo"].Value.ToString();
                txtPrecio.Text = dgvMateriales.Rows[e.RowIndex].Cells["PrecioPromedio"].Value.ToString();
                cboCriticidad.Text = dgvMateriales.Rows[e.RowIndex].Cells["Criticidad"].Value.ToString();

                // Manejo seguro por ID
                if (dgvMateriales.Rows[e.RowIndex].Cells["IdCategoria"].Value != DBNull.Value)
                    cboCategoria.SelectedValue = dgvMateriales.Rows[e.RowIndex].Cells["IdCategoria"].Value;

                if (dgvMateriales.Rows[e.RowIndex].Cells["IdClasificacion"].Value != DBNull.Value)
                    cboClasificacion.SelectedValue = dgvMateriales.Rows[e.RowIndex].Cells["IdClasificacion"].Value;
                else
                    cboClasificacion.SelectedIndex = -1;

                if (dgvMateriales.Rows[e.RowIndex].Cells["IdUnidad"].Value != DBNull.Value)
                    cboUnidad.SelectedValue = dgvMateriales.Rows[e.RowIndex].Cells["IdUnidad"].Value;

                btnEditar.Enabled = true;
                btnEditar.FillColor = Color.Khaki;
                btnDeshabilitar.Enabled = true;
                btnDeshabilitar.FillColor = Color.IndianRed;
                btnAgregar.Enabled = btnGuardar.Enabled = false;
                btnAgregar.FillColor = btnGuardar.FillColor = Color.Gainsboro;
            }
        }
        private void frmMaterial_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cambiosPendientes)
            {
                var resultado = MessageBox.Show(
                    "Tienes cambios sin guardar. ¿Deseas salir sin guardar?",
                    "Aviso",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2);

                if (resultado == DialogResult.No)
                {
                    e.Cancel = true; // Cancela el cierre
                }
            }
        }
        public bool ConfirmarSalidaConCambios()
        {
            if (cambiosPendientes)
            {
                var resultado = MessageBox.Show(
                    "Tienes cambios sin guardar. ¿Deseas salir sin guardar?",
                    "Aviso",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2);

                return resultado == DialogResult.Yes;
            }
            return true; // no hay cambios pendientes, puede salir
        }


    }
}
