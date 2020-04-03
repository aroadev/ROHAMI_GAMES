using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ROHAMI_GAMES_WEBAPP.AppCode.Main
{
    public class Main_BC
    {
        public DataSet Login(string usr, string psw)
        {
            /* Creamos el objeto de la clase de Datos */
            Main_DC objDC = new Main_DC();

            /* Creamos el DataSet que devolverá la función y le asignamos el resultado de la función */
            DataSet ds = objDC.Login(usr, psw);

            /* Retornamos el DataSet */
            return ds;
        }
    }
}