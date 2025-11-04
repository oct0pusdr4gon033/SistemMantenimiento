using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemMantenimiento.JefeLogi.Proveedores
{
    public partial class AgregarPro : Form
    {
        public AgregarPro()
        {
            InitializeComponent();
        }

        private void lbl_titulo_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AgregarPro_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'mantenimientoDBDataSet.Proveedor' Puede moverla o quitarla según sea necesario.
            this.proveedorTableAdapter.Fill(this.mantenimientoDBDataSet.Proveedor);

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
