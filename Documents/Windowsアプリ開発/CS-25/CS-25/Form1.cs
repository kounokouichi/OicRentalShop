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

namespace CS_25
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

        private void dataload()
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
            comboBox1.Items.Clear();
            for(int i=0;i<dt.Rows.Count;i++)
            {
                comboBox1.Items.Add(dt.Rows[i][0].ToString());
            }
            comboBox1.Text = dt.Rows[0][0].ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataload();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("ID="+comboBox1.Text+"のデータを削除してもよろしいですか","CS-25",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.No)
            {
                return;
            }
            cmd.Connection = cn;
            cmd.CommandText = "DELETE FROM Member WHERE ID ='" + comboBox1.Text+ "'";
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("削除しました", "CS-25");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "CS-25");
            }
            cn.Close();
            dataload();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = dataGridView1.Rows[comboBox1.SelectedIndex].Cells["ID"];
            dataGridView1.Rows[comboBox1.SelectedIndex].Selected = true;
            dataGridView1.FirstDisplayedScrollingRowIndex = comboBox1.SelectedIndex;
        }
    }
}
