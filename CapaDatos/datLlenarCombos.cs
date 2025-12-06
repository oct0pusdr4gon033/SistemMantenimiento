using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datLlenarCombos
    {
        private static readonly datLlenarCombos _instancia = new datLlenarCombos();
        public static datLlenarCombos Instancia
        {
            get { return datLlenarCombos._instancia; }
        }


        #region metodos

        ///Combos de Area_Equipo
        public List<entCombo> LLenarComboArea()
        {
            List<entCombo> lista = new List<entCombo>();
            try
            {
                using (SqlConnection conn = ConexionDB.ConexionDB.Instancia.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_ListarAreas", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                entCombo combo = new entCombo()
                                {
                                    id_combo = Convert.ToInt32(reader["id_area"]),
                                    nombre_combo = reader["nombre_area"].ToString()
                                };
                                lista.Add(combo);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al llenar el combo de áreas de equipo.", ex);
            }
            return lista;
        }

        ///Combo de Tipo_Equipo
        public List<entCombo> LLenarComboTipo()
        {
            List<entCombo> lista = new List<entCombo>();
            try
            {
                using (SqlConnection conn = ConexionDB.ConexionDB.Instancia.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_ListarTipoEquipo", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                entCombo combo = new entCombo()
                                {
                                    id_combo = Convert.ToInt32(reader["id_tipo_equipo"]),
                                    nombre_combo = reader["nombre_tipo_equipo"].ToString()
                                };
                                lista.Add(combo);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al llenar el combo de áreas de equipo.", ex);
            }
            return lista;
        }

        ///Combo de Modelo_Equipo

        public List<entCombo> LLenarComboModelo()
        {
            List<entCombo> lista = new List<entCombo>();
            try
            {
                using (SqlConnection conn = ConexionDB.ConexionDB.Instancia.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_ListarModeloEquipoCombo", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                entCombo combo = new entCombo()
                                {
                                    id_combo = Convert.ToInt32(reader["id_modelo_equipo"]),
                                    nombre_combo = reader["nombre_modelo"].ToString()
                                };
                                lista.Add(combo);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al llenar el combo de áreas de equipo.", ex);
            }
            return lista;
        }

        ///LLenar Combo Marca_Equipo
        public List<entCombo> LLenarComboMarca()
        {
            List<entCombo> lista = new List<entCombo>();
            try
            {
                using (SqlConnection conn = ConexionDB.ConexionDB.Instancia.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_ListarMarcasEquipo", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                entCombo combo = new entCombo()
                                {
                                    id_combo = Convert.ToInt32(reader["id_marca"]),
                                    nombre_combo = reader["nombre_marca"].ToString()
                                };
                                lista.Add(combo);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al llenar el combo de áreas de equipo.", ex);
            }
            return lista;
        }


        #endregion

    }
}
