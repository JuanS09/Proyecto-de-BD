using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;

namespace CapaNegocio
{
    public class LogicaNegociosComentarios
    {
        AccesoDatosComentarios ac = new AccesoDatosComentarios();

        public int insertarComentarios(Comentarios co)
        {
            return ac.insertarComentarios(co);
        }

        public List<Comentarios> listarComentarios()
        {
            return ac.ListarComentarios();
        }

        public int eliminarComentarios(int idcoment)
        {
            return ac.EliminarComentarios(idcoment);
        }
        
        public int EditarComentarios(Comentarios co)
        {
            return ac.EditarComentarios(co);
        }

        public List<Comentarios> BuscarComentarios(string dato)
        {
            return ac.BuscarComentarios(dato);
        }
        
    }
}
