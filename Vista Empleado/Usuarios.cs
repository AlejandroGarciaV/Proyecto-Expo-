using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;

namespace Vista_Empleado
{
    public partial class Usuarios : Form
    {
        ControllerUsuario objusuario;

        public Usuarios()
        {
            InitializeComponent();
        }

        void CargarUser()
        {
            dgvAdministracionUser.DataSource = ControllerUsuario.ObtenerUser();
        }

        void CargarEstadoUser()
        {
            try
            {
                cmbestadoUser.DataSource = ControllerUsuario.ObtenerEstadoUser();
                cmbestadoUser.ValueMember = "idestadousuario";
                cmbestadoUser.DisplayMember = "estadousuario";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los estado de usuarios, verifique su conexión a internet y si el problema persiste consulte con el administrador.", "Error de lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void CargarTipoUsuario()
        {
            try
            {
                DataTable retornotipouser = ControllerUsuario.ObtenerTipoUser();
                cmbTipoUser.DataSource = retornotipouser;
                cmbTipoUser.DisplayMember = "tipousuario";
                cmbTipoUser.ValueMember = "idtipousuario";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los tipos de usuarios, verifique su conexión a internet y si el problema persiste consulte con el administrador.", "Error de lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void EnvioDatos()
        {
            //DECLARANDO VARIABLES
            string usuario, clave;
            int idEmpleado, idestadousuario, idtipousuario;
            usuario = txtNombreUser.Text;
            clave = txtClaveUser.Text;
            idEmpleado = Convert.ToInt16(txtIdempleadoUser.Text);
            idestadousuario = Convert.ToInt16(cmbestadoUser.SelectedValue);
            idtipousuario = Convert.ToInt16(cmbTipoUser.SelectedValue);

            //ENVIANDO DATOS
            objusuario = new ControllerUsuario(usuario, clave, idEmpleado, idestadousuario, idtipousuario);
            bool respuesta = objusuario.EnviarDatosController();
            if (respuesta == true)
            {
                MessageBox.Show("Usuario ingresado exitosamente.", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al intentar ingresar el usuario, favor verifique los datos.", "Registro incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void LimpiarCampos()
        {
            txtNombreUser.Clear();
            txtClaveUser.Clear();
        }

        private void dgvAdministracionUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion;
            posicion = dgvAdministracionUser.CurrentRow.Index;
            txtIdUser.Text = dgvAdministracionUser[0, posicion].Value.ToString();
            txtNombreUser.Text = dgvAdministracionUser[1, posicion].Value.ToString();
            txtClaveUser.Text = dgvAdministracionUser[2, posicion].Value.ToString();
            txtIdempleadoUser.Text = dgvAdministracionUser[3, posicion].Value.ToString();

            int idestadousuario = Convert.ToInt16(dgvAdministracionUser[4, posicion].Value.ToString());
            cmbestadoUser.DataSource = ControllerUsuario.CargarEstadoUsuarioInnerJoin_Controller(idestadousuario);
            cmbestadoUser.DisplayMember = "estadousuarios";
            cmbestadoUser.ValueMember = "idestadousuario";

            int idtipousuario = Convert.ToInt16(dgvAdministracionUser[5, posicion].Value.ToString());
            cmbTipoUser.DataSource = ControllerUsuario.CargartipoUsuariosInnerJoin_Controller(idtipousuario);
            cmbTipoUser.DisplayMember = "tipousuarios";
            cmbTipoUser.ValueMember = "idtipousuario";
        }
        void ActualizarDatos()
        {
            ControllerUsuario.idusuario = Convert.ToInt16(txtIdUser.Text);
            objusuario = new ControllerUsuario(txtNombreUser.Text,
                                                   txtClaveUser.Text,
                                                   Convert.ToInt16(txtIdempleadoUser.Text),
                                                   Convert.ToInt16(cmbestadoUser.SelectedValue),
                                                   Convert.ToInt16(cmbTipoUser.SelectedValue));
            bool respuesta = objusuario.ActualizarDatosController();
            if (respuesta == true)
            {
                MessageBox.Show("Usuario actualizado exitosamente", "Proceso completado",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Usuario no pudo ser actualizado.", "Proceso inconmpleto",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void EliminarUserDatos()
        {
            ControllerUsuario.idusuario = Convert.ToInt16(txtIdUser.Text);
            if (MessageBox.Show("¿Está seguro que quiere eliminar el registro " + txtIdUser.Text + "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ControllerUsuario.EliminarUser_Controller();
                MessageBox.Show("Usuario eliminado con exito", "Informacion de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAgregarUser_Click(object sender, EventArgs e)
        {
            EnvioDatos();
            CargarUser();
            LimpiarCampos();
        }


        private void Usuarios_Load(object sender, EventArgs e)
        {
            CargarUser();
            CargarEstadoUser();
            CargarTipoUsuario();
        }

        private void btnActualizaUser_Click(object sender, EventArgs e)
        {
            ActualizarDatos();
            CargarUser();
            LimpiarCampos();
        }

        private void cmbestadoUser_Click(object sender, EventArgs e)
        {
            CargarEstadoUser();
        }

        private void cmbTipoUser_Click(object sender, EventArgs e)
        {
            CargarTipoUsuario();
        }

        private void btnBuscarUser_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnEliminarUser_Click(object sender, EventArgs e)
        {
            EliminarUserDatos();
            LimpiarCampos();
            CargarUser();
        }
    }
}
