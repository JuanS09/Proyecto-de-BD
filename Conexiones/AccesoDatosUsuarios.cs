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
    public class AccesoDatosUsuarios
    {
        SqlConnection cnx;
        Usuarios s = new Usuarios();
        Conexion cn = new Conexion();
        SqlCommand cm = null;
        int indicador = 0;
        SqlDataReader dr = null;
        List<Usuarios> ListaUsuarios = null;

        public int insertarCuentas(Usuarios usu)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Usuarios", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("idusuario", "");
                cm.Parameters.AddWithValue("@cedula", usu.cedula);
                cm.Parameters.AddWithValue("@nombres", usu.nombres);
                cm.Parameters.AddWithValue("@apellidos", usu.apellidos);
                cm.Parameters.AddWithValue("@email", usu.email);
                cm.Parameters.AddWithValue("@telefono", usu.telefono);

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

        public List<Usuarios> ListarUsuarios()
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("Usuarios", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@idusuario", "");
                cm.Parameters.AddWithValue("@cedula", "");
                cm.Parameters.AddWithValue("@nombres", "");
                cm.Parameters.AddWithValue("@apellidos", "");
                cm.Parameters.AddWithValue("@email", "");
                cm.Parameters.AddWithValue("@telefono", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                ListaUsuarios = new List<Usuarios>();
                while (dr.Read())
                {
                    Usuarios us = new Usuarios();
                    us.idusuario = Convert.ToInt32(dr["idusuario"].ToString());
                    us.cedula = dr["cedula"].ToString();
                    us.nombres = dr["nombres"].ToString();
                    us.apellidos = dr["apellidos"].ToString();
                    us.email = dr["email"].ToString();
                    us.telefono = dr["telefono"].ToString();
                    ListaUsuarios.Add(us);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                ListaUsuarios = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return ListaUsuarios;
        }

        public int EliminarUsuarios(int idusu)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Usuarios", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@idusuario", idusu);
                cm.Parameters.AddWithValue("@cedula", "");
                cm.Parameters.AddWithValue("@nombres", "");
                cm.Parameters.AddWithValue("@apellidos", "");
                cm.Parameters.AddWithValue("@email", "");
                cm.Parameters.AddWithValue("@telefono", "");

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

        public int EditarUsuarios(Usuarios usu)
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("Usuarios", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@idusuario", usu.idusuario);
                cm.Parameters.AddWithValue("@cedula", "");
                cm.Parameters.AddWithValue("@nombres", "");
                cm.Parameters.AddWithValue("@apellidos", "");
                cm.Parameters.AddWithValue("@email", "");
                cm.Parameters.AddWithValue("@telefono", "");
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

        public List<Usuarios> BuscarUsuarios(string dato)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Usuarios", cnx);
                cm.Parameters.AddWithValue("@b", 5);
                cm.Parameters.AddWithValue("@idusuario", "");
                cm.Parameters.AddWithValue("@cedula", dato);
                cm.Parameters.AddWithValue("@nombres", "");
                cm.Parameters.AddWithValue("@apellidos", "");
                cm.Parameters.AddWithValue("@email", dato);
                cm.Parameters.AddWithValue("@telefono", dato);

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                ListaUsuarios = new List<Usuarios>();

                while (dr.Read())
                {
                    Usuarios us = new Usuarios();
                    us.idusuario = Convert.ToInt32(dr["idusuario"].ToString());
                    us.cedula = dr["cedula"].ToString();
                    us.nombres = dr["nombres"].ToString();
                    us.apellidos = dr["apellidos"].ToString();
                    us.email = dr["email"].ToString();
                    us.telefono = dr["telefono"].ToString();
                    ListaUsuarios.Add(us);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                ListaUsuarios = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return ListaUsuarios;
        }
    }
}
