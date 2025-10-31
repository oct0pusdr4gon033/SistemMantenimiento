using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.ConexionDB
{
    public class ConexionDB
    {
        private static  readonly ConexionDB _instancia= new ConexionDB();
        
        public static ConexionDB Instancia
        {
            get { return ConexionDB._instancia; }
        }

        public SqlConnection Conectar()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = conn.ConnectionString = 
                "Data Source=localhost;" +
                "Initial Catalog=DB_Mantto;" +
                "Integrated Security=True;";
            return conn;

        }




    }
}
