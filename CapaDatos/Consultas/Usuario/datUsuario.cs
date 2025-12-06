using CapaDatos.ConexionDB;
using CapaEntidad;

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
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
        public entUsuario Login(string user, string contrasena)
        {
           

            using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("sp_LoginUsuario", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                // Parámetros — nombres deben coincidir EXACTAMENTE con los del SP
                cmd.Parameters.AddWithValue("@username", user);
                cmd.Parameters.AddWithValue("@contrasena", contrasena);

                try
                {
                    cn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        string estado = dr["estado"].ToString();

                        if (estado == "OK")
                        {
                            return new entUsuario()
                            {
                                id_empleado = Convert.ToInt32(dr["id_empleado"]),
                                username = user,
                                rol = dr["rol"].ToString()
                            };
                        }
                    }
                    dr.Close();
                }
                catch (Exception ex)
                {
                    // Nunca hagas "throw ex;" porque pierdes la traza original
                    throw new Exception("Error al intentar iniciar sesión", ex);
                }
            }

            return null;
        }
        #endregion

    }

}
