using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Modelo
{
    public class ModeloCarroConf
    {
        public static DataTable ObtenerCarrosConf()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM vehiculo";
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
        public static DataTable Cargar_estado()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM estadovehi";
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
        public static DataTable CargarEstadoid(int idEstadoVehi)
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM estadovehi WHERE idEstadoVehi = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), ModeloConexión.getConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", idEstadoVehi));
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
        //CRUD
        public static bool ActualizarEstado(int estadoVehi, int idinforme)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdupdate = new MySqlCommand(string.Format("UPDATE vehiculo SET idEstadoVehi = '" + estadoVehi + "' WHERE idVehiculo = '" + idinforme + "'"), ModeloConexión.getConnect());
                retorno = Convert.ToBoolean(cmdupdate.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }

        public static DataTable BuscarVehi(string matricula)
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM vehiculo WHERE Matricula = ?param1";
                MySqlCommand cmdbuscar = new MySqlCommand(string.Format(query), ModeloConexión.getConnect());
                cmdbuscar.Parameters.Add(new MySqlParameter("param1", matricula));
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdbuscar);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }

        }
        public static bool EliminarVehiculoConf(int idinforme)
        {
            bool retorno;
            try
            {
                MySqlCommand cmddel = new MySqlCommand(string.Format("DELETE FROM vehiculo WHERE idVehiculo = '" + idinforme + "'"), ModeloConexión.getConnect());
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
