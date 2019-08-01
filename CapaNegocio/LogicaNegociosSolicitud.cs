using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;

namespace CapaNegocio
{
    public class LogicaNegociosSolicitud
    {
        AccesoDatosSolicitud soli = new AccesoDatosSolicitud();

        public int insertarSolicitud(Solicitud sol)
        {
            return soli.insertarSolicitud(sol);
        }

        public List<Solicitud> ListarSolicitud()
        {
            return soli.ListarSolicitud();
        }

        public int EliminarSolicitud(int idsoli)
        {
            return soli.EliminarSolicitud(idsoli);
        }

        public int EditarSolicitud(Solicitud so)
        {
            return soli.EditarSolicitud(so);
        }

        public List<Solicitud> BuscarSolicitud(string dato)
        {
            return soli.BuscarSolicitud(dato);
        }
    }
}
