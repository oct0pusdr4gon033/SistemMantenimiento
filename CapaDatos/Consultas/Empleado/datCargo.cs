using CapaDatos.ConexionDB;
using CapaEntidad;
using CapaEntidad.Empleado;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.ConsultasEmpleado
{
    public class datCargo
    {
        private static readonly datCargo _instancia = new datCargo();
        public static datCargo Instancia => _instancia;

        private datCargo() { }

        // LISTAR
        public List<entCargo> Listar()
        {
            List<entCargo> lista = new List<entCargo>();

            try
            {
                using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
                using (SqlCommand cmd = new SqlCommand("sp_ListarCargo", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cn.Open();

                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        lista.Add(new entCargo
                        {
                            id_cargo = Convert.ToInt32(dr["id_cargo"]),
                            nombre_cargo = dr["nombre_cargo"].ToString()
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar cargos: " + ex.Message);
            }

            return lista;
        }

        // INSERTAR
        public bool Insertar(entCargo cargo)
        {
            try
            {
                using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
                using (SqlCommand cmd = new SqlCommand("sp_InsertarCargo", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@nombre_cargo", SqlDbType.VarChar).Value = cargo.nombre_cargo;

                    cn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar cargo: " + ex.Message);
            }
        }

        // EDITAR
        public bool Editar(entCargo cargo)
        {
            try
            {
                using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
                using (SqlCommand cmd = new SqlCommand("sp_EditarCargo", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id_cargo", SqlDbType.Int).Value = cargo.id_cargo;
                    cmd.Parameters.Add("@nombre_cargo", SqlDbType.VarChar).Value = cargo.nombre_cargo;

                    cn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al editar cargo: " + ex.Message);
            }
        }

        // ELIMINAR
        public bool Eliminar(int idCargo)
        {
            try
            {
                using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
                using (SqlCommand cmd = new SqlCommand("sp_EliminarCargo", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id_cargo", SqlDbType.Int).Value = idCargo;

                    cn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar cargo: " + ex.Message);
            }
        }
    }
}
