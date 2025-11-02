using CapaEntidad.Equipo;
using CapaLogica.Equipo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemMantenimiento.JeffeMantto
{
    public partial class ConsultarEquipo : Form
    {
        private entEquipo equipo_seleccionado;
        public ConsultarEquipo()
        {
            InitializeComponent();
            RealizarBusqueda(null, null, null, null, null, null);
            panel_opciones.Visible = false;
        }
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string valor = txb_valo_busqueda.Text.Trim();

            if (string.IsNullOrEmpty(valor))
            {
                RealizarBusqueda(null, null, null, null, null, null);
                return;
            }

            // 2. Obtenemos el tipo de filtro seleccionado
            string filtroSeleccionado = cmb_tipo_filtro.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(filtroSeleccionado))
            {
                MessageBox.Show("Por favor, seleccione un tipo de filtro.");
                return;
            }

            // 3. Preparamos todas las variables como 'null' por defecto
            string tipo = null;
            string marca = null;
            int? anio = null;
            string modelo = null;
            string fecha = null;
            string num_serie = null;

            // 4. Usamos un 'switch' para asignar el 'valor' al parámetro correcto
            switch (filtroSeleccionado)
            {
                case "Marca de Equipo":
                    marca = valor;
                    break;
                case "Tipo de Equipo":
                    tipo = valor;
                    break;
                case "Año de Fabricacion":
                    int anioTemp;
                    if (int.TryParse(valor, out anioTemp))
                    {
                        anio = anioTemp;
                    }
                    else
                    {
                        MessageBox.Show("Por favor, ingrese un año válido (ej: 2020).");
                        return;
                    }
                    break;
                case "Buscar por Modelo":
                    modelo = valor;
                    break;
                case "Buscar por Serie":
                    num_serie = valor;
                    break;
            }

            RealizarBusqueda(tipo, marca, anio, modelo, fecha, num_serie);
            limpiarBuscador();
        }
        private void limpiarBuscador()
        {
            txb_valo_busqueda.Text = "";
            cmb_tipo_filtro.SelectedIndex = -1;

        }

        // Función maestra de búsqueda y dibujado
        private void RealizarBusqueda(string tipo, string marca, int? anio,
                                    string modelo, string fecha, string num_serie)
        {
            DesactivarPanelDeAcciones();
            flp_equipos_buscados.Controls.Clear();

            try
            {
                List<entEquipo> resultados = logEquipo.Instancia.BuscarEquipos(tipo, marca, anio, modelo, fecha, num_serie);

                if (resultados.Count == 0)
                {
                    MessageBox.Show("No se encontraron equipos.");
                    return;
                }

                // Crear y agregar tarjetas con eventos conectados
                foreach (entEquipo equipo in resultados)
                {
                    EquipoCard nuevaTarjeta = new EquipoCard();

                    nuevaTarjeta.CargarDatos(
                        equipo.id_equipo,
                        equipo.tipo_equipo,
                        equipo.num_serie,
                        equipo.marca,
                        equipo.modelo,
                        equipo.fecha_registro,
                        equipo.anio_fabricacion
                    );

                    // ¡CORREGIDO! Suscribirse al evento antes de agregar
                    nuevaTarjeta.TarjetaClickeada += Tarjeta_Click_Handler;

                    flp_equipos_buscados.Controls.Add(nuevaTarjeta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error");
            }
        }
        // Manejador del evento de clic en tarjeta
        private void Tarjeta_Click_Handler(object sender, int idEquipo)
        {
            ActivarPanelDeAcciones(idEquipo);
        }

        private void ActivarPanelDeAcciones(int idDelEquipo)
        {
            // Toggle: Si ya está visible y es el mismo equipo, cerrar
            if (panel_opciones.Visible &&
                equipo_seleccionado != null &&
                equipo_seleccionado.id_equipo == idDelEquipo)
            {
                DesactivarPanelDeAcciones();
                return;
            }

            try
            {
                equipo_seleccionado = logEquipo.Instancia.ObtenerEquipoPorId(idDelEquipo);
                if (equipo_seleccionado != null)
                {
                    lblEquipoSeleccionado.Text =
                        $"{equipo_seleccionado.codigo_flota}\n" +
                        $"{equipo_seleccionado.marca} {equipo_seleccionado.modelo}";

                    SetBotonesEnabled(panel_opciones, true);
                    panel_opciones.Visible = true;
                    panel_opciones.BackColor = Color.FromArgb(0, 77, 64);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener detalles del equipo: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DesactivarPanelDeAcciones()
        {
            equipo_seleccionado = null;
            lblEquipoSeleccionado.Text = "Seleccione un equipo";
            SetBotonesEnabled(panel_opciones, false);
            panel_opciones.Visible = false;
            panel_opciones.BackColor = Color.White; 
        }

        private void SetBotonesEnabled(Control parent, bool enabled)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.Enabled = enabled;
                }
                if (ctrl.HasChildren)
                {
                    SetBotonesEnabled(ctrl, enabled);
                }
            }
        }


        private void ConsultarEquipo_Load(object sender, EventArgs e)
        {

        }
    }
}
