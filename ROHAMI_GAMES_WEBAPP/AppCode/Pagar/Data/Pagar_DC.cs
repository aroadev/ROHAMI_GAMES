using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ROHAMI_GAMES_WEBAPP.AppCode.Pagar.Data
{
    public class Pagar_DC
    {
        public int GuardarPago (string acreedor, string numero, string expiracion, string cvv, string idUsuario)
        {
            SqlConnection objCon = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            objCon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objCon;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "RG_spi_GuardarDatosTarjeta";

            cmd.Parameters.AddWithValue("@OWNER", acreedor);
            cmd.Parameters.AddWithValue("@NUMERO", numero);
            cmd.Parameters.AddWithValue("@EXPIRACION", expiracion);
            cmd.Parameters.AddWithValue("@CVV", cvv);
            cmd.Parameters.AddWithValue("@ID_USUARIO", idUsuario);
            cmd.ExecuteNonQuery();


            return 0;
        }
    }
}