using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace Modelo
{
    public class ModelRegistroVehi
    {
        public static DataTable CargarDepartamento()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM departamento";
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
            finally
            {
                ModeloConexión.getConnect().Close();
            }
        }

        public static DataTable CargarMunicipio()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM municipio";
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
            finally
            {
                ModeloConexión.getConnect().Close();
            }
        }

        public static DataTable CargarDelegacion()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM delegacion";
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
            finally
            {
                ModeloConexión.getConnect().Close();
            }
        }

        public static DataTable CargarRazon()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM razon";
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

            finally
            {
                ModeloConexión.getConnect().Close();
            }
        }

        public static DataTable CargarTipoVehiculo()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tipodevehiculo";
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
            finally
            {
                ModeloConexión.getConnect().Close();
            }
        }

        public static DataTable CargarEstado()
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
            finally
            {
                ModeloConexión.getConnect().Close();
            }
        }

        public static bool RegistrarVehiculo(string matricula, string modelo, string marca, string color, string año, string fechaconf, string direccionconf, int departamento, int municipio, int delegacion, int razon, int tipovehi, int estado)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO vehiculo (idEstadoVehi, idTipoVehi, idDepartamento, idMunicipio, idDelegacion, idRazon, matricula, modelo, marca, color, año, fechaconf, direccionconf) VALUES ('{0}', '{1}', '{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}')", estado, tipovehi, departamento, municipio, delegacion, razon, matricula, modelo, marca, color, año, fechaconf, direccionconf), ModeloConexión.getConnect());
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno;
            }
        }

        
    }
}
