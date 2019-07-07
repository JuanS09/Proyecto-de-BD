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
    public class AccesoDatosCuenta
    {
        SqlConnection cnx;
        Cuentas s = new Cuentas();
        Conexion cn = new Conexion();
        SqlCommand cm = null;
        int indicador = 0;
        SqlDataReader dr = null;
        List<Cuentas> ListaCuentas = null;

        public int insertarCuentas(Cuentas cu)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Cuentas", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("idcuenta", "");
                cm.Parameters.AddWithValue("@nombreuser", cu.nombreuser);
                cm.Parameters.AddWithValue("@clave", cu.clave);
                cm.Parameters.AddWithValue("@rol", cu.rol);

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

        public List<Cuentas> ListarCuentas()
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("Cuentas", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@idcuenta", "");
                cm.Parameters.AddWithValue("@nombreuser", "");
                cm.Parameters.AddWithValue("@clave", "");
                cm.Parameters.AddWithValue("@rol", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                ListaCuentas = new List<Cuentas>();
                while (dr.Read())
                {
                    Cuentas ct = new Cuentas();
                    ct.idcuenta = Convert.ToInt32(dr["idcuenta"].ToString());
                    ct.nombreuser = dr["nombreuser"].ToString();
                    ct.clave = dr["clave"].ToString();
                    ct.rol = dr["rol"].ToString();
                    ListaCuentas.Add(ct);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                ListaCuentas = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return ListaCuentas;
        }

        public int EliminarCuentas(int idcuen)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Cuentas", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@idcuenta", idcuen);
                cm.Parameters.AddWithValue("@nombreuser", "");
                cm.Parameters.AddWithValue("@clave", "");
                cm.Parameters.AddWithValue("@rol", "");

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

        public int EditarCuentas(Cuentas cu)
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("Cuentas", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@idcuenta", cu.idcuenta);
                cm.Parameters.AddWithValue("@nombreuser", "");
                cm.Parameters.AddWithValue("@clave", "");
                cm.Parameters.AddWithValue("@rol", "");
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

        public List<Cuentas> BuscarCuentas(string dato)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Cuentas", cnx);
                cm.Parameters.AddWithValue("@b", 5);
                cm.Parameters.AddWithValue("@idcuenta", "");
                cm.Parameters.AddWithValue("@nombreuser", dato);
                cm.Parameters.AddWithValue("@clave", "");
                cm.Parameters.AddWithValue("@rol", dato);

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                ListaCuentas = new List<Cuentas>();

                while (dr.Read())
                {
                    Cuentas ct = new Cuentas();
                    ct.idcuenta = Convert.ToInt32(dr["idcuenta"].ToString());
                    ct.nombreuser = dr["nombreuser"].ToString();
                    ct.clave = dr["clave"].ToString();
                    ct.rol = dr["rol"].ToString();
                    ListaCuentas.Add(ct);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                ListaCuentas = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return ListaCuentas;
        }
    }
}
