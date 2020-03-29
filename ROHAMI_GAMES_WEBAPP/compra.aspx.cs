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
            
            if (!IsPostBack)
            {
                if (Session["DatosUsuario"] == null) /* Comparamos si la Session del usuario viene vacía evitando la ruptura de código. */
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Notify", "alert('Notification : No a ingresado, porfavor ingrese con su cuenta de ROHAMI GAMES ACCES.');", true);
                    Response.Redirect("Login.aspx"); /* Redireccionamos al Login para que el usuario acceda a su Login. */
                }
                else
                {
                    compra_BC objBC = new compra_BC(); /* Se llama a la clase de Bussines. */
                    DataSet ds = (DataSet)Session["DatosUsuario"]; /* Bajamos los datos de sesión del usuario. */
                    string idUsuario = ds.Tables[0].Rows[0]["ID_USUARIO"].ToString();
                    DataTable dt = objBC.LlenaTarjetas(idUsuario); /* Llenamos un data table con los valores de las tarjetas almacenadas del usuario. */

                    if (dt == null) /* Evaluamos si la tabla de tarjetas viene vacía. */
                    {
                        /* Le mandamos una advertencia al usuario dónde le comentamos que no tiene datos de tarjeta asociados a su cuenta */
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Notify", "alert('Advertencia: No tiene datos de tarjeta, porfavor en la configuración de su cuenta agrege una.');", true);
                        ddlTiposPago.SelectedValue = "No hay tarjetas registradas"; /* Al venir vacía ponemos el valor seleccionado como el texto. */
                    }
                    else 
                    {
                        /* Encambio si viene con datos, la llenamos con el DataTable y la pintamos con las tarjetas registradas del Usuario. */
                        ddlTiposPago.DataSource = dt; /* Colo camos el origen de los datos. */
                        ddlTiposPago.DataBind(); /* Pintamos los datos */
                    }

                    lblUsuario.Text = ds.Tables[0].Rows[0]["USERNAME"].ToString(); /* Sacamos el nombre del usuario. */
                    string idJuego = Request.QueryString["idJuego"].ToString(); /* Atrapamos el QueryString en una variable string. */
                   
                    DataTable dtJuegos = objBC.mostrarJuegoEnCompra(idJuego); /* Se crea la tabla "dtJuegos" con los valores de la clase de Bussines. */
                    lblNombreJuego.Text = dtJuegos.Rows[0]["NOMBRE"].ToString(); /* Se asigna al Label el nombre del juego desde la tabla "dt". */
                    lblEmpresa.Text = dtJuegos.Rows[0]["EMPRESA"].ToString();
                    lblClasificacion.Text = dtJuegos.Rows[0]["CLASIFICACION"].ToString();
                    lblPlataforma.Text = dtJuegos.Rows[0]["TIPO_PLATAFORMA"].ToString();
                    lblPrecio.Text = dtJuegos.Rows[0]["PRECIO"].ToString();
                }
            }
        }

        protected void btnComprar_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)Session["DatosUsuario"]; /* Llenamos un DataTable con los datos del usuario. */
            compra_BC objBC = new compra_BC(); /* Llamamos a la clase Business. */
            
            if (ddlTiposPago.SelectedValue == "No hay tarjetas registradas")
            {
                /* Se le advierte al cliente que no cuenta con metodos de pago */
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Notify", "alert('Advertencia: No tiene datos de tarjeta, porfavor en la configuración de su cuenta agrege una.');", true);
                return; /* Retornamos para evitar que sigan las demás instrucciones */
            }
            else
            {
                string idJuego = Request.QueryString["idJuego"].ToString(); /* Atrapamos el QueryString en una variable string. */
                string idUsuario = dt.Rows[0]["ID_USUARIO"].ToString(); /* Sacamos del DataTable el ID del usuario. */
                string tipoPago = ddlTiposPago.SelectedValue; /* Tomamos el valor seleccionado de las tarjetas del usuario. */
                objBC.CompraJuego(idJuego, idUsuario, tipoPago); /* Usamos la funcion CompraJuego para almacenar la compra del usuario. */
            } 
        }
    }
}