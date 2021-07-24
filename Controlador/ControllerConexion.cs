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
    public class ControllerConexion
    {
        public static MySqlConnection ConnectController()
        { 
            return ModeloConexión.getConnect();
        }

        public static MySqlConnection Conectar_Modelo()
        {
            return ModeloConexión.getConnect();
        }
                
    }
}
