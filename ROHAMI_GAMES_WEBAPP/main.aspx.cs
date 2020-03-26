using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROHAMI_GAMES_WEBAPP.AppCode
{
    public partial class main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                if(Session["DatosUsuario"] == null)
                {
                    lblUsuario.Text = " USUARIO";
                    lkbIniciarSesion.Visible = true;
                }
                else
                {
                    DataSet ds = (DataSet)Session["DatosUsuario"];
                    lblUsuario.Text = ds.Tables[0].Rows[0]["USERNAME"].ToString();
                    lkbCerrarSesion.Visible = true;
                    lkbRegistrar.Visible = false;
                    lkbIniciarSesion.Visible = false;
                    if (ds.Tables[0].Rows[0]["EMPRESA"] != "0")
                    {
                        lkbAgregarJuego.Visible = true;
                    }
                }
                
            }
        }

        protected void txtLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void lkbCerrarSesion_Click(object sender, EventArgs e)
        {
            Session["DatosUsuario"] = null;
            Response.Redirect("main.aspx");
        }

        protected void lkbRegistrar_Click(object sender, EventArgs e)
        {
            Response.Redirect("register.aspx");
        }

        protected void lkbIniciarSesion_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }

        protected void lkbAgregarJuego_Click(object sender, EventArgs e)
        {
            Response.Redirect("SubirJuego.aspx");
        }
    }
}