using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ROHAMI_GAMES_WEBAPP.AppCode.Main
{
    public class Main_DC
    {
        public DataSet comprarJuegoOferta()
        {
            DataSet dt = new DataSet();
            return dt;
        }

        public DataSet Login(string usuario, string psw)
        {
            /* Llamamos a nuestro objeto de conexión */
            Connection objCon = new Connection();

            /* Creamos el DataSet a devolver */
            DataSet ds = objCon.ValidacionLogins(usuario, psw);

            /* Retornamos el DataSet */
            return ds;
        }
    }
}