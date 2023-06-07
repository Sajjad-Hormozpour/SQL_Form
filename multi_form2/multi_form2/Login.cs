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

namespace multi_form2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        L L = new L();//......landing
        private void button1_Click(object sender, EventArgs e)
        {
            {
                try

                {
                    string Username = textBox1.Text;
                    string password = textBox2.Text;

                    SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\source\repos\multi_form2\multi_form2\Database1.mdf;Integrated Security=True");
                    sqlConnection.Open();
                    string query = " SELECT password FROM Login WHERE Username = '" + Username + "'";
                    SqlCommand command = new SqlCommand(query, sqlConnection);
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    string pass = reader ["password"].ToString();
                    if (password == pass)
                    {
                        L.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Username or password incorrect plz try again ");
                    }
                    sqlConnection.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Username or password incorrect plz try again ");
                }

            }

        }

    }   
}
