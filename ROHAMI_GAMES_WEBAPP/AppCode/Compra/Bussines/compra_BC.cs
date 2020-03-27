using ROHAMI_GAMES_WEBAPP.AppCode.Compra.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ROHAMI_GAMES_WEBAPP.AppCode.Compra.Bussines
{
    public class compra_BC
    {
        public DataTable mostrarJuegoEnCompra(string idJuego)
        {
            compra_DC objDC = new compra_DC();
            DataTable dt = objDC.mostrarJuegoEnCompra(idJuego);
            return dt;
        }

        public int CompraJuego(string idJuego, string idUsuario, string tipoPago)
        {
            compra_DC objDC = new compra_DC();
            objDC.CompraJuego(idJuego, idUsuario, tipoPago);
            return 0;
        }

        public DataTable LlenaTarjetas(string idUsuario)
        {
            compra_DC objDC = new compra_DC();
            DataTable dt = objDC.LlenaTarjetas(idUsuario);
            return dt;
        }
    }
}