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

namespace CS_21
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

        private void button1_Click(object sender, EventArgs e)
        {
            cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\DBJapan.accdb;";
            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM Member";
            da.SelectCommand = cmd;
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1_Click(sender,e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoResizeColumns();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dataGridView1.DataSource = null;
            pictureBox1.Image = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("列数=" + dataGridView1.ColumnCount.ToString(), "CS-21");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("行数=" + dataGridView1.RowCount.ToString(), "CS-21");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count==0)
            {
                MessageBox.Show("データを表示してください", "CS-21");
                return;
            }
            MessageBox.Show("選択列番号=" + dataGridView1.CurrentCell.ColumnIndex.ToString(), "CS-21");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("データを表示してください", "CS-21");
                return;
            }
            MessageBox.Show("選択行番号=" + dataGridView1.CurrentCell.RowIndex.ToString(), "CS-21");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("データを表示してください", "CS-21");
                return;
            }
            MessageBox.Show("選択セルの値=" + dataGridView1[dataGridView1.CurrentCell.ColumnIndex,dataGridView1.CurrentCell.RowIndex].Value.ToString(), "CS-21");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dt.Rows.Count > 0)
            {
                //string img = @".\Japan\" + dt.dataGridView1[dataGridView1.CurrentCell.RowIndex].Value.ToString();
                string img = @".\Japan\" + dt.Rows[dataGridView1.CurrentCell.RowIndex][7].ToString();
                pictureBox1.Image = Image.FromFile(img);
            }
        }
    }
}
