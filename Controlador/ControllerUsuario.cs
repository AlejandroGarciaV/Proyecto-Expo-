using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data;

namespace Controlador
{
    public class ControllerUsuario
    {
        public static DataTable ObtenerUser()
        {
            return ModelUsuario.CargarUser();
        }
        public static DataTable ObtenerEstadoUser()
        {
            return ModelUsuario.CargarEstadoUser();
        }
        public static DataTable ObtenerTipoUser()
        {
            return ModelUsuario.CargarTipoUser();
        }
        public static int idusuario { get; set; }
        public string usuario { get; set; }
        public string clave { get; set; }
        public int idEmpleado { get; set; }
        public int idestadousuario { get; set; }
        public int idtipousuario { get; set; }

        public ControllerUsuario(string pusuario, string pclave, int pidEmpleado, int pidestadousuario, int pidtipousuario)
        {

            usuario = pusuario;
            clave = pclave;
            idEmpleado = pidEmpleado;
            idestadousuario = pidestadousuario;
            idtipousuario = pidtipousuario;
        }
        public bool EnviarDatosController()
        {
            return ModelUsuario.RegistrarUsuario(usuario, clave, idEmpleado, idestadousuario, idtipousuario);
        }
        public static DataTable CargarEstadoUsuarioInnerJoin_Controller(int id)
        {
            return ModelUsuario.CargarEstadosUsuarioInner(id);
        }
        public static DataTable CargartipoUsuariosInnerJoin_Controller(int id)
        {
            return ModelUsuario.CargarTipoUsuarioInner(id);
        }
        public bool ActualizarDatosController()
        {
            return ModelUsuario.ActualizarUsuarios(idusuario, usuario, clave, idEmpleado, idestadousuario, idtipousuario);
        }
        public static bool EliminarUser_Controller()
        {
            return ModelUsuario.EliminarUsuario(idusuario);
        }
    }
}
