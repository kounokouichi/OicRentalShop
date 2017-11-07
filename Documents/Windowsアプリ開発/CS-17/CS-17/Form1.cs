using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 *作成者：高野公一
 *作成日：2017/05/26
 */

namespace CS_17
{
    public partial class Form1 : Form
    {
        public Form2 fm2;

        public Form1()
        {
            InitializeComponent();
            fm2 = new Form2();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = (int)numericUpDown1.Value * 1000;
            Splash sp = new Splash();
            sp.Show();
            sp.Refresh();

            Application.DoEvents();
            Thread.Sleep(2000);

            sp.Close();
            sp.Dispose();

            this.Activate();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("終了してもよろしてもよろしいですか", "MyEditer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog()==DialogResult.OK)
            {
                string path = folderBrowserDialog1.SelectedPath;
                textBoxFile.Text = path;
                listBoxFile.DataSource = System.IO.Directory.GetFiles(path, "*.jpg");
            }
        }

        private void btnStert_Click(object sender, EventArgs e)
        {
            if(listBoxFile.Items.Count>0)
            {
                btnStert.Enabled = false;
                btnPause.Enabled = true;
                labelState.Text = "開始中です";
                timer1.Start();
            }
            else
            {
                MessageBox.Show("リストが空です", "確認", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            btnStert.Enabled = true;
            btnPause.Enabled = false;
            labelState.Text = "停止中です";
            timer1.Stop();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(fm2.Visible==true)
            {
                fm2.Close();
                timer1.Stop();
                btnOpen.Enabled = true;
                btnStert.Enabled = false;
                btnPause.Enabled = false;
                btnClose.Enabled = false;
                labelState.Text="";
            }
        }

        private void HomePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("www.oic.ac.jp");
        }

        private void VersionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 abbox = new AboutBox1();
            abbox.ShowDialog();
        }

        private void EndToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBoxFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(fm2.Visible==true)
            {
                fm2.pictureBox1.BackgroundImage = Image.FromFile((string)listBoxFile.SelectedItem);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = (int)numericUpDown1.Value * 1000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(listBoxFile.SelectedIndex==listBoxFile.Items.Count-1)
            {
                listBoxFile.SelectedIndex = 0;
            }
            else
            {
                listBoxFile.SelectedIndex++;
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if(listBoxFile.Items.Count>0)
            {
                fm2= new Form2();
                fm2.pictureBox1.BackgroundImage=Image.FromFile((string)listBoxFile.SelectedItem);
                fm2.Show();
                fm2.fm1=this;
                btnOpen.Enabled=false;
                btnStert.Enabled=true;
                btnPause.Enabled=false;
                btnClose.Enabled = true;
                this.TopMost = true;
            }
            else
            {
                MessageBox.Show("リストが空です", "確認", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
