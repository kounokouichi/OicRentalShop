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

namespace CS_22
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
        DataSet ds = new DataSet();

        private void DataReader_Click(object sender, EventArgs e)
        {
            Release_Click(sender,e);
            cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\DBJapan.accdb;";
            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM Member";
            cn.Open();
            OleDbDataReader dreader = cmd.ExecuteReader();
            dataGridView1.Columns.Add("id","ID");
            dataGridView1.Columns.Add("name","名前");
            dataGridView1.Columns.Add("positionid","ポジションID");
            dataGridView1.Columns.Add("teamid","所属ID");
            dataGridView1.Columns.Add("bornyear","生年月日");
            dataGridView1.Columns.Add("height","身長");
            dataGridView1.Columns.Add("weight","体重");
            dataGridView1.Columns.Add("imagefile","画像ファイル");
            int cnt = 0;
            while(dreader.Read())
            {
                dataGridView1.Rows.Add();
                dataGridView1["id", cnt].Value = dreader.GetString(0);
                dataGridView1["name", cnt].Value = dreader.GetString(1);
                dataGridView1["positionid", cnt].Value = dreader.GetString(2);
                dataGridView1["teamid", cnt].Value = dreader.GetString(3);
                dataGridView1["bornyear", cnt].Value = dreader.GetDateTime(4).ToString("yyyy/MM/dd");
                dataGridView1["height", cnt].Value = dreader.GetInt32(5).ToString();
                dataGridView1["weight", cnt].Value = dreader.GetInt32(6).ToString();
                dataGridView1["imagefile", cnt].Value = dreader.GetString(7);
                cnt++;
            }
            cn.Close();
            dataGridView1.AutoResizeColumns();
          }

        private void DataTable1_Click(object sender, EventArgs e)
        {
            Release_Click(sender, e);
            dt = new DataTable();
            cn =new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\DBJapan.accdb;");
            da = new OleDbDataAdapter("SELECT * FROM Member", cn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoResizeColumns();
        }

        private void DataTable2_Click(object sender, EventArgs e)
        {
            Release_Click(sender, e);
            dt = new DataTable();
            cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\DBJapan.accdb;";
            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM Member";
            da.SelectCommand = cmd;
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoResizeColumns();
        }

        private void DataSet_Click(object sender, EventArgs e)
        {
            Release_Click(sender, e);
            ds = new DataSet();
            ds.Tables.Add("T_Member");
            ds.Tables.Add("T_Role");
            ds.Tables.Add("T_Team");

            cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\DBJapan.accdb;";
            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM Member";
            da.SelectCommand = cmd;
            da.Fill(ds,"T_Member");
            dataGridView1.DataSource = ds.Tables["T_Member"];
            dataGridView1.AutoResizeColumns();

            cmd.CommandText = "SELECT * FROM Role";
            da.SelectCommand = cmd;
            da.Fill(ds, "T_Role");
            dataGridView2.DataSource = ds.Tables["T_Role"];
            dataGridView2.AutoResizeColumns();

            cmd.CommandText = "SELECT * FROM Team";
            da.SelectCommand = cmd;
            da.Fill(ds, "T_Team");
            dataGridView3.DataSource = ds.Tables["T_Team"];
            dataGridView3.AutoResizeColumns();
        }

        private void Release_Click(object sender, EventArgs e)
        {
            dt.Clear();
            ds.Tables.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
            dataGridView3.DataSource = null;
        }
    }
}
