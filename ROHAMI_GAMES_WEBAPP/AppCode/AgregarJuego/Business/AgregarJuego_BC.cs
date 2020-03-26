using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ROHAMI_GAMES_WEBAPP.AppCode.AgregarJuego.Data;

namespace ROHAMI_GAMES_WEBAPP.AppCode.AgregarJuego.Business
{
    public class AgregarJuego_BC
    {
        public int SubirJuego(string NombreJuego, string NombreEmpresa, string Plataforma, string Clasificacion, string Precio, byte[] Imagen)
        {
            AgregarJuego_Data objDC = new AgregarJuego_Data();
            return objDC.SubirJuego(NombreJuego, NombreEmpresa, Plataforma, Clasificacion, Precio, Imagen);
        }
    }
}