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

namespace CS_23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection cn = new OleDbConnection();
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataTable dt = new DataTable();

        private void Form1_Load(object sender, EventArgs e)
        {
            cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\DBJapan.accdb;");
        }

        private void selectfunc(string cmdstr)
        {
            dt.Clear();
            dt = new DataTable();
            dataGridView1.DataSource = null;
            da = new OleDbDataAdapter(cmdstr, cn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoResizeColumns();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectfunc("SELECT * FROM Member");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectfunc("SELECT * FROM Member ORDER BY 身長 ASC");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectfunc("SELECT * FROM Member ORDER BY 体重 DESC");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            selectfunc("SELECT 名前,生年月日 FROM Member");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            selectfunc("SELECT * FROM Member WHERE ポジションID='DF'");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            selectfunc("SELECT * FROM Member WHERE 体重<=70");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            selectfunc("SELECT * FROM Member WHERE 名前 LIKE '%司%'");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            selectfunc("SELECT * FROM Member WHERE 身長>=180 AND ポジションID='DF'");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            selectfunc("SELECT m.名前,r.ポジション名,t.チーム名 FROM Member m,Role r,Team t WHERE m.所属ID=t.ID AND m.ポジションID=r.ID");

        }

        private void button10_Click(object sender, EventArgs e)
        {
            selectfunc("SELECT 名前,FORMAT$(生年月日,'ggggee年mm月dd日')AS 和暦 FROM Member");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            selectfunc("SELECT m.名前,r.ポジション名,t.チーム名 FROM (Member m INNER JOIN Role r ON m.ポジションID=r.ID) INNER JOIN Team t ON m.所属ID=t.ID ");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            selectfunc("SELECT 名前,DATEDIFF('yyyy',生年月日,Date()) AS 年齢 FROM Member");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            selectfunc("SELECT COUNT(*) AS 25以下の人数 FROM Member WHERE DATEDIFF('yyyy',生年月日,Date())<=25");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            selectfunc("SELECT m.名前,t.チーム国名 FROM Member m,Team t WHERE m.所属ID=T.ID AND t.チーム国名='日本'");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            selectfunc("SELECT 名前,身長 FROM Member WHERE 身長 = (SELECT MAX(身長) FROM Member)");

        }

        private void button16_Click(object sender, EventArgs e)
        {
            selectfunc("SELECT FORMAT$(AVG(身長),'###.##')AS 平均身長 FROM Member");

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
        }
    }
}
