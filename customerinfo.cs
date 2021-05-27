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


        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";
        public static string SetValueForText3 = "";


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


                SetValueForText1 = textBox1.Text;
                SetValueForText2 = textBox2.Text;
                SetValueForText3 = textBox3.Text;

                Fuse fuse = new Fuse();
                fuse.Show();





                MessageBox.Show("Information Updated"); 
            }
                
        }

        private void customerinfo_Load(object sender, EventArgs e)
        {

        }
    }
}
