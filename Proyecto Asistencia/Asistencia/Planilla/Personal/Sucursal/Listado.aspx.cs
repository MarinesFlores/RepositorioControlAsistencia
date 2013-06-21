using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Personal.Presentacion.Sucursal
{
    public partial class Listado : System.Web.UI.Page
    {

        #region Variables privadas

        private Negocio.GSucursal NSucursal_ = new Negocio.GSucursal ();

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
                NSucursal_.Eliminar ( int.Parse ( e.CommandArgument.ToString () ) );
                actualizar ();
            }
        }

        #endregion

        #region Metodos privados

        private void actualizar ()
        {
            gvListado.DataSource = NSucursal_.Listar ();
            gvListado.DataBind ();
        }


        public string defImagen ( int activo )
        {
            if ( activo == 1 )
                return "../../imgs/action_check.png";
            else
                return "../../imgs/action_remove.png";
        }
        //    Function defImagen(ByVal estado As Integer) As String
        //    If estado = 1 Then
        //        Return "../App_Themes/Default/iconos/action_check.png"
        //    ElseIf estado = 0 Then
        //        Return "../App_Themes/Default/iconos/sign_minus.png"
        //    End If
        //    Return ""
        //End Function

        #endregion
    }
}