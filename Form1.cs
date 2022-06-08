Carl Cuba
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Fuse fuse = new Fuse();
            fuse.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearView2 clar = new ClearView2();
            clar.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SPS_UI sps = new SPS_UI();
            sps.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clarity clar = new Clarity();
            clar.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form3 from3 = new Form3();
            from3.Show();
        }
    }
}
