using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Personal.Presentacion.Contrato
{
    public partial class Formulario : System.Web.UI.Page
    {

        #region Variables privadas

        private Personal.Negocio.GEmpleado NEmpleado_ = new Personal.Negocio.GEmpleado ();
        private Personal.Negocio.GContrato NContrato_ = new Personal.Negocio.GContrato ();
        private Asistencia.Negocio.Cronograma NCronograma_ = new Asistencia.Negocio.Cronograma ();
        private Asistencia.Negocio.Turno NTurno_ = new Asistencia.Negocio.Turno ();

        #endregion

        #region eventos

        protected void Page_Load ( object sender, EventArgs e )
        {
            if ( !IsPostBack )
            {
                tFecha.Text = DateTime.Now.ToString ( "dd/MM/yyyy" );
                tFechaFin.Text = DateTime.Now.ToString ( "dd/MM/yyyy" );
                if ( !string.IsNullOrEmpty ( Request["id"] ) )
                {
                    cargarDatosEmpleado ();
                    // CargarCombo();
                    cargarContrato ();
                    //pHor1.Visible = true;
                    pHor2.Visible = true;
                }
            }
        }

        protected void lbGuardar_Click ( object sender, EventArgs e )
        {
            // if (tCod.Text == "")
            insertar ();
            //  else
            //    modificar();
        }

        protected void lbAddH_Click ( object sender, EventArgs e )
        {
            //insertarContrato();
        }

        protected void gvHorario_RowCommand ( object sender, GridViewCommandEventArgs e )
        {
            if ( e.CommandName == "EliminarC" )
            {
                NContrato_.Eliminar ( int.Parse ( e.CommandArgument.ToString () ) );
                cargarContrato ();
                //  c1.EliminarCronogramaTurno(int.Parse(e.CommandArgument.ToString()));
                //  cargarContrato();
                //t.EliminarHorario(int.Parse(e.CommandArgument.ToString()));
                //cargarHorarios();
            }
        }

        protected void lbGuardar_Command ( object sender, CommandEventArgs e )
        {

        }

        #endregion

        #region Metodos privados

        private void cargarDatosEmpleado ()
        {
            System.Data.DataRow o = NEmpleado_.Obtener ( int.Parse ( Request["id"] ) );
            lbEmpleado.Text = "Empleado " + o[1].ToString () + ", [" + o[2].ToString () + " - " + o[3].ToString () + "-" + o[4].ToString () + " ]";
            //tcodE.Text = o[0].ToString();
            //tci.Text = o[1].ToString();
            //tnombre.Text = o[2].ToString();
            //tapaterno.Text = o[3].ToString();
            //tAmaterno.Text = o[4].ToString();

        }

        private void cargarContrato ()
        {
            gvContrato.DataSource = NContrato_.Listar ( int.Parse ( Request["id"] ) );
            //gvTurnos.DataSource = c1.ListarDeCronograma(int.Parse(tCod.Text));
            //gvHorario.DataSource = t.ListarHorarioDeTurno(int.Parse(tCod.Text));
            //gvHorario.DataBind();
            gvContrato.DataBind ();

        }


        private void insertar ()
        {
            try
            {
                int a = 0;
                if ( chActivo.Checked )
                    a = 1;
                int id = NContrato_.Insertar ( DateTime.Parse ( tFecha.Text ), DateTime.Parse ( tFechaFin.Text ), a, int.Parse ( Request["id"] ) );
                Response.Redirect ( "Formulario.aspx?id=" + int.Parse ( Request["id"] ) );
            }
            catch ( Exception )
            {
            }
        }

        private void modificar ()
        {
            try
            {
                //c1.Actualizar(int.Parse(tCod.Text), tDesc.Text);
                //Response.Redirect("Listado.aspx");
            }
            catch ( Exception )
            {
            }
        }



        private void CargarCombo ()
        {
            //cbTurno.DataSource = t.Listar();
            //cbTurno.DataValueField = "id";
            //cbTurno.DataTextField = "descricion";
            //cbTurno.DataBind();
        }




        public string defImagen ( int vigente )
        {
            if ( vigente == 1 )
                return "../../imgs/action_check.png";
            else
                return "../../imgs/action_remove.png";
        }

        #endregion

    }
}