using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multi_form2
{
    public partial class S : Form
    {
        public S()
        {
            InitializeComponent();
        }
        Addstudent As = new Addstudent();

        private void button1_Click(object sender, EventArgs e)
        {
            As.Show();
        }
        Editstudent Es = new Editstudent();

        private void button2_Click(object sender, EventArgs e)
        {
            Es.Show();;
        }
       Removestudent Rs = new Removestudent();

        private void button3_Click(object sender, EventArgs e)
        {
            Es.Show();
            this.Hide();
        }
    }
}
