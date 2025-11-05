using CapaDatos.Consultas.Proveedor;
using CapaEntidad.EntLogistica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Proveedor
{
    public class logProveedor
    {
        private static readonly logProveedor _instancia = new logProveedor();

        public static logProveedor Instancia
        {
            get { return logProveedor._instancia; }
        }

        #region Metodos

        // Método que tu formulario llamará para mostrar datos en un DataGridView
        public List<entProveedor> ListarProveedores()
        {
            try
            {
                // Llamamos a la instancia de datProveedor
                return datProveedor.Instancia.ListarProveedores();
            }
            catch (Exception ex)
            {
                // Manejo de excepción (igual que logEquipo)
                throw new Exception("Error en la capa lógica al listar proveedores.", ex);
            }
        }

        // Método que tu botón "Guardar" (para nuevo) llamará
        public bool AgregarProveedor(entProveedor pro)
        {
            // --- REGLAS DE NEGOCIO (Validaciones) ---
            if (string.IsNullOrEmpty(pro.ruc))
            {
                throw new ArgumentException("El RUC no puede estar vacío.");
            }
            if (pro.ruc.Length != 11) // Ejemplo de regla
            {
                throw new ArgumentException("El RUC debe tener 11 dígitos.");
            }
            if (string.IsNullOrEmpty(pro.razon_social))
            {
                throw new ArgumentException("La Razón Social no puede estar vacía.");
            }
            // ... más validaciones ...

            // Si pasa las validaciones, llama a la capa de datos
            try
            {
                return datProveedor.Instancia.AgregarProveedor(pro);
            }
            catch (Exception ex)
            {
                // Manejo de excepción (igual que logEquipo)
                throw new Exception("Error en la capa lógica al agregar proveedor.", ex);
            }
        }

        // Método que tu botón "Guardar" (para editar) llamará
        public bool EditarProveedor(entProveedor pro)
        {
            // --- REGLAS DE NEGOCIO (Validaciones) ---
            if (string.IsNullOrEmpty(pro.ruc))
            {
                throw new ArgumentException("El RUC es necesario para editar.");
            }
            if (string.IsNullOrEmpty(pro.razon_social))
            {
                throw new ArgumentException("La Razón Social no puede estar vacía.");
            }
            // ... más validaciones ...

            try
            {
                return datProveedor.Instancia.EditarProveedor(pro);
            }
            catch (Exception ex)
            {
                // Manejo de excepción (igual que logEquipo)
                throw new Exception("Error en la capa lógica al editar proveedor.", ex);
            }
        }

        // Método que tu botón "Eliminar" llamará
        public bool EliminarProveedor(string ruc)
        {
            // --- REGLAS DE NEGOCIO ---
            if (string.IsNullOrEmpty(ruc))
            {
                throw new ArgumentException("Se necesita el RUC para eliminar.");
            }

            try
            {
                return datProveedor.Instancia.EliminarProveedor(ruc);
            }
            catch (Exception ex)
            {
                // Manejo de excepción (igual que logEquipo)
                throw new Exception("Error en la capa lógica al eliminar proveedor.", ex);
            }
        }

        #endregion Metodos
    }
}
