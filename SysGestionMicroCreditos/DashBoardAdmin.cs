using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysGestionMicroCreditos
{
    public partial class dashboardadmin : Form
    {
        public dashboardadmin(string nombre)
        {
            InitializeComponent();
            mensajeadmin.Text = nombre;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dashboardadmin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form agregarclientes = new PantallaAgregar();
            agregarclientes.Show();

        }

        private void labladmin_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form gestionarclientes = new PantallaGestionar();
            gestionarclientes.Show();
        }
    }
}
