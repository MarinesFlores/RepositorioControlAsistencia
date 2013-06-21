using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asistencia.Presentacion.Feriado
{
    public partial class Formulario : System.Web.UI.Page
    {
        #region Variables privadas

        private Asistencia.Negocio.GFeriado NFeriado_ = new Asistencia.Negocio.GFeriado ();

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
            System.Data.DataRow o = NFeriado_.Obtener ( int.Parse ( Request["id"] ) );
            tCod.Text = o[0].ToString ();
            tDesc.Text = o[1].ToString ();
            tFecha.Text = string.Format ( "{0:dd/MMMM}", DateTime.Parse ( ( o[2].ToString () ) ) );
        }

        private void insertar ()
        {
            try
            {
                int id = NFeriado_.Insertar ( tDesc.Text, DateTime.Parse ( tFecha.Text ) );
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
                NFeriado_.Actualizar ( int.Parse ( tCod.Text ), tDesc.Text, DateTime.Parse ( tFecha.Text ) );
                Response.Redirect ( "Listado.aspx" );
            }
            catch ( Exception )
            {
            }
        }

        #endregion

    }
}