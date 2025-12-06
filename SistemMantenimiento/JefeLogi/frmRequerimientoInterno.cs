using CapaEntidad.Requerimiento;
using CapaEntidad.Empleado;
using CapaEntidad.Producto;
using CapaLogica.Requerimiento;
using CapaLogica.Producto;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemMantenimiento.JefeLogi
{
    public partial class frmRequerimientoInterno : Form
    {
        private List<entDetReqInt> listaDetalles = new List<entDetReqInt>();

        public frmRequerimientoInterno()
        {
            InitializeComponent();
            this.Load += frmRequerimientoInterno_Load;

            btnAgregar.Click += btnAgregar_Click;
            btnGuardar.Click += btnGuardar_Click;
            btnCancelar.Click += btnCancelar_Click;
        }

        private void frmRequerimientoInterno_Load(object sender, EventArgs e)
        {
            InicializarFormulario();
            CargarCombos();
        }

        private void InicializarFormulario()
        {
            listaDetalles.Clear();
            dgvDetalles.DataSource = null;

            txtCodigo.Enabled = true;
            txtCantidad.Enabled = true;
            cmbEmpleado.Enabled = true;
            cmbProducto.Enabled = true;

            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void CargarCombos()
        {
            try
            {
                cmbEmpleado.DataSource = logEmpleado.Instancia.Listar();
                cmbEmpleado.DisplayMember = "nombre_empleado";
                cmbEmpleado.ValueMember = "id_empleado";
                cmbEmpleado.SelectedIndex = -1;

                cmbProducto.DataSource = logProducto.Instancia.ListarProductos();
                cmbProducto.DisplayMember = "nombre";
                cmbProducto.ValueMember = "id_producto";
                cmbProducto.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando combos: " + ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un material");
                return;
            }

            if (!decimal.TryParse(txtCantidad.Text.Trim(), out decimal cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida");
                return;
            }

            entDetReqInt det = new entDetReqInt()
            {
                id_material = Convert.ToInt32(cmbProducto.SelectedValue),
                cantidad = cantidad,
                nombre_material = cmbProducto.Text
            };

            listaDetalles.Add(det);
            ActualizarDGV();
            txtCantidad.Clear();
        }

        private void ActualizarDGV()
        {
            dgvDetalles.DataSource = null;
            dgvDetalles.DataSource = listaDetalles;
            dgvDetalles.ClearSelection();

            if (dgvDetalles.Columns["id_detalle"] != null)
            {
                dgvDetalles.Columns["id_detalle"].Visible = false;
                dgvDetalles.Columns["id_requerimiento"].Visible = false;
                dgvDetalles.Columns["unidad_abreviatura"].Visible = false;
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbEmpleado.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el empleado responsable");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Ingrese un código de requerimiento");
                return;
            }
            if (listaDetalles.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un material");
                return;
            }

            // ✔ Validar stock disponible por cada producto
            foreach (var det in listaDetalles)
            {
                var producto = logProducto.Instancia.BuscarPorId(det.id_material);

                if (producto == null)
                {
                    MessageBox.Show("No se encontró el producto seleccionado.");
                    return;
                }

                if (det.cantidad > producto.stock_actual)
                {
                    MessageBox.Show($"Stock insuficiente para el producto: {producto.nombre}.\n" +
                                    $"Disponible: {producto.stock_actual}, Solicitado: {det.cantidad}");
                    return;
                }
            }

            // ✔ Guardar requerimiento
            entRequerimientoInterno req = new entRequerimientoInterno()
            {
                cod_req = txtCodigo.Text.Trim(),
                fech_req = dtpFecha.Value,
                id_empleado = Convert.ToInt32(cmbEmpleado.SelectedValue)
            };

            int idReqGenerado = logRequerimientoInterno.Instancia.RegistrarRequerimiento(req);

            if (idReqGenerado <= 0)
            {
                MessageBox.Show("Error al registrar el requerimiento");
                return;
            }

            // ✔ Guardar detalles y descontar inventario
            foreach (var det in listaDetalles)
            {
                det.id_requerimiento = idReqGenerado;
                logDetReqInt.Instancia.InsertarDetalle(det);
                logProducto.Instancia.DescontarStock(det.id_material, det.cantidad); // 👈 Aquí descontamos stock
            }

            MessageBox.Show("Requerimiento registrado exitosamente ✔");
            InicializarFormulario();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            InicializarFormulario();
        }
    }
}
