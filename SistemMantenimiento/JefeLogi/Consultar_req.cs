using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CapaLogica.Requerimiento;
using CapaEntidad.Requerimiento;
using System.Linq;

namespace SistemMantenimiento.JefeLogi
{
    public partial class Consultar_req : Form
    {
        public Consultar_req()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text.Trim();
            DateTime fecha = dtpFecha.Value.Date;

            if (string.IsNullOrWhiteSpace(codigo))
            {
                MessageBox.Show("Ingrese código de requerimiento.");
                return;
            }

            // Buscar lista de coincidencias
            var lista = logRequerimientoInterno.Instancia.BuscarPorCodigoYFecha(codigo, fecha);

            if (lista == null || lista.Count == 0)
            {
                MessageBox.Show("No se encontró un requerimiento con los datos proporcionados.");
                LimpiarCampos();
                dgvDetalles.DataSource = null;
                return;
            }

            // Tomar el primero encontrado
            entRequerimientoInterno req = lista.First();

            // Mostrar cabecera
            txtCodReq.Text = req.cod_req;
            txtEmpleado.Text = req.nombre_empleado;
            dtpFechaReq.Value = req.fech_req;

            // Cargar detalles del requerimiento
            var detalles = logDetReqInt.Instancia.ListarDetallesPorRequerimiento(req.id_req);
            dgvDetalles.DataSource = detalles;

            if (detalles.Count > 0)
            {
                dgvDetalles.Columns["id_detalle"].Visible = false;
                dgvDetalles.Columns["id_requerimiento"].Visible = false;
                dgvDetalles.Columns["id_material"].Visible = false;
            }
        }

        private void LimpiarCampos()
        {
            txtCodReq.Clear();
            txtEmpleado.Clear();
            dtpFechaReq.Value = DateTime.Now;
        }
    }
}
