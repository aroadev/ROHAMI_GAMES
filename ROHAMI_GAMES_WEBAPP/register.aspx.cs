using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using ROHAMI_GAMES_WEBAPP.AppCode.Register.Business;

namespace ROHAMI_GAMES_WEBAPP.App_Code
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            Register_BC objBC = new Register_BC();
            string usuario = txtNombre.Text;
            string contraseña = txtPassword.Text;
            string confirmacion = txtConfirm.Text;
            if (contraseña != confirmacion)
            {
                Response.Write("<script language=javascript>alert('Las contraseñas no coinciden. Verifíque las contraseñas');</script>");
                txtPassword.Text = "";
                txtConfirm.Text = "";
                return;
            }
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string correo = txtCorreo.Text;
            string telefono = txtTelefono.Text;

            objBC.registrarUsuario(usuario, contraseña, nombre, apellido, correo, telefono);
            Response.Redirect("main.aspx");
        }

        protected void btnAcceder_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}