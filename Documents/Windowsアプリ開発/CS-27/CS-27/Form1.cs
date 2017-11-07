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

namespace CS_27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        OleDbConnection cn = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataTable dt = new DataTable();

        private void dataload(int n)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = null;
            cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\DBJapan.accdb;";
            da = new OleDbDataAdapter("SELECT * FROM Member ORDER BY ID", cn);
            dt.Clear();
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoResizeColumns();
            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = dataGridView1.Rows[n].Cells["ID"];
            dataGridView1.Rows[n].Selected = true;
            dataGridView1.FirstDisplayedScrollingColumnIndex = n;

            foreach(DataGridViewColumn c in dataGridView1.Columns)
            {
                c.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void clickdata()
        {
            int max = int.Parse(dataGridView1[0, dataGridView1.Rows.Count - 2].Value.ToString());
            textBox1.Text = (max + 1).ToString("D3");
            textBox2.Text = dataGridView1[1, dataGridView1.CurrentCell.RowIndex].Value.ToString();
            comboBox1.Text = dataGridView1[2, dataGridView1.CurrentCell.RowIndex].Value.ToString();
            comboBox2.Text = dataGridView1[3, dataGridView1.CurrentCell.RowIndex].Value.ToString();
            textBox5.Text = DateTime.Parse(dataGridView1[4, dataGridView1.CurrentCell.RowIndex].Value.ToString()).ToString("yyyy/MM/dd");
            textBox6.Text = dataGridView1[5, dataGridView1.CurrentCell.RowIndex].Value.ToString();
            textBox7.Text = dataGridView1[6, dataGridView1.CurrentCell.RowIndex].Value.ToString();
            textBox3.Text = dataGridView1[7, dataGridView1.CurrentCell.RowIndex].Value.ToString();
            pictureBox1.Image = Image.FromFile(@".\Japan\" + textBox3.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataload(0);
            clickdata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ID=" + textBox1.Text + "のデータを追加してもよろしいですか", "CS-27", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            if(textBox4.Text=="")
            {
                MessageBox.Show("ID=" + textBox1.Text + "新規画像がありません。登録済み画像が設定されます", "CS-27", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox4.Text = textBox3.Text;
            }
            cmd.Connection = cn;
            cmd.CommandText="INSERT INTO Member(ID,名前,ポジションID,所属ID,生年月日,身長,体重,画像ファイル)"+
                "VALUES('"+textBox1.Text+"','"+
                textBox2.Text+"', '"+
                comboBox1.Text+"', '"+
                comboBox2.Text+"', '"+
                textBox5.Text+"', "+
                int.Parse(textBox6.Text)+","+
                int.Parse(textBox7.Text)+",'"+
                textBox4.Text+"')";
            try{
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("追加しました","CS-27");
            }    
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "CS-27");
            }
            cn.Close();
            textBox4.Text="";
            pictureBox1.Image=null;
            pictureBox2.Image=null;
            label10.Visible = true;
            dataload(dataGridView1.Rows.Count-1);

            clickdata();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("ID=" + comboBox1.Text + "のデータを削除してもよろしいですか", "CS-25", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            if(textBox4.Text=="")
            {
                MessageBox.Show("画像は更新されません", "CS-26", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox4.Text = textBox3.Text;
            }
            cmd.Connection = cn;
            cmd.CommandText = "UPDATE Member SET 名前='" + textBox2.Text + "'," +
                "ポジションID='" + comboBox1.Text + "'" +
                "所属ID='" + comboBox2.Text + "'" +
                "生年月日='" + textBox5.Text + "'" +
                "身長=" + textBox6.Text + "'" +
                "体重=" + textBox7.Text + "'" +
                "画像ファイル='" + textBox4.Text + "'" +
                "WHERE ID='" + textBox1.Text + "'";
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("更新しました", "CS-26");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "CS-26");
            }
            cn.Close();
            textBox4.Text="";
            pictureBox1.Image=null;
            pictureBox2.Image=null;
            label10.Visible = true;
            dataload(dataGridView1.CurrentCell.RowIndex);
            clickdata();
        }

        private void panel2_DragDrop(object sender, DragEventArgs e)
        {
            string dropfile = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
            string imagefile = System.IO.Path.GetFileName(dropfile);
            string Path = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @".\Japan\" + imagefile;
            pictureBox2.Image = Image.FromFile(dropfile);
            try
            {
                System.IO.File.Copy(dropfile, Path, true);
            }
            catch
            {
                MessageBox.Show("コピーできませんでした。", "CS-26");
            }
            textBox4.Text = imagefile;
            label10.Visible = false;
        }

        private void panel2_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
