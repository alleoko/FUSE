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
    public partial class Clarity : Form
    {
        public Clarity()
        {
            InitializeComponent();
        }

        private void serviceFaultToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearView clear = new ClearView();
            clear.Show();
        }
    }
}
