using CapaEntidad;
using CapaEntidad.Equipo;
using CapaEntidad.Usuario;
using CapaLogica;
using CapaLogica.Equipo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaEntidad.Equipo;

namespace SistemMantenimiento.JeffeMantto
{
    public partial class Horometros : Form
    {
        private entEquipo equipo_selecionado;
        logLlenarCombos llenar;
        public Horometros(entEquipo equipo, entUsuarioLogueado usuarioLogueado)
        {
            InitializeComponent();
            equipo_selecionado = equipo;
            CargarEquipo(equipo);
            txb_codigo_flota.Enabled = false;
            txb_num_serie.Enabled = false;
            txb_horometro_anterior.Enabled = false;
            cmb_tipo_equipo.Enabled = false;
            txb_diferencia_horometro.Enabled = false;
            llenarCombos();
        }
        public Horometros()
        {
            InitializeComponent();
            this.equipo_selecionado = null;
        }

        private void CargarEquipo(entEquipo equipo)
        {
            txb_id_equipo.Text = equipo.id_equipo.ToString();
            txb_codigo_flota.Text = equipo.codigo_flota.ToString();
            txb_num_serie.Text = equipo.nume_serie.ToString();
            txb_horometro_anterior.Text = equipo.horometro_ingreso.ToString();
            cmb_tipo_equipo.Text = equipo.nombre_tipo_equipo.ToString();
        }
        public void llenarCombos()
        {
            try
            {
                // ====== TIPO EQUIPO ======
                logLlenarCombos llenar = new logLlenarCombos();
                var listaTipos = llenar.LLenarComboTipo();
                CargarCombo(cmb_tipo_equipo, listaTipos, "nombre_combo", "id_combo");
                var listaEmpleados = logEmpleado.Instancia.ListarEmpleados();
                CargarCombo(cmb_empleado, listaEmpleados, "nombre_combo", "id_combo");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar los combos: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarCombo<T>(ComboBox cbo, List<T> lista, string display, string value)
        {
            // 1. PRIMERO: Configura qué campos usar
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            // 2. SEGUNDO: Asigna los datos
            cbo.DataSource = lista;
            // 3. OPCIONAL: Para que no quede nada seleccionado al inicio
            cbo.SelectedIndex = -1;
        }

        private void Horometros_Load(object sender, EventArgs e)
        {
            llenarCombos();
        }

        private void btn_guardar_registro_Click(object sender, EventArgs e)
        {
            var listaErrores = new List<string>();
            listaErrores = ValidarCamposNoVacios();
            if (listaErrores.Count > 0)
            {
                string mensajeErrores = string.Join("\n", listaErrores);
                MessageBox.Show("Por favor, corrija los siguientes errores antes de guardar:\n" + mensajeErrores,
                                "Errores de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Parse seguro para horometros y diferencia
                if (!float.TryParse(txb_horometro_anterior.Text, out float horometroAnterior))
                {
                    MessageBox.Show("Horómetro anterior inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!float.TryParse(txb_horometro_actual.Text, out float horometroActual))
                {
                    MessageBox.Show("Horómetro actual inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!float.TryParse(txb_diferencia_horometro.Text, out float diferencia))
                {
                    MessageBox.Show("Diferencia inválida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!DateTime.TryParse(txb_fecha_registro.Text, out DateTime fechaRegistro))
                {
                    MessageBox.Show("La fecha ingresada no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Luego asignas la variable convertida
               

                int idEquipo = int.Parse(txb_id_equipo.Text);
                int idEmpleado = (int)cmb_empleado.SelectedValue;

                logHorometro.Instancia.InsertarHorometro(
                    new entHorometro
                    {
                        id_equipo = idEquipo,
                        horometro_anterior = horometroAnterior,
                        hotometro_actual = horometroActual,
                        fecha_registro = fechaRegistro,
                        descripcion = rch_observacion.Text,
                        id_empleado = idEmpleado,
                        diferencia = diferencia
                    }
                );

                MessageBox.Show("Registro de horómetro guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el registro de horómetro: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private List<string> ValidarCamposNoVacios()
        {
            var errores = new List<string>();

            // Recorrer los controles dentro de un panel (puedes cambiar panel1 por cualquier panel)
            foreach (Control ctrl in panel_informacion.Controls)
            {
                // Validar Guna2TextBox
                if (ctrl is Guna.UI2.WinForms.Guna2TextBox txt)
                {
                    if (string.IsNullOrWhiteSpace(txt.Text))
                    {
                        errores.Add($"El campo '{txt.Name}' no puede estar vacío.");
                    }
                }

                // Validar Guna2ComboBox
                else if (ctrl is Guna.UI2.WinForms.Guna2ComboBox cmb)
                {
                    if (cmb.SelectedIndex == -1 || cmb.SelectedValue == null)
                    {
                        errores.Add($"Debe seleccionar un valor en '{cmb.Name}'.");
                    }
                }

                // Validar RichTextBox
                else if (ctrl is RichTextBox rch)
                {
                    if (string.IsNullOrWhiteSpace(rch.Text))
                    {
                        errores.Add($"El campo '{rch.Name}' no puede estar vacío.");
                    }
                }
            }

            return errores;
        }

    }
}
