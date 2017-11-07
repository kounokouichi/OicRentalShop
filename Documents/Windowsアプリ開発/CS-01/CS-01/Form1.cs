//:高野公一
//:2017.4.7
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "起動時";//ラベルのtextプロパティを設定
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Windowsアプリケーションの第一歩";//ラベルのtextプロパティを設定
        }
    }
}
