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
    public partial class Removestudent : Form
    {
        public Removestudent()
        {
            InitializeComponent();
        }

        private void remove_student_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\source\repos\multi_form2\multi_form2\Database1.mdf;Integrated Security=True");
            sqlConnection.Open();
            string query = "SELECT name FROM students";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string name = reader ["name"].ToString();
                comboBox1.Items.Add(Name);
            }
            sqlConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = comboBox1 .SelectedItem.ToString();
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\source\repos\multi_form2\multi_form2\Database1.mdf;Integrated Security=True");
            sqlConnection.Open();
            string sqlquery = ("DELETE FROM students WHERE name='" + name + "'");
            SqlCommand command = new SqlCommand(sqlquery, sqlConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("deleted");
            sqlConnection.Close();
        }

        private void remove_student_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
       
    }
}
