using ROHAMI_GAMES_WEBAPP.AppCode.Pagar.Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROHAMI_GAMES_WEBAPP
{
    public partial class Pagar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                /* Se valida que el usuario esté con sesión iniciada par evitar posibles problemas */
                if (Session["DatosUsuario"] == null)
                {
                    Response.Redirect("Login.aspx");
                    return;
                }

                /* Se llenan los DropDownList con For */
                for (int a = 1; a <= 12; a++)
                {
                    string item = Convert.ToString(a);
                    ddlDia.Items.Add(item);
                }
                for (int a = 20; a <= 35; a++)
                {
                    string item = Convert.ToString(a);
                    ddlMes.Items.Add(item);
                }
            }
        }

        protected void btnAgregarMetodo_Click(object sender, EventArgs e)
        {
            //DataTable dt = (DataTable)Session["DatosUsuario"];
            DataSet ds = (DataSet)Session["DatosUsuario"];
            Pagar_BC objBC = new Pagar_BC();
            string Nombre = txtNombrePropietario.Text.ToUpper().Trim();
            string Numero = txtNumeroTarjeta.Text.ToUpper().Trim();
            string CVV = txtCVV.Text.ToUpper().Trim();
            string eMes = ddlDia.SelectedValue;
            string eYear = ddlMes.SelectedValue;

            string expiracion = eMes + "/" + eYear;

            string idUsuario = ds.Tables[0].Rows[0]["ID_USUARIO"].ToString();

            objBC.GuardarPago(Nombre, Numero, expiracion, CVV, idUsuario);
            lblSucces.Visible = true;
            Thread.Sleep(3000);
            Response.Redirect("ConfiguracionCuenta.aspx");
        }
    }
}