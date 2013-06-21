using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Personal.Datos
{
    public class Adenda
    {


        #region Variables privadas

        private System.Int32 id_;
        private System.DateTime fechaFin_;
        private System.Double salario_;
        private System.DateTime fecha_;
        private System.Int32 idContrato_;

        private System.Int32 idTipoContrato_;
        private System.Int32 idCronograma_;
        private System.Int32 idSucursal_;
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
        public System.DateTime fechaFin
        {
            get
            {
                return fechaFin_;
            }
            set
            {
                fechaFin_ = value;
            }
        }
        public System.Double salario
        {
            get
            {
                return salario_;
            }
            set
            {
                salario_ = value;
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
        public System.Int32 idContrato
        {
            get
            {
                return idContrato_;
            }
            set
            {
                idContrato_ = value;
            }
        }

        public System.Int32 idTipoContrato
        {
            get
            {
                return idTipoContrato_;
            }
            set
            {
                idTipoContrato_ = value;
            }
        }
        public System.Int32 idCronograma
        {
            get
            {
                return idCronograma_;
            }
            set
            {
                idCronograma_ = value;
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
            if ( Conexion.Conexion.Ejecutar ( "insert into Adendas values(?, ?, ?, ?, ?, ?, ?, ?)", fechaFin, salario, fecha, idContrato, idTipoContrato, idCronograma, idSucursal, activo ) == 0 )
                return -1;
            System.Data.DataTable t = Conexion.Conexion.Obtener ( "select max(id) from Adendas" );
            Conexion.Conexion.Ejecutar ( "update Adendas set activo=0 where id<>? and  idContrato=?", System.Convert.ToInt32 ( t.Rows[0][0] ), idContrato );

            return System.Convert.ToInt32 ( t.Rows[0][0] );
        }

        public void Actualizar ()
        {
            Conexion.Conexion.Ejecutar ( "update Adendas set fechaFin=?, salario=?, fecha=?, idContrato=?, idTipoContrato=?, idCronograma=?, idSucursal=?, activo=? where id=?", fechaFin, salario, fecha, idContrato, idTipoContrato, idCronograma, idSucursal, activo, id );
        }

        public void Eliminar ()
        {
            Conexion.Conexion.Ejecutar ( "delete from Adendas where id=?", id );
        }

        public System.Data.DataTable Listar ()
        {
            return Listar ( "" );
        }

        public System.Data.DataTable Listar ( string condicion, params object[] args )
        {
            string s = "select * from Adendas " + ( !string.IsNullOrEmpty ( condicion ) ? "where " + condicion : "" );
            return Conexion.Conexion.Obtener ( s, args );
        }

        public System.Data.DataRow Obtener ()
        {
            System.Data.DataTable t = Conexion.Conexion.Obtener ( "select * from Adendas where id=?", id );
            if ( t.Rows.Count > 0 )
            {
                id = System.Convert.ToInt32 ( t.Rows[0][0] );
                fechaFin = System.Convert.ToDateTime ( t.Rows[0][1] );
                salario = System.Convert.ToDouble ( t.Rows[0][2] );
                fecha = System.Convert.ToDateTime ( t.Rows[0][3] );
                idContrato = System.Convert.ToInt32 ( t.Rows[0][4] );
                idTipoContrato = System.Convert.ToInt32 ( t.Rows[0][5] );
                idCronograma = System.Convert.ToInt32 ( t.Rows[0][6] );
                idSucursal = System.Convert.ToInt32 ( t.Rows[0][7] );
                activo = System.Convert.ToInt32 ( t.Rows[0][8] );
                return t.Rows[0];
            }
            return null;
        }



        public System.Data.DataTable ListarDeAdendas ( int idContrato )
        {
            string s = "select DAsistencia_.*, NTipoContrato_.descripcion as tipoContrato, DSucursal_.descripcion as sucursal, NCronograma_.descripcion as cronograma from adendas DAsistencia_, tipoContrato NTipoContrato_, sucursal DSucursal_, cronograma NCronograma_ where DAsistencia_.idTipoContrato=NTipoContrato_.id and DAsistencia_.idSucursal=DSucursal_.id and NCronograma_.id= DAsistencia_.idCronograma and DAsistencia_.idContrato=? ";
            return Conexion.Conexion.Obtener ( s, idContrato );
        }

        #endregion

    }
}