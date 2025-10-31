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
        public AgregarEquipos()
        {
            InitializeComponent();
            top_cinco(flp_top);
        }
        public void top_cinco(FlowLayoutPanel flp_top_cinco)
        {
            // 1. (Recomendado) Limpia el panel antes de añadir nuevos controles
            flp_top_cinco.Controls.Clear();

            // 2. Asegúrate de que apile los controles verticalmente
            flp_top_cinco.FlowDirection = FlowDirection.TopDown;

            // (Opcional) Añade un poco de relleno interno
            flp_top_cinco.Padding = new Padding(10);

            for (int i = 1; i <= 5; i++)
            {
                Label lbl = new Label();
                lbl.Name = "lbl_top_" + i;
                lbl.BackColor = Color.Red;
                lbl.Size = new Size(150, 30); // El FlowLayoutPanel respetará este tamaño
                lbl.Text = "Top " + i;
                lbl.ForeColor = Color.White;
                lbl.TextAlign = ContentAlignment.MiddleCenter;

                // (Opcional) Añade un margen para separarlos
                lbl.Margin = new Padding(0, 0, 0, 5);

                // 3. Añade el Label al FlowLayoutPanel
                // ¡Él se encargará de la posición automáticamente!
                flp_top_cinco.Controls.Add(lbl);
            }



        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
                 List<string> listaDeErrores = ValidarDatos();

            if (listaDeErrores.Count > 0)
            {
                string mensajeCompleto = "Por favor, corrija los siguientes errores:\n\n";
                mensajeCompleto += string.Join("\n", listaDeErrores);
                MessageBox.Show(this, mensajeCompleto, "Errores de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    entEquipo nuevoEquipo = new entEquipo()
                    {
                        codigo_flota = txb_codigo_flota.Text.Trim(),
                        marca = cmb_marca.GetItemText(cmb_marca.SelectedItem),
                        modelo = txb_modelo.Text.Trim(),
                        num_serie = txb_numero_serie.Text.Trim(),
                        tipo_equipo = cmb_tipo_equipo.GetItemText(cmb_tipo_equipo.SelectedItem),
                        anio_fabricacion = int.Parse(txb_anio_fabricacion.Text),
                        horometro_inicial = int.Parse(txb_horometro_inicial.Text),
                        horometro_actual = int.Parse(txb_horometro_actual.Text),
                        fecha_registro = dtp_fecha_compra.Value,
                        fecha_compra = dtp_fecha_registro.Value,
                        estado_equipo = get_estado_bool(cmb_estado.GetItemText(cmb_estado.SelectedItem))

                    };

                    logEquipo.Instancia.insertar_equipo(nuevoEquipo);
                    MessageBox.Show("Equipo guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error:\n" + ex.Message,
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private bool get_estado_bool(string estado)
        {
            
            return string.Equals(estado?.Trim(), "Activo", StringComparison.OrdinalIgnoreCase);
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

            if (dtp_fecha_registro.Value < dtp_fecha_compra.Value)
            {
                errores.Add("La 'Fecha de Ingreso' no puede ser anterior a la 'Fecha de Registro'.");
            }

            // --- 4. Devolver la lista de errores ---
            return errores;
        }
    }
}
