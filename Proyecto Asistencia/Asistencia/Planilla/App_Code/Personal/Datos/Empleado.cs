using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Personal.Datos
{
    public class Empleado
    {
        #region Variables privadas

        private System.Int32 id_;
        private System.String ci_;
        private System.String nombre_;
        private System.String APaterno_;
        private System.String AMaterno_;
        private System.DateTime fechaNac_;
        private System.String Genero_;
        private System.String estadoCivil_;
        private System.String profesion_;
        private System.String nacionalidad_;
        private System.String telefono1_;
        private System.String telefenoInterno_;
        private System.String direccion_;
        private System.String nroAsegurado_;
        private System.String NUA_;
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
        public System.String ci
        {
            get
            {
                return ci_.Trim ();
            }
            set
            {
                ci_ = value;
            }
        }
        public System.String nombre
        {
            get
            {
                return nombre_.Trim ();
            }
            set
            {
                nombre_ = value;
            }
        }
        public System.String APaterno
        {
            get
            {
                return APaterno_.Trim ();
            }
            set
            {
                APaterno_ = value;
            }
        }
        public System.String AMaterno
        {
            get
            {
                return AMaterno_.Trim ();
            }
            set
            {
                AMaterno_ = value;
            }
        }
        public System.DateTime fechaNac
        {
            get
            {
                return fechaNac_;
            }
            set
            {
                fechaNac_ = value;
            }
        }
        public System.String Genero
        {
            get
            {
                return Genero_.Trim ();
            }
            set
            {
                Genero_ = value;
            }
        }
        public System.String estadoCivil
        {
            get
            {
                return estadoCivil_.Trim ();
            }
            set
            {
                estadoCivil_ = value;
            }
        }
        public System.String profesion
        {
            get
            {
                return profesion_.Trim ();
            }
            set
            {
                profesion_ = value;
            }
        }
        public System.String nacionalidad
        {
            get
            {
                return nacionalidad_.Trim ();
            }
            set
            {
                nacionalidad_ = value;
            }
        }
        public System.String telefono1
        {
            get
            {
                return telefono1_.Trim ();
            }
            set
            {
                telefono1_ = value;
            }
        }
        public System.String telefenoInterno
        {
            get
            {
                return telefenoInterno_.Trim ();
            }
            set
            {
                telefenoInterno_ = value;
            }
        }
        public System.String direccion
        {
            get
            {
                return direccion_.Trim ();
            }
            set
            {
                direccion_ = value;
            }
        }
        public System.String nroAsegurado
        {
            get
            {
                return nroAsegurado_.Trim ();
            }
            set
            {
                nroAsegurado_ = value;
            }
        }
        public System.String NUA
        {
            get
            {
                return NUA_.Trim ();
            }
            set
            {
                NUA_ = value;
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
            if ( Conexion.Conexion.Ejecutar ( "insert into Empleado values(?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)", ci, nombre, APaterno, AMaterno, fechaNac, Genero, estadoCivil, profesion, nacionalidad, telefono1, telefenoInterno, direccion, nroAsegurado, NUA, activo ) == 0 )
                return -1;
            System.Data.DataTable t = Conexion.Conexion.Obtener ( "select max(id) from Empleado" );
            return System.Convert.ToInt32 ( t.Rows[0][0] );
        }

        public void Actualizar ()
        {
            Conexion.Conexion.Ejecutar ( "update Empleado set ci=?, nombre=?, APaterno=?, AMaterno=?, fechaNac=?, Genero=?, estadoCivil=?, profesion=?, nacionalidad=?, telefono1=?, telefenoInterno=?, direccion=?, nroAsegurado=?, NUA=?, activo=? where id=?", ci, nombre, APaterno, AMaterno, fechaNac, Genero, estadoCivil, profesion, nacionalidad, telefono1, telefenoInterno, direccion, nroAsegurado, NUA, activo, id );
        }

        public void Eliminar ()
        {

            Conexion.Conexion.Ejecutar ( "delete from empleado where id=?", id );
        }

        public System.Data.DataTable Listar ()
        {
            return Listar ( "" );
        }

        public System.Data.DataTable ListarActivos ()
        {
            return Listar ( "activo<>0" );
        }

        public System.Data.DataTable Listar ( string condicion, params object[] args )
        {
            string s = "select * from Empleado " + ( !string.IsNullOrEmpty ( condicion ) ? "where " + condicion : "" );
            return Conexion.Conexion.Obtener ( s, args );
        }

        public System.Data.DataTable ListarE ( string condicion, params object[] args )
        {
            string s = "select id, ci, apaterno + ' ' + amaterno + ' ' + nombre as nombre from empleado" + ( !string.IsNullOrEmpty ( condicion ) ? "where " + condicion : "" );
            return Conexion.Conexion.Obtener ( s, args );
        }

        public System.Data.DataRow Obtener ()
        {
            System.Data.DataTable t = Conexion.Conexion.Obtener ( "select * from Empleado where id=?", id );
            if ( t.Rows.Count > 0 )
            {
                id = System.Convert.ToInt32 ( t.Rows[0][0] );
                ci = System.Convert.ToString ( t.Rows[0][1] );
                nombre = System.Convert.ToString ( t.Rows[0][2] );
                APaterno = System.Convert.ToString ( t.Rows[0][3] );
                AMaterno = System.Convert.ToString ( t.Rows[0][4] );
                fechaNac = System.Convert.ToDateTime ( t.Rows[0][5] );
                Genero = System.Convert.ToString ( t.Rows[0][6] );
                estadoCivil = System.Convert.ToString ( t.Rows[0][7] );
                profesion = System.Convert.ToString ( t.Rows[0][8] );
                nacionalidad = System.Convert.ToString ( t.Rows[0][9] );
                telefono1 = System.Convert.ToString ( t.Rows[0][10] );
                telefenoInterno = System.Convert.ToString ( t.Rows[0][11] );
                direccion = System.Convert.ToString ( t.Rows[0][12] );
                nroAsegurado = System.Convert.ToString ( t.Rows[0][13] );
                NUA = System.Convert.ToString ( t.Rows[0][14] );
                activo = System.Convert.ToInt32 ( t.Rows[0][15] );
                return t.Rows[0];
            }
            return null;
        }

        public System.Data.DataRow ObtenerDeContrato ( int idContrato )
        {
            System.Data.DataTable t = Conexion.Conexion.Obtener ( "select NEmpleado_.ci, NEmpleado_.nombre, NEmpleado_.APaterno, NEmpleado_.AMaterno from empleado NEmpleado_ inner join contrato DCronograma_ on DCronograma_.idEmpleado=NEmpleado_.id where DCronograma_.id=?", idContrato );
            if ( t.Rows.Count > 0 )
            {
                ci = System.Convert.ToString ( t.Rows[0][0] );
                nombre = System.Convert.ToString ( t.Rows[0][1] );
                APaterno = System.Convert.ToString ( t.Rows[0][2] );
                AMaterno = System.Convert.ToString ( t.Rows[0][3] );
                return t.Rows[0];
            }
            return null;
        }

        #endregion

    }

    }
}