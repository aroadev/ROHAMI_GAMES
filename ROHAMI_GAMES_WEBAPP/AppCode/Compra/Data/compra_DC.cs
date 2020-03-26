using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ROHAMI_GAMES_WEBAPP.AppCode.Compra.Data
{
    public class compra_DC
    {
        public DataTable mostrarJuegoEnCompra(string idJuego)
        {
            SqlConnection objCon = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            objCon.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = objCon;
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "RG_spq_JuegoEnCompra";

            com.Parameters.AddWithValue("@ID_JUEGO", idJuego);
            com.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
        public DataSet comprarJuego()
        {
            DataSet ds = new DataSet();
            return ds;
        }
    }
}