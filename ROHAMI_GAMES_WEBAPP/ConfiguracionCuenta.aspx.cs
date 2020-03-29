using ROHAMI_GAMES_WEBAPP.AppCode.ConfiguracionCuenta.Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Timers;
using System.Threading;

namespace ROHAMI_GAMES_WEBAPP
{
    public partial class ConfiguracionCuenta : System.Web.UI.Page
    {
        private static System.Timers.Timer timer;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                if(Session["DatosUsuario"] == null)
                {
                    Response.Redirect("Login.aspx");

                }
                else
                {
                    DataSet dsUsuario = (DataSet)Session["DatosUsuario"];
                    txtNombreUsuario.Text = dsUsuario.Tables[0].Rows[0]["USERNAME"].ToString();

                    txtNombreUsuario.Text = dsUsuario.Tables[0].Rows[0]["USERNAME"].ToString();
                    txtCorreo.Text = dsUsuario.Tables[0].Rows[0]["CORREO"].ToString();
                    txtApellido.Text = dsUsuario.Tables[0].Rows[0]["APELLIDO_MATERNO"].ToString();
                    txtNombre.Text = dsUsuario.Tables[0].Rows[0]["NOMBRE"].ToString();
                }
            }
        }

        protected void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            /* Ponemos todos los controles en visible para que el usuario pueda meter sus datos */
            lblTexto1.Visible = true;
            lblTexto2.Visible = true;
            lblTexto3.Visible = true;
            txtPasswordActual.Visible = true;
            txtNuevaPassword.Visible = true;
            txtConfirmacion.Visible = true;
            btnCambiarPassword.Visible = true;
        }

        protected void btnCambiarPassword_Click(object sender, EventArgs e)
        {
            ConfiguracionCuenta_BC objBC = new ConfiguracionCuenta_BC(); /* Llamamos a la clase de Business */
            DataTable dtUsuario = (DataTable)Session["DatosUsuario"]; /* Bajamos los datos del usuario en una tabla */
            
            /* Validamos que la contraseña actual sea la correcta */
            if (txtPasswordActual.Text.Equals(dtUsuario.Rows[0]["PSSWORD"].ToString()))
            {
                if (txtNuevaPassword.Text.Equals(txtPasswordActual.Text))
                {
                    lblPasswordAdv2.Visible = true; /* Le decimos al usuario que la contraseña nueva no puede ser igual a la actual */
                    /* Ponemos vacios los textos */
                    txtPasswordActual.Text = "";
                    txtNuevaPassword.Text = "";
                    txtConfirmacion.Text = "";
                }

                /* Una vez que se valide la contraseña actual, validamos si la nueva coincide con la confirmación */
                if (txtNuevaPassword.Text.Equals(txtConfirmacion.Text))
                {
                    string NuevaPassword = txtNuevaPassword.Text.Trim(); /* Guardamos en una variable la nueva contraseña del usuario */
                    objBC.CambioPassword(NuevaPassword, dtUsuario.Rows[0]["ID_USUARIO"].ToString()); /* Ejecutamos la funcion de cambio de password */
                    lblSuccess.Visible = true; /* Le notificamos al usuario que el cambio de contraseña fué exitoso. */
                }
                else
                {
                    /* Se le notifica al usuario que la contraseña nueva y la confirmacion no coinciden */
                    lblPasswordAdv1.Visible = true;
                    txtNuevaPassword.Text = "";
                    txtConfirmacion.Text = "";
                }
            }
            else
            {
                /* Le notificamos al usuario que la contraseña que colocó como actual no coincide */
                lblPasswordAdv4.Visible = true;
                txtPasswordActual.Text = "";
                txtNuevaPassword.Text = "";
                txtConfirmacion.Text = "";
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            ConfiguracionCuenta_BC objBC = new ConfiguracionCuenta_BC();
            DataTable dtUsuario = (DataTable)Session["DatosUsuario"]; /* Creamos un data table con los datos del usuario */
            
            string idUsuario = dtUsuario.Rows[0]["ID_USUARIO"].ToString();
            string username = txtNombreUsuario.Text.Trim();
            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            string correo = txtCorreo.Text.Trim();

            objBC.ActualizaDatos(idUsuario, username, nombre, apellido, correo);
            lblSuccesUpdate.Visible = true;
            Thread.Sleep(5000);
        }
    }
}