using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Controlador;

namespace Vista_Empleado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnInicio_Click(null,e);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparaw, int lparam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 77;
                Logo1.Visible = false;
                Logo2.Visible = true;
            }
            else
            {
                MenuVertical.Width = 250;
                Logo1.Visible = true;
                Logo2.Visible = false;
            }
        }

        private void IconoCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Minimizartamaño.Visible = true;
            Maximizar.Visible = false;
        }

        private void Minimizartamaño_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            Minimizartamaño.Visible = false;
            Maximizar.Visible = true;
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AbirFormEnPanel(object Formhijo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
        }
        
        private void btnVehi_Conf_Click(object sender, EventArgs e)
        {
            AbirFormEnPanel(new Vehiculos_Conf());
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            AbirFormEnPanel(new Informes());
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbirFormEnPanel(new inicio());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbirFormEnPanel(new Usuarios());
        }

        private void btnSucursales_Click(object sender, EventArgs e)
        {
            AbirFormEnPanel(new PeticionesRetiro());
        }
        
    }
}
