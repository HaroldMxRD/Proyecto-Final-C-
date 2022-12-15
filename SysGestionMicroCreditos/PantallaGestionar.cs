using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysGestionMicroCreditos
{
    public partial class PantallaGestionar : Form
    {
        public PantallaGestionar()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = sysgestionmicrocreditos; Integrated Security = True");

        public void llenar_tabla()
        {
            string consulta = "select * from clientes";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView3.DataSource = dt;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string consulta = "select * from clientes";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView3.DataSource = dt;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            traernombreCliente.Text = dataGridView3.SelectedCells[2].Value.ToString();
            traercedulaCliente.Text = dataGridView3.SelectedCells[4].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void btneliminar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("");
            cmd.CommandText = "DELETE FROM clientes WHERE Idcliente=4";
            MessageBox.Show("Cliente eliminado correctamente.");
            cmd.Connection = conexion;
            cmd.ExecuteNonQuery();
            llenar_tabla();
            conexion.Close();


        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {`

            conexion.Open();
            SqlCommand cmd = new SqlCommand("");
            cmd.CommandText = "UPDATE clientes where IdCliente= 5 set Cedula=402-254455-5";
            MessageBox.Show("Cliente Modificado correctamente.");
            cmd.Connection = conexion;
            cmd.ExecuteNonQuery();
            llenar_tabla();
            conexion.Close();

        }
    }
}
