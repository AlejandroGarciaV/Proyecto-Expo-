using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Controlador
{
    public class ControllerConexion
    {
        public static MySqlConnection ConnectController()
        { 
            return Modelo.ModeloConexión.getConnect();
        }
    }
}
