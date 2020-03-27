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
        public int CompraJuego(string idJuego, string idUsuario, string tipoPago)
        {
            SqlConnection objCon = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            objCon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objCon;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "RG_spi_ComprarJuego";

            cmd.Parameters.AddWithValue("@ID_USUARIO", idUsuario);
            cmd.Parameters.AddWithValue("@ID_JUEGO", idJuego);
            cmd.Parameters.AddWithValue("@TIPO_PAGO", tipoPago);
            cmd.ExecuteNonQuery();

            return 0;
        }

        public DataTable LlenaTarjetas(string idUsuario)
        {
            SqlConnection objCon = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            objCon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objCon;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "RG_spq_MostrarTarjetas";

            cmd.Parameters.AddWithValue("@ID_USUARIO", idUsuario);
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }
}