using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Personal.Presentacion.TipoContrato
{
    public partial class Listado : System.Web.UI.Page
    {

        #region Variables privadas

        private Negocio.GTipoContrato NTipoContrato_ = new Negocio.GTipoContrato ();

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
                NTipoContrato_.Eliminar ( int.Parse ( e.CommandArgument.ToString () ) );
                actualizar ();
            }
        }


        #endregion

        #region Metodos privados

        private void actualizar ()
        {
            gvListado.DataSource = NTipoContrato_.Listar ();
            gvListado.DataBind ();
        }




        public string defImagen ( int activo )
        {
            if ( activo == 1 )
                return "../../imgs/action_check.png";
            else
                return "../../imgs/action_remove.png";
        }

        #endregion

    }
}