namespace CS_22
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DataReader = new System.Windows.Forms.Button();
            this.DataTable1 = new System.Windows.Forms.Button();
            this.DataTable2 = new System.Windows.Forms.Button();
            this.DataSet = new System.Windows.Forms.Button();
            this.Release = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Memberテーブル";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Roleテーブル";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Teamテーブル";
            // 
            // DataReader
            // 
            this.DataReader.Location = new System.Drawing.Point(14, 12);
            this.DataReader.Name = "DataReader";
            this.DataReader.Size = new System.Drawing.Size(107, 23);
            this.DataReader.TabIndex = 3;
            this.DataReader.Text = "DataReaderで表示";
            this.DataReader.UseVisualStyleBackColor = true;
            this.DataReader.Click += new System.EventHandler(this.DataReader_Click);
            // 
            // DataTable1
            // 
            this.DataTable1.Location = new System.Drawing.Point(127, 12);
            this.DataTable1.Name = "DataTable1";
            this.DataTable1.Size = new System.Drawing.Size(110, 23);
            this.DataTable1.TabIndex = 4;
            this.DataTable1.Text = "DataTableで表示1";
            this.DataTable1.UseVisualStyleBackColor = true;
            this.DataTable1.Click += new System.EventHandler(this.DataTable1_Click);
            // 
            // DataTable2
            // 
            this.DataTable2.Location = new System.Drawing.Point(243, 12);
            this.DataTable2.Name = "DataTable2";
            this.DataTable2.Size = new System.Drawing.Size(109, 23);
            this.DataTable2.TabIndex = 5;
            this.DataTable2.Text = "DataTableで表示2";
            this.DataTable2.UseVisualStyleBackColor = true;
            this.DataTable2.Click += new System.EventHandler(this.DataTable2_Click);
            // 
            // DataSet
            // 
            this.DataSet.Location = new System.Drawing.Point(358, 12);
            this.DataSet.Name = "DataSet";
            this.DataSet.Size = new System.Drawing.Size(99, 23);
            this.DataSet.TabIndex = 6;
            this.DataSet.Text = "DataSetで表示";
            this.DataSet.UseVisualStyleBackColor = true;
            this.DataSet.Click += new System.EventHandler(this.DataSet_Click);
            // 
            // Release
            // 
            this.Release.Location = new System.Drawing.Point(547, 12);
            this.Release.Name = "Release";
            this.Release.Size = new System.Drawing.Size(75, 23);
            this.Release.TabIndex = 7;
            this.Release.Text = "接続解除";
            this.Release.UseVisualStyleBackColor = true;
            this.Release.Click += new System.EventHandler(this.Release_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(610, 172);
            this.dataGridView1.TabIndex = 8;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 293);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 21;
            this.dataGridView2.Size = new System.Drawing.Size(292, 242);
            this.dataGridView2.TabIndex = 9;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(320, 293);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 21;
            this.dataGridView3.Size = new System.Drawing.Size(302, 242);
            this.dataGridView3.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 547);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Release);
            this.Controls.Add(this.DataSet);
            this.Controls.Add(this.DataTable2);
            this.Controls.Add(this.DataTable1);
            this.Controls.Add(this.DataReader);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CS-22";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DataReader;
        private System.Windows.Forms.Button DataTable1;
        private System.Windows.Forms.Button DataTable2;
        private System.Windows.Forms.Button DataSet;
        private System.Windows.Forms.Button Release;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
    }
}

