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
            RealizarBusqueda(null, null, null, null, null);
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
            string marca = null;
            string area = null; 

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
                case "Marca":
                    marca = valor;
                    break;
                case "Area":
                    area= valor;
                    break; 
            }

            RealizarBusqueda( codigo_flota, modelo, marca,area, anio);
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
        private void RealizarBusqueda(string codigo_flota, string modelo, string marca, string area, int? anio)
        {
            DesactivarPanelDeAcciones();
            flp_equipos_buscados.Controls.Clear();

            try
            {
                // Normalizar valores: si están vacíos, enviamos null
                string filtroFlota = string.IsNullOrWhiteSpace(codigo_flota) ? null : codigo_flota;
                string filtroModelo = string.IsNullOrWhiteSpace(modelo) ? null : modelo;
                string filtroMarca = string.IsNullOrWhiteSpace(marca) ? null : marca;
                string filtroArea = string.IsNullOrWhiteSpace(area) ? null : area;

                // Conversión correcta del año: si no hay valor, enviar null
                int anioFinal = anio.HasValue ? anio.Value : 0;
                // → En nuestra lógica, 0 significa "NULL en SQL"

                // Ejecutar la búsqueda REAL basada en nuestro SP
                List<entEquipo> resultados = logEquipo.Instancia.BuscarEquipoParametros(
                    filtroFlota,
                    filtroModelo,
                    filtroMarca,
                    filtroArea,
                    anioFinal
                );

                if (resultados.Count == 0)
                {
                    MessageBox.Show("No se encontraron equipos con esos criterios.");
                    return;
                }

                foreach (entEquipo equipo in resultados)
                {
                    EquipoCard nuevaTarjeta = new EquipoCard();

                    nuevaTarjeta.CargarDatos(
                        equipo.id_equipo,
                        equipo.nombre_area,
                        equipo.codigo_flota,
                        equipo.nombre_tipo_equipo,
                        equipo.nume_serie,        // ✔ NOMBRE REAL EN ENTIDAD
                        equipo.nombre_marca,
                        equipo.nombre_modelo,
                        equipo.fecha_ingreso,
                        equipo.anio_fabricacion      // ✔ MAPEADO DESDE anio_frabricacion BD
                    );

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
                lblEquipoSeleccionado.Text = "Cargando detalles...";
                // Reutilizamos la búsqueda enviando NULL en todo excepto el código de flota
                // Orden de params según el SP: (flota, modelo, marca, area, anio)
                var listaResultados = logEquipo.Instancia.BuscarEquipoParametros(
                    null,
                    null,
                    null,
                    null,
                    0
                );

                equipo_seleccionado = listaResultados.FirstOrDefault();

                if (equipo_seleccionado == null)
                {
                    MessageBox.Show("No se encontró el equipo seleccionado (pudo haber sido eliminado).");
                    return;
                }

                // Mostrar información en panel lateral
                lblEquipoSeleccionado.Text =
                    $"{equipo_seleccionado.codigo_flota}\n" +
                    $"{equipo_seleccionado.nombre_marca} {equipo_seleccionado.nombre_modelo}";

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

        private void btn_generar_ot_Click(object sender, EventArgs e)
        {
           
        }
    }
}
