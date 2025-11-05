using CapaDatos.Consultas.Equipo;
using CapaEntidad.EntLogistica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Consultas.Proveedor
{
    public class datProveedor
    {
        private static readonly datProveedor _instancia = new datProveedor();

        public static datProveedor Instancia
        {
            get { return datProveedor._instancia; }
        }
        
        #region metodos

        
        public List<entProveedor> ListarProveedores()
        {
            List<entProveedor> lista = new List<entProveedor>();
            // Usamos la clase de conexión que ya tienes (asumiendo que también es Singleton)
            using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_ListarProveedores", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        lista.Add(new entProveedor()
                        {
                            ruc = dr["ruc"].ToString(),
                            razon_social = dr["razon_social"].ToString(),
                            tipo_proveedor = dr["tipo_proveedor"].ToString(),
                            telefono = dr["telefono"].ToString(),
                            correo = dr["correo"].ToString(),
                            direccion = dr["direccion"].ToString(),
                            contacto_nombre = dr["contacto_nombre"].ToString(),
                            contacto_telefono = dr["contacto_telefono"].ToString(),
                            dias_credito = Convert.ToInt32(dr["dias_credito"]),
                            activo = Convert.ToBoolean(dr["activo"]),
                            creado_en = Convert.ToDateTime(dr["creado_en"])
                        });
                    }
                }
                catch (Exception ex)
                {
                    // Manejar la excepción (por ejemplo, registrarla)
                    Console.WriteLine("Error al listar proveedores: " + ex.Message);
                    throw ex;
                }
            }
            return lista;
        }

        // Método para Agregar un proveedor
        public bool AgregarProveedor(entProveedor pro)
        {
            bool insertado = false;
            using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_AgregarProveedor", cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ruc", pro.ruc);
                    cmd.Parameters.AddWithValue("@razon_social", pro.razon_social);
                    cmd.Parameters.AddWithValue("@tipo_proveedor", pro.tipo_proveedor);
                    cmd.Parameters.AddWithValue("@telefono", pro.telefono);
                    cmd.Parameters.AddWithValue("@correo", pro.correo);
                    cmd.Parameters.AddWithValue("@direccion", pro.direccion);
                    cmd.Parameters.AddWithValue("@contacto_nombre", pro.contacto_nombre);
                    cmd.Parameters.AddWithValue("@contacto_telefono", pro.contacto_telefono);
                    cmd.Parameters.AddWithValue("@dias_credito", pro.dias_credito);
                    cmd.Parameters.AddWithValue("@activo", pro.activo);

                    cn.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                    {
                        insertado = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al agregar proveedor: " + ex.Message);
                    throw ex;
                }
            }
            return insertado;
        }

        // Método para Editar un proveedor
        public bool EditarProveedor(entProveedor pro)
        {
            bool editado = false;
            using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_EditarProveedor", cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ruc", pro.ruc); // Llave para el WHERE
                    cmd.Parameters.AddWithValue("@razon_social", pro.razon_social);
                    cmd.Parameters.AddWithValue("@tipo_proveedor", pro.tipo_proveedor);
                    cmd.Parameters.AddWithValue("@telefono", pro.telefono);
                    cmd.Parameters.AddWithValue("@correo", pro.correo);
                    cmd.Parameters.AddWithValue("@direccion", pro.direccion);
                    cmd.Parameters.AddWithValue("@contacto_nombre", pro.contacto_nombre);
                    cmd.Parameters.AddWithValue("@contacto_telefono", pro.contacto_telefono);
                    cmd.Parameters.AddWithValue("@dias_credito", pro.dias_credito);
                    cmd.Parameters.AddWithValue("@activo", pro.activo);

                    cn.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                    {
                        editado = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al editar proveedor: " + ex.Message);
                    throw ex;
                }
            }
            return editado;
        }

        // Método para Eliminar (lógicamente) un proveedor
        public bool EliminarProveedor(string ruc)
        {
            bool eliminado = false;
            using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_EliminarProveedor", cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ruc", ruc); // Llave para el WHERE

                    cn.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                    {
                        eliminado = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al eliminar proveedor: " + ex.Message);
                    throw ex;
                }
            }
            return eliminado;
        }

        #endregion metodos
    }
}
