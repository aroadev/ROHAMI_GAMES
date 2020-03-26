using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace ROHAMI_GAMES_WEBAPP.AppCode.AgregarJuego.Data
{
    public class AgregarJuego_Data
    {
        public int SubirJuego(string NombreJuego, string NombreEmpresa, string Plataforma, string Clasificacion, string Precio, byte[] Imagen)
        {
            SqlConnection objCon = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            objCon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objCon;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "RG_spi_SubirJuego";

            cmd.Parameters.AddWithValue("@NOMBRE", NombreJuego);
            cmd.Parameters.AddWithValue("@EMPRESA", NombreEmpresa);
            cmd.Parameters.AddWithValue("PLATAFORMA", Plataforma);
            cmd.Parameters.AddWithValue("@CLASIFICACION", Clasificacion);
            cmd.Parameters.AddWithValue("@PRECIO", Precio);
            cmd.Parameters.Add("@IMAGEN", SqlDbType.Image).Value = Imagen;
            cmd.ExecuteNonQuery();

            return 0;
        }
    }
}