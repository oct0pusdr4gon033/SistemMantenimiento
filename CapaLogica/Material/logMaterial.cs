using System;
using System.Collections.Generic;
using System.Data;
using CapaEntidad.Material;
using CapaDatos.Consultas.Material;

namespace CapaLogica.Material
{
    public class logMaterial
    {
        private static readonly logMaterial _instancia = new logMaterial();
        public static logMaterial Instancia => _instancia;
        private logMaterial() { }

        public List<entMaterial> ListarMateriales()
        {
            try
            {
                return datMaterial.Instancia.ListarMateriales();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar materiales: " + ex.Message);
            }
        }

        public bool RegistrarMaterial(entMaterial material)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(material.CodigoMaterial))
                    throw new ArgumentException("El código del material es obligatorio.");

                if (string.IsNullOrWhiteSpace(material.Nombre))
                    throw new ArgumentException("El nombre del material es obligatorio.");

                if (material.IdCategoria <= 0)
                    throw new ArgumentException("Debe seleccionar una categoría válida.");

                if (material.IdUnidad <= 0)
                    throw new ArgumentException("Debe seleccionar una unidad de medida válida.");

                return datMaterial.Instancia.RegistrarMaterial(material);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar material: " + ex.Message);
            }
        }

        public bool ActualizarMaterial(entMaterial material)
        {
            try
            {
                if (material.IdMaterial <= 0)
                    throw new ArgumentException("El ID del material no es válido.");

                return datMaterial.Instancia.ActualizarMaterial(material);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar material: " + ex.Message);
            }
        }

        public bool EliminarMaterial(int idMaterial)
        {
            try
            {
                if (idMaterial <= 0)
                    throw new ArgumentException("El ID del material no es válido.");

                return datMaterial.Instancia.EliminarMaterial(idMaterial);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar material: " + ex.Message);
            }
        }

        public entMaterial BuscarMaterial(string criterio)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(criterio))
                    throw new ArgumentException("Debe ingresar un criterio de búsqueda.");

                return datMaterial.Instancia.BuscarMaterial(criterio);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar material: " + ex.Message);
            }
        }
        public void DeshabilitarMaterial(int idMaterial)
        {
            try
            {
                datMaterial.Instancia.DeshabilitarMaterial(idMaterial);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al deshabilitar material: " + ex.Message);
            }
        }



        // ================================
        // Métodos adicionales para combos
        // ================================

        public List<entCategoriaMaterial> ListarCategorias()
        {
            try
            {
                return datMaterial.Instancia.ListarCategorias();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar categorías: " + ex.Message);
            }
        }

        public List<entUnidadMedida> ListarUnidades()
        {
            try
            {
                return datMaterial.Instancia.ListarUnidades();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar unidades: " + ex.Message);
            }
        }

        public List<entClasificacionMaterial> ListarClasificaciones()
        {
            try
            {
                return datMaterial.Instancia.ListarClasificaciones();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar clasificaciones: " + ex.Message);
            }
        }
    }
}
