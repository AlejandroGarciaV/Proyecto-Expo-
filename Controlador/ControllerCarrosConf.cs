using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using Modelo;

namespace Controlador
{
    public class ControllerCarrosConf
    {
        //Cargar datos al DataGridView
        public static DataTable CargarCarrosController()
        {
            return ModeloCarroConf.ObtenerCarrosConf();
        }
        //Actualizacion de estado
        public int idEstadovehi { get; set; }
        public static int idinfo { get; set; }
        public string matricula { get; set; }
        public ControllerCarrosConf(int estadoVehiculo, string Matricula)
        {
            idEstadovehi = estadoVehiculo;
            matricula = Matricula;
        }

        public bool ActualizarEstado_Contoller()
        {
            return ModeloCarroConf.ActualizarEstado(idEstadovehi, idinfo);
        }
        //Buscador
        public DataTable BusquedaController()
        {
            return ModeloCarroConf.BuscarVehi(matricula);
        }

        //Llenado la el comboBox de estado
        public static DataTable CargarEstadoVehi()
        {
            return ModeloCarroConf.Cargar_estado();
        }
        //Llenando el ComboBox con el id del estado en la base de datos 
        public static DataTable Consultaidestado(int id)
        {
            return ModeloCarroConf.CargarEstadoid(id);
        }
        public static bool EliminarDatosController()
        {
            return ModeloCarroConf.EliminarVehiculoConf(idinfo);
        }
    }
}
