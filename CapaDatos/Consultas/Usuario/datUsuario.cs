using CapaDatos.ConexionDB;
using CapaEntidad;
using CapaEntidad; 
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Consultas.Usuario
{
    public class datUsuario
    {
        private static readonly datUsuario _instancia = new datUsuario();

        public static datUsuario Instancia
        {
            get { return datUsuario._instancia; }
        }

        #region metodos 
        /////////////////////////login
        public bool Login(entUsuario usuario)
        {
            bool logea = false;

            using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("sp_Login", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                // Parámetros — nombres deben coincidir EXACTAMENTE con los del SP
                cmd.Parameters.AddWithValue("@dni", usuario.dni);
                cmd.Parameters.AddWithValue("@hash", usuario.password);
                cmd.Parameters.AddWithValue("@id_rol", usuario.id_rol);

                try
                {
                    cn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        // Si el SP devuelve un registro, el usuario existe
                        logea = true;
                    }
                    dr.Close();
                }
                catch (Exception ex)
                {
                    // Nunca hagas "throw ex;" porque pierdes la traza original
                    throw new Exception("Error al intentar iniciar sesión", ex);
                }
            }

            return logea;
        }
        #endregion

    }

}
