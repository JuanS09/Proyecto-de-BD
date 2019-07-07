using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;

namespace CapaNegocio
{
    class LogicaNegociosUsuarios
    {
        AccesoDatosUsuarios us = new AccesoDatosUsuarios();

        public int insertarCuentas(Usuarios usu)
        {
            return us.insertarCuentas(usu);
        }

        public List<Usuarios> ListarUsuarios()
        {
            return us.ListarUsuarios();
        }

        public int EliminarUsuarios(int idusu)
        {
            return us.EliminarUsuarios(idusu);
        }

        public int EditarUsuarios(Usuarios usu)
        {
            return us.EditarUsuarios(usu);
        }

        public List<Usuarios> BuscarUsuarios(string dato)
        {
            return us.BuscarUsuarios(dato);
        }
    }
}
