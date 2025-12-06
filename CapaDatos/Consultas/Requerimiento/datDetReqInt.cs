using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad.Requerimiento;
using CapaDatos.ConexionDB;

namespace CapaDatos.Consultas.Requerimiento
{
    public class datDetReqInt
    {
        private static readonly datDetReqInt _instancia = new datDetReqInt();
        public static datDetReqInt Instancia => _instancia;

        // INSERTAR DETALLE
        public bool InsertarDetalle(entDetReqInt det)
        {
            try
            {
                using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
                using (SqlCommand cmd = new SqlCommand("sp_InsertarDetalleReqInterno", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_req", det.id_requerimiento);
                    cmd.Parameters.AddWithValue("@id_producto", det.id_material);
                    cmd.Parameters.AddWithValue("@cantidad", det.cantidad);

                    cn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar detalle: " + ex.Message);
            }
        }

        // LISTAR DETALLES POR REQUERIMIENTO
        public List<entDetReqInt> ListarDetallesPorRequerimiento(int idReq)
        {
            List<entDetReqInt> lista = new List<entDetReqInt>();

            using (SqlConnection cn = ConexionDB.ConexionDB.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("sp_ListarDetalleReqInterno", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_req", idReq);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new entDetReqInt
                    {
                        id_detalle = Convert.ToInt32(dr["id_det_req"]),
                        id_requerimiento = Convert.ToInt32(dr["id_req"]),
                        id_material = Convert.ToInt32(dr["id_producto"]),
                        cantidad = Convert.ToDecimal(dr["stock_solicitado"]),
                        nombre_material = dr["nombre"].ToString(),
                        unidad_abreviatura = dr["abreviatura"].ToString()
                    });
                }
            }

            return lista;
        }

    }
}
