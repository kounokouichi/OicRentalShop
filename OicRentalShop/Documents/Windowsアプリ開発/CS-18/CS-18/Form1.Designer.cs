namespace CS_18
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ReturntoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.MovetoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.HometoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.EntertoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.FavoritetoolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.yahooToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.googleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.microsoftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iconFinderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VersiontoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ReturntoolStripButton,
            this.MovetoolStripButton,
            this.toolStripSeparator1,
            this.HometoolStripButton,
            this.toolStripTextBox1,
            this.EntertoolStripButton,
            this.toolStripSeparator2,
            this.FavoritetoolStripDropDownButton,
            this.VersiontoolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(688, 39);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(350, 39);
            this.toolStripTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox1_KeyDown);
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // ReturntoolStripButton
            // 
            this.ReturntoolStripButton.Enabled = false;
            this.ReturntoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ReturntoolStripButton.Image")));
            this.ReturntoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ReturntoolStripButton.Name = "ReturntoolStripButton";
            this.ReturntoolStripButton.Size = new System.Drawing.Size(68, 36);
            this.ReturntoolStripButton.Text = "戻る";
            this.ReturntoolStripButton.Click += new System.EventHandler(this.ReturntoolStripButton_Click);
            // 
            // MovetoolStripButton
            // 
            this.MovetoolStripButton.Enabled = false;
            this.MovetoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("MovetoolStripButton.Image")));
            this.MovetoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MovetoolStripButton.Name = "MovetoolStripButton";
            this.MovetoolStripButton.Size = new System.Drawing.Size(68, 36);
            this.MovetoolStripButton.Text = "進む";
            this.MovetoolStripButton.Click += new System.EventHandler(this.MovetoolStripButton_Click);
            // 
            // HometoolStripButton
            // 
            this.HometoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HometoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("HometoolStripButton.Image")));
            this.HometoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HometoolStripButton.Name = "HometoolStripButton";
            this.HometoolStripButton.Size = new System.Drawing.Size(36, 36);
            this.HometoolStripButton.Text = "ホーム";
            this.HometoolStripButton.Click += new System.EventHandler(this.HometoolStripButton_Click);
            // 
            // EntertoolStripButton
            // 
            this.EntertoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EntertoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("EntertoolStripButton.Image")));
            this.EntertoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EntertoolStripButton.Name = "EntertoolStripButton";
            this.EntertoolStripButton.Size = new System.Drawing.Size(36, 36);
            this.EntertoolStripButton.Text = "決定";
            this.EntertoolStripButton.Click += new System.EventHandler(this.EntertoolStripButton_Click);
            // 
            // FavoritetoolStripDropDownButton
            // 
            this.FavoritetoolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FavoritetoolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yahooToolStripMenuItem,
            this.googleToolStripMenuItem,
            this.microsoftToolStripMenuItem,
            this.appleToolStripMenuItem,
            this.iconFinderToolStripMenuItem});
            this.FavoritetoolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("FavoritetoolStripDropDownButton.Image")));
            this.FavoritetoolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FavoritetoolStripDropDownButton.Name = "FavoritetoolStripDropDownButton";
            this.FavoritetoolStripDropDownButton.Size = new System.Drawing.Size(45, 36);
            this.FavoritetoolStripDropDownButton.Text = "お気に入り";
            // 
            // yahooToolStripMenuItem
            // 
            this.yahooToolStripMenuItem.Image = global::CS_18.Properties.Resources.yahoo;
            this.yahooToolStripMenuItem.Name = "yahooToolStripMenuItem";
            this.yahooToolStripMenuItem.Size = new System.Drawing.Size(168, 38);
            this.yahooToolStripMenuItem.Text = "Yahoo...";
            this.yahooToolStripMenuItem.Click += new System.EventHandler(this.yahooToolStripMenuItem_Click);
            // 
            // googleToolStripMenuItem
            // 
            this.googleToolStripMenuItem.Image = global::CS_18.Properties.Resources.google;
            this.googleToolStripMenuItem.Name = "googleToolStripMenuItem";
            this.googleToolStripMenuItem.Size = new System.Drawing.Size(168, 38);
            this.googleToolStripMenuItem.Text = "Google...";
            this.googleToolStripMenuItem.Click += new System.EventHandler(this.googleToolStripMenuItem_Click);
            // 
            // microsoftToolStripMenuItem
            // 
            this.microsoftToolStripMenuItem.Image = global::CS_18.Properties.Resources.microsoft;
            this.microsoftToolStripMenuItem.Name = "microsoftToolStripMenuItem";
            this.microsoftToolStripMenuItem.Size = new System.Drawing.Size(168, 38);
            this.microsoftToolStripMenuItem.Text = "Microsoft...";
            this.microsoftToolStripMenuItem.Click += new System.EventHandler(this.microsoftToolStripMenuItem_Click);
            // 
            // appleToolStripMenuItem
            // 
            this.appleToolStripMenuItem.Image = global::CS_18.Properties.Resources.apple;
            this.appleToolStripMenuItem.Name = "appleToolStripMenuItem";
            this.appleToolStripMenuItem.Size = new System.Drawing.Size(168, 38);
            this.appleToolStripMenuItem.Text = "Apple...";
            this.appleToolStripMenuItem.Click += new System.EventHandler(this.appleToolStripMenuItem_Click);
            // 
            // iconFinderToolStripMenuItem
            // 
            this.iconFinderToolStripMenuItem.Image = global::CS_18.Properties.Resources.icon_finder;
            this.iconFinderToolStripMenuItem.Name = "iconFinderToolStripMenuItem";
            this.iconFinderToolStripMenuItem.Size = new System.Drawing.Size(168, 38);
            this.iconFinderToolStripMenuItem.Text = "IconFinder...";
            this.iconFinderToolStripMenuItem.Click += new System.EventHandler(this.iconFinderToolStripMenuItem_Click);
            // 
            // VersiontoolStripButton
            // 
            this.VersiontoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.VersiontoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("VersiontoolStripButton.Image")));
            this.VersiontoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.VersiontoolStripButton.Name = "VersiontoolStripButton";
            this.VersiontoolStripButton.Size = new System.Drawing.Size(36, 36);
            this.VersiontoolStripButton.Text = "バージョン";
            this.VersiontoolStripButton.Click += new System.EventHandler(this.VersiontoolStripButton_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 39);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(688, 392);
            this.webBrowser1.TabIndex = 3;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(688, 431);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MyBrowser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ReturntoolStripButton;
        private System.Windows.Forms.ToolStripButton MovetoolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton HometoolStripButton;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton EntertoolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton FavoritetoolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem yahooToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem googleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem microsoftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iconFinderToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton VersiontoolStripButton;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

