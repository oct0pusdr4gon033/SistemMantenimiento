using CapaEntidad.Equipo;
using CapaEntidad.Usuario;
using CapaLogica.Equipo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogica; 

namespace SistemMantenimiento.JeffeMantto
{
    public partial class EditarEquipo : Form
    {
        entEquipo equipo = new entEquipo();
        entUsuarioLogueado usuarioEdito =null;
        entArea area = null; 
        logLlenarCombos llenar = new logLlenarCombos();
        private logEquipo loEquipo = new logEquipo();
        public EditarEquipo(entEquipo _equipo, entUsuarioLogueado usuarioLogueado)
        {
            InitializeComponent();
            loEquipo = new logEquipo();
            equipo = _equipo;
            cmb_area.Text = equipo.nombre_area;
            cmb_tipo_e.SelectedValue = equipo.id_tipo_equipo;
            cmb_modelo.SelectedValue = equipo.id_modelo_equipo;
            // Marca NO viene su id, solo nombre — se carga por texto
            cmb_marca.Text = equipo.nombre_marca;
            // Estado
            cmb_estado.Text = equipo.estado;
            usuarioEdito = usuarioLogueado;
            llenarCombos();
            llenarFormularioEquipo(equipo);
            // Asignar valores
            usuarioEdito = usuarioLogueado;


        }
        public EditarEquipo()
        {
            InitializeComponent();
            usuarioEdito = null;
            equipo = null;
            txb_buscar_flota.Enabled = true;
        }
        private void llenarFormularioEquipo(entEquipo equipo)
        {
            // CAMPOS DE TEXTO
            txb_codigo_flota.Text = equipo.codigo_flota;
            txb_num_serie.Text = equipo.nume_serie;
            txb_anio_fabricacion.Text = equipo.anio_fabricacion.ToString();
            txb_h_compra.Text = equipo.horometro_compra.ToString();
            txb_h_ingreso.Text = equipo.horometro_ingreso.ToString();

            // FECHA
            dtp_fecha_ingreso.Value = equipo.fecha_ingreso;

            // COMBOS (INTENTAMOS POR VALUE, Y SI NO EXISTE, POR TEXTO)
            try
            {
                //cmb_area.SelectedValue = equipo.id_area;
                cmb_area.Text = equipo.nombre_area;
            }
            catch 
            { 
                cmb_area.Text = equipo.nombre_area; 
            }

            try
            {
                //cmb_tipo_e.SelectedValue = equipo.id_tipo_equipo;
                cmb_tipo_e.SelectedValue = equipo.id_tipo_equipo;
            }
            catch { cmb_tipo_e.Text = equipo.nombre_tipo_equipo; }

            try
            {
                //cmb_modelo.SelectedValue = equipo.id_modelo_equipo;
                cmb_modelo.SelectedValue = equipo.id_modelo_equipo;

            }
            catch { cmb_modelo.Text = equipo.nombre_modelo; }

            // Marca NO viene su id, solo nombre — se carga por texto
            cmb_marca.Text = equipo.nombre_marca;

            // Estado
            cmb_estado.Text = equipo.estado;
        }
        private void no_editables()
        {
            txb_buscar_flota.Enabled = false;
            dtp_fecha_ingreso.Enabled = false;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {

            try
            {
                string flota = txb_buscar_flota.Text.Trim();

                if (string.IsNullOrWhiteSpace(flota))
                {
                    MessageBox.Show("Ingrese un código de flota para buscar.",
                                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Buscar un equipo exacto por flota
                var lista = loEquipo.BuscarEquipoParametros(flota, null, null, null,0);

                if (lista.Count == 0)
                {
                    MessageBox.Show("No se encontró ningún equipo con ese código.",
                                    "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // --- Tomamos el primero (solo 1 flota debería existir) ---
                equipo = lista.First();

                // --- Llenar el formulario ---
                llenarFormularioEquipo(equipo);

                no_editables();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el equipo: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void llenarCombos()
        {
            try
            {
                // ====== MARCA ======
                var listaMarcas = llenar.LlenarComboMarca();
                CargarCombo(cmb_marca, listaMarcas, "nombre_combo", "id_combo");

                // ====== MODELO ======
                var listaModelos = llenar.LLenarComboModelo();
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

        private void btn_editar_Click(object sender, EventArgs e)
        {
            logEquipo insertar = new logEquipo();

            DialogResult r= MessageBox.Show("¿Está seguro de editar el equipo?",
                "Confirmar edición", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                logEquipo.Instancia.EditarEquipo(new entEquipo
                {
                    id_equipo = equipo.id_equipo,
                    codigo_flota = txb_codigo_flota.Text.Trim().ToUpper(),
                    id_area = Convert.ToInt32(cmb_area.SelectedValue),
                    id_tipo_equipo = Convert.ToInt32(cmb_tipo_e.SelectedValue),
                    id_modelo_equipo = Convert.ToInt32(cmb_modelo.SelectedValue),
                    nombre_marca = cmb_marca.Text.Trim().ToUpper(),
                    nume_serie = txb_num_serie.Text.Trim().ToUpper(),
                    anio_fabricacion = int.Parse(txb_anio_fabricacion.Text),
                    horometro_compra = double.Parse(txb_h_compra.Text),
                    horometro_ingreso = double.Parse(txb_h_ingreso.Text),
                    fecha_ingreso = dtp_fecha_ingreso.Value,
                    estado = cmb_estado.Text.Trim(),
                });
                MessageBox.Show("Equipo editado correctamente",
                    "Edición exitosa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                return; 
            }
               

        }

        private void EditarEquipo_Load(object sender, EventArgs e)
        {
            llenarCombos();
        }


    }
}
