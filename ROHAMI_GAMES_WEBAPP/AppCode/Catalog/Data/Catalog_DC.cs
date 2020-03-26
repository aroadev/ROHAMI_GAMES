using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ROHAMI_GAMES_WEBAPP.AppCode.Catalog.Data
{
    public class Catalog_DC
    {
        public DataTable MostrarJuegos ()
        {
            DataTable dt = new DataTable();
            SqlConnection objCon = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            objCon.Open();

            SqlDataAdapter SqlDa = new SqlDataAdapter("RG_spq_MostrarCatalogo", objCon);
            SqlDa.Fill(dt);
            return dt;
        }
    }
}