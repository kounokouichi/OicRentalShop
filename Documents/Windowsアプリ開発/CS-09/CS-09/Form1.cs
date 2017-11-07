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
namespace CS_09
{
    public partial class Form1 : Form
    {
        String[,] jp ={
    { "川島 永嗣","kawashima.jpg"},
    {"内田 篤人","uchida.jpg"},
    {"本田 圭佑","honda.jpg"},
    {"森重 真人","morishige.jpg"},
    {"柴崎 岳","shibasaki.jpg"},
    {"乾 貴士","inui.jpg"},
    {"岡崎 慎司","okazaki.jpg"},
    {"香川 真司","kagawa.jpg"},
    {"長谷部 誠","hasebe.jpg"},
    {"吉田 麻也","yoshida.jpg"},
    {"酒井 高徳","sakaigotoku.jpg"},
    };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = jp.GetLength(0).ToString(); 
            for (int i = 0; i < jp.GetLength(0); i++)
            {
                comboBox1.Items.Add(jp[i,0]);
            }
            comboBox1.Text=jp[0,0];
            pictureBox1.Focus();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string imgstr = jp[comboBox1.SelectedIndex, 1];
            pictureBox1.Image = Image.FromFile(@"img\" + imgstr);
            pictureBox1.Focus();
        }
    }
}
