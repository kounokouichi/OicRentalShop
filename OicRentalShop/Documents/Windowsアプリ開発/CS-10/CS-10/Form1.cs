using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*作成者：高野公一
 *作成日：2017.04.28
 */
namespace CS_10
{
    public partial class Form1 : Form
    {
        System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "00:00:00";
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            sw.Start();
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            sw.Stop();
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "00:00:00";
            sw.Reset();
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //  label1.Text=System.DateTime.Now.ToLongTimeString();
            label1.Text = sw.Elapsed.ToString();
        }
    }
}
