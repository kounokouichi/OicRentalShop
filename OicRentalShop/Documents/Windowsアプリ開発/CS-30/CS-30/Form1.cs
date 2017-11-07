using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_30
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Form2 fm2;
        OleDbConnection cn = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataTable dt = new DataTable();

        private void dataload(int n)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = null;
            string apass = fm2.pass;
            cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\DBJapanPass.accdb;" + "Jet OLEDB:Database Password=" + apass + ";";
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM Member ORDER BY ID", cn);
            dt.Clear();
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoResizeColumns();
            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = dataGridView1.Rows[n].Cells["ID"];
            dataGridView1.Rows[n].Selected = true;
        }

        private void clickdata()
        {
            if(radioButton1.Checked==true)
            {
                textBox1.Text = dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString();
            }
            else
            {
                int max = int.Parse(dataGridView1[0, dataGridView1.Rows.Count - 2].Value.ToString());
                textBox1.Text = (max + 1).ToString("D3");
            }
            textBox1.Text = dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString();
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
            if (MessageBox.Show("ID=" + textBox1.Text + "のデータを削除してもよろしいですか", "CS-30", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            if (textBox4.Text == "")
            {
                MessageBox.Show("画像は更新されません", "CS-30", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox4.Text = textBox3.Text;
            }
            cmd.Connection = cn;
            cmd.CommandText = "UPDATE Member SET 名前='" + textBox2.Text + "', " +
                "ポジションID='" + comboBox1.Text + "', " +
                "所属ID='" + comboBox2.Text + "', " +
                "生年月日='" + textBox5.Text + "', " +
                "身長=" + int.Parse(textBox6.Text) + ", " +
                "体重=" + int.Parse(textBox7.Text) + ", " +
                "画像ファイル='" + textBox4.Text + "' " +
                "WHERE ID ='" + textBox1.Text + "'";
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("更新しました", "CS-30");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "CS-30");
            }
            cn.Close();
            textBox4.Text = "";
            pictureBox1.Image = null;
            pictureBox2.Image = null;
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
                MessageBox.Show("コピーできませんでした。", "CS-30");
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

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            clickdata();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                button2.Enabled = true;
                button1.Enabled = true;
                button3.Enabled = false;
                textBox1.Text=dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                label9.Text = "更新画像";
            }
            else
            {
                button2.Enabled = false;
                button1.Enabled = false;
                button3.Enabled = true;
                int max = int.Parse(dataGridView1[0, dataGridView1.Rows.Count - 2].Value.ToString());
                textBox1.Text = (max + 1).ToString("D3");
                label9.Text = "新規登録画像";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                int max = int.Parse(dataGridView1[0, dataGridView1.Rows.Count - 2].Value.ToString()) + 1;
                cmd.Connection = cn;
                cn.Open();
                StreamReader sr = new StreamReader(openFileDialog1.FileName, Encoding.Default);
                string filedata;
                while ((filedata = sr.ReadLine()) != null)
                {
                    string[] data = filedata.Split(',');
                    cmd.Connection = cn;
                    cmd.CommandText = "INSERT INTO Member(ID,名前,ポジションID,所属ID,生年月日,身長,体重,画像ファイル)" +
                        "VALUES('" + (max++).ToString("D3") + "','" +
                        data[0] + "', '" +
                        data[1] + "', '" +
                        data[2] + "', '" +
                        data[3] + "', " +
                        int.Parse(data[4]) + "," +
                        int.Parse(data[5]) + ",'" +
                        data[6] + "')";
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "CS-30");
                    }
                }
                sr.Close();
                cn.Close();
                dataload(dataGridView1.Rows.Count - 1);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                cmd.Connection = cn;
                cmd.CommandText = "SELECT * FROM Member ORDER BY ID";
                cn.Open();
                OleDbDataReader dreader = cmd.ExecuteReader();
                StreamWriter sw = new System.IO.StreamWriter(saveFileDialog1.FileName, false, Encoding.Default);
                while (dreader.Read())
                {
                    sw.Write(dreader.GetString(1) + "," +
                        dreader.GetString(2) + "," +
                        dreader.GetString(3) + "," +
                        dreader.GetDateTime(4).ToString("yyyy/MM/dd") + "," +
                        dreader.GetInt32(5).ToString() + "," +
                        dreader.GetInt32(6).ToString() + "," +
                        dreader.GetString(7) + "\n");
                }
                sw.Close();
                cn.Close();
                MessageBox.Show("ファイルを作成しました", "CS-30");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ID=" + textBox1.Text + "のデータを削除してもよろしいですか", "CS-30", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            cmd.Connection = cn;
            cmd.CommandText = "DELETE FROM Member WHERE ID ='" + textBox1.Text + "'";
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("削除しました", "CS-30");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "CS-30");
            }
            cn.Close();
            dataload(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ID=" + textBox1.Text + "のデータを追加してもよろしいですか", "CS-27", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            if (textBox4.Text == "")
            {
                MessageBox.Show("ID=" + textBox1.Text + "新規画像がありません。登録済み画像が設定されます", "CS-27", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox4.Text = textBox3.Text;
            }
            cmd.Connection = cn;
            cmd.CommandText = "INSERT INTO Member(ID,名前,ポジションID,所属ID,生年月日,身長,体重,画像ファイル)" +
                "VALUES('" + textBox1.Text + "','" +
                textBox2.Text + "', '" +
                comboBox1.Text + "', '" +
                comboBox2.Text + "', '" +
                textBox5.Text + "', " +
                int.Parse(textBox6.Text) + "," +
                int.Parse(textBox7.Text) + ",'" +
                textBox4.Text + "')";
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("追加しました", "CS-30");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "CS-30");
            }
            cn.Close();
            textBox4.Text = "";
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            label10.Visible = true;
            dataload(dataGridView1.Rows.Count - 1);

            clickdata();
        }
    }
}
