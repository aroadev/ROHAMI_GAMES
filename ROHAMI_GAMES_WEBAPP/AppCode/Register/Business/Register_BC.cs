using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ROHAMI_GAMES_WEBAPP.AppCode.Register.Data;

namespace ROHAMI_GAMES_WEBAPP.AppCode.Register.Business
{
    public class Register_BC
    {
        public int registrarUsuario(string usuario, string contraseña, string nombre, string apellido, string correo, string telefono)
        {
            Register_DC ObjDC = new Register_DC();
            return ObjDC.registrarUsuario(usuario, contraseña, nombre, apellido, correo, telefono);
        }
    }
}