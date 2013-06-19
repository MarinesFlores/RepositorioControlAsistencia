using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Asistencia.Negocio
{
    public class GAsistencia
    {
        #region Variables privadas

        private Datos.Asistencia DAsistencia_;

        #endregion

        #region Metodos publicos

        public System.Int32 Insertar ( System.DateTime hora, System.Int32 evento, System.Int32 tipo, System.Int32 idEmpleado )
        {
            try
            {
                DAsistencia_ = new Datos.Asistencia ();
                DAsistencia_.hora = hora;
                DAsistencia_.evento = evento;
                DAsistencia_.tipo = tipo;
                DAsistencia_.idEmpleado = idEmpleado;
                int i = DAsistencia_.Insertar ();
                if ( i < 0 )
                    throw new System.Exception ( "Asistencia: Error al insertar. \n" );
                return i;
            }
            catch ( System.Exception ex )
            {
                throw new System.Exception ( "Asistencia: Error al insertar. \n" + ex.Message );
            }
        }

        public void Actualizar ( System.Int32 id, System.DateTime hora, System.Int32 evento, System.Int32 tipo, System.Int32 idEmpleado )
        {
            try
            {
                DAsistencia_ = new Datos.Asistencia ();
                DAsistencia_.id = id;
                DAsistencia_.hora = hora;
                DAsistencia_.evento = evento;
                DAsistencia_.tipo = tipo;
                DAsistencia_.idEmpleado = idEmpleado;
                ;
                DAsistencia_.Actualizar ();
            }
            catch ( System.Exception ex )
            {
                throw new System.Exception ( "Asistencia: Error al actualizar. \n" + ex.Message );
            }
        }

        public void Eliminar ( System.Int32 id )
        {
            try
            {
                DAsistencia_ = new Datos.Asistencia ();
                DAsistencia_.id = id;
                DAsistencia_.Eliminar ();
            }
            catch ( System.Exception ex )
            {
                throw new System.Exception ( "Asistencia: Error al eliminar. \n" + ex.Message );
            }
        }

        public System.Data.DataTable Listar ()
        {
            DAsistencia_ = new Datos.Asistencia ();
            return DAsistencia_.Listar ();
        }

        public System.Data.DataTable Listar ( string condicion, params object[] args )
        {
            try
            {
                DAsistencia_ = new Datos.Asistencia ();
                return DAsistencia_.Listar ( condicion, args );
            }
            catch ( System.Exception ex )
            {
                throw new System.Exception ( "Asistencia: Error al listar. \n" + ex.Message );
            }
        }

        public System.Data.DataRow Obtener ( System.Int32 id )
        {
            try
            {
                DAsistencia_ = new Datos.Asistencia ();
                DAsistencia_.id = id;
                return DAsistencia_.Obtener ();
            }
            catch ( System.Exception ex )
            {
                throw new System.Exception ( "Asistencia: Error al obtener datos. \n" + ex.Message );
            }
        }

        #endregion
    }
}