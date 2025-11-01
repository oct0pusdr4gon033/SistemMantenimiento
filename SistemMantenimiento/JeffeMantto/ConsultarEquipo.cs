using CapaEntidad.Equipo;
using CapaLogica.Equipo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public ConsultarEquipo()
        {
            InitializeComponent();
            // Llama a tu función para que cargue TODOS los equipos al iniciar
            RealizarBusqueda(null, null, null, null, null);
        }
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            // 1. Obtenemos el valor a buscar
            string valor = txb_valo_busqueda.Text.Trim();

            // ¡¡CORRECCIÓN 1!! (Para limpiar el filtro)
            if (string.IsNullOrEmpty(valor))
            {
                // Si el texto está vacío, recarga todo
                RealizarBusqueda(null, null, null, null, null); // <-- Llama a la función
                return; // <-- Y LUEGO detente
            }

            // 2. Obtenemos el tipo de filtro seleccionado
            string filtroSeleccionado = cmb_tipo_filtro.SelectedItem.ToString();

            // 3. Preparamos todas las variables como 'null' por defecto (TUS 5 PARÁMETROS)
            string tipo = null;
            string marca = null;
            int? anio = null;
            string modelo = null;
            string fecha = null;

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
            }

            // 5. ¡¡CORRECCIÓN 2!! (Llama a la función correcta)
            // Llama a tu función maestra 'RealizarBusqueda'
            RealizarBusqueda(tipo, marca, anio, modelo, fecha);
        }

        // (Tu función maestra de dibujado)
        private void RealizarBusqueda(string tipo, string marca, int? anio, string modelo, string fecha)
        {
            // 1. Limpia el panel
            flp_equipos_buscados.Controls.Clear(); // (Asegúrate que tu panel se llame así)

            try
            {
                // 2. Llama a tu capa de lógica (con tus 5 parámetros, ¡perfecto!)
                List<entEquipo> resultados = logEquipo.Instancia.BuscarEquipos(tipo, marca, anio, modelo, fecha);

                // 3. Verifica si hay resultados
                if (resultados.Count == 0)
                {
                    MessageBox.Show("No se encontraron equipos.");
                    return;
                }

                // 4. Bucle para crear las tarjetas
                foreach (entEquipo equipo in resultados)
                {
                    EquipoCard nuevaTarjeta = new EquipoCard();

                    // ¡¡CORRECCIÓN 3!! (Orden y cantidad de parámetros para la TARJETA)
                    // Tu tarjeta (el UserControl) necesita 6 datos para mostrarse
                    nuevaTarjeta.CargarDatos(
                       
                        equipo.tipo_equipo,          // <-- 2. Tipo
                        equipo.marca,                // <-- 3. Marca
                        equipo.modelo,               // <-- 4. Modelo
                        equipo.fecha_registro,       // <-- 5. Fecha
                        equipo.anio_fabricacion      // <-- 6. Año
                    );

                    // (Eliminamos la línea del Width para que el FlowLayoutPanel decida
                    // y pueda poner 2 columnas, como te expliqué antes)

                    // Añade la tarjeta al panel
                    flp_equipos_buscados.Controls.Add(nuevaTarjeta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error");
            }
        }

    }
}
