using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaEntidades;
using System.Data;


namespace CapaDatos
{
     public class AccesoDatosComentarios
    {
        SqlConnection cnx;
        Comentarios s = new Comentarios();
        Conexion cn = new Conexion();
        SqlCommand cm = null;
        int indicador = 0;
        SqlDataReader dr = null;
        List<Comentarios> ListaComentarios = null;

        public int insertarComentarios(Comentarios Co)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Comentar", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("idcomentario", "");
                cm.Parameters.AddWithValue("@nombres", Co.nombres);
                cm.Parameters.AddWithValue("@correo", Co.correo);
                cm.Parameters.AddWithValue("@telefono", Co.telefono);
                cm.Parameters.AddWithValue("@mensaje", Co.mensaje);

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                cm.ExecuteNonQuery();
                indicador = 1;
            }
            catch (Exception e)
            {
                e.Message.ToString();
                indicador = 0;
            }
            finally
            {
                cm.Connection.Close();
            }
            return indicador;
        }

        public List<Comentarios> ListarComentarios()
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("Comentar", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@idcomentario", "");
                cm.Parameters.AddWithValue("@nombres", "");
                cm.Parameters.AddWithValue("@correo", "");
                cm.Parameters.AddWithValue("@telefono", "");
                cm.Parameters.AddWithValue("@mensaje", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                ListaComentarios = new List<Comentarios>();
                while (dr.Read())
                {
                    Comentarios c = new Comentarios();
                    c.idcomentario = Convert.ToInt32(dr["idcomentario"].ToString());
                    c.nombres = dr["nombre"].ToString();
                    c.correo = dr["correo"].ToString();
                    c.telefono = dr["telefono"].ToString();
                    c.mensaje = dr["mensaje"].ToString();
                    ListaComentarios.Add(c);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                ListaComentarios = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return ListaComentarios;
        }

        public int EliminarComentarios(int idcoment)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("comentar", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@idcomentario", idcoment);
                cm.Parameters.AddWithValue("@nombres", "");
                cm.Parameters.AddWithValue("@correo", "");
                cm.Parameters.AddWithValue("@telefono", "");
                cm.Parameters.AddWithValue("@mensaje", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                cm.ExecuteNonQuery();
                indicador = 1;
            }
            catch (Exception e)
            {
                e.Message.ToString();
                indicador = 0;
            }
            finally
            { cm.Connection.Close(); }
            return indicador;
        }

        public int EditarComentarios(Comentarios co)
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("Comentar", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@idcomentario", co.idcomentario);
                cm.Parameters.AddWithValue("@nombres", "");
                cm.Parameters.AddWithValue("@correo", "");
                cm.Parameters.AddWithValue("@telefono", "");
                cm.Parameters.AddWithValue("@mensaje", co.mensaje);

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                cm.ExecuteNonQuery();
                indicador = 1;
            }
            catch (Exception e)
            {
                e.Message.ToString();
                indicador = 0;
            }
            finally
            { cm.Connection.Close(); }
            return indicador;
        }

        public List<Comentarios> BuscarComentarios(string dato)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Cometar", cnx);
                cm.Parameters.AddWithValue("@b", 5);
                cm.Parameters.AddWithValue("@idcomentario", "");
                cm.Parameters.AddWithValue("@nombre", dato);
                cm.Parameters.AddWithValue("@correo", "");
                cm.Parameters.AddWithValue("@telefono", "");
                cm.Parameters.AddWithValue("@mensaje", dato);

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                ListaComentarios = new List<Comentarios>();

                while (dr.Read())
                {
                    Comentarios c = new Comentarios();
                    c.idcomentario = Convert.ToInt32(dr["idcomentario"].ToString());
                    c.nombres = dr["nombres"].ToString();
                    c.correo = dr["correo"].ToString();
                    c.telefono = dr["telefono"].ToString();
                    c.mensaje = dr["Mensaje"].ToString();
                    ListaComentarios.Add(c);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                ListaComentarios = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return ListaComentarios;
        }
    }
}
