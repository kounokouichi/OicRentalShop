using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

/*作成者：高野公一
 　作成日：05/19
 */


namespace CS_16
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
                string fontname = "MS 明朝";
                int fontsize = 11;
                Font fnt = new Font(fontname, fontsize);
                FontNametoolStripComboBox.Text = fontname;
                FontSizetoolStripComboBox.Text = fontsize.ToString();
                InstalledFontCollection ifc = new InstalledFontCollection();
                FontFamily[] ffs = ifc.Families;
                foreach(FontFamily ff in ffs)
                {
                    FontNametoolStripComboBox.Items.Add(ff.Name);
                }
                int[] f = { 6, 7, 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
                for(int i=0;i<f.Length;i++)
                {
                    FontSizetoolStripComboBox.Items.Add(f[i]);
                }
                richTextBox1.Font = fnt;
                fnt.Dispose();
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
            Font fnt = new Font(FontNametoolStripComboBox.Text, int.Parse(FontSizetoolStripComboBox.Text));
            fontDialog1.Font = fnt;
            if(fontDialog1.ShowDialog()==DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
                richTextBox1.ForeColor = fontDialog1.Color;
                FontNametoolStripComboBox.Text = fontDialog1.Font.Name;
                FontSizetoolStripComboBox.Text = ((int)fontDialog1.Font.Size).ToString();
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

        private void OpentoolStripButton_Click(object sender, EventArgs e)
        {
            open();
        }

        private void SavetoolStripButton_Click(object sender, EventArgs e)
        {
            save();
        }

        private void CuttoolStripButton_Click(object sender, EventArgs e)
        {
            cut();
        }

        private void CopytoolStripButton_Click(object sender, EventArgs e)
        {
            copy();
        }

        private void PastetoolStripButton_Click(object sender, EventArgs e)
        {
            paste();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void UndotoolStripButton_Click(object sender, EventArgs e)
        {
            undo();
        }

        private void RedotoolStripButton_Click(object sender, EventArgs e)
        {
            redo();                                                                                        
        }

        private void CMCutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cut();
        }

        private void CMCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copy();
        }

        private void CMPasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            paste();
        }

        private void CMClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void CMUndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            undo();
        }

        private void CMRedoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            redo();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            toolStripSeparator2.Text = richTextBox1.TextLength.ToString();
        }

        private void FontNametoolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Font fnt = new Font(FontNametoolStripComboBox.Text, int.Parse(FontSizetoolStripComboBox.Text));
            richTextBox1.Font = fnt;
        }

        private void FontSizetoolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Font fnt = new Font(FontNametoolStripComboBox.Text, int.Parse(FontSizetoolStripComboBox.Text));
            richTextBox1.Font = fnt;
        }

        private void CleartoolStripButton_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
