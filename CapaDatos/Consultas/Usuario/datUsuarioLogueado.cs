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

        public entUsuarioLogueado login(string usuario, string contrasena)
        {
            entUsuarioLogueado entidad = null;

            using (SqlConnection conn =ConexionDB.ConexionDB.Instancia.Conectar() )
            using (SqlCommand cmd = new SqlCommand("sp_InfoUsuario", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", usuario);
                cmd.Parameters.AddWithValue("@contrasena", contrasena);

                conn.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        entidad = new entUsuarioLogueado
                        {
                            IdUsuario = dr.GetInt32(dr.GetOrdinal("IdUsuario")),
                            Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
                            Apellido = dr.GetString(dr.GetOrdinal("Apellido")),
                            Rol = dr.GetString(dr.GetOrdinal("Rol"))
                        };
                    }
                }
            }
            return entidad;
        }
    }
}
