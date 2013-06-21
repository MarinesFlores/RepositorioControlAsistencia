using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Personal.Presentacion.Contrato
{
    public partial class FormularioAdendas : System.Web.UI.Page
    {

        #region Variables privadas

        private Personal.Negocio.GEmpleado NEmpleado_ = new Personal.Negocio.GEmpleado ();
        private Personal.Negocio.GContrato NContrato_ = new Personal.Negocio.GContrato ();
      //  private Personal.Negocio.GCargo NCargo_ = new Personal.Negocio.GCargo ();
        private Personal.Negocio.GTipoContrato NTipoContrato_ = new Personal.Negocio.GTipoContrato ();
        private Asistencia.Negocio.Cronograma NCronograma_ = new Asistencia.Negocio.Cronograma ();
        private Personal.Negocio.GSucursal NSucusal_ = new Personal.Negocio.GSucursal ();

        private Personal.Negocio.GAdenda NAdendas_ = new Personal.Negocio.GAdenda ();

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
                    cargarDatosContrato ();
                    CargarTipoContrato ();
                    CargarSucursal ();
                    CargarCronograma ();
                    cargarDatosEmpleado ();
                  //  CargarCargo ();
                    actualizar ();
                    pHor2.Visible = true;

                }
            }
        }

        protected void gvHorario_RowCommand ( object sender, GridViewCommandEventArgs e )
        {

            if ( e.CommandName == "EliminarC" )
            {
                NAdendas_.Eliminar ( int.Parse ( e.CommandArgument.ToString () ) );
                actualizar ();
            }

        }

        protected void lbGuardar_Click ( object sender, EventArgs e )
        {
            try
            {

                int s = 0;
                if ( chActivo.Checked )
                    s = 1;
                int id = NAdendas_.Insertar ( DateTime.Parse ( tFechaFin.Text ), double.Parse ( tsaldo.Text ), DateTime.Parse ( tFecha.Text ), int.Parse ( tcontrato.Text ),int.Parse ( cbTContrato.SelectedValue ), int.Parse ( cbCornograma.SelectedValue ), int.Parse ( cbSucusal.SelectedValue ), s );


                //como deberia de ir
                //int id = a.Insertar(DateTime.Parse(tFechaFin.Text),double.Parse(tsaldo.Text),DateTime.Parse(tFecha.Text),int.Parse(tcontrato.Text),int.Parse(cbCargo.SelectedValue),int.Parse(cbTContrato.SelectedValue),int.Parse(cbCornograma.SelectedValue),int.Parse(cbSucusal.SelectedValue),1);
                Response.Redirect ( "FormularioAdendas.aspx?id=" + tcontrato.Text );
            }
            catch ( Exception )
            {
            }


        }


        #endregion

        #region Metodos privados

        private void actualizar ()
        {
            gvAdendas.DataSource = NAdendas_.ListarDeAdenadas ( int.Parse ( tcontrato.Text ) );
            gvAdendas.DataBind ();
        }

        private void cargarDatosContrato ()
        {
            System.Data.DataRow o = NContrato_.Obtener ( int.Parse ( Request["id"] ) );

            tcontrato.Text = o[0].ToString ();
            //tci.Text = o[1].ToString();
            //tnombre.Text = o[2].ToString();
            //tapaterno.Text = o[3].ToString();
            //tAmaterno.Text = o[4].ToString();

        }


        private void cargarDatosEmpleado ()
        {
            System.Data.DataRow o = NEmpleado_.ObtenerDeContrato ( int.Parse ( Request["id"] ) );
            lbEmpleado.Text = "Empleado " + o[0].ToString () + ", [" + o[1].ToString () + " - " + o[2].ToString () + "-" + o[3].ToString () + " ]";

            //tcontrato.Text = o[0].ToString();
            //tci.Text = o[1].ToString();
            //tnombre.Text = o[2].ToString();
            //tapaterno.Text = o[3].ToString();
            //tAmaterno.Text = o[4].ToString();

        }

       // private void CargarCargo ()
       // {
           // cbCargo.DataSource = NCargo_.Listar ();
            //cbCargo.DataValueField = "id";
            //cbCargo.DataTextField = "descripcion";
            //cbCargo.DataBind ();
       // }



        private void CargarTipoContrato ()
        {
            cbTContrato.DataSource = NTipoContrato_.ListarActivo ();
            cbTContrato.DataValueField = "id";
            cbTContrato.DataTextField = "descripcion";
            cbTContrato.DataBind ();
        }

        private void CargarCronograma ()
        {
            cbCornograma.DataSource = NCronograma_.Listar ();
            cbCornograma.DataValueField = "id";
            cbCornograma.DataTextField = "descripcion";
            cbCornograma.DataBind ();
        }


        private void CargarSucursal ()
        {
            cbSucusal.DataSource = NSucusal_.ListarActivo ();
            cbSucusal.DataValueField = "id";
            cbSucusal.DataTextField = "descripcion";
            cbSucusal.DataBind ();
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