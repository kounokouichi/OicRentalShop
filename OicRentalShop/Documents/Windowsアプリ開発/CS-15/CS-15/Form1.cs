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

/*作成者：高野公一
 　作成日：05/19
 */


namespace CS_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void open()
        {
            if (richTextBox1.TextLength>0)
            {
                if (MessageBox.Show("文字を入れ替えてもよろしいですか","MyEditer",
                    MessageBoxButtons.YesNo,MessageBoxIcon.Question)!=DialogResult.Yes)
                {
                    return;
                }
            }
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog1.FileName);
            }
        }
            private void save()
        {
                if(saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName);
            }
        }
        private void cut()
            {
                richTextBox1.Cut();
            }
               private void copy()
            {
                richTextBox1.Copy();
            }      
               private void paste()
            {
                richTextBox1.Paste();
            }
        private void clear()
           {
            if(MessageBox.Show("文章をクリアしてもよろしいですか","MyEditer",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                richTextBox1.Clear();
            }
           }
        private void undo()
        {
            richTextBox1.Undo();
        }
        private void redo()
        {
            richTextBox1.Redo();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            {
                Splash sp = new Splash();
                sp.Show();
                sp.Refresh();

                Application.DoEvents();
                Thread.Sleep(2000);

                sp.Close();
                sp.Dispose();

                this.Activate();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("終了してもよろしてもよろしいですか", "MyEditer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save();
        }

        private void EndToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cut();
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copy();
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            paste();
        }

        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            undo();
        }

        private void RedoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            redo();
        }

        private void FontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;
            fontDialog1.Font = richTextBox1.Font;
            if(fontDialog1.ShowDialog()==DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
                richTextBox1.ForeColor = fontDialog1.Color;
            }
        }

        private void BackColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog()==DialogResult.OK)
            {
                richTextBox1.BackColor = colorDialog1.Color;
            }
        }

        private void HomePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                Process.Start("www.oic.ac.jp");
            }
        }

        private void VersionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                AboutBox1 abbox = new AboutBox1();
                abbox.ShowDialog();
            }
        }
    }
}
