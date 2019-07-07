using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;

namespace CapaNegocio
{
    class LogicaNegociosCuentas
    {
        AccesoDatosCuenta acu = new AccesoDatosCuenta();

        public int insertarComentarios(Cuentas cu)
        {
            return acu.insertarCuentas(cu);
        }

        public List<Cuentas> listarCuentas()
        {
            return acu.ListarCuentas();
        }

        public int EliminarCuentas(int idcuent)
        {
            return acu.EliminarCuentas(idcuent);
        }

        public int EditarCuentas(Cuentas cu)
        {
            return acu.EditarCuentas(cu);
        }

        public List<Cuentas> BuscarCuentas(string dato)
        {
            return acu.BuscarCuentas(dato);
        }
    }
}
