using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad.Usuario;
using SistemMantenimiento.JefeLogi;
using SistemMantenimiento.JefeLogi.Proveedores;


namespace SistemMantenimiento
{
    internal static class Program
    {

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
           

            // =========================================================
            // PASO 1: SIMULAMOS UN USUARIO LOGUEADO PARA PRUEBAS
            // =========================================================
            // (Usamos las clases que me mostraste)
            entUsuarioLogueado usuarioDePrueba = new entUsuarioLogueado
            {
                IdUsuario = 1,
                Nombre = "Usuario",
                Apellido = "De Prueba",
                Rol = "Jefe de Mantenimiento" // O el rol que necesites probar
            };




            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmProveedor  ());
        }
    }
}
