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
    public class AccesoDatosSolicitud
    {
        SqlConnection cnx;
        Solicitud s = new Solicitud();
        Conexion cn = new Conexion();
        SqlCommand cm = null;
        int indicador = 0;
        SqlDataReader dr = null;
        List<Solicitud> ListaSolicitud = null;

        public int insertarSolicitud(Solicitud sol)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Solicitar", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("idsolicitud", "");
                cm.Parameters.AddWithValue("@aula", sol.aula);
                cm.Parameters.AddWithValue("@nivel", sol.nivel);
                cm.Parameters.AddWithValue("@fechasolicitud", sol.fechasolicitud);
                cm.Parameters.AddWithValue("@fechauso", sol.fechauso);
                cm.Parameters.AddWithValue("@horainicio", sol.horainicio);
                cm.Parameters.AddWithValue("@horafinal", sol.horafinal);
                cm.Parameters.AddWithValue("@carrera", sol.carrera);
                cm.Parameters.AddWithValue("@asignatura", sol.asignatura);
                cm.Parameters.AddWithValue("@idrecursos", sol.idrecursos);
                cm.Parameters.AddWithValue("@idusuario", sol.idusuario);

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

        public List<Solicitud> ListarSolicitud()
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("Solicitar", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@idsolicitud", "");
                cm.Parameters.AddWithValue("@aula", "");
                cm.Parameters.AddWithValue("@nivel", "");
                cm.Parameters.AddWithValue("@fechasolictud", "");
                cm.Parameters.AddWithValue("@fechauso", "");
                cm.Parameters.AddWithValue("@horainicio", "");
                cm.Parameters.AddWithValue("@horafinal", "");
                cm.Parameters.AddWithValue("@carrera", "");
                cm.Parameters.AddWithValue("@asignatura", "");
                cm.Parameters.AddWithValue("@idrecursos","");
                cm.Parameters.AddWithValue("@idusuario", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                ListaSolicitud = new List<Solicitud>();
                while (dr.Read())
                {
                    Solicitud s = new Solicitud();
                    s.idsolicitud = Convert.ToInt32(dr["idsolicitud"].ToString());
                    s.aula = dr["aula"].ToString();
                    s.nivel = dr["nivel"].ToString();
                    s.fechasolicitud = Convert.ToDateTime (dr["fechasolicitud"]);
                    s.fechauso = Convert.ToDateTime(dr["fechauso"]);
                    s.horainicio = Convert.ToDateTime(dr["horainicio"]);
                    s.horafinal = Convert.ToDateTime(dr["horafinal"]);
                    s.carrera = dr["carrera"].ToString();
                    s.asignatura = dr["asignatura"].ToString();
                    s.idrecursos = Convert.ToInt32(dr["idrecursos"].ToString());
                    s.idusuario = Convert.ToInt32(dr["idusuario"].ToString());

                    ListaSolicitud.Add(s);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                ListaSolicitud = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return ListaSolicitud;
        }

        public int EliminarSolicitud(int idsoli)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Solicitar", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@idsolicitud", idsoli);
                cm.Parameters.AddWithValue("@aula", "");
                cm.Parameters.AddWithValue("@nivel", "");
                cm.Parameters.AddWithValue("@fechasolictud", "");
                cm.Parameters.AddWithValue("@fechauso", "");
                cm.Parameters.AddWithValue("@horainicio", "");
                cm.Parameters.AddWithValue("@horafinal", "");
                cm.Parameters.AddWithValue("@carrera", "");
                cm.Parameters.AddWithValue("@asignatura", "");
                cm.Parameters.AddWithValue("@idrecursos", "");
                cm.Parameters.AddWithValue("@idusuario", "");

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

        public int EditarSolicitud(Solicitud so)
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("Solicitar", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@idsolicitud", so.idsolicitud);
                cm.Parameters.AddWithValue("@aula", so.aula);
                cm.Parameters.AddWithValue("@nivel", "");
                cm.Parameters.AddWithValue("@fechasolictud", "");
                cm.Parameters.AddWithValue("@fechauso", "");
                cm.Parameters.AddWithValue("@horainicio", "");
                cm.Parameters.AddWithValue("@horafinal", "");
                cm.Parameters.AddWithValue("@carrera", "");
                cm.Parameters.AddWithValue("@asignatura", "");

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

        public List<Solicitud> BuscarSolicitud(string dato)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Solicitar", cnx);
                cm.Parameters.AddWithValue("@b", 5);
                cm.Parameters.AddWithValue("@idsolicitud", "");
                cm.Parameters.AddWithValue("@aula", "");
                cm.Parameters.AddWithValue("@nivel", "");
                cm.Parameters.AddWithValue("@fechasolicitud", dato);
                cm.Parameters.AddWithValue("@fechauso", dato);
                cm.Parameters.AddWithValue("@horainicio", dato);
                cm.Parameters.AddWithValue("@horafinal", dato);
                cm.Parameters.AddWithValue("@carrera", dato);
                cm.Parameters.AddWithValue("@asignatura", dato);
                cm.Parameters.AddWithValue("@idrecursos", "");
                cm.Parameters.AddWithValue("@idusuario", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                ListaSolicitud = new List<Solicitud>();

                while (dr.Read())
                {
                    Solicitud s = new Solicitud();
                    s.idsolicitud = Convert.ToInt32(dr["idsolicitud"].ToString());
                    s.aula = dr["aula"].ToString();
                    s.nivel = dr["nivel"].ToString();
                    s.fechasolicitud = Convert.ToDateTime(dr["fechasolicitud"]);
                    s.fechauso = Convert.ToDateTime(dr["fechauso"]);
                    s.horainicio = Convert.ToDateTime(dr["horainicio"]);
                    s.horafinal = Convert.ToDateTime(dr["horafinal"]);
                    s.carrera = dr["carrera"].ToString();
                    s.asignatura = dr["asignatura"].ToString();
                    s.idrecursos = Convert.ToInt32(dr["idrecursos"].ToString());
                    s.idusuario = Convert.ToInt32(dr["idusuario"].ToString());
                    ListaSolicitud.Add(s);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                ListaSolicitud = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return ListaSolicitud;
        }
    }
}
