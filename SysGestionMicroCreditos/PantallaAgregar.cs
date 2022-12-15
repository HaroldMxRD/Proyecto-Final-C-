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
using System.Configuration;

namespace SysGestionMicroCreditos
{
    public partial class PantallaAgregar : Form
    {
        public PantallaAgregar()
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
            dataGridView1.DataSource = dt;

        }
        private void PantallaAgregar_Load(object sender, EventArgs e)
        {

            string consulta = "select * from clientes";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource= dt;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {

            conexion.Open();
            SqlCommand cmd = new SqlCommand("");
            cmd.CommandText = "INSERT INTO clientes (Nombre, Apellido, Edad, Cedula, Direccion, MontoDelPrestamo, Cuota, Tasa, FechaInicio, FechaFinal, TotalAPagarPrestamo, Periodo  ) VALUES (@Nombre, @Apellido, @Edad, @Cedula, @Direccion, @MontoDelPrestamo, @Cuota, @Tasa, @FechaInicio, @FechaFinal, @TotalAPagarPrestamo, @Periodo)";
            cmd.Parameters.AddWithValue("@Nombre", nombreCliente.Text);
            cmd.Parameters.AddWithValue("@Apellido", apellidoCliente.Text);
            cmd.Parameters.AddWithValue("@Edad", edadCliente.Text);
            cmd.Parameters.AddWithValue("@Cedula", cedulaCliente.Text);
            cmd.Parameters.AddWithValue("@Direccion", direccionCliente.Text);

            cmd.Parameters.AddWithValue("@MontoDelPrestamo", montoPrestamoCliente.Text);
            cmd.Parameters.AddWithValue("@TotalAPagarPrestamo", totaldelprestamoapagarCliente.Text);
            cmd.Parameters.AddWithValue("@Cuota", cuotaCliente.Text);
            cmd.Parameters.AddWithValue("@Tasa", tasaCliente.Text);
            cmd.Parameters.AddWithValue("@FechaInicio", fechainicioCliente.Text);
            cmd.Parameters.AddWithValue("@FechaFinal", fechafinalCliente.Text);
            cmd.Parameters.AddWithValue("@Periodo", periodoCliente.Text);

            MessageBox.Show("Cliente agregado correctamente.");
            cmd.Connection = conexion;
            cmd.ExecuteNonQuery();
            llenar_tabla();
            conexion.Close();
           
        }

        private void edadCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
