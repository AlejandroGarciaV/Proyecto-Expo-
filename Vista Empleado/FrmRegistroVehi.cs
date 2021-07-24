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
    public partial class FrmRegistroVehi : Form
    {
        public FrmRegistroVehi()
        {
            InitializeComponent();
        }

        private void FrmRegistroVehi_load(object sender, EventArgs e)
        {
            cargarListas();
        }

        void cargarListas()
        {
            DataTable retornodep, retornomuni, retornodele, retornoraz, retornotipvehi, retornoest;
            retornodep = ControllerRegistroVehi.ObtenerDepartamento();
            retornomuni = ControllerRegistroVehi.ObtenerMunicipio();
            retornodele = ControllerRegistroVehi.ObtenerDelegacion();
            retornoraz = ControllerRegistroVehi.ObtenerRazon();
            retornotipvehi = ControllerRegistroVehi.ObtenerTipoVehiculo();
            retornoest = ControllerRegistroVehi.ObtenerEstado();
            if (retornodep != null && retornomuni != null && retornodele != null && retornoraz != null && retornotipvehi != null && retornoest != null)
            {
                cmbdepartamento.DataSource = retornodep;
                cmbdepartamento.ValueMember = "idDepartamento";
                cmbdepartamento.DisplayMember = "Nombre_departamento";

                cmbmunicipios.DataSource = retornomuni;
                cmbmunicipios.ValueMember = "idMunicipio";
                cmbmunicipios.DisplayMember = "Nombre_municipio";

                cmbdelagacion.DataSource = retornodele;
                cmbdelagacion.ValueMember = "idDelegacion";
                cmbdelagacion.DisplayMember = "Nombre_deleg";

                cmbrazon.DataSource = retornoraz;
                cmbrazon.ValueMember = "idRazon";
                cmbrazon.DisplayMember = "N_Razon";

                cmbtipoveh.DataSource = retornotipvehi;
                cmbtipoveh.ValueMember = "idTipoVehi";
                cmbtipoveh.DisplayMember = "Tipo_Vehiculo";

                cmbestado.DataSource = retornoest;
                cmbestado.ValueMember = "idEstadoVehi";
                cmbestado.DisplayMember = "Estado_Vehi";


            }
            else
            {
                MessageBox.Show("Error al cargar los datos, por favor revise su conneccion.", "Error de carga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void envioDatos()
        {
            ControllerRegistroVehi agregar;
            string matricula, modelo, marca, color, año, fechaconf, direccionconf;
            int departamento, municipio, delegacion, razon, tipovehi, estado;
            matricula = txtmatricula.Text;
            modelo = txtmodelo.Text;
            marca = txtmarca.Text;
            color = txtcolor.Text;
            año = txtaño.Text;
            fechaconf = dtfechaconf.Text;
            direccionconf = txtdireccion.Text;
            departamento = Convert.ToInt16(cmbdepartamento.SelectedValue);
            municipio = Convert.ToInt16(cmbmunicipios.SelectedValue);
            delegacion = Convert.ToInt16(cmbdelagacion.SelectedValue);
            razon = Convert.ToInt16(cmbrazon.SelectedValue);
            tipovehi = Convert.ToInt16(cmbtipoveh.SelectedValue);
            estado = Convert.ToInt16(cmbestado.SelectedValue);
            agregar = new ControllerRegistroVehi(matricula, modelo, marca, color, año, fechaconf, direccionconf, departamento, municipio, delegacion, razon, tipovehi, estado);

            bool respuesta = agregar.EnviarDatosController();
            if (respuesta == true)
            {
                MessageBox.Show("Vehiculo ingresado exitosamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al intentar ingresar vehiculo", "Proceso imcompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        void limpiarCampos()
        {
            txtmatricula.Clear();
            txtmodelo.Clear();
            txtmarca.Clear();
            txtcolor.Clear();
            txtaño.Clear();
            txtdireccion.Clear();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            envioDatos();
        }

        private void btnLimpiarCam_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }
    }
}
