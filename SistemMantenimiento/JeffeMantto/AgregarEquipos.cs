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
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
      

        public void LimpiarCampos()
        {
           
          
        }
        private void extraer_areas()
        {
            try
            {
                List<entArea> listaAreas = logArea.Instancia.ObtenerAreas();

                
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

            

            // --- 4. Devolver la lista de errores ---
            return errores;
        }
    }
}
