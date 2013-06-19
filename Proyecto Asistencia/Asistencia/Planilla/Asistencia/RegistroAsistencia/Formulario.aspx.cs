using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asistencia.Presentacion.RegistroAsistencia
{
    public partial class Formulario : System.Web.UI.Page
    {
        #region Variables privadas

        private Negocio.GAsistencia NAsistencia_ = new Negocio.GAsistencia ();
        private Personal.Negocio.GEmpleado NEmpleado_ = new Personal.Negocio.GEmpleado ();

        #endregion

        #region eventos

        protected void Page_Load ( object sender, EventArgs e )
        {

            if ( !IsPostBack )
            {
                tFecha.Text = DateTime.Now.ToString ( "dd/MM/yyyy" );
                cargarCombo ();

                if ( !string.IsNullOrEmpty ( Request["id"] ) )
                {
                    cargarDatos ();
                }
            }
        }

        protected void lbGuardar_Click ( object sender, EventArgs e )
        {
            if ( txCod.Text == "" )
                insertar ();
            else
                modificar ();
        }

        #endregion

        #region Metodos privados

        private void cargarCombo ()
        {
            ddEmpleado.DataSource = NEmpleado_.ListarE ();
            ddEmpleado.DataValueField = "id";
            ddEmpleado.DataTextField = "nombre";
            ddEmpleado.DataBind ();
        }

        private void cargarDatos ()
        {
            txCod.Text = Request["id"].ToString ();
            System.Data.DataRow o = NAsistencia_.Obtener ( int.Parse ( txCod.Text ) );
            txCod.Text = o[0].ToString ();
            tIH.Text = DateTime.Parse ( o[1].ToString () ).ToString ( "HH" );
            tIM.Text = DateTime.Parse ( o[1].ToString () ).ToString ( "mm" );
            tFecha.Text = DateTime.Parse ( o[1].ToString () ).ToString ( "dd/MM/yyyy" );
            if ( o[2].ToString ().Trim () == "2" )
                rbsalida.Checked = true;
            ddTipo.SelectedValue = o[3].ToString ();
            ddEmpleado.SelectedValue = o[4].ToString ();

        }

        private void insertar ()
        {
            try
            {
                int x = 1;
                if ( rbsalida.Checked )
                    x = 2;
                NAsistencia_.Insertar ( DateTime.Parse ( tFecha.Text + " " + tIH.Text + ":" + tIM.Text ), x, int.Parse ( ddTipo.SelectedValue.ToString () ), int.Parse ( ddEmpleado.SelectedValue.ToString () ) );
                Response.Redirect ( "Listado.aspx" );
            }
            catch ( Exception ex )
            {

            }
        }

        private void modificar ()
        {
            try
            {
                int x = 1;
                if ( rbsalida.Checked )
                    x = 2;
                NAsistencia_.Actualizar ( int.Parse ( txCod.Text ), DateTime.Parse ( tFecha.Text + " " + tIH.Text + ":" + tIM.Text ), x, int.Parse ( ddTipo.SelectedValue.ToString () ), int.Parse ( ddEmpleado.SelectedValue.ToString () ) );
                Response.Redirect ( "Listado.aspx" );
            }
            catch ( Exception ex )
            {
            }
        }



        #endregion

    }
}