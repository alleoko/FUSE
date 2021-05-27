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
    public partial class customerinfo : Form
    {
        public customerinfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0 || textBox2.TextLength == 0 || textBox3.TextLength == 0 || textBox4.TextLength == 0 || textBox5.TextLength == 0 || textBox6.TextLength == 0) {

            }
            else 
            { 
                MessageBox.Show("Information Updated"); 
            }
                
        }
    }
}
