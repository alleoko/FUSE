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
    public partial class ClearView2 : Form
    {
        public ClearView2()
        {
            InitializeComponent();
        }

        private void ClearView2_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            Form2 clar = new Form2();
            clar.Show();


        }
    }
}
