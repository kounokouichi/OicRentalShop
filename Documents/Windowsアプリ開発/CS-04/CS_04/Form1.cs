﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//作成者：高野公一
//作成日：2017.04.14
namespace CS_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textinput();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AboutBox1 abbox = new AboutBox1();
            abbox.ShowDialog();
            //abbox.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            label2.Text = "文字数（改行も一行とカウント）：" + richTextBox1.TextLength;
        }

        private void textBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textinput();
        }
        private void textinput()
        {
            richTextBox1.AppendText(textBox1.Text + "\n");
            textBox1.Clear();
        }
    }
}
