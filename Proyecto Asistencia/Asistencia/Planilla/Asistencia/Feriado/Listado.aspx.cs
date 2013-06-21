using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asistencia.Presentacion.Feriado
{
    public partial class Listado : System.Web.UI.Page
    {

        #region Variables privadas

        private Negocio.GFeriado NFeriado_ = new Negocio.GFeriado ();

        #endregion

        #region eventos

        protected void Page_Load ( object sender, EventArgs e )
        {
            actualizar ();
        }

        protected void gvListado_RowCommand ( object sender, GridViewCommandEventArgs e )
        {
            if ( e.CommandName == "Eliminar" )
            {
                NFeriado_.Eliminar ( int.Parse ( e.CommandArgument.ToString () ) );
                actualizar ();
            }
        }

        #endregion

        #region Metodos privados

        private void actualizar ()
        {
            gvListado.DataSource = NFeriado_.Listar ();
            gvListado.DataBind ();
        }

        #endregion

    }
}