using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos; 

namespace CapaLogica
{
    public class logLlenarCombos
    {
        private static readonly logLlenarCombos _instancia = new logLlenarCombos();
        public static logLlenarCombos Instancia
        {
            get { return logLlenarCombos._instancia; }
        }

        #region metodos
        ///Combos de Area_Equipo

        public List<entCombo> LLenarComboArea()
        {
            try
            {
                return CapaDatos.datLlenarCombos.Instancia.LLenarComboArea();

            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }

        ///Combo de Tipo_Equipo

        public List<entCombo> LLenarComboTipo()
        {
            try
            {
                return datLlenarCombos.Instancia.LLenarComboTipo();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        ///Combo de Modelo_Equipo
        
        public List<entCombo> LLenarComboModelo()
        {
            try
            {
                return CapaDatos.datLlenarCombos.Instancia.LLenarComboModelo();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List <entCombo> LlenarComboMarca()
        {
            try
            {
                return CapaDatos.datLlenarCombos.Instancia.LLenarComboMarca();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

    }
}
