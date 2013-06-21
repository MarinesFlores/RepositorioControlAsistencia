using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Personal.Presentacion.Sucursal
{
    public partial class Formulario : System.Web.UI.Page
    {

        #region Variables privadas

        private Personal.Negocio.GSucursal NSucursal_ = new Personal.Negocio.GSucursal ();
        private Asistencia.Negocio.GFeriado NFeriado_ = new Asistencia.Negocio.GFeriado ();

        #endregion

        #region eventos

        protected void Page_Load ( object sender, EventArgs e )
        {
            if ( !IsPostBack )
            {
                if ( !string.IsNullOrEmpty ( Request["id"] ) )
                {
                    cargarDatos ();
                    CargarCombo ();
                    cargarSucursalFeriado ();

                    //cargarDatos();
                    //CargarCombo();
                    //cargarTurnos();
                    pHor1.Visible = true;
                    pHor2.Visible = true;
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

        protected void lbAddH_Click ( object sender, EventArgs e )
        {
            insertarFeriado ();
        }

        protected void gvHorario_RowCommand ( object sender, GridViewCommandEventArgs e )
        {
            if ( e.CommandName == "EliminarC" )
            {
                NSucursal_.EliminarSucursalFeriado ( int.Parse ( e.CommandArgument.ToString () ) );
                cargarSucursalFeriado ();

            }
        }

        #endregion

        #region Metodos privados

        private void cargarDatos ()
        {
            System.Data.DataRow o = NSucursal_.Obtener ( int.Parse ( Request["id"] ) );
            tCod.Text = o[0].ToString ();
            tDesc.Text = o[1].ToString ();
            if ( o[2].ToString () == "0" )
                chActivo.Checked = false;
        }

        private void cargarSucursalFeriado ()
        {
            gvFeriado.DataSource = NSucursal_.ListarDeSucursal ( int.Parse ( tCod.Text ) );
            //gvHorario.DataSource = t.ListarHorarioDeTurno(int.Parse(tCod.Text));
            //gvHorario.DataBind();
            gvFeriado.DataBind ();

        }

        private void insertarFeriado ()
        {
            NSucursal_.InsertarSucursalFeriado ( int.Parse ( tCod.Text ), int.Parse ( cbFeriado.SelectedValue ) );
            //t.InsertarHorario(ddDia.SelectedValue, DateTime.Parse("2012/12/12 " + tHIni.Text), DateTime.Parse("2012/12/12 " + tHFin.Text), int.Parse(tCod.Text));
            cargarSucursalFeriado ();
        }

        private void insertar ()
        {
            try
            {
                int a = 0;
                if ( chActivo.Checked )
                    a = 1;
                int id = NSucursal_.Insertar ( tDesc.Text, a );
                Response.Redirect ( "Formulario.aspx?id=" + id.ToString () );
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
                NSucursal_.Actualizar ( int.Parse ( tCod.Text ), tDesc.Text, a );
                Response.Redirect ( "Listado.aspx" );
            }
            catch ( Exception )
            {
            }
        }

        private void CargarCombo ()
        {
            cbFeriado.DataSource = NFeriado_.Listar ();
            cbFeriado.DataValueField = "id";
            cbFeriado.DataTextField = "descripcion";
            cbFeriado.DataBind ();
        }

        #endregion

    }
}