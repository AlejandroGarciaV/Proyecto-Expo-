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
    public class ControllerRegistroVehi
    {
        public static DataTable ObtenerDepartamento()
        {
            return ModelRegistroVehi.CargarDepartamento();
        }

        public static DataTable ObtenerMunicipio()
        {
            return ModelRegistroVehi.CargarMunicipio();
        }

        public static DataTable ObtenerDelegacion()
        {
            return ModelRegistroVehi.CargarDelegacion();
        }

        public static DataTable ObtenerRazon()
        {
            return ModelRegistroVehi.CargarRazon();
        }

        public static DataTable ObtenerTipoVehiculo()
        {
            return ModelRegistroVehi.CargarTipoVehiculo();
        }

        public static DataTable ObtenerEstado()
        {
            return ModelRegistroVehi.CargarEstado();
        }

        public static int idVehiculo { get; set; }
        public string matricula { get; set; }
        public string modelo { get; set; }
        public string marca { get; set; }
        public string color { get; set; }
        public string año { get; set; }
        public string fechaconf { get; set; }
        public string direccionconf { get; set; }
        public int departamento { get; set; }
        public int municipio { get; set; }
        public int delegacion { get; set; }
        public int razon { get; set; }
        public int tipovehi { get; set; }
        public int estado { get; set; }

        public ControllerRegistroVehi(string pmatricula, string pmodelo, string pmarca, string pcolor, string paño, string pfechaconf, string pdireccionconf, int pdepartamento, int pmunicipio, int pdelegacion, int prazon, int ptipovehi, int pestado)
            

        {
            matricula = pmatricula;
            modelo = pmodelo;
            marca = pmarca;
            color = pcolor;
            año = paño;
            fechaconf = pfechaconf;
            direccionconf = pdireccionconf;
            departamento = pdepartamento;
            municipio = pmunicipio;
            delegacion = pdelegacion;
            razon = prazon;
            tipovehi = ptipovehi;
            estado = pestado;

        }

        public bool EnviarDatosController()
        {
            return ModelRegistroVehi.RegistrarVehiculo(matricula, modelo, marca, color, año, fechaconf, direccionconf, departamento, municipio, delegacion, razon, tipovehi, estado);
        }

       
    }
}
