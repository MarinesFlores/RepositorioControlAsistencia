using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Personal.Negocio
{
    public class GSucursal
    {

        #region Variables privadas

        private Datos.Sucursal DSucursal_;

        #endregion

        #region Metodos publicos

        public System.Int32 Insertar ( System.String descripcion, System.Int32 activo )
        {
            try
            {
                DSucursal_ = new Datos.Sucursal ();
                DSucursal_.descripcion = descripcion;
                DSucursal_.activo = activo;
                int i = DSucursal_.Insertar ();
                if ( i < 0 )
                    throw new System.Exception ( "Sucursal: Error al insertar. \n" );
                return i;
            }
            catch ( System.Exception ex )
            {
                throw new System.Exception ( "Sucursal: Error al insertar. \n" + ex.Message );
            }
        }

        public void Actualizar ( System.Int32 id, System.String descripcion, System.Int32 activo )
        {
            try
            {
                DSucursal_ = new Datos.Sucursal ();
                DSucursal_.id = id;
                DSucursal_.descripcion = descripcion;
                DSucursal_.activo = activo;
                ;
                DSucursal_.Actualizar ();
            }
            catch ( System.Exception ex )
            {
                throw new System.Exception ( "Sucursal: Error al actualizar. \n" + ex.Message );
            }
        }

        public void Eliminar ( System.Int32 id )
        {
            try
            {
                DSucursal_ = new Datos.Sucursal ();
                DSucursal_.id = id;
                DSucursal_.Eliminar ();
            }
            catch ( System.Exception ex )
            {
                throw new System.Exception ( "Sucursal: Error al eliminar. \n" + ex.Message );
            }
        }

        public System.Data.DataTable Listar ()
        {
            DSucursal_ = new Datos.Sucursal ();
            return DSucursal_.Listar ();
        }


        public System.Data.DataTable ListarActivo ()
        {
            DSucursal_ = new Datos.Sucursal ();
            return DSucursal_.Listar ( "" );
        }

        public System.Data.DataTable Listar ( string condicion, params object[] args )
        {
            try
            {
                DSucursal_ = new Datos.Sucursal ();
                return DSucursal_.Listar ( condicion, args );
            }
            catch ( System.Exception ex )
            {
                throw new System.Exception ( "Sucursal: Error al listar. \n" + ex.Message );
            }
        }

        public System.Data.DataRow Obtener ( System.Int32 id )
        {
            try
            {
                DSucursal_ = new Datos.Sucursal ();
                DSucursal_.id = id;
                return DSucursal_.Obtener ();
            }
            catch ( System.Exception ex )
            {
                throw new System.Exception ( "Sucursal: Error al obtener datos. \n" + ex.Message );
            }
        }

        #endregion

        #region SucursalFeriado

        #region Variables privadas

        private Datos.SucursalFeriado DSucursalFeriado;

        #endregion

        #region Metodos publicos

        public System.Int32 InsertarSucursalFeriado ( System.Int32 idSucursal, System.Int32 idFeriado )
        {
            try
            {
                DSucursalFeriado = new Datos.SucursalFeriado ();
                DSucursalFeriado.idSucursal = idSucursal;
                DSucursalFeriado.idFeriado = idFeriado;
                int i = DSucursalFeriado.Insertar ();
                if ( i < 0 )
                    throw new System.Exception ( "SucursalFeriado: Error al insertar. \n" );
                return i;
            }
            catch ( System.Exception ex )
            {
                throw new System.Exception ( "SucursalFeriado: Error al insertar. \n" + ex.Message );
            }
        }

        public void ActualizarSucursalFeriado ( System.Int32 id, System.Int32 idSucursal, System.Int32 idFeriado )
        {
            try
            {
                DSucursalFeriado = new Datos.SucursalFeriado ();
                DSucursalFeriado.id = id;
                DSucursalFeriado.idSucursal = idSucursal;
                DSucursalFeriado.idFeriado = idFeriado;
                ;
                DSucursalFeriado.Actualizar ();
            }
            catch ( System.Exception ex )
            {
                throw new System.Exception ( "SucursalFeriado: Error al actualizar. \n" + ex.Message );
            }
        }

        public void EliminarSucursalFeriado ( System.Int32 id )
        {
            try
            {
                DSucursalFeriado = new Datos.SucursalFeriado ();
                DSucursalFeriado.id = id;
                DSucursalFeriado.Eliminar ();
            }
            catch ( System.Exception ex )
            {
                throw new System.Exception ( "SucursalFeriado: Error al eliminar. \n" + ex.Message );
            }
        }

        public System.Data.DataTable ListarSucursalFeriado ()
        {
            DSucursalFeriado = new Datos.SucursalFeriado ();
            return DSucursalFeriado.Listar ();
        }

        public System.Data.DataTable ListarSucursalFeriado ( string condicion, params object[] args )
        {
            try
            {
                DSucursalFeriado = new Datos.SucursalFeriado ();
                return DSucursalFeriado.Listar ( condicion, args );
            }
            catch ( System.Exception ex )
            {
                throw new System.Exception ( "SucursalFeriado: Error al listar. \n" + ex.Message );
            }
        }

        public System.Data.DataRow ObtenerSucursalFeriado ( System.Int32 id )
        {
            try
            {
                DSucursalFeriado = new Datos.SucursalFeriado ();
                DSucursalFeriado.id = id;
                return DSucursalFeriado.Obtener ();
            }
            catch ( System.Exception ex )
            {
                throw new System.Exception ( "SucursalFeriado: Error al obtener datos. \n" + ex.Message );
            }
        }


        public System.Data.DataTable ListarDeSucursal ( int idSucursal )
        {
            try
            {
                DSucursalFeriado = new Datos.SucursalFeriado ();
                return DSucursalFeriado.ListarDeSucursal ( idSucursal );
            }
            catch ( System.Exception ex )
            {
                throw new System.Exception ( "Sucursal feriado: Error al listar. \n" + ex.Message );
            }
        }

        #endregion

        #endregion
    }
}