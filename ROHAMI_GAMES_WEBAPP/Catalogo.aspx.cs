﻿using ROHAMI_GAMES_WEBAPP.AppCode.Catalog.Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROHAMI_GAMES_WEBAPP
{
    public partial class Catalogo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {

                    if (Session["DatosUsuario"] == null)
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Notify", "alert('Notification : No a ingresado, porfavor ingrese con su cuenta de ROHAMI GAME ACCES.');", true);
                        Response.Redirect("Login.aspx");
                        return;
                    }
                    Catalog_BC objBC = new Catalog_BC();
                    DataTable dt = objBC.MostrarJuegos();
                    gvJuegos.DataSource = dt;
                    gvJuegos.DataBind();
                }
            }
            catch
            {
                throw;
            }
        }

        protected void btnComprar_Click(object sender, EventArgs e)
        {
            try
            {
                Catalog_BC objBC = new Catalog_BC();
                Button btnComprar = sender as Button; /* Creamos el botón de esta manera para poder tomar el DataKey */

                GridViewRow gvrEnContexto = btnComprar.NamingContainer as GridViewRow; /* Tomamos el DataKey del Row en contexto */
                int index = gvrEnContexto.RowIndex; /* Tomamos el Index del GridViewRow */

                var DataKeyNames = gvJuegos.DataKeys[index].Values; /* Creamos un objeto var para almacenar el DAtaKeyName que necesitamos */
                string idJuego = (DataKeyNames[0].ToString()); /* Lo convertimos a String para poder usarlo */

                Response.Redirect("compra.aspx?idJuego=" + idJuego);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}