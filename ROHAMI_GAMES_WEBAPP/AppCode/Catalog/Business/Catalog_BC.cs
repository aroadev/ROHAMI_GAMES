using ROHAMI_GAMES_WEBAPP.AppCode.Catalog.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ROHAMI_GAMES_WEBAPP.AppCode.Catalog.Business
{
    public class Catalog_BC
    {
        public DataTable  MostrarJuegos()
        {
            Catalog_DC objDC = new Catalog_DC();
            DataTable dt = objDC.MostrarJuegos();
            return dt;
        }
    }
}