using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace SysGestionMicroCreditos
{
    public partial class login : Form
    {

        public login()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = sysgestionmicrocreditos; Integrated Security = True");

        public void logins(string usuario, string contrasena)
        {

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Nombre, Tipo_Usuario FROM usuarios WHERE Usuario = @usuario AND Password = @pas", con);
                cmd.Parameters.AddWithValue("usuario", usuario);
                cmd.Parameters.AddWithValue("pas", contrasena);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if(dt.Rows.Count ==1){

                    this.Hide();
                    if (dt.Rows[0][1].ToString() == "Admin")
                    {
                        new dashboardadmin(dt.Rows[0][0].ToString()).Show();

                    }
                    else if (dt.Rows[0][1].ToString() == "Usuario")
                    {
                        new dashboardusuario(dt.Rows[0][0].ToString()).Show();

                    }

                }
                else
                {
                    MessageBox.Show("Usuario y/o Contrasena Incorrecta");

                }

            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();
            }

        }
            


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            logins(this.txtuser.Text,this.txtpassword.Text);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
