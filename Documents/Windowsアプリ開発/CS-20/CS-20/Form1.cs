using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void memberBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.memberBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBjapanDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'dBjapanDataSet.Member' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.memberTableAdapter.Fill(this.dBjapanDataSet.Member);

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            memberDataGridView.AutoResizeColumns();
        }
    }
}
