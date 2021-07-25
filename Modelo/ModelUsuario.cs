using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace Modelo
{
    public class ModelUsuario
    {
        public static DataTable CargarUser()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM usuarios";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), ModeloConexión.getConnect());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }

        public static DataTable CargarEstadoUser()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM estadousuarios";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), ModeloConexión.getConnect());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adp.Fill(data);

                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }
        public static DataTable CargarTipoUser()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tipousuarios;";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), ModeloConexión.getConnect());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }

        }

        public static bool RegistrarUsuario(string usuario, string clave, int idEmpleado, int idestadousuario, int idtipousuario)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO usuarios(usuario, clave,idEmpleado, idestadousuario, idtipousuario) VALUES('{0}','{1}','{2}','{3}','{4}')", usuario, clave, idEmpleado, idestadousuario, idtipousuario), ModeloConexión.getConnect());
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno;
            }
        }
        public static DataTable CargarEstadosUsuarioInner(int id)
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM estadousuarios WHERE idestadousuario = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), ModeloConexión.getConnect());
                //Asignando valor al parametro param1
                cmdselect.Parameters.Add(new MySqlParameter("param1", id));
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }
        public static DataTable CargarTipoUsuarioInner(int id)
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tipousuarios WHERE idtipousuario = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), ModeloConexión.getConnect());
                //Asignando valor al parametro param1
                cmdselect.Parameters.Add(new MySqlParameter("param1", id));
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }
        public static bool ActualizarUsuarios(int idusuario, string usuario, string clave, int idEmpleado, int idestadousuario, int idtipousuario)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdupdate = new MySqlCommand(string.Format("UPDATE usuarios SET usuario = '" + usuario + "', clave = '" + clave + "', idEmpleado = '" + idEmpleado + "', idestadousuario = '" + idestadousuario + "', idtipousuario = '" + idtipousuario + "' WHERE idusuario = '" + idusuario + "'"), ModeloConexión.getConnect());
                retorno = Convert.ToBoolean(cmdupdate.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }
        public static bool EliminarUsuario(int id)
        {
            bool retorno;
            try
            {
                MySqlCommand cmddel = new MySqlCommand(string.Format("DELETE FROM usuarios WHERE idusuario = '" + id + "'"), ModeloConexión.getConnect());
                retorno = Convert.ToBoolean(cmddel.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }
    }
}
