using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FUSE
{
    public partial class Fuse : Form
    {
        public Fuse()
        {
            InitializeComponent();
        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void updateCustomerInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customerinfo cx = new customerinfo();
            cx.Show();
        }
    }
}
