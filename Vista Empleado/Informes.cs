using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Vista_Empleado
{
    public partial class Informes : Form
    {


        SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-BM38B0O;Initial Catalog=sisconfiscacioncarros;Integrated Security=True");



        public Informes()
        {
            InitializeComponent();
        }

        private void Informes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sisconfiscacioncarrosDataSet.informe' table. You can move, or remove it, as needed.
            this.informeTableAdapter.Fill(this.sisconfiscacioncarrosDataSet.informe);

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            conexion.Open();

            SqlCommand cmd = conexion.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from informe where idAgente like ('" + textBox1.Text + "%')";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            dataGridView1.DataSource = dt;


            conexion.Close();
        }
    }
}
