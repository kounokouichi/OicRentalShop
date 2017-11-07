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

namespace CS_26
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
        }

        private void clickdata()
        {
            textBox1.Text = dataGridView1[0, dataGridView1. CurrentCell.RowIndex].Value.ToString();
            textBox2.Text = dataGridView1[1, dataGridView1. CurrentCell.RowIndex].Value.ToString();
            comboBox1.Text = dataGridView1[2, dataGridView1. CurrentCell.RowIndex].Value.ToString();
            comboBox2.Text = dataGridView1[3, dataGridView1. CurrentCell.RowIndex].Value.ToString();
            textBox5.Text = DateTime.Parse(dataGridView1[4, dataGridView1. CurrentCell.RowIndex].Value.ToString()).ToString("yyyy/MM/dd");
            textBox6.Text = dataGridView1[5, dataGridView1. CurrentCell.RowIndex].Value.ToString();
            textBox7.Text = dataGridView1[6, dataGridView1. CurrentCell.RowIndex].Value.ToString();
            textBox3.Text = dataGridView1[7, dataGridView1. CurrentCell.RowIndex].Value.ToString();
            pictureBox1.Image = Image.FromFile(@".\Japan\" + textBox3.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataload(0);
            clickdata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
            cmd.CommandText="UPDATE Member SET 名前='"+textBox2.Text+"',"+"ポジションID"+comboBox1.Text+"'"+
        }

        private void panel2_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void panel2_DragEnter(object sender, DragEventArgs e)
        {

        }
    }
}
