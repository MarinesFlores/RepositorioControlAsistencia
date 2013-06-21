using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Personal.Datos
{
    public class Sucursal
    {

        #region Variables privadas

        private System.Int32 id_;
        private System.String descripcion_;
        private System.Int32 activo_;

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
        public System.String descripcion
        {
            get
            {
                return descripcion_.Trim ();
            }
            set
            {
                descripcion_ = value;
            }
        }
        public System.Int32 activo
        {
            get
            {
                return activo_;
            }
            set
            {
                activo_ = value;
            }
        }

        #endregion

        #region Metodos publicos

        public System.Int32 Insertar ()
        {
            if ( Conexion.Conexion.Ejecutar ( "insert into Sucursal values(?, ?)", descripcion, activo ) == 0 )
                return -1;
            System.Data.DataTable t = Conexion.Conexion.Obtener ( "select max(id) from Sucursal" );
            return System.Convert.ToInt32 ( t.Rows[0][0] );
        }

        public void Actualizar ()
        {
            Conexion.Conexion.Ejecutar ( "update Sucursal set descripcion=?, activo=? where id=?", descripcion, activo, id );
        }

        public void Eliminar ()
        {
            Conexion.Conexion.Ejecutar ( "update sucursal set activo=0 where id=?", id );
        }

        public System.Data.DataTable Listar ()
        {
            return Listar ( "" );
        }

        public System.Data.DataTable Listar ( string condicion, params object[] args )
        {
            string s = "select * from Sucursal " + ( !string.IsNullOrEmpty ( condicion ) ? "where " + condicion : "" );
            return Conexion.Conexion.Obtener ( s, args );
        }

        public System.Data.DataRow Obtener ()
        {
            System.Data.DataTable t = Conexion.Conexion.Obtener ( "select * from Sucursal where id=?", id );
            if ( t.Rows.Count > 0 )
            {
                id = System.Convert.ToInt32 ( t.Rows[0][0] );
                descripcion = System.Convert.ToString ( t.Rows[0][1] );
                activo = System.Convert.ToInt32 ( t.Rows[0][2] );
                return t.Rows[0];
            }
            return null;
        }

        public System.Data.DataTable ListarActivos ( string condicion, params object[] args )
        {
            string s = "select * from Sucursal where activo=1" + ( !string.IsNullOrEmpty ( condicion ) ? "where " + condicion : "" );
            return Conexion.Conexion.Obtener ( s, args );
        }

        #endregion

    }
}
