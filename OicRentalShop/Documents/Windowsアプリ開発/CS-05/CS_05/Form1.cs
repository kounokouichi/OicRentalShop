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
    public partial class Form1 : Form
    {
        public Form2 fm2 = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            fm2.fm1 = this; //Form2で制御するfm1は、this(Form1)である
            fm2.Show();
        }
    }
}
