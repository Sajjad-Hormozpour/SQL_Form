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
    public partial class L : Form
    {
        public L()
        {
            InitializeComponent();
        }
        S s = new ();//S  =...Students
        private void button1_Click(object sender, EventArgs e)
        {
            s.Show();
            this.Hide();    
        }
    }
}
