using CapaEntidad;
using CapaEntidad.Equipo;
using CapaEntidad.Usuario;
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
        private Form formularioActivo = null;
        List<entEquipo> lista_equipos = new List<entEquipo>();
        private entUsuarioLogueado usuarioLogueado = null;

        public ConsultarEquipo(entUsuarioLogueado usuario )
        {
            InitializeComponent();
            usuarioLogueado = usuario;
            RealizarBusqueda(null, null, null, null);
            panel_opciones.Visible = false;
            panel_form_hijo.Visible = false;
       
        }
        public ConsultarEquipo()
        {
            InitializeComponent();
            this.usuarioLogueado = null; 
        }
        private void AbrirFormularioEnPanel(Form formularioHijo)
        {
            // 1. Si ya hay un formulario abierto, lo cerramos
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }

            // 2. Guardamos la referencia del nuevo formulario
            formularioActivo = formularioHijo;
            // 3. Configuramos el formulario para que actúe como un control
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill; // <-- ¡Tu línea mágica!

            // 4. Limpiamos el panel y añadimos el nuevo formulario (UNA SOLA VEZ)
            panel_form_hijo.Visible = true;
            panel_form_hijo.BringToFront();
            panel_form_hijo.Controls.Clear();
            panel_form_hijo.Controls.Add(formularioHijo);
            panel_form_hijo.Tag = formularioHijo;

            // 5. Lo mostramos
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string valor = txb_valo_busqueda.Text.Trim();

            if (string.IsNullOrEmpty(valor))
            {
                //RealizarBusqueda(null, null, null, null, null, null);
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
            string codigo_flota = null;
            string modelo = null;
            int ? anio = null;
            string num_serie = null;



            // 4. Usamos un 'switch' para asignar el 'valor' al parámetro correcto
            switch (filtroSeleccionado)
            {
                case "Codigo de Flota":
                    codigo_flota = valor;
                    break;
                case "Modelo de Equipo":
                    modelo = valor;
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
                case "Número por Serie":
                    num_serie = valor;
                    break;
            }

            RealizarBusqueda( codigo_flota,  modelo,  anio,
                                       num_serie);
            limpiarBuscador();
        }
        private void limpiarBuscador()
        {
            txb_valo_busqueda.Text = "";
            cmb_tipo_filtro.SelectedIndex = -1;

        }
        
        /// <summary>
        /// Función maestra de búsqueda y dibujado
        /// </summary>
        /// <param name="tipo"></param>
        /// <param name="marca"></param>
        /// <param name="anio"></param>
        /// <param name="modelo"></param>
        /// <param name="fecha"></param>
        /// <param name="num_serie"></param>
        private void RealizarBusqueda(string codigo_flota, string modelo, int? anio,
                                      string num_serie)
        {
            DesactivarPanelDeAcciones();
            flp_equipos_buscados.Controls.Clear();

            try
            {
                List<entEquipo> resultados = logEquipo.Instancia.BuscarEquipos(codigo_flota, modelo, num_serie,anio);

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
                        equipo.codigo_flota,
                        equipo.tipo_equipo, // Argumento 3: tipoEquipo (string)
                        equipo.numero_serie,
                        equipo.marca,
                        equipo.modelo,
                        equipo.fecha_ingreso.HasValue ? equipo.fecha_ingreso.Value : DateTime.MinValue,
                        equipo.anio_fabricacion.HasValue ? equipo.anio_fabricacion.Value : 0 // Argumento 8: anioFabricacion (int)
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
        private void Tarjeta_Click_Handler(object sender, string codigo_flota)
        {
            try
            {
                // Cargar la entidad desde la BD
                equipo_seleccionado = logEquipo.Instancia.BuscarEquipos(codigo_flota, null, null, null)
                                        .FirstOrDefault();

                if (equipo_seleccionado == null)
                {
                    MessageBox.Show("No se encontró el equipo seleccionado.");
                    return;
                }

                // Mostrar información en panel lateral
                lblEquipoSeleccionado.Text =
                    $"{equipo_seleccionado.codigo_flota}\n" +
                    $"{equipo_seleccionado.marca} {equipo_seleccionado.modelo}";

                SetBotonesEnabled(panel_opciones, true);
                panel_opciones.Visible = true;
                panel_opciones.BackColor = Color.White;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener los detalles: {ex.Message}",
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

        private void btn_editar_Click_1(object sender, EventArgs e)
        {
            if (equipo_seleccionado == null)
            {
                MessageBox.Show("Seleccione un equipo antes de editar.");
                return;
            }

            AbrirFormularioEnPanel(new EditarEquipo(equipo_seleccionado, usuarioLogueado));
        }
    }
}
