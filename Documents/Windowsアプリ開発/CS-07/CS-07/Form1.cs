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
namespace CS_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int gokei = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = "0";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                gokei = gokei + 500;
            }
            else
            {
                gokei = gokei - 500;
            }
            label2.Text = gokei.ToString();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked==true)
            {
                gokei = gokei + 250;
            }
            else
            {
                gokei = gokei - 250;
            }
            label2.Text = gokei.ToString();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                gokei = gokei + 150;
            }
            else
            {
                gokei = gokei - 150;
            }
            label2.Text = gokei.ToString();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                gokei = gokei + 300;
            }
            else
            {
                gokei = gokei - 300;
            }
            label2.Text = gokei.ToString();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                gokei = gokei + 400;
            }
            else
            {
                gokei = gokei - 400;
            }
            label2.Text = gokei.ToString();
        }
    }
}
