using CapaEntidad;
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
    public partial class PlannerMantto : Form
    {
        entUsuarioLogueado usuarioLogueado = null; 

        public PlannerMantto(entUsuarioLogueado usuario)
        {
            InitializeComponent();
            usuarioLogueado = usuario;
        }
    }
}
