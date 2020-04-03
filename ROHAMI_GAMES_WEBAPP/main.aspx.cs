using ROHAMI_GAMES_WEBAPP.AppCode.Main;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROHAMI_GAMES_WEBAPP.AppCode
{
    /* Esto es una prueba de una nueva rama de desarrollo para no tocar el código principal. */
    public partial class main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /* Validamos que sea la primera vez que el usuario entra a la página */
            if(!IsPostBack)
            {
                /* Comprobamos si los datos de Sesión vienen con datos en un principio */
                if(Session["DatosUsuario"] != null)
                {
                    /* Bajamos los datos de sesión a un DataTable */
                    DataTable dt = (DataTable)Session["DatosUsuario"];
                    lblUser.Text = dt.Rows[0]["USERNAME"].ToString();
                    string Empresa = dt.Rows[0]["EMPRESA"].ToString();
                    if (Empresa != "0")
                    {

                    }
                }
                else
                {
                    /* Ponemos el label del Botón con un texto para iniciar sesión */
                    lblUser.Text = "Iniciar Sesión";
                }
                
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            /* Llamamos a la capa de Business */
            Main_BC objBC = new Main_BC();

            /* Tomamos en variables String los valores de los Textbox de inicio de sesión */
            string usr = txtLogin.Text.Trim();
            string psw = txtPassword.Text.Trim();

            /* Llamamos a la variable de sesión y le asignamos el resultado de la función Login */
            Session["DatosUsuario"] = objBC.Login(usr, psw);

            /* Creamos un DataTable con los datos del Usuario para comprobar que sea existente */
            DataTable dtUsr = (DataTable)Session["DatosUsuario"];

            /* Comprobamos que el usuario sea existente */
            if (dtUsr.Rows.Count != 0)
            {
                Response.Redirect("main.aspx");
                return;
            }
            else
            {
                /* Mostramos mensaje de alerta */
                lblError.Visible = true;
                return;
            }
            
        }
    }
}