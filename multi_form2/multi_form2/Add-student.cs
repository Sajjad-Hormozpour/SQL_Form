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
    public partial class Addstudent : Form
    {
        public Addstudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string nationalcode = textBox2.Text;
            string mobile = textBox3.Text;
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\source\repos\multi_form2\multi_form2\Database1.mdf;Integrated Security=True");
            sqlConnection.Open();
            string query = "INSERT INTO students (name,national_code,mobile_number) VALUES ('" + name + "','" + nationalcode + "','" + mobile + "')";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.ExecuteNonQuery();
            MessageBox.Show(" Added new student");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();


            sqlConnection.Close();
        }

        private void AddStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }
    }
}
