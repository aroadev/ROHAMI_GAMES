using ROHAMI_GAMES_WEBAPP.AppCode.Login.Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROHAMI_GAMES_WEBAPP
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {

            }
        }

        protected void btnAcceder_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuarioLogin.Text;
            string password = txtPasswordLogin.Text;
            Login_BC ObjBC = new Login_BC();
            Session["DatosUsuario"] = ObjBC.ValidarLogin(usuario, password);

            DataSet dt = (DataSet)Session["DatosUsuario"];

            if(dt.Tables[0].Rows.Count == 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Notify", "alert('Notification : Usuario inexistente. Porfavor regístrese.');", true);
            }
            else
            {
                string usuarioLogged = dt.Tables[0].Rows[0]["USERNAME"].ToString();
                string nombre = dt.Tables[0].Rows[0]["NOMBRE"].ToString();
                Response.Redirect("main.aspx");
            }

            
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            Response.Redirect("register.aspx");
        }
    }
}