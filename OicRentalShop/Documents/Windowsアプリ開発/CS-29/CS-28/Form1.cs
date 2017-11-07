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

namespace CS_28
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
            dataGridView1.FirstDisplayedScrollingRowIndex = n;

            foreach (DataGridViewColumn c in dataGridView1.Columns)
            {
                c.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataload(0);
        }

        private void button1_Click(object sender, EventArgs e)
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
                        MessageBox.Show(ex.Message, "CS-28");
                    }
                }
                sr.Close();
                cn.Close();
                dataload(dataGridView1.Rows.Count - 1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                cmd.Connection = cn;
                cmd.CommandText="SELECT * FROM Member ORDER BY ID";
                cn.Open();
                OleDbDataReader dreader = cmd.ExecuteReader();
                StreamWriter sw = new System.IO.StreamWriter(saveFileDialog1.FileName, false, Encoding.Default);
                while(dreader.Read())
                {
                    sw.Write(dreader.GetString(1)+","+
                        dreader.GetString(2)+","+
                        dreader.GetString(3)+","+
                        dreader.GetDateTime(4).ToString("yyyy/MM/dd")+","+
                        dreader.GetInt32(5).ToString()+","+
                        dreader.GetInt32(6).ToString()+","+
                        dreader.GetString(7)+"\n");
                }
                sw.Close();
                cn.Close();
                MessageBox.Show("ファイルを作成しました","CS-28");
            }
        }
    }
}
