using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Personal.Presentacion.Empleado
{
    public partial class Formulario : System.Web.UI.Page
    {

        #region Variables privadas

        private Personal.Negocio.GEmpleado NEmpleado_ = new Personal.Negocio.GEmpleado ();

        #endregion

        #region eventos

        protected void Page_Load ( object sender, EventArgs e )
        {
            if ( !IsPostBack )
            {

                tFecha.Text = DateTime.Now.ToString ( "dd/MM/yyyy" );
                if ( !string.IsNullOrEmpty ( Request["id"] ) )
                {
                    cargarDatos ();
                }
            }
        }

        protected void lbGuardar_Click ( object sender, EventArgs e )
        {
            if ( tCod.Text == "" )
                insertar ();
            else
                modificar ();
        }

        #endregion

        #region Metodos privados

        private void cargarDatos ()
        {
            System.Data.DataRow o = NEmpleado_.Obtener ( int.Parse ( Request["id"] ) );

            tCod.Text = o[0].ToString ();
            tci.Text = o[1].ToString ();
            tnombre.Text = o[2].ToString ();
            tAPaterno.Text = o[3].ToString ();
            tAMaterno.Text = o[4].ToString ();
            tFecha.Text = o[5].ToString ();
            if ( o[6].ToString ().Trim () == "M" )
                rbGenM.Checked = true;
            //tGenero.Text = o[6].ToString();
            //tEstadoC.Text = o[7].ToString();
            ddEstado.SelectedValue = o[7].ToString ();
            tProfesion.Text = o[8].ToString ();
            tNacionalidad.Text = o[9].ToString ();
            tTelf1.Text = o[10].ToString ();
            tTelfInterno.Text = o[11].ToString ();
            tdireccion.Text = o[12].ToString ();
            tNroAsegurado.Text = o[13].ToString ();
            tNUA.Text = o[14].ToString ();
            if ( o[15].ToString () == "0" )
                chActivo.Checked = false;
        }


        private void insertar ()
        {
            try
            {
                int a = 0;
                if ( chActivo.Checked )
                    a = 1;
                string genero = "F";
                if ( rbGenM.Checked )
                    genero = "M";
                int id = NEmpleado_.Insertar ( tci.Text, tnombre.Text, tAPaterno.Text, tAMaterno.Text, DateTime.Parse ( tFecha.Text ), genero, ddEstado.SelectedValue, tProfesion.Text, tNacionalidad.Text, tTelf1.Text, tTelfInterno.Text, tdireccion.Text, tNroAsegurado.Text, tNUA.Text, a );
                Response.Redirect ( "Listado.aspx" );
            }
            catch ( Exception )
            {
            }
        }

        private void modificar ()
        {
            try
            {
                int a = 0;
                if ( chActivo.Checked )
                    a = 1;
                string genero = "F";
                if ( rbGenM.Checked )
                    genero = "M";
                NEmpleado_.Actualizar ( int.Parse ( tCod.Text ), tci.Text, tnombre.Text, tAPaterno.Text, tAMaterno.Text, DateTime.Parse ( tFecha.Text ), genero, ddEstado.SelectedValue, tProfesion.Text, tNacionalidad.Text, tTelf1.Text, tTelfInterno.Text, tdireccion.Text, tNroAsegurado.Text, tNUA.Text, a );
                Response.Redirect ( "Listado.aspx" );
            }
            catch ( Exception )
            {
            }
        }





        #endregion

    }
}