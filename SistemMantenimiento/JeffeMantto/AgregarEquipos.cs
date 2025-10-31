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
            top_cinco(flp_top);
        }
        public void top_cinco(FlowLayoutPanel flp_top_cinco)
        {
           
            flp_top_cinco.Controls.Clear();
            flp_top_cinco.FlowDirection = FlowDirection.TopDown;
            flp_top_cinco.Padding = new Padding(10);

            try
            {
             
                List<entEquipo> listaTopEquipos = objLogica.ListarTop5Equipos();
                if (listaTopEquipos.Count > 0)
                {

                    foreach (entEquipo equipo in listaTopEquipos)
                    {
                        Label lbl = new Label();

                        // Hacemos el Label tan ancho como el panel
                        // (AutoSize = false es clave para esto)
                        lbl.AutoSize = false;
                        lbl.Width = flp_top_cinco.Width - 25; // Ancho del panel menos el padding
                        lbl.Height = 30; // Altura fija

                        // --- ESTILO COMO TU IMAGEN ---

                        // 1. Quitamos el fondo rojo (lo hacemos transparente)
                        lbl.BackColor = Color.Transparent;

                        // 2. Cambiamos el color del texto a un gris oscuro
                        lbl.ForeColor = Color.DimGray; // 'DimGray' es un color muy similar al de tu foto

                        // 3. Ajustamos la alineación del texto
                        // (En tu foto parece alineado a la izquierda o al centro-izquierda)
                        lbl.TextAlign = ContentAlignment.MiddleLeft;

                        // 4. (Opcional) Ajustamos la fuente para que se vea profesional
                        lbl.Font = new Font("Segoe UI", 10, FontStyle.Regular); // Segoe UI es estándar en WinForms

                        // 5. Asignamos el texto
                        lbl.Text = equipo.codigo_flota + " - " + equipo.marca;

                        // 6. Añadimos el ToolTip que vimos antes (¡sigue siendo útil!)
                        ToolTip tt = new ToolTip();
                        tt.SetToolTip(lbl, "Modelo: " + equipo.modelo + "\nTipo: " + equipo.tipo_equipo);

                        // 7. Añadimos el Label al panel
                        flp_top_cinco.Controls.Add(lbl);
                    }
                }
                else
                {
                
                    Label lblVacio = new Label();
                    lblVacio.Name = "lbl_vacio";
                    lblVacio.BackColor = Color.Gray; // Color diferente
                    lblVacio.Size = new Size(150, 30);
                    lblVacio.Text = "No hay equipos";
                    lblVacio.ForeColor = Color.White;
                    lblVacio.TextAlign = ContentAlignment.MiddleCenter;

                    flp_top_cinco.Controls.Add(lblVacio);
                }
                // --- FIN DE LA CONEXIÓN A LA LÓGICA ---
            }
            catch (Exception ex)
            {
                
                Label lblError = new Label();
                lblError.Name = "lbl_error";
                lblError.BackColor = Color.Black;
                lblError.Size = new Size(150, 60); // Más alto para el error
                lblError.Text = "Error al cargar:\n" + ex.Message;
                lblError.ForeColor = Color.Yellow;
                lblError.TextAlign = ContentAlignment.MiddleCenter;

                flp_top_cinco.Controls.Add(lblError);
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
