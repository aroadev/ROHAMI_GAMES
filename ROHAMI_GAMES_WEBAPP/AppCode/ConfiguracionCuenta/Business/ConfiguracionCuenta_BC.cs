using ROHAMI_GAMES_WEBAPP.AppCode.ConfiguracionCuenta.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ROHAMI_GAMES_WEBAPP.AppCode.ConfiguracionCuenta.Business
{
    public class ConfiguracionCuenta_BC
    {
        public int CambioPassword(string NuevoPassword, string idUsuario)
        {
            ConfiguracionCuenta_DC objDC = new ConfiguracionCuenta_DC();
            _ = objDC.CambioPassword(NuevoPassword, idUsuario); /* Usamos una opcion de descarte para ejecutar la función */
            return 0;
        }

        public void ActualizaDatos(string idUsuario, string nUsuario, string NombreReal, string Apellido, string Correo)
        {
            ConfiguracionCuenta_DC objDC = new ConfiguracionCuenta_DC();
            _ = objDC.ActualizaDatos(idUsuario, nUsuario, NombreReal, Apellido, Correo);
        }
    }
}