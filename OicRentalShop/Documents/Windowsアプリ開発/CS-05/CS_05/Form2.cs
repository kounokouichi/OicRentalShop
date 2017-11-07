using System;
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
namespace CS_05
{
    public partial class Form2 : Form
    {
        public Form1 fm1;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)  //戻るボタン
        {
            this.Hide();    //このthisは、Form2
            fm1.Show();     //最初のページを表示
        }

        private void button2_Click(object sender, EventArgs e)//Form1の設定データを表示ボタン
        {
            textBox1.Text = fm1.textBox1.Text;//Form1のtextBox1のテキストを設定
        }

        private void button3_Click(object sender, EventArgs e)  //Form1にデータ設定ボタン
        {
            fm1.textBox2.Text = textBox2.Text;  //Form1のtextBox2にテキストを設定
        }
    }
}
