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
    public class AccesoDatosRecursos
    {
        SqlConnection cnx;
        Recursos s = new Recursos();
        Conexion cn = new Conexion();
        SqlCommand cm = null;
        int indicador = 0;
        SqlDataReader dr = null;
        List<Recursos> ListaRecursos = null;

        public int insertarRecursos(Recursos re)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Recursos", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("idrecursos", "");
                cm.Parameters.AddWithValue("@nombrer", re.nombrer);
                cm.Parameters.AddWithValue("@codigo", re.codigo);
                cm.Parameters.AddWithValue("@descripcion", re.descripcion);

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

        public List<Recursos> ListarRecursos()
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("Recursos", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@idrecursos", "");
                cm.Parameters.AddWithValue("@nombrer", "");
                cm.Parameters.AddWithValue("@codigo", "");
                cm.Parameters.AddWithValue("@descripcion", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                ListaRecursos = new List<Recursos>();
                while (dr.Read())
                {
                    Recursos rec = new Recursos();
                    rec.idrecursos = Convert.ToInt32(dr["idrecursos"].ToString());
                    rec.nombrer = dr["nombrer"].ToString();
                    rec.codigo = dr["codigo"].ToString();
                    rec.descripcion = dr["descripcion"].ToString();
                    ListaRecursos.Add(rec);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                ListaRecursos = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return ListaRecursos;
        }

        public int EliminarRecursos(int idrec)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Recursos", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@idrecursos", idrec);
                cm.Parameters.AddWithValue("@nombrer", "");
                cm.Parameters.AddWithValue("@codigo", "");
                cm.Parameters.AddWithValue("@descripcion", "");

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

        public int EditarRecursos(Recursos re)
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("Recursos", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@idrecursos", re.idrecursos);
                cm.Parameters.AddWithValue("@nombrer", "");
                cm.Parameters.AddWithValue("@codigo", "");
                cm.Parameters.AddWithValue("@descripcion", "");
                /*cm.Parameters.AddWithValue("@mensaje", co.mensaje);*/

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

        public List<Recursos> BuscarRecursos(string dato)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Recursos", cnx);
                cm.Parameters.AddWithValue("@b", 5);
                cm.Parameters.AddWithValue("@idrecursos", "");
                cm.Parameters.AddWithValue("@nombrer", dato);
                cm.Parameters.AddWithValue("@codigo", "");
                cm.Parameters.AddWithValue("@descripcion", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                ListaRecursos = new List<Recursos>();

                while (dr.Read())
                {
                    Recursos rec = new Recursos();
                    rec.idrecursos = Convert.ToInt32(dr["idrecursos"].ToString());
                    rec.nombrer = dr["nombrer"].ToString();
                    rec.codigo = dr["codigo"].ToString();
                    rec.descripcion = dr["descripcion"].ToString();
                    ListaRecursos.Add(rec);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                ListaRecursos = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return ListaRecursos;
        }
    }
}
