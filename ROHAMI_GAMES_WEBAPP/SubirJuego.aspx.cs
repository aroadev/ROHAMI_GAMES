using ROHAMI_GAMES_WEBAPP.AppCode.AgregarJuego.Business;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROHAMI_GAMES_WEBAPP
{
    public partial class SubirJuego : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubir_Click(object sender, EventArgs e)
        {
            AgregarJuego_BC objBC = new AgregarJuego_BC();
            int size = fuImagen.PostedFile.ContentLength;
            byte[] img = new byte[size];

            fuImagen.PostedFile.InputStream.Read(img, 0, size);

            Bitmap imgBinary = new Bitmap(fuImagen.PostedFile.InputStream);
            string img64 = "data:image/jpg.base64," + Convert.ToBase64String(img);

            string Nombre = txtNombreJuego.Text.Trim().ToUpper();
            string Empresa = txtEmpresa.Text.Trim().ToUpper();
            string Plataforma = ddlPlataforma.SelectedValue.Trim().ToUpper();
            string Clasificacion = ddlClasificacion.SelectedValue.Trim().ToUpper();
            string Precio = txtPrecio.Text.Trim().ToUpper();

            objBC.SubirJuego(Nombre, Empresa, Plataforma, Clasificacion, Precio, img);
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Notify", "alert('Juego subido exitosamente');", true);
        }

        protected void btnExit_Click(object sender, EventArgs e)
        {
            Response.Redirect("main.aspx");
        }
    }
}