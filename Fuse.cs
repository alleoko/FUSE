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
            Close();
            customerinfo cx = new customerinfo();
            cx.Show();
        }

        private void Fuse_Load(object sender, EventArgs e)
        {
            secName.Text = customerinfo.SetValueForText1;
            secContact.Text = customerinfo.SetValueForText2;
            secEmail.Text = customerinfo.SetValueForText3;

            groupBox8.Visible = false;
            tabControl1.Visible = false;
            tabControl2.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {

          



            if (textBox2.TextLength == 0)
            {

            }
            else
            {
                groupBox8.Visible = true;
                tabControl1.Visible = true;
                tabControl2.Visible = true;
            }
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox8.Visible = false;
            tabControl1.Visible = false;
            tabControl2.Visible = false;
        }
    }
}
