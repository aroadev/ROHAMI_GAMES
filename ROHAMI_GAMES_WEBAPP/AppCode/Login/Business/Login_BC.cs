using ROHAMI_GAMES_WEBAPP.AppCode.Login.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ROHAMI_GAMES_WEBAPP.AppCode.Login.Business
{
    public class Login_BC
    {
        public DataSet ValidarLogin (string usuario, string password)
        {
            DataSet ds = new DataSet();
            Login_DC ObjDC = new Login_DC();
            return ds = ObjDC.ValidarLogin(usuario, password);
        }
    }
}