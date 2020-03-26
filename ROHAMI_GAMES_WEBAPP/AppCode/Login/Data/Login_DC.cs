using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ROHAMI_GAMES_WEBAPP.AppCode.Login.Data
{
    public class Login_DC
    {
        public DataSet ValidarLogin (string usuario, string password)
        {
            SqlConnection objCon = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            objCon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objCon;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "RG_spq_Login";

            cmd.Parameters.AddWithValue("@USERNAME", usuario);
            cmd.Parameters.AddWithValue("@PASSWORD", password);
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return ds;
        }
    }
}