using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Personal.Negocio
{
    public class GAdenda
    {
        #region Variables privadas

        private Datos.Adenda DAdendas_;

        #endregion

        #region Metodos publicos

        public System.Int32 Insertar ( System.DateTime fechaFin, System.Double salario, System.DateTime fecha, System.Int32 idContrato, System.Int32 idTipoContrato, System.Int32 idCronograma, System.Int32 idSucursal, System.Int32 activo )
        {
            try
            {
                DAdendas_ = new Datos.Adenda ();
                DAdendas_.fechaFin = fechaFin;
                DAdendas_.salario = salario;
                DAdendas_.fecha = fecha;
                DAdendas_.idContrato = idContrato;
                DAdendas_.idTipoContrato = idTipoContrato;
                DAdendas_.idCronograma = idCronograma;
                DAdendas_.idSucursal = idSucursal;
                DAdendas_.activo = activo;
                int i = DAdendas_.Insertar ();
                if ( i < 0 )
                    throw new System.Exception ( "Adendas: Error al insertar. \n" );
                return i;
            }
            catch ( System.Exception ex )
            {
                throw new System.Exception ( "Adendas: Error al insertar. \n" + ex.Message );
            }
        }

        public void Actualizar ( System.Int32 id, System.DateTime fechaFin, System.Double salario, System.DateTime fecha, System.Int32 idContrato, System.Int32 idTipoContrato, System.Int32 idCronograma, System.Int32 idSucursal, System.Int32 activo )
        {
            try
            {
                DAdendas_ = new Datos.Adenda ();
                DAdendas_.id = id;
                DAdendas_.fechaFin = fechaFin;
                DAdendas_.salario = salario;
                DAdendas_.fecha = fecha;
                DAdendas_.idContrato = idContrato;
                DAdendas_.idTipoContrato = idTipoContrato;
                DAdendas_.idCronograma = idCronograma;
                DAdendas_.idSucursal = idSucursal;
                DAdendas_.activo = activo;
                ;
                DAdendas_.Actualizar ();
            }
            catch ( System.Exception ex )
            {
                throw new System.Exception ( "Adendas: Error al actualizar. \n" + ex.Message );
            }
        }

        public void Eliminar ( System.Int32 id )
        {
            try
            {
                DAdendas_ = new Datos.Adenda ();
                DAdendas_.id = id;
                DAdendas_.Eliminar ();
            }
            catch ( System.Exception ex )
            {
                throw new System.Exception ( "Adendas: Error al eliminar. \n" + ex.Message );
            }
        }

        public System.Data.DataTable Listar ()
        {
            DAdendas_ = new Datos.Adenda ();
            return DAdendas_.Listar ();
        }

        public System.Data.DataTable Listar ( string condicion, params object[] args )
        {
            try
            {
                DAdendas_ = new Datos.Adenda ();
                return DAdendas_.Listar ( condicion, args );
            }
            catch ( System.Exception ex )
            {
                throw new System.Exception ( "Adendas: Error al listar. \n" + ex.Message );
            }
        }

        public System.Data.DataRow Obtener ( System.Int32 id )
        {
            try
            {
                DAdendas_ = new Datos.Adenda ();
                DAdendas_.id = id;
                return DAdendas_.Obtener ();
            }
            catch ( System.Exception ex )
            {
                throw new System.Exception ( "Adendas: Error al obtener datos. \n" + ex.Message );
            }
        }


        public System.Data.DataTable ListarDeAdenadas ( int idContrato )
        {
            try
            {
                DAdendas_ = new Datos.Adenda ();
                return DAdendas_.ListarDeAdendas ( idContrato );
            }
            catch ( System.Exception ex )
            {
                throw new System.Exception ( "Adendas: Error al listar. \n" + ex.Message );
            }
        }

        #endregion

    }
}