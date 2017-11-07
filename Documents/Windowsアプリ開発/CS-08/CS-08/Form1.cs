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
namespace CS_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton3.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg = "";
            foreach(Control c in groupBox1.Controls)
            {
                RadioButton rb = (RadioButton)c;
                if(rb.Checked==true)
                {
                    msg = msg + "性別：" + rb.Text;
                    break;
                }
            }
            msg = msg + "\r\n";for(int i=0;i<groupBox2.Controls.Count;i++)
            {
                RadioButton rb = (RadioButton)groupBox2.Controls[i];
                if(rb.Checked==true)
                {
                    msg = msg + "年齢：" + rb.Text;
                    break;
                }
            }
            msg = msg + "\r\n";
            msg = msg + "関心：";
            string kansin = "";
            for(int i=groupBox3.Controls.Count-1;i>=0;i--)
            {
                CheckBox cb = (CheckBox)groupBox3.Controls[i];
                if(cb.Checked==true)
                {
                    kansin = kansin + cb.Text + " ";
                }
            }
            if(kansin=="")
            {
                kansin = "なし";
            }
            textBox1.Text = msg + kansin;
        }
    }
}
