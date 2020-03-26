using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ROHAMI_GAMES_WEBAPP.AppCode.Register.Data
{
    public class Register_DC
    {
        public int registrarUsuario(string usuario, string contraseña, string nombre, string apellido, string correo, string telefono)
        {
            SqlConnection objCon = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            objCon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objCon;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "RG_spi_GuardaUsuario";

            cmd.Parameters.AddWithValue("@USERNAME", usuario);
            cmd.Parameters.AddWithValue("@CONTRASEÑA", contraseña);
            cmd.Parameters.AddWithValue("@NOMBRE", nombre);
            cmd.Parameters.AddWithValue("@APELLIDO_MATERNO", apellido);
            cmd.Parameters.AddWithValue("@CORREO", correo);
            cmd.Parameters.AddWithValue("@TELEFONO", telefono);
            cmd.ExecuteNonQuery();

            return 1;
        }
    }
}