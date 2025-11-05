using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad.Equipo; 
using CapaLogica.Equipo;


namespace SistemMantenimiento.JeffeMantto
{
    public partial class AgregarEquipos : Form
    {
        private logEquipo objLogica = new logEquipo();
        public AgregarEquipos()
        {
            InitializeComponent();
            extraer_areas();
        }
        
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            List<string> listaDeErrores = ValidarDatos();

            if (listaDeErrores.Count > 0)
            {
                string mensajeCompleto = "Por favor, corrija los siguientes errores:\n\n";
                mensajeCompleto += string.Join("\n", listaDeErrores);
                MessageBox.Show(this, mensajeCompleto, "Errores de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Conversión segura de tipos numéricos (compatible con .NET 4.7)
                decimal? horometroInicial = null;
                decimal valorHorometroInicial;
                if (decimal.TryParse(txb_horometro_inicial.Text, out valorHorometroInicial))
                    horometroInicial = valorHorometroInicial;

                decimal? horometroActual = null;
                decimal valorHorometroActual;
                if (decimal.TryParse(txb_horometro_actual.Text, out valorHorometroActual))
                    horometroActual = valorHorometroActual;

                int? anioFabricacion = null;
                int valorAnio;
                if (int.TryParse(txb_anio_fabricacion.Text, out valorAnio))
                    anioFabricacion = valorAnio;
                // Crear entidad
                entEquipo nuevoEquipo = new entEquipo()
                {
                    codigo_flota = txb_codigo_flota.Text.Trim(),
                    marca = cmb_marca.GetItemText(cmb_marca.SelectedItem),
                    modelo = txb_modelo.Text.Trim(),
                    numero_serie = txb_numero_serie.Text.Trim(),
                    anio_fabricacion = anioFabricacion,
                    horometro_inicial = horometroInicial,
                    horometro_actual = horometroActual,
                    id_area = ObtenerIdAreaSeleccionada(),
                    criticidad = cmb_criticidad.GetItemText(cmb_criticidad.SelectedItem),
                    estado = cmb_estado.GetItemText(cmb_estado.SelectedItem), // ✅ varchar ahora
                    fecha_ingreso = dtp_fecha_registro.Value,
                    activo = cmb_estado.GetItemText(cmb_estado.SelectedItem) == "Activo",
                    tipo_equipo = cmb_tipo_equipo.GetItemText(cmb_tipo_equipo.SelectedItem)
                }; 

                entEquipo equipoRegistrado = logEquipo.Instancia.insertar_equipo(nuevoEquipo);

                if (equipoRegistrado != null && equipoRegistrado.id_equipo > 0)
                    MessageBox.Show("Equipo guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No se pudo registrar el equipo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private int ObtenerIdAreaSeleccionada()
        {
            if (cmb_area.SelectedItem is Area areaSeleccionada)
            {
                return areaSeleccionada.IdArea;
            }
            else
            {
                throw new InvalidOperationException("No se ha seleccionado un área válida.");
            }
        }

        public void LimpiarCampos()
        {
            txb_codigo_flota.Clear();
            txb_numero_serie.Clear();
            cmb_marca.SelectedIndex = -1;
            txb_modelo.Clear();
            txb_anio_fabricacion.Clear();
            txb_horometro_inicial.Clear();
            txb_horometro_actual.Clear();
            cmb_area.SelectedIndex = -1;
            cmb_criticidad.SelectedIndex = -1;
            cmb_estado.SelectedIndex = -1;
          
        }
        private void extraer_areas()
        {
            try
            {
                List<Area> listaAreas = logArea.Instancia.ObtenerAreas();

                cmb_area.DataSource = listaAreas;
                cmb_area.DisplayMember = "Nombre";   // ✅ coincide con la propiedad de la clase
                cmb_area.ValueMember = "IdArea";     // ✅ coincide con la propiedad de la clase
                cmb_area.SelectedIndex = -1;         // ✅ sin selección inicial
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las áreas: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //////Funcion para validacion 
        private List<string> ValidarDatos()
        {
            var errores = new List<string>();

            // 📋 Validaciones de texto
            if (string.IsNullOrWhiteSpace(txb_codigo_flota.Text))
                errores.Add("El 'Código de Flota' es obligatorio.");

            if (cmb_marca.SelectedItem == null)
                errores.Add("Debe seleccionar una 'Marca'.");

            if (string.IsNullOrWhiteSpace(txb_modelo.Text))
                errores.Add("El 'Modelo' es obligatorio.");

            if (string.IsNullOrWhiteSpace(txb_numero_serie.Text))
                errores.Add("El 'Número de Serie' es obligatorio.");

            if (cmb_tipo_equipo.SelectedItem == null)
                errores.Add("Debe seleccionar un 'Tipo de Equipo'.");

            if (cmb_estado.SelectedItem == null)
                errores.Add("Debe seleccionar un 'Estado del Equipo'.");

            // --- 2. Validar números ---
            int anioTemp = 0; 
            if (string.IsNullOrWhiteSpace(txb_anio_fabricacion.Text))
            {
                errores.Add("El 'Año de Fabricación' es obligatorio.");
            }
            else if (!int.TryParse(txb_anio_fabricacion.Text, out anioTemp))
            {
                errores.Add("El 'Año de Fabricación' debe ser un número válido.");
            }

            int horoIniTemp = 0;
            if (!int.TryParse(txb_horometro_inicial.Text, out horoIniTemp))
            {
                // Nota: Podríamos permitir 0 o vacío si es opcional
                errores.Add("El 'Horómetro Inicial' debe ser un número válido.");
            }

            int horoActTemp = 0;
            if (!int.TryParse(txb_horometro_actual.Text, out horoActTemp))
            {
                errores.Add("El 'Horómetro Actual' debe ser un número válido.");
            }

            // --- 3. Validar lógica de negocio ---
            // Solo comparamos si ambos fueron números válidos
            if (horoActTemp < horoIniTemp)
            {
                errores.Add("El 'Horómetro Actual' no puede ser menor que el 'Horómetro Inicial'.");
            }

            // Es mejor usar DateTime.Today que ya viene sin la hora.
            DateTime fechaActual = DateTime.Today;

            if (dtp_fecha_registro.Value.Date != fechaActual)
            {
                // Este mensaje de error es más claro para el usuario.
                errores.Add("La 'Fecha de Ingreso' debe ser la fecha de hoy.");
            }

            // --- 4. Devolver la lista de errores ---
            return errores;
        }
    }
}
