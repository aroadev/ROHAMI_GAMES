using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ROHAMI_GAMES_WEBAPP.AppCode.ConfiguracionCuenta.Data
{
    public class ConfiguracionCuenta_DC
    {
        public int CambioPassword (string NuevoPassword, string idUsuario)
        {
            SqlConnection objCon = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            objCon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objCon;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "RG_spu_ActualizarPassword";

            cmd.Parameters.AddWithValue("@ID_USUARIO", idUsuario);
            cmd.Parameters.AddWithValue("@NEWPSSWORD", NuevoPassword);
            cmd.ExecuteNonQuery();
            return 0;
        }

        public void ActualizaDatos (string idUsuario, string nUsuario, string NombreReal, string Apellido, string Correo)
        {
            SqlConnection objCon = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            objCon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objCon;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "RG_spu_ActualizarDatosUsuario";

            cmd.Parameters.AddWithValue("@ID_USUARIO", idUsuario);
            cmd.Parameters.AddWithValue("@USERNAME", nUsuario);
            cmd.Parameters.AddWithValue("@NOMBRE", NombreReal);
            cmd.Parameters.AddWithValue("@APELLIDO_MATENRO", Apellido);
            cmd.Parameters.AddWithValue("@CORREO", Apellido);
            cmd.ExecuteNonQuery();
        }
    }
}