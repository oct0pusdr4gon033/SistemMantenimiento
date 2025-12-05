using CapaEntidad.Equipo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Consultas.Equipo
{
    public class datPM
    {
        private static readonly datPM _instancia = new datPM();

        public static datPM Instancia
        {
            get { return datPM._instancia; }

        }

        #region metodos

        public entPM InsertarPM(entPM pm)
        {
            try
            {
                using (SqlConnection conn = ConexionDB.ConexionDB.Instancia.Conectar())
                {
                    using (SqlCommand cmd= new SqlCommand ("sp_InsertarPM",conn))
                    {

                    }
                }
            }catch(Exception ex)
            {
                throw ex; 
            }
        }

        #endregion
    }

}
