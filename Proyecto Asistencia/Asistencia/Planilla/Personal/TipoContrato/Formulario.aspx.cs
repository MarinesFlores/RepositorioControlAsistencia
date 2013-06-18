using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Personal.Presentacion.TipoContrato
{
    public partial class Formulario : System.Web.UI.Page
    {

        #region Variables privadas

        private Personal.Negocio.GTipoContrato NTipoContrato_ = new Personal.Negocio.GTipoContrato ();
        //  private Planilla_.Negocio.GTipoBono xx = new Planilla_.Negocio.GTipoBono();

        #endregion

        #region eventos

        protected void Page_Load ( object sender, EventArgs e )
        {
            if ( !IsPostBack )
            {
                if ( !string.IsNullOrEmpty ( Request["id"] ) )
                {
                    cargarDatos ();
                    //  CargarCombo();
                    //cargarTurnos();

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
            System.Data.DataRow o = NTipoContrato_.Obtener ( int.Parse ( Request["id"] ) );
            tCod.Text = o[0].ToString ();
            tDesc.Text = o[1].ToString ();
            if ( o[2].ToString () == "0" )
                chActivo.Checked = false;
        }


        private void insertar ()
        {
            try
            {
                int a = 0;
                if ( chActivo.Checked )
                    a = 1;
                int id = NTipoContrato_.Insertar ( tDesc.Text, a );
                Response.Redirect ( "Listado.aspx?id=" + id.ToString () );
            }
            catch ( Exception ) { }
        }

        private void modificar ()
        {
            try
            {
                int a = 0;
                if ( chActivo.Checked )
                    a = 1;
                NTipoContrato_.Actualizar ( int.Parse ( tCod.Text ), tDesc.Text, a );
                Response.Redirect ( "Listado.aspx" );
            }
            catch ( Exception ) { }
        }



        //protected void lbAddH_Click(object sender, EventArgs e)
        //{
        //    insertarTipoBono();
        //}

        //protected void gvHorario_RowCommand(object sender, GridViewCommandEventArgs e)
        //{
        //    if (e.CommandName == "EliminarC")
        //    {
        //        tc.EliminarDepartamentoTipoBono(int.Parse(e.CommandArgument.ToString()));
        //        cargarTurnos();
        //        //t.EliminarHorario(int.Parse(e.CommandArgument.ToString()));
        //        //cargarHorarios();
        //    }
        //}

        //private void CargarCombo()
        //{
        //    cbTipoBono.DataSource = xx.Listar();
        //    cbTipoBono.DataValueField = "id";
        //    cbTipoBono.DataTextField = "descripcion";
        //    cbTipoBono.DataBind();
        //}
        #endregion

    }
}