using CapaEntidad.Equipo;
using CapaLogica;
using CapaLogica;
using CapaLogica.Equipo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SistemMantenimiento.JeffeMantto
{
    public partial class AgregarEquipos : Form
    {
        private logEquipo objLogica = new logEquipo();
        private logLlenarCombos llenar = new logLlenarCombos();
        public AgregarEquipos()
        {
            InitializeComponent();
        }
        
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            // 1. Validaciones (Tu código actual)
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
                // 2. Crear y llenar el objeto entidad
                entEquipo equipo = new entEquipo();

                // --- EXTRACCIÓN DE IDs DE LOS COMBOS ---
                // Convert.ToInt32 maneja el objeto que devuelve SelectedValue y lo pasa a entero
                equipo.id_area = Convert.ToInt32(cmb_area.SelectedValue);
                equipo.id_tipo_equipo = Convert.ToInt32(cmb_tipo_e.SelectedValue);
                equipo.id_modelo_equipo = Convert.ToInt32(cmb_modelo.SelectedValue);

                // --- CAMPOS DE TEXTO ---
                equipo.codigo_flota = txb_codigo_flota.Text.Trim().ToUpper();
                equipo.nume_serie = txb_num_serie.Text.Trim().ToUpper();

                // --- CAMPOS NUMÉRICOS (Parseo) ---
                // Asumiendo que ya validaste que son números en ValidarDatos()
                equipo.anio_fabricacion = int.Parse(txb_anio_fabricacion.Text);
                try
                {
                    equipo.horometro_compra = double.Parse(txb_h_compra.Text);
                    equipo.horometro_ingreso = double.Parse(txb_h_ingreso.Text);
                }
                catch (Exception ex )
                {
                    MessageBox.Show(
                        "Error al ingresar los horometros: " + ex,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                }

                // --- FECHAS Y BOOLEANOS ---
                equipo.fecha_ingreso = dtp_fecha_ingreso.Value; // Usando un DateTimePicker

                
                equipo.estado = cmb_estado.Text; 

                if (equipo.estado==null)
                {
                    MessageBox.Show(
                        $"No el estado es nulo porfavor corregir: {equipo.estado}" ,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        
                        );
                    return; 
                }


                // 3. Llamar a la Capa de Lógica (o Datos directamente si no tienes Lógica)
                // Suponiendo que tienes una clase logEquipo
                bool resultado = logEquipo.Instancia.InsertarEquipo(equipo);

                if (resultado)
                {
                    MessageBox.Show("Equipo registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    LimpiarCampos(); 
                   
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el equipo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error crítico:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
      

        public void LimpiarCampos()
        {

            txb_anio_fabricacion.Clear();
            txb_codigo_flota.Clear();   
            txb_h_compra.Clear();
            txb_h_ingreso.Clear();
            txb_num_serie.Clear();
            cmb_area.SelectedIndex = -1;
            cmb_estado.SelectedIndex = -1;
            cmb_marca.SelectedIndex = -1;
            cmb_modelo.SelectedIndex = -1;
            cmb_tipo_e.SelectedIndex = -1;

        }
     

        //////Funcion para validacion 
        private List<string> ValidarDatos()
        {
            var errores = new List<string>();

            // === 1. Validar fecha ===
            DateTime fechaSeleccionada = dtp_fecha_ingreso.Value.Date;
            DateTime fechaSistema = DateTime.Now.Date;

            if (fechaSeleccionada != fechaSistema)
                errores.Add("La fecha de ingreso debe ser igual a la fecha del sistema.");


            // === 2. Validar horómetros ===
            bool horoCompraOK = double.TryParse(txb_h_compra.Text.Trim(), out double horometroCompra);
            bool horoIngresoOK = double.TryParse(txb_h_ingreso.Text.Trim(), out double horometroIngreso);

            if (!horoCompraOK)
                errores.Add("El horómetro de compra no es válido.");

            if (!horoIngresoOK)
                errores.Add("El horómetro actual no es válido.");

            // Si ambos valores son numéricos, validar reglas
            if (horoCompraOK && horoIngresoOK)
            {
                if (horometroCompra < 0)
                    errores.Add("El horómetro de compra no puede ser negativo.");

                if (horometroIngreso < 0)
                    errores.Add("El horómetro actual no puede ser negativo.");

                if (horometroIngreso < horometroCompra)
                    errores.Add("El horómetro actual no puede ser menor que el horómetro de compra.");
            }


            // === 3. Validar otros campos obligatorios ===
            if (string.IsNullOrWhiteSpace(txb_codigo_flota.Text))
                errores.Add("Debe ingresar el código de flota.");

            if (string.IsNullOrWhiteSpace(txb_num_serie.Text))
                errores.Add("Debe ingresar el número de serie.");

            if (cmb_estado.SelectedItem == null)
                errores.Add("Debe seleccionar un estado.");

            if (cmb_area.SelectedIndex == -1)
                errores.Add("Debe seleccionar un área.");

            if (cmb_marca.SelectedIndex == -1)
                errores.Add("Debe seleccionar una marca.");

            if (cmb_modelo.SelectedIndex == -1)
                errores.Add("Debe seleccionar un modelo.");

            if (cmb_tipo_e.SelectedIndex == -1)
                errores.Add("Debe seleccionar un tipo de equipo.");

            return errores;
        }

        public void llenarCombos()
        {
            try
            {
                // ====== MARCA ======
                var listaMarcas = llenar.LlenarComboMarca();
                CargarCombo(cmb_marca, listaMarcas, "nombre_combo", "id_combo");

                // ====== MODELO ======
                var listaModelos =llenar.LLenarComboModelo();
                CargarCombo(cmb_modelo, listaModelos, "nombre_combo", "id_combo");

                // ====== ÁREA ======
                var listaAreas = llenar.LLenarComboArea();
                CargarCombo(cmb_area, listaAreas, "nombre_combo", "id_combo");

                // ====== TIPO EQUIPO ======
                var listaTipos = llenar.LLenarComboTipo();
                CargarCombo(cmb_tipo_e, listaTipos, "nombre_combo", "id_combo");


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

        private void AgregarEquipos_Load(object sender, EventArgs e)
        {
            llenarCombos();
        }
    }
}
