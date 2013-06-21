using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Asistencia.Negocio
{
    public class GFeriado
    {
        #region Variables privadas

        private Datos.Feriado DFeriado_;

        #endregion

        #region Metodos publicos

        public System.Int32 Insertar ( System.String descripcion, System.DateTime fecha )
        {
            try
            {
                DFeriado_ = new Datos.Feriado ();
                DFeriado_.descripcion = descripcion;
                DFeriado_.fecha = fecha;
                int i = DFeriado_.Insertar ();
                if ( i < 0 )
                    throw new System.Exception ( "Feriado: Error al insertar. \n" );
                return i;
            }
            catch ( System.Exception ex )
            {
                throw new System.Exception ( "Feriado: Error al insertar. \n" + ex.Message );
            }
        }

        public void Actualizar ( System.Int32 id, System.String descripcion, System.DateTime fecha )
        {
            try
            {
                DFeriado_ = new Datos.Feriado ();
                DFeriado_.id = id;
                DFeriado_.descripcion = descripcion;
                DFeriado_.fecha = fecha;
                ;
                DFeriado_.Actualizar ();
            }
            catch ( System.Exception ex )
            {
                throw new System.Exception ( "Feriado: Error al actualizar. \n" + ex.Message );
            }
        }

        public void Eliminar ( System.Int32 id )
        {
            try
            {
                DFeriado_ = new Datos.Feriado ();
                DFeriado_.id = id;
                DFeriado_.Eliminar ();
            }
            catch ( System.Exception ex )
            {
                throw new System.Exception ( "Feriado: Error al eliminar. \n" + ex.Message );
            }
        }

        public System.Data.DataTable Listar ()
        {
            DFeriado_ = new Datos.Feriado ();
            return DFeriado_.Listar ();
        }

        public System.Data.DataTable Listar ( string condicion, params object[] args )
        {
            try
            {
                DFeriado_ = new Datos.Feriado ();
                return DFeriado_.Listar ( condicion, args );
            }
            catch ( System.Exception ex )
            {
                throw new System.Exception ( "Feriado: Error al listar. \n" + ex.Message );
            }
        }

        public System.Data.DataRow Obtener ( System.Int32 id )
        {
            try
            {
                DFeriado_ = new Datos.Feriado ();
                DFeriado_.id = id;
                return DFeriado_.Obtener ();
            }
            catch ( System.Exception ex )
            {
                throw new System.Exception ( "Feriado: Error al obtener datos. \n" + ex.Message );
            }
        }

        #endregion

    }
}