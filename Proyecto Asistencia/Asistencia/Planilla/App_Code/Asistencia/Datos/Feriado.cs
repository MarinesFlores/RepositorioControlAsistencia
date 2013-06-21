using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Asistencia.Datos
{
    public class Feriado
    {

        #region Variables privadas

        private System.Int32 id_;
        private System.String descripcion_;
        private System.DateTime fecha_;

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
        public System.DateTime fecha
        {
            get
            {
                return fecha_;
            }
            set
            {
                fecha_ = value;
            }
        }

        #endregion

        #region Metodos publicos

        public System.Int32 Insertar ()
        {
            if ( Conexion.Conexion.Ejecutar ( "insert into Feriado values(?, ?)", descripcion, fecha ) == 0 )
                return -1;
            System.Data.DataTable t = Conexion.Conexion.Obtener ( "select max(id) from Feriado" );
            return System.Convert.ToInt32 ( t.Rows[0][0] );
        }

        public void Actualizar ()
        {
            Conexion.Conexion.Ejecutar ( "update Feriado set descripcion=?, fecha=? where id=?", descripcion, fecha, id );
        }

        public void Eliminar ()
        {
            Conexion.Conexion.Ejecutar ( "delete from Feriado where id=?", id );
        }

        public System.Data.DataTable Listar ()
        {
            return Listar ( "" );
        }

        public System.Data.DataTable Listar ( string condicion, params object[] args )
        {
            string s = "select * from Feriado " + ( !string.IsNullOrEmpty ( condicion ) ? "where " + condicion : "" );
            return Conexion.Conexion.Obtener ( s, args );
        }

        public System.Data.DataRow Obtener ()
        {
            System.Data.DataTable t = Conexion.Conexion.Obtener ( "select * from Feriado where id=?", id );
            if ( t.Rows.Count > 0 )
            {
                id = System.Convert.ToInt32 ( t.Rows[0][0] );
                descripcion = System.Convert.ToString ( t.Rows[0][1] );
                fecha = System.Convert.ToDateTime ( t.Rows[0][2] );
                return t.Rows[0];
            }
            return null;
        }
        #endregion

    }
}