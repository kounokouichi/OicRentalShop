using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_30
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form1 fm1;
        public string pass;

        private void button1_Click(object sender, EventArgs e)
        {
            fm1 = new Form1();
            fm1.fm2 = this;
            pass = "oic";
            if(textBox1.Text==pass)
            {
                this.Visible = false;
                fm1.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("パスワードが異なります", "CS-30");
                textBox1.Text = "";
                return;
            }
        }
    }
}
