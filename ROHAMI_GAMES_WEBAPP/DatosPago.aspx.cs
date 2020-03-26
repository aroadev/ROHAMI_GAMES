using ROHAMI_GAMES_WEBAPP.AppCode.Pagar.Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
                for (int a = 1; a <= 31; a++)
                {
                    string item = Convert.ToString(a);
                    ddlDia.Items.Add(item);
                }
                for (int a = 01; a <= 12; a++)
                {
                    string item = Convert.ToString(a);
                    ddlMes.Items.Add(item);
                }
            }
        }

        protected void btnAgregarMetodo_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)Session["DatosUsuario"];
            Pagar_BC objBC = new Pagar_BC();
            string Nombre = txtNombrePropietario.Text.ToUpper().Trim();
            string Numero = txtNumeroTarjeta.Text.ToUpper().Trim();
            string CVV = txtCVV.Text.ToUpper().Trim();
            string eDay = ddlDia.SelectedValue;
            string eMes = ddlMes.SelectedValue;

            string expiracion = eDay + "/" + eMes;

            string idUsuario = dt.Rows[0]["ID_USUARIO"].ToString();

            objBC.GuardarPago(Nombre, Numero, expiracion, CVV, idUsuario);
        }
    }
}