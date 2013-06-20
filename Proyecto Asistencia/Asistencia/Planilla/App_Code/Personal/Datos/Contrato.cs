using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Personal.Datos
{
    public class Contrato
    {

        #region Variables privadas

        private System.Int32 id_;
        private System.DateTime fecha_;
        private System.DateTime fechaIni_;
        private System.Int32 vigente_;
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
        public System.DateTime fechaIni
        {
            get
            {
                return fechaIni_;
            }
            set
            {
                fechaIni_ = value;
            }
        }
        public System.Int32 vigente
        {
            get
            {
                return vigente_;
            }
            set
            {
                vigente_ = value;
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
            if ( Conexion.Conexion.Ejecutar ( "insert into Contrato values(?, ?, ?, ?)", fecha, fechaIni, vigente, idEmpleado ) == 0 )
                return -1;
            System.Data.DataTable t = Conexion.Conexion.Obtener ( "select max(id) from Contrato" );
            return System.Convert.ToInt32 ( t.Rows[0][0] );
        }

        public void Actualizar ()
        {
            Conexion.Conexion.Ejecutar ( "update Contrato set fecha=?, fechaIni=?, vigente=?, idEmpleado=? where id=?", fecha, fechaIni, vigente, idEmpleado, id );
        }

        public void Eliminar ()
        {
            Conexion.Conexion.Ejecutar ( "delete from Contrato where id=?", id );
        }

        public System.Data.DataTable Listar ( int idL )
        {
            string s = "select *from contrato where idEmpleado=? ";
            return Conexion.Conexion.Obtener ( s, idL );
        }


        //public System.Data.DataTable Listar()
        //{
        //    return Listar("");
        //}

        public System.Data.DataTable Listar ( string condicion, params object[] args )
        {
            string s = "select * from Contrato " + ( !string.IsNullOrEmpty ( condicion ) ? "where " + condicion : "" );
            return Conexion.Conexion.Obtener ( s, args );
        }

        public System.Data.DataRow Obtener ()
        {
            System.Data.DataTable t = Conexion.Conexion.Obtener ( "select * from Contrato where id=?", id );
            if ( t.Rows.Count > 0 )
            {
                id = System.Convert.ToInt32 ( t.Rows[0][0] );
                fecha = System.Convert.ToDateTime ( t.Rows[0][1] );
                fechaIni = System.Convert.ToDateTime ( t.Rows[0][2] );
                vigente = System.Convert.ToInt32 ( t.Rows[0][3] );
                idEmpleado = System.Convert.ToInt32 ( t.Rows[0][4] );
                return t.Rows[0];
            }
            return null;
        }

        #endregion

    }
}