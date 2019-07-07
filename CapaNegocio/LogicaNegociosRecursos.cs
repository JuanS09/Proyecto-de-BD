using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;

namespace CapaNegocio
{
    class LogicaNegociosRecursos
    {
        AccesoDatosRecursos acu = new AccesoDatosRecursos();

        public int insertarRecursos(Recursos rec)
        {
            return acu.insertarRecursos(rec);
        }

        public List<Recursos> ListarRecursos()
        {
            return acu.ListarRecursos();
        }

        public int EliminarRecursos(int idrec)
        {
            return acu.EliminarRecursos(idrec);
        }

        public int EditarRecursos(Recursos rec)
        {
            return acu.EditarRecursos(rec);
        }

        public List<Recursos> BuscarRecursos(string dato)
        {
            return acu.BuscarRecursos(dato);
        }
    }
}
