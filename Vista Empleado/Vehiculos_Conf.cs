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
    public partial class Vehiculos_Conf : Form
    {
        public ControllerCarrosConf objecontroller;

        public Vehiculos_Conf()
        {
            InitializeComponent();
        }

        void obtenerCarros()
        {
            dgvVehiculosConf.DataSource = ControllerCarrosConf.CargarCarrosController();
        }

        void actualizarEstado()
        {
            ControllerCarrosConf.idinfo = Convert.ToInt16(txtIdinforme.Text);
            objecontroller = new ControllerCarrosConf(Convert.ToInt16(cmbEstadoCarro.SelectedValue), txtmatriculaconf.Text);
            bool respuesta = objecontroller.ActualizarEstado_Contoller();
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

        void BuscarVehi()
        {
            objecontroller = new ControllerCarrosConf(Convert.ToInt16(cmbEstadoCarro.SelectedValue), txtmatriculaconf.Text);
            dgvVehiculosConf.DataSource = objecontroller.BusquedaController();
            if (txtmatriculaconf.Text == "")
            {
                obtenerCarros();
            }
        }

        void CargarEstadoVehi()
        {
            try
            {
                cmbEstadoCarro.DataSource = ControllerCarrosConf.CargarEstadoVehi();
                cmbEstadoCarro.ValueMember = "idEstadoVehi";
                cmbEstadoCarro.DisplayMember = "Estado_Vehi";
            }
            catch (Exception)
            {
                MessageBox.Show("Error en cargar estados de vehiculos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void LimpiarCampos()
        {
            txtIdinforme.Clear();
            txtmatriculaCarro.Clear();
            txtmatriculaconf.Clear();
        }

        private void Vehiculos_Conf_Load(object sender, EventArgs e)
        {
            obtenerCarros();
            CargarEstadoVehi();
        }

        void EliminarDatos()
        {
            ControllerCarrosConf.idinfo = Convert.ToInt16(txtIdinforme.Text);
            if (MessageBox.Show("¿Está seguro que quiere eliminar el registro " + txtIdinforme.Text + "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ControllerCarrosConf.EliminarDatosController();
            }
        }

        private void dgvVehiculosConf_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion;
            posicion = dgvVehiculosConf.CurrentRow.Index;
            txtIdinforme.Text = dgvVehiculosConf[0, posicion].Value.ToString();
            txtmatriculaCarro.Text = dgvVehiculosConf[1, posicion].Value.ToString();
            int estadovehi = Convert.ToInt16(dgvVehiculosConf[2, posicion].Value.ToString());
            cmbEstadoCarro.DataSource = ControllerCarrosConf.Consultaidestado(estadovehi);
            cmbEstadoCarro.ValueMember = "idEstadoVehi";
            cmbEstadoCarro.DisplayMember = "Estado_Vehi";
        }

        private void cmbEstadoCarro_Click(object sender, EventArgs e)
        {
            CargarEstadoVehi();
        }

        private void btnActualizarEstadoV_Click(object sender, EventArgs e)
        {
            actualizarEstado();
            obtenerCarros();
            LimpiarCampos();
        }

        private void btnBuscarV_Click(object sender, EventArgs e)
        {
            BuscarVehi();
        }

        private void btnEliminarConfi_Click(object sender, EventArgs e)
        {
            EliminarDatos();
            LimpiarCampos();
            obtenerCarros();
        }

        private void btnLimpiarConfi_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            obtenerCarros();
        }
    }
}
