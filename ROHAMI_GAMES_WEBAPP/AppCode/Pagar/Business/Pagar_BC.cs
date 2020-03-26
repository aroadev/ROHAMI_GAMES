using ROHAMI_GAMES_WEBAPP.AppCode.Pagar.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ROHAMI_GAMES_WEBAPP.AppCode.Pagar.Business
{
    public class Pagar_BC
    {
        public int GuardarPago(string acreedor, string numero, string expiracion, string cvv, string idUsuario)
        {
            Pagar_DC objDC = new Pagar_DC();
            return objDC.GuardarPago(acreedor, numero, expiracion, cvv, idUsuario);
        }
    }
}