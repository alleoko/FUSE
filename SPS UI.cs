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
    public partial class SPS_UI : Form
    {
        public SPS_UI()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dTSOnlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Show();
        }

        private void SPS_UI_Load(object sender, EventArgs e)
        {
            panel1.Hide(); 
            panel2.Hide(); 
            panel3.Hide();
            button1.Hide();
            textBox3.Enabled = false;
            textBox4.Enabled = false;




        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Enabled = true;
            textBox4.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox4.Enabled = true;
            textBox3.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Show();

          

        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel3.Show();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox4.TextLength == 0)
            {

                button1.Hide();

            }
            else
            {
               
                button1.Show();

            }
        }
    }
}
