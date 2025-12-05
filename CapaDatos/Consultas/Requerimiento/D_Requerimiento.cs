using CapaEntidad.Requerimiento;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos.Consultas.Requerimiento
{
    public class D_Requerimiento
    {
        // Implementación del patrón Singleton (igual que tu ejemplo)
        private static readonly D_Requerimiento _instancia = new D_Requerimiento();

        public static D_Requerimiento Instancia
        {
            get { return D_Requerimiento._instancia; }
        }

        // Método Registrar con Transacción
        public bool Registrar(EntRequerimiento obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            // Usamos la cadena de conexión de tu clase ConexionDB
            using (SqlConnection oconexion = ConexionDB.ConexionDB.Instancia.Conectar())
            {
                try
                {
                    oconexion.Open();

                    // Iniciamos la transacción: Todo o Nada
                    SqlTransaction transaction = oconexion.BeginTransaction();

                    try
                    {
                        int idReqGenerado = 0;

                        // ---------------------------------------------------
                        // 1. Insertar Cabecera (Tabla Requerimiento_Interno)
                        // ---------------------------------------------------
                        using (SqlCommand cmd = new SqlCommand("sp_RegistrarRequerimiento", oconexion, transaction))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            // Es buena práctica poner el @ delante del nombre del parámetro
                            cmd.Parameters.AddWithValue("@id_empleado", obj.IdEmpleado);
                            cmd.Parameters.AddWithValue("@cod_req", obj.CodReq);

                            // Parámetro de salida para recuperar el ID generado
                            SqlParameter output = new SqlParameter("@resultado", SqlDbType.Int);
                            output.Direction = ParameterDirection.Output;
                            cmd.Parameters.Add(output);

                            cmd.ExecuteNonQuery();
                            idReqGenerado = Convert.ToInt32(output.Value);
                        }

                        // ---------------------------------------------------
                        // 2. Insertar Detalles (Tabla Det_Req_Int)
                        // ---------------------------------------------------
                        foreach (EntDetalleRequerimiento det in obj.ListaDetalles)
                        {
                            using (SqlCommand cmdDet = new SqlCommand("sp_InsertarDetalleRequerimiento", oconexion, transaction))
                            {
                                cmdDet.CommandType = CommandType.StoredProcedure;
                                cmdDet.Parameters.AddWithValue("@id_req", idReqGenerado);
                                cmdDet.Parameters.AddWithValue("@id_producto", det.IdProducto);
                                cmdDet.Parameters.AddWithValue("@stock_solicitado", det.StockSolicitado);
                                cmdDet.ExecuteNonQuery();
                            }
                        }

                        // Si llegamos aquí sin errores, guardamos todo permanentemente
                        transaction.Commit();
                        respuesta = true;
                    }
                    catch (Exception ex)
                    {
                        // Si algo falló en el camino, deshacemos todo
                        transaction.Rollback();
                        respuesta = false;
                        Mensaje = "Error en transacción: " + ex.Message;
                    }
                }
                catch (Exception ex)
                {
                    respuesta = false;
                    Mensaje = "Error de conexión: " + ex.Message;
                }
            }
            return respuesta;
        }
    }
}
