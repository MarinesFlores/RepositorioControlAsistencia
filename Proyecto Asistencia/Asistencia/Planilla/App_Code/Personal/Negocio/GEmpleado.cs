using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Personal.Negocio
{
    public class GEmpleado
    {
       #region Variables privadas

        private Datos.Empleado DEmpleado_;

        #endregion

        #region Metodos publicos

        public System.Int32 Insertar ( System.String ci, System.String nombre, System.String APaterno, System.String AMaterno, System.DateTime fechaNac, System.String Genero, System.String estadoCivil, System.String profesion, System.String nacionalidad, System.String telefono1, System.String telefenoInterno, System.String direccion, System.String nroAsegurado, System.String NUA, System.Int32 activo )
        {
            try
            {
                DEmpleado_ = new Datos.Empleado ();
                DEmpleado_.ci = ci;
                DEmpleado_.nombre = nombre;
                DEmpleado_.APaterno = APaterno;
                DEmpleado_.AMaterno = AMaterno;
                DEmpleado_.fechaNac = fechaNac;
                DEmpleado_.Genero = Genero;
                DEmpleado_.estadoCivil = estadoCivil;
                DEmpleado_.profesion = profesion;
                DEmpleado_.nacionalidad = nacionalidad;
                DEmpleado_.telefono1 = telefono1;
                DEmpleado_.telefenoInterno = telefenoInterno;
                DEmpleado_.direccion = direccion;
                DEmpleado_.nroAsegurado = nroAsegurado;
                DEmpleado_.NUA = NUA;
                DEmpleado_.activo = activo;
                int i = DEmpleado_.Insertar ();
                if ( i < 0 )
                    throw new System.Exception ( "Empleado: Error al insertar. \n" );
                return i;
            }
            catch ( System.Exception ex )
            {
                throw new System.Exception ( "Empleado: Error al insertar. \n" + ex.Message );
            }
        }

        public void Actualizar ( System.Int32 id, System.String ci, System.String nombre, System.String APaterno, System.String AMaterno, System.DateTime fechaNac, System.String Genero, System.String estadoCivil, System.String profesion, System.String nacionalidad, System.String telefono1, System.String telefenoInterno, System.String direccion, System.String nroAsegurado, System.String NUA, System.Int32 activo )
        {
            try
            {
                DEmpleado_ = new Datos.Empleado ();
                DEmpleado_.id = id;
                DEmpleado_.ci = ci;
                DEmpleado_.nombre = nombre;
                DEmpleado_.APaterno = APaterno;
                DEmpleado_.AMaterno = AMaterno;
                DEmpleado_.fechaNac = fechaNac;
                DEmpleado_.Genero = Genero;
                DEmpleado_.estadoCivil = estadoCivil;
                DEmpleado_.profesion = profesion;
                DEmpleado_.nacionalidad = nacionalidad;
                DEmpleado_.telefono1 = telefono1;
                DEmpleado_.telefenoInterno = telefenoInterno;
                DEmpleado_.direccion = direccion;
                DEmpleado_.nroAsegurado = nroAsegurado;
                DEmpleado_.NUA = NUA;
                DEmpleado_.activo = activo;
                ;
                DEmpleado_.Actualizar ();
            }
            catch ( System.Exception ex )
            {
                throw new System.Exception ( "Empleado: Error al actualizar. \n" + ex.Message );
            }
        }

        public void Eliminar ( System.Int32 id )
        {
            try
            {
                DEmpleado_ = new Datos.Empleado ();
                DEmpleado_.id = id;
                DEmpleado_.Eliminar ();
            }
            catch ( System.Exception ex )
            {
                throw new System.Exception ( "Empleado: Error al eliminar. \n" + ex.Message );
            }
        }

        public System.Data.DataTable Listar ()
        {
            DEmpleado_ = new Datos.Empleado ();
            return DEmpleado_.Listar ();
        }

        public System.Data.DataTable ListarActivos ()
        {
            try
            {
                DEmpleado_ = new Datos.Empleado ();
                return DEmpleado_.ListarActivos ();
            }
            catch ( System.Exception ex )
            {
                throw new System.Exception ( "Empleado: Error al listar. \n" + ex.Message );
            }
        }

        public System.Data.DataTable Listar ( string condicion, params object[] args )
        {
            try
            {
                DEmpleado_ = new Datos.Empleado ();
                return DEmpleado_.Listar ( condicion, args );
            }
            catch ( System.Exception ex )
            {
                throw new System.Exception ( "Empleado: Error al listar. \n" + ex.Message );
            }
        }

        public System.Data.DataRow Obtener ( System.Int32 id )
        {
            try
            {
                DEmpleado_ = new Datos.Empleado ();
                DEmpleado_.id = id;
                return DEmpleado_.Obtener ();
            }
            catch ( System.Exception ex )
            {
                throw new System.Exception ( "Empleado: Error al obtener datos. \n" + ex.Message );
            }
        }

        public System.Data.DataRow ObtenerDeContrato ( System.Int32 id )
        {
            try
            {
                DEmpleado_ = new Datos.Empleado ();
                return DEmpleado_.ObtenerDeContrato ( id );
            }
            catch ( System.Exception ex )
            {
                throw new System.Exception ( "Empleado: Error al obtenerDeContrato datos. \n" + ex.Message );
            }
        }

        public System.Data.DataTable ListarE ()
        {
            try
            {
                DEmpleado_ = new Datos.Empleado ();
                return DEmpleado_.ListarE ( "" );
            }
            catch ( System.Exception ex )
            {
                throw new System.Exception ( "Empleado: Error al obtener datos. \n" + ex.Message );
            }
        }

        #endregion


        
    }
}