using ROHAMI_GAMES_WEBAPP.AppCode.Compra.Bussines;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROHAMI_GAMES_WEBAPP
{
    public partial class compra : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {

                if (Session["DatosUsuario"] == null)
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Notify", "alert('Notification : No a ingresado, porfavor ingrese con su cuenta de ROHAMI GAMES ACCES.');", true);
                    Response.Redirect("Login.aspx");
                }
                else
                {
                    DataSet ds = (DataSet)Session["DatosUsuario"];
                    lblUsuario.Text = ds.Tables[0].Rows[0]["USERNAME"].ToString();
                    string idJuego = Request.QueryString["idJuego"].ToString(); /* Se declara una variable con el nombre del juego, haciendo TryHard Codding */
                    compra_BC objBC = new compra_BC(); /* Se llama a la clase de Bussines */
                    DataTable dt = objBC.mostrarJuegoEnCompra(idJuego); /* Se crea la tabla "dt" con los valores de la clase de Bussines */
                    lblNombreJuego.Text = dt.Rows[0]["NOMBRE"].ToString(); /* Se asigna al Label el nombre del juego desde la tabla "dt" */
                    lblEmpresa.Text = dt.Rows[0]["EMPRESA"].ToString();
                    lblClasificacion.Text = dt.Rows[0]["CLASIFICACION"].ToString();
                    lblPlataforma.Text = dt.Rows[0]["TIPO_PLATAFORMA"].ToString();
                    lblPrecio.Text = dt.Rows[0]["PRECIO"].ToString();
                }
            }
        }

        protected void btnComprar_Click(object sender, EventArgs e)
        {
            
        }
    }
}