using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Asistencia.Datos
{
    public class Asistencia
    {
        #region Variables privadas

        private System.Int32 id_;
        private System.DateTime hora_;
        private System.Int32 evento_;
        private System.Int32 tipo_;
        private System.Int32 idEmpleado_;

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

        public System.DateTime hora
        {
            get
            {
                return hora_;
            }
            set
            {
                hora_ = value;
            }
        }

        public System.Int32 evento
        {
            get
            {
                return evento_;
            }
            set
            {
                evento_ = value;
            }
        }

        public System.Int32 tipo
        {
            get
            {
                return tipo_;
            }
            set
            {
                tipo_ = value;
            }
        }

        public System.Int32 idEmpleado
        {
            get
            {
                return idEmpleado_;
            }
            set
            {
                idEmpleado_ = value;
            }
        }

        #endregion

        #region Metodos publicos

        public System.Int32 Insertar ()
        {
            if ( Conexion.Conexion.Ejecutar ( "insert into Asistencia values ( ?, ?, ?, ? ) ", hora, evento, tipo, idEmpleado ) == 0 ) return -1;
            System.Data.DataTable t = Conexion.Conexion.Obtener ( "select max(id) from Asistencia" );

            return System.Convert.ToInt32 ( t.Rows[0][0] );
        }

        public void Actualizar ()
        {
            Conexion.Conexion.Ejecutar ( "update Asistencia set hora=?, evento=?, tipo=?, idEmpleado=? where id=?", hora, evento, tipo, idEmpleado, id );
        }

        public void Eliminar ()
        {
            Conexion.Conexion.Ejecutar ( "delete from Asistencia where id=?", id );
        }

        public System.Data.DataTable Listar ()
        {
            return Listar ( "" );
        }

        public System.Data.DataTable Listar ( string condicion, params object[] args )
        {
            string s = "select * from Asistencia " + ( !string.IsNullOrEmpty ( condicion ) ? "where " + condicion : "" );

            return Conexion.Conexion.Obtener ( s, args );
        }

        public System.Data.DataRow Obtener ()
        {
            System.Data.DataTable t = Conexion.Conexion.Obtener ( "select * from Asistencia where id=?", id );
            if ( t.Rows.Count > 0 )
            {
                id = System.Convert.ToInt32 ( t.Rows[0][0] );
                hora = System.Convert.ToDateTime ( t.Rows[0][1] );
                evento = System.Convert.ToInt32 ( t.Rows[0][2] );
                tipo = System.Convert.ToInt32 ( t.Rows[0][3] );
                idEmpleado = System.Convert.ToInt32 ( t.Rows[0][4] );

                return t.Rows[0];
            }

            return null;
        }

        #endregion

    }
}