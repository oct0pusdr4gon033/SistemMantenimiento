using CapaEntidad.Equipo;
using System;
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
    public partial class VerHistorialMantto : Form
    {
        private entEquipo _equipo;

        public VerHistorialMantto(entEquipo equipo)
        {
            InitializeComponent();
            _equipo = equipo;
           
           
        }
        public VerHistorialMantto()
        {
            InitializeComponent();
            this._equipo = null;
        }
    }
}
