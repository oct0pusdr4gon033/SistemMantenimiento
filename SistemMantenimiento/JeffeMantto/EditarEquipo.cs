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

namespace SistemMantenimiento.JeffeMantto
{
    public partial class EditarEquipo : Form
    {
        entEquipo equipo = new entEquipo();
        entUsuarioLogueado usuarioEdito =null;
        Area area = null; 
        

        public EditarEquipo(entEquipo _equipo, entUsuarioLogueado usuarioLogueado)
        {
            InitializeComponent();
            
            equipo = _equipo;
            usuarioEdito = usuarioLogueado;

            // Asignar valores
            equipo = _equipo;
            usuarioEdito = usuarioLogueado;

            // Cargar las áreas antes de asignar valores
            CargarAreas();

            // Llenar los campos con la información del equipo
            CargarDatosEquipo();


        }
        public EditarEquipo()
        {
            InitializeComponent();
            usuarioEdito = null;
            equipo = null;

            // Cargar áreas incluso si es un nuevo registro
            CargarAreas();

            txb_buscar_flota.Enabled = true;
        }

        // 🔹 Método para cargar las áreas en el ComboBox
        private void CargarAreas()
        {
            try
            {
                List<Area> listaAreas = logArea.Instancia.ObtenerAreas();
                cmb_area.DataSource = listaAreas;
                cmb_area.DisplayMember = "Nombre";
                cmb_area.ValueMember = "IdArea";
                cmb_area.SelectedIndex = -1; // sin selección inicial
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las áreas: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 🔹 Método que llena los campos con la información del equipo
        private void CargarDatosEquipo()
        {
            if (equipo == null) return;

            txb_buscar_flota.Text = equipo.id_equipo.ToString();
            txb_codigo_flota.Text = equipo.codigo_flota;
            txb_numero_serie.Text = equipo.numero_serie;
            cmb_marca.Text = equipo.marca;
            txb_modelo.Text = equipo.modelo;
            txb_anio_fabricacion.Text = equipo.anio_fabricacion?.ToString() ?? "";
            cmb_tipo_equipo.Text = equipo.tipo_equipo;
            txb_horometro_actual.Text = equipo.horometro_actual?.ToString() ?? "";
            txb_horometro_inicial.Text = equipo.horometro_inicial?.ToString() ?? "";
            cmb_estado.Text = equipo.estado;
            cmb_criticidad.Text = equipo.criticidad;
            dtp_fecha_registro.Value = equipo.fecha_ingreso ?? DateTime.Now;

            // Si el equipo tiene área, seleccionarla en el combo
            if (equipo.id_area.HasValue)
            {
                cmb_area.SelectedValue = equipo.id_area.Value;
            }
        }

        // 🔹 Bloquear campos no editables
        private void no_editables()
        {
            txb_buscar_flota.Enabled = false;
            dtp_fecha_registro.Enabled = false;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {

            try
            {
                if (cmb_area.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione un área primero.",
                                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idAreaSeleccionada = Convert.ToInt32(cmb_area.SelectedValue);
                Area areaSeleccionada = logArea.Instancia.ObtenerAreaPorId(idAreaSeleccionada);
                
                if (areaSeleccionada != null)
                {
                    MessageBox.Show($"Área seleccionada:\n\nNombre: {areaSeleccionada.Nombre}\nCódigo: {areaSeleccionada.Codigo}",
                                    "Área encontrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el área: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /*
        public bool validar_existencia_bitacora(int id_equipo)
        {
          return logEquipo.Instancia.existe_bitacora(id_equipo);
        }
        */
        /*
       public void desactivar_botones()
        {
            try
            {
                if (equipo == null)
                {
                    MessageBox.Show("No se ha seleccionado ningún equipo.", 
                                    "Aviso", 
                                    MessageBoxButtons.OK, 
                                    MessageBoxIcon.Warning);
                    return;
                }

               // bool existeBitacora = validar_existencia_bitacora(equipo.id_equipo);

                if (existeBitacora)
                {
                    // 🔒 Desactivar campos
                    txb_id_editar.Enabled = false;
                    dtp_fecha_registro.Enabled = false;
                    txb_codigo_flota.Enabled = false;
                    btn_editar.Enabled = false;
                    btn_buscar.Enabled = false;
                    txb_marca.Enabled = false;
                    txb_modelo.Enabled = false;
                    txb_numero_serie.Enabled = false;
                    txb_tipo_equipo.Enabled = false;
                    txb_anio_fabricacion.Enabled = false;
                    cmb_estado.Enabled = false;
                    txb_horometro_inicial.Enabled = false;
                    txb_horometro_actual.Enabled = false;
                    rch_observacion.Enabled = false;

                    // 🎨 Configurar botón Guna2
                    btn_eliminar.FillColor = Color.Red;               // Fondo rojo
                    btn_eliminar.HoverState.FillColor = Color.DarkRed; // Fondo más oscuro al pasar el mouse
                    btn_eliminar.ForeColor = Color.White;              // Texto blanco
                    btn_eliminar.BorderThickness = 0;                  // Sin borde
                    btn_eliminar.Text = "Eliminar";                   // Cambiar texto para indicar estado

                    MessageBox.Show("Este equipo tiene una bitácora registrada. La edición ha sido deshabilitada.", 
                                    "Acción restringida", 
                                    MessageBoxButtons.OK, 
                                    MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al desactivar los controles: " + ex.Message, 
                                "Error", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Error);
            }
        }


        private void editables()

        {
            txb_marca.Enabled = true;
            txb_modelo.Enabled = true;
            txb_numero_serie.Enabled = true;
            txb_tipo_equipo.Enabled = true;
            txb_anio_fabricacion.Enabled = true;
            cmb_estado.Enabled = true;
            txb_horometro_inicial.Enabled = true;
            txb_horometro_actual.Enabled = true;
            rch_observacion.Enabled = true;
        }

        private void EditarEquipo_Load(object sender, EventArgs e)
        {
            no_editables();
            editables();
            desactivar_botones();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                GuardarCambios();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los cambios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private bool getEstado(ComboBox cmb)
        {
           if (cmb.SelectedItem.ToString() == "Activo")
           {
                return true;
           }
           else
           {
                return false;
           }
        }
        private entEquipo ObtenerDatosFormulario()
        {
            bool estado = getEstado(cmb_estado);
            return new entEquipo
            {
                id_equipo = int.Parse(txb_id_editar.Text),
                codigo_flota = txb_codigo_flota.Text.Trim(),
                marca = txb_marca.Text.Trim(),
                modelo = txb_modelo.Text.Trim(),
                numero_serie = txb_numero_serie.Text.Trim(),
                tipo_equipo = txb_tipo_equipo.Text.Trim(),
                anio_fabricacion = int.Parse(txb_anio_fabricacion.Text),
                horometro_inicial = int.Parse(txb_horometro_inicial.Text),
                horometro_actual = int.Parse(txb_horometro_actual.Text),
                fecha_ingreso = dtp_fecha_registro.Value,
                estado = cmb_estado.SelectedItem.ToString(),
            }; 
        }
        private void GuardarCambios()
        {
            // Obtener el registro original desde la base
            //entEquipo original = logEquipo.Instancia.ObtenerEquipoPorId(equipo.id_equipo);
            entEquipo actualizado = ObtenerDatosFormulario();

            // Comparar campo por campo
            List<(string campo, string antes, string despues)> cambios = new List<(string, string, string)>();

            if (original.marca != actualizado.marca)
                cambios.Add(("Marca", original.marca, actualizado.marca));

            if (original.modelo != actualizado.modelo)
                cambios.Add(("Modelo", original.modelo, actualizado.modelo));

            if (original.numero_serie != actualizado.numero_serie)
                cambios.Add(("Número de Serie", original.numero_serie, actualizado.numero_serie));

            if (original.tipo_equipo != actualizado.tipo_equipo)
                cambios.Add(("Tipo de Equipo", original.tipo_equipo, actualizado.tipo_equipo));

            if (original.anio_fabricacion != actualizado.anio_fabricacion)
                cambios.Add(("Año de Fabricación", original.anio_fabricacion.ToString(), actualizado.anio_fabricacion.ToString()));

            if (original.horometro_inicial != actualizado.horometro_inicial)
                cambios.Add(("Horómetro Inicial", original.horometro_inicial.ToString(), actualizado.horometro_inicial.ToString()));

            if (original.horometro_actual != actualizado.horometro_actual)
                cambios.Add(("Horómetro Actual", original.horometro_actual.ToString(), actualizado.horometro_actual.ToString()));

            //if (original.estado != actualizado.estado)
              //  cambios.Add(("Estado", original.estado ? "Activo" : "Inactivo",
                //                             actualizado.estado ? "Activo" : "Inactivo"));

            if (cambios.Count == 0)
            {
                MessageBox.Show("No se detectaron cambios para registrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string nombre = usuarioEdito.Nombre;
            string apellido = usuarioEdito.Apellido;
            string usuario = $"{nombre} {apellido}";

            string motivo = rch_observacion.Text.Trim();
            //logEquipo.Instancia.ActualizarEquipo(actualizado, usuario, motivo);

            MessageBox.Show("Cambios guardados correctamente y registrados en la bitácora automáticamente.",
                            "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                 "Este equipo tiene una bitácora por edición registrada. ¿Desea dar de baja al equipo?",
                 "Acción restringida",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question
             );

            if (result == DialogResult.Yes)
            {
                // 👉 Acción si el usuario acepta
                //logEquipo.Instancia.dar_baja_equipo(equipo.id_equipo);
                MessageBox.Show("El equipo ha sido dado de baja correctamente.",
                                "Acción completada",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                // ❌ Acción si el usuario cancela
                MessageBox.Show("Operación cancelada. No se realizaron cambios.",
                                "Cancelado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }

        }
        */
    }
}
