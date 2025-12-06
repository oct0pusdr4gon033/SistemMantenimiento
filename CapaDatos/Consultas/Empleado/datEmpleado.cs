using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.ConexionDB;
using CapaEntidad;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad.Empleado;
namespace CapaDatos.Consultas
{
    public class datEmpleado
    {
        private static readonly datEmpleado _instancia = new datEmpleado();
        public static datEmpleado Instancia => _instancia;

        public List<entEmpleado> Listar()
        {
            List<entEmpleado> lista = new List<entEmpleado>();

            using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("sp_ListarEmpleado", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new entEmpleado
                    {
                        id_empleado = Convert.ToInt32(dr["id_empleado"]),
                        dni_empleado = dr["dni_empleado"].ToString(),
                        id_cargo = Convert.ToInt32(dr["id_cargo"]),
                        nombre_empleado = dr["nombre_empleado"].ToString(),
                        apellido_empleado = dr["apellido_empleado"].ToString(),
                        telf = dr["telf"].ToString(),
                        correo = dr["correo"].ToString(),
                    });
                }
            }

            return lista;
        }

        public void Insertar(entEmpleado e)
        {
            using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("sp_InsertarEmpleado", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@dni", e.dni_empleado);
                cmd.Parameters.AddWithValue("@id_cargo", e.id_cargo);
                cmd.Parameters.AddWithValue("@nombre", e.nombre_empleado);
                cmd.Parameters.AddWithValue("@apellido", e.apellido_empleado);
                cmd.Parameters.AddWithValue("@telf", e.telf);
                cmd.Parameters.AddWithValue("@correo", e.correo);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Editar(entEmpleado e)
        {
            using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("sp_EditarEmpleado", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", e.id_empleado);
                cmd.Parameters.AddWithValue("@dni", e.dni_empleado);
                cmd.Parameters.AddWithValue("@id_cargo", e.id_cargo);
                cmd.Parameters.AddWithValue("@nombre", e.nombre_empleado);
                cmd.Parameters.AddWithValue("@apellido", e.apellido_empleado);
                cmd.Parameters.AddWithValue("@telf", e.telf);
                cmd.Parameters.AddWithValue("@correo", e.correo);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

    }
}

