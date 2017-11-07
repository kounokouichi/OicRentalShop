using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_17
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form fm1;
        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            fm1.WindowState = FormWindowState.Normal;
        }
    }
}
