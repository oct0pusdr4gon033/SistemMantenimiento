using CapaDatos.ConexionDB;
using CapaEntidad;
using CapaEntidad.Usuario;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.ConexionDB;


namespace CapaDatos.Consultas.Usuario
{
    public  class datUsuarioLogueado
    {
        private static readonly datUsuarioLogueado _instancia = new datUsuarioLogueado();

        public static datUsuarioLogueado Instancia
        {
            get { return datUsuarioLogueado._instancia; }
        }

        public entUsuarioLogueado ObtenerDatosUsuario(string dni, int idRol)
        {
            SqlCommand cmd = null;
            entUsuarioLogueado usuario = null;

            try
            {
                using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
                {
                    cmd = new SqlCommand("sp_ObtenerInfoUsuario", cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@dni", dni);
                    cmd.Parameters.AddWithValue("@id_rol", idRol);

                    cn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        usuario = new entUsuarioLogueado()
                        {
                            IdUsuario = Convert.ToInt32(dr["idUsuario"]),
                            Nombre = dr["nombre"].ToString(),
                            Apellido = dr["apellido"].ToString(),
                            Rol = dr["Rol"].ToString()
                        };
                    }
                    dr.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cmd != null) cmd.Dispose();
            }

            return usuario;
        }
    }
}
