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
    public partial class Horometros : Form
    {
        private entEquipo equipo_selecionado; 
        public Horometros(entEquipo equipo)
        {
            InitializeComponent();
            equipo_selecionado = equipo;
        }
        public Horometros()
        {
            InitializeComponent();
            this.equipo_selecionado = null;
        }
    }
}
