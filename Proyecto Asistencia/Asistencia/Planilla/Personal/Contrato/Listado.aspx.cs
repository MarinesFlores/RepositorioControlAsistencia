using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Personal.Presentacion.Contrato
{
    public partial class Listado : System.Web.UI.Page
    {

        #region Variables privadas

        private Negocio.GEmpleado NEmpleado_ = new Negocio.GEmpleado ();

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

                // e.Eliminar(int.Parse(e.CommandArgument.ToString()));
                actualizar ();
            }
        }


        #endregion

        #region Metodos privados

        private void actualizar ()
        {
            gvListado.DataSource = NEmpleado_.ListarActivos ();
            gvListado.DataBind ();
        }



        #endregion

    }
}