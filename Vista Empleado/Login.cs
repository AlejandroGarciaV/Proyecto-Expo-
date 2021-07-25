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

namespace Vista_Empleado
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparaw, int lparam);

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;

            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.Gray;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.Black;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.ForeColor = Color.Gray;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void btnCerrarL_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizarL_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            string contraseña = txtContraseña.Text;
            string usuario = txtUsuario.Text;

            if (txtUsuario.Text != "USUARIO")
            {
                if (txtContraseña.Text != "CONTRASEÑA")
                {

                }
                else msgerror("Porfavor ingrese la contraseña");

            }
            else msgerror("Porfavor ingrese el usuario");

            if (usuario != "admin")
            {
                if (contraseña != "admin123")
                {

                }
                else
                {
                    Form formulario = new Form1();
                    formulario.Hide();
                }
            }
            else if (contraseña == "admin123")
            {
                Form formulario = new Form1();
                formulario.Show();
                this.Hide();
            }

            if (usuario != "admin2")
            {
                if (contraseña != "admin456")
                {

                }
                else
                {
                    Form formulario = new Form1();
                    formulario.Hide();
                }
            }
            else if (contraseña == "admin456")
            {
                Form formulario = new Form1();
                formulario.Show();
                this.Hide();
            }

            if (usuario != "agente")
            {
                if (contraseña != "agente123")
                {

                }
                else
                {
                    Form formulario = new Form1();
                    formulario.Hide();
                }
            }
            else if (contraseña == "agente123")
            {
                Form formulario = new FrmRegistroVehi();
                formulario.Show();
                this.Hide();
            }

            if (usuario != "agente2")
            {
                if (contraseña != "agente456")
                {

                }
                else
                {
                    Form formulario = new Form1();
                    formulario.Hide();
                }
            }
            else if (contraseña == "agente456")
            {
                Form formulario = new FrmRegistroVehi();
                formulario.Show();
                this.Hide();
            }
        }
        private void msgerror(string msg)
            {
                lblerror.Text = "     " + msg;
                lblerror.Visible = true;
            }
    }
}
