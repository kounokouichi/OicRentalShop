using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_33
{
    public partial class Form1 : Form
    {
        OleDbConnection cn = new OleDbConnection();
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataTable dt = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\DBJapan.accdb;");
            da = new OleDbDataAdapter("SELECT m.ID,m.名前,r.ポジション名,t.チーム名,DATEDIFF('yyyy',m.生年月日,Date()),m.画像ファイル FROM Member m,Role r ,Team t WHERE m.ポジションID=r.ID AND m.所属ID=t.ID ORDER By m.ID ASC", cn);
            dt = new DataTable();
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBID.Items.Add(dt.Rows[i][0].ToString());
            }
            comboBID.Text = dt.Rows[0][0].ToString();
        }

        private void comboBID_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxName.Text = dt.Rows[comboBID.SelectedIndex][1].ToString();
            textBoxPosName.Text =dt.Rows[comboBID.SelectedIndex][2].ToString();
            textBTeamName.Text = dt.Rows[comboBID.SelectedIndex][3].ToString();
            textBAge.Text =dt.Rows[comboBID.SelectedIndex][4].ToString();
            string img = dt.Rows[comboBID.SelectedIndex][5].ToString();
            pictureBox1.Image = Image.FromFile(@".\Japan\" + img);
            pictureBox1.Focus();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("終了してもよろしいですか", "CS-33", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void VersionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 abbox = new AboutBox1();
            abbox.ShowDialog();
        }
    }
}
