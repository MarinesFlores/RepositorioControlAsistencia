using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Personal.Negocio
{
    public class GContrato
    {

        #region Variables privadas

        private Datos.Contrato c;

        #endregion

        #region Metodos publicos

        public System.Int32 Insertar ( System.DateTime fecha, System.DateTime fechaIni, System.Int32 vigente, System.Int32 idEmpleado )
        {
            try
            {
                c = new Datos.Contrato ();
                c.fecha = fecha;
                c.fechaIni = fechaIni;
                c.vigente = vigente;
                c.idEmpleado = idEmpleado;
                int i = c.Insertar ();
                if ( i < 0 )
                    throw new System.Exception ( "Contrato: Error al insertar. \n" );
                return i;
            }
            catch ( System.Exception ex )
            {
                throw new System.Exception ( "Contrato: Error al insertar. \n" + ex.Message );
            }
        }

        public void Actualizar ( System.Int32 id, System.DateTime fecha, System.DateTime fechaIni, System.Int32 vigente, System.Int32 idEmpleado )
        {
            try
            {
                c = new Datos.Contrato ();
                c.id = id;
                c.fecha = fecha;
                c.fechaIni = fechaIni;
                c.vigente = vigente;
                c.idEmpleado = idEmpleado;
                ;
                c.Actualizar ();
            }
            catch ( System.Exception ex )
            {
                throw new System.Exception ( "Contrato: Error al actualizar. \n" + ex.Message );
            }
        }

        public void Eliminar ( System.Int32 id )
        {
            try
            {
                c = new Datos.Contrato ();
                c.id = id;
                c.Eliminar ();
            }
            catch ( System.Exception ex )
            {
                throw new System.Exception ( "Contrato: Error al eliminar. \n" + ex.Message );
            }
        }

        public System.Data.DataTable Listar ( int id )
        {
            c = new Datos.Contrato ();
            return c.Listar ( id );
        }

        public System.Data.DataTable Listar ( string condicion, params object[] args )
        {
            try
            {
                c = new Datos.Contrato ();
                return c.Listar ( condicion, args );
            }
            catch ( System.Exception ex )
            {
                throw new System.Exception ( "Contrato: Error al listar. \n" + ex.Message );
            }
        }

        public System.Data.DataRow Obtener ( System.Int32 id )
        {
            try
            {
                c = new Datos.Contrato ();
                c.id = id;
                return c.Obtener ();
            }
            catch ( System.Exception ex )
            {
                throw new System.Exception ( "Contrato: Error al obtener datos. \n" + ex.Message );
            }
        }

        #endregion

    }
}