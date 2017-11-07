//高野公一
//2017.4.07
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int box1 ;
            int box2;
            int sum = 0;
            if (int.TryParse(textBox1.Text, out box1) != true)
            {
                MessageBox.Show("一番目の項目に整数を入力してください");
                textBox1.Clear();
                textBox1.Focus();
                return;
            }
            if (int.TryParse(textBox2.Text, out box2) != true)
            {
                MessageBox.Show("二番目の項目に整数を入力してください");
                textBox2.Clear();
                textBox2.Focus();
                return;
            }
            sum = box1 + box2;
            textBox3.Text = sum.ToString();
            button2.Focus();
        }





        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.Focus();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Text = "";
            textBox3.Text = "";
            textBox1.Focus();
        }


    }
}
