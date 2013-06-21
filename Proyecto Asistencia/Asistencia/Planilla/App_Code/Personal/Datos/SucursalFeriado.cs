using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Personal.Datos
{
    public class SucursalFeriado
    {

        #region Variables privadas

        private System.Int32 id_;
        private System.Int32 idSucursal_;
        private System.Int32 idFeriado_;

        #endregion

        #region Propiedades publicas

        public System.Int32 id
        {
            get
            {
                return id_;
            }
            set
            {
                id_ = value;
            }
        }
        public System.Int32 idSucursal
        {
            get
            {
                return idSucursal_;
            }
            set
            {
                idSucursal_ = value;
            }
        }
        public System.Int32 idFeriado
        {
            get
            {
                return idFeriado_;
            }
            set
            {
                idFeriado_ = value;
            }
        }

        #endregion

        #region Metodos publicos

        public System.Int32 Insertar ()
        {
            if ( Conexion.Conexion.Ejecutar ( "insert into SucursalFeriado values(?, ?)", idSucursal, idFeriado ) == 0 )
                return -1;
            System.Data.DataTable t = Conexion.Conexion.Obtener ( "select max(id) from SucursalFeriado" );
            return System.Convert.ToInt32 ( t.Rows[0][0] );
        }

        public void Actualizar ()
        {
            Conexion.Conexion.Ejecutar ( "update SucursalFeriado set idSucursal=?, idFeriado=? where id=?", idSucursal, idFeriado, id );
        }

        public void Eliminar ()
        {
            Conexion.Conexion.Ejecutar ( "delete from SucursalFeriado where id=?", id );
        }

        public System.Data.DataTable Listar ()
        {
            return Listar ( "" );
        }

        public System.Data.DataTable Listar ( string condicion, params object[] args )
        {
            string s = "select * from SucursalFeriado " + ( !string.IsNullOrEmpty ( condicion ) ? " where " + condicion : "" );
            return Conexion.Conexion.Obtener ( s, args );
        }

        public System.Data.DataRow Obtener ()
        {
            System.Data.DataTable t = Conexion.Conexion.Obtener ( "select * from SucursalFeriado where id=?", id );
            if ( t.Rows.Count > 0 )
            {
                id = System.Convert.ToInt32 ( t.Rows[0][0] );
                idSucursal = System.Convert.ToInt32 ( t.Rows[0][1] );
                idFeriado = System.Convert.ToInt32 ( t.Rows[0][2] );
                return t.Rows[0];
            }
            return null;
        }


        public System.Data.DataTable ListarDeSucursal ( int idSucursal )
        {
            string s = "select DSucursalFeriado.*, NFeriado_.descripcion as feriado , NFeriado_.fecha from SucursalFeriado  DSucursalFeriado inner join feriado NFeriado_ on DSucursalFeriado.idFeriado =NFeriado_.id where DSucursalFeriado.idSucursal=? ";
            return Conexion.Conexion.Obtener ( s, idSucursal );
        }

        #endregion

    }
}