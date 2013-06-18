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

        

    }
}