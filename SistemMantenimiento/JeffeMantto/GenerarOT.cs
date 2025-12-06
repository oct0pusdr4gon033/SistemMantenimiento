using CapaEntidad;
using CapaEntidad.Equipo;
using CapaEntidad.Usuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemMantenimiento
{
    public partial class GenerarOT : Form
    {
        public GenerarOT(entEquipo equipoOT,entUsuarioLogueado usiaroLog )
        {
            InitializeComponent();
        }

        public GenerarOT () 
        {
            InitializeComponent();
        }

        private void cargarDatosEquipo(entEquipo equipoOT)
        {
            // Cargar los datos del equipo en los controles del formulario
            //txb_id_equipo.Text=equipoOT.id_equipo.ToString();

        }
    }
}
