using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ROHAMI_GAMES_WEBAPP.AppCode
{
    public class Connection
    {
        /* Cremos el objeto de la conexión par apoder llamarlo en todo el archivo. */
        SqlConnection objCon = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        /* Creamos el comando SQL */
        SqlCommand com = new SqlCommand();

        public DataSet ValidacionLogins(string Username, string Password)
        {
            /* Creamos el DataSet a retornar */
            DataSet ds = new DataSet();

            try
            {
                /* Abrimos la conexión */
                objCon.Open();
                /* Le asignamos al commando la conexión */
                com.Connection = objCon;
                /* Asignamos el tipo de comando StoredProcedure a la variable de comando */
                com.CommandType = CommandType.StoredProcedure;
                /* Le damos el nombre del Sotred Procedure para que lo ejecute */
                com.CommandText = "RG_spq_Login";

                /* Le añadimos al comando los valores necesarios para el Stoed Proceure */
                com.Parameters.AddWithValue("@USERNAME", Username);
                com.Parameters.AddWithValue("@PASSWORD", Password);
                /* Ejecutamos el comando con la función ExecuteNonQuery de SQL */
                com.ExecuteNonQuery();

                /* Creamos un SQLAdapter para llenar el DataSet */
                SqlDataAdapter sqlDa = new SqlDataAdapter(com);

                /* Le asignamos al DataSet el resultado de la ejecución del SotredProcedure */
                sqlDa.Fill(ds);

                /* Cerramos la conexión */
                objCon.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error has ocurred", ex.Message);

            }

            /* Retornamos el DataSet */
            return ds;
        }
    }
}