using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Personal.Negocio
{
    public class GTipoContrato
    {
 #region Variables privadas

        private Datos.TipoContrato DTipoContrato_;

        #endregion

        #region Metodos publicos

        public System.Int32 Insertar ( System.String descripcion, System.Int32 activo )
        {
            try
            {
                DTipoContrato_ = new Datos.TipoContrato ();
                DTipoContrato_.descripcion = descripcion;
                DTipoContrato_.activo = activo;
                int i = DTipoContrato_.Insertar ();
                if ( i < 0 )
                    throw new System.Exception ( "TipoContrato: Error al insertar. \n" );
                return i;
            }
            catch ( System.Exception ex )
            {
                throw new System.Exception ( "TipoContrato: Error al insertar. \n" + ex.Message );
            }
        }

        public void Actualizar ( System.Int32 id, System.String descripcion, System.Int32 activo )
        {
            try
            {
                DTipoContrato_ = new Datos.TipoContrato ();
                DTipoContrato_.id = id;
                DTipoContrato_.descripcion = descripcion;
                DTipoContrato_.activo = activo;
                ;
                DTipoContrato_.Actualizar ();
            }
            catch ( System.Exception ex )
            {
                throw new System.Exception ( "TipoContrato: Error al actualizar. \n" + ex.Message );
            }
        }

        public void Eliminar ( System.Int32 id )
        {
            try
            {
                DTipoContrato_ = new Datos.TipoContrato ();
                DTipoContrato_.id = id;
                DTipoContrato_.Eliminar ();
            }
            catch ( System.Exception ex )
            {
                throw new System.Exception ( "TipoContrato: Error al eliminar. \n" + ex.Message );
            }
        }

        public System.Data.DataTable Listar ()
        {
            DTipoContrato_ = new Datos.TipoContrato ();
            return DTipoContrato_.Listar ();
        }

        public System.Data.DataTable ListarActivo ()
        {
            DTipoContrato_ = new Datos.TipoContrato ();
            return DTipoContrato_.ListarActivos ( "" );
        }


        public System.Data.DataTable Listar ( string condicion, params object[] args )
        {
            try
            {
                DTipoContrato_ = new Datos.TipoContrato ();
                return DTipoContrato_.Listar ( condicion, args );
            }
            catch ( System.Exception ex )
            {
                throw new System.Exception ( "TipoContrato: Error al listar. \n" + ex.Message );
            }
        }

        public System.Data.DataRow Obtener ( System.Int32 id )
        {
            try
            {
                DTipoContrato_ = new Datos.TipoContrato ();
                DTipoContrato_.id = id;
                return DTipoContrato_.Obtener ();
            }
            catch ( System.Exception ex )
            {
                throw new System.Exception ( "TipoContrato: Error al obtener datos. \n" + ex.Message );
            }
        }

        #endregion
    }
}