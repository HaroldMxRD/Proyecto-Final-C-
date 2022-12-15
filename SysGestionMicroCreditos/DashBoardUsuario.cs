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
    public partial class dashboardusuario : Form
    {
        public dashboardusuario(string nombre)
        {
            InitializeComponent();
            mensajeusuario.Text = nombre;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
