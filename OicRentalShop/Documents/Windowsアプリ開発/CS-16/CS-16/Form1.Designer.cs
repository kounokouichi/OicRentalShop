namespace CS_16
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.EndToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ClearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.UndoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RedoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DispToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BackColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HomePageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VersionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CMCutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CMCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CMPasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CMClearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CMUndoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CMRedoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.OpentoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SavetoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.CuttoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.CopytoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.PastetoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.UndotoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.RedotoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.FontNametoolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.FontSizetoolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.DispToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.toolStripSeparator1,
            this.EndToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
            this.FileToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Image = global::CS_16.Properties.Resources.File_Open;
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.OpenToolStripMenuItem.Text = "開く(&O)...";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Image = global::CS_16.Properties.Resources.File_Save;
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.SaveToolStripMenuItem.Text = "保存(&S)...";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // EndToolStripMenuItem
            // 
            this.EndToolStripMenuItem.Name = "EndToolStripMenuItem";
            this.EndToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.EndToolStripMenuItem.Text = "終了(&X)";
            this.EndToolStripMenuItem.Click += new System.EventHandler(this.EndToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CutToolStripMenuItem,
            this.CopyToolStripMenuItem,
            this.PasteToolStripMenuItem,
            this.toolStripSeparator2,
            this.ClearToolStripMenuItem,
            this.toolStripSeparator3,
            this.UndoToolStripMenuItem,
            this.RedoToolStripMenuItem});
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(61, 22);
            this.EditToolStripMenuItem.Text = "編集(&E)";
            // 
            // CutToolStripMenuItem
            // 
            this.CutToolStripMenuItem.Image = global::CS_16.Properties.Resources.Cut;
            this.CutToolStripMenuItem.Name = "CutToolStripMenuItem";
            this.CutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.CutToolStripMenuItem.Text = "切り取り(&T)";
            this.CutToolStripMenuItem.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
            // 
            // CopyToolStripMenuItem
            // 
            this.CopyToolStripMenuItem.Image = global::CS_16.Properties.Resources.Copy;
            this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
            this.CopyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.CopyToolStripMenuItem.Text = "コピー(&C)";
            this.CopyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // PasteToolStripMenuItem
            // 
            this.PasteToolStripMenuItem.Image = global::CS_16.Properties.Resources.Paste;
            this.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
            this.PasteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.PasteToolStripMenuItem.Text = "貼り付け(&V)";
            this.PasteToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // ClearToolStripMenuItem
            // 
            this.ClearToolStripMenuItem.Image = global::CS_16.Properties.Resources.Clear;
            this.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem";
            this.ClearToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ClearToolStripMenuItem.Text = "クリア(&Y)";
            this.ClearToolStripMenuItem.Click += new System.EventHandler(this.ClearToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // UndoToolStripMenuItem
            // 
            this.UndoToolStripMenuItem.Image = global::CS_16.Properties.Resources.Undo;
            this.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem";
            this.UndoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.UndoToolStripMenuItem.Text = "元に戻す(&U)";
            this.UndoToolStripMenuItem.Click += new System.EventHandler(this.UndoToolStripMenuItem_Click);
            // 
            // RedoToolStripMenuItem
            // 
            this.RedoToolStripMenuItem.Image = global::CS_16.Properties.Resources.Redo;
            this.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem";
            this.RedoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.RedoToolStripMenuItem.Text = "やり直し(&R)";
            this.RedoToolStripMenuItem.Click += new System.EventHandler(this.RedoToolStripMenuItem_Click);
            // 
            // DispToolStripMenuItem
            // 
            this.DispToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FontToolStripMenuItem,
            this.BackColorToolStripMenuItem});
            this.DispToolStripMenuItem.Name = "DispToolStripMenuItem";
            this.DispToolStripMenuItem.Size = new System.Drawing.Size(62, 22);
            this.DispToolStripMenuItem.Text = "表示(&V)";
            // 
            // FontToolStripMenuItem
            // 
            this.FontToolStripMenuItem.Image = global::CS_16.Properties.Resources.Font;
            this.FontToolStripMenuItem.Name = "FontToolStripMenuItem";
            this.FontToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.FontToolStripMenuItem.Text = "フォント(&F)...";
            this.FontToolStripMenuItem.Click += new System.EventHandler(this.FontToolStripMenuItem_Click);
            // 
            // BackColorToolStripMenuItem
            // 
            this.BackColorToolStripMenuItem.Image = global::CS_16.Properties.Resources.Color;
            this.BackColorToolStripMenuItem.Name = "BackColorToolStripMenuItem";
            this.BackColorToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.BackColorToolStripMenuItem.Text = "背景色(&C)...";
            this.BackColorToolStripMenuItem.Click += new System.EventHandler(this.BackColorToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HomePageToolStripMenuItem,
            this.VersionToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(75, 22);
            this.HelpToolStripMenuItem.Text = "ヘルプ(&H)";
            // 
            // HomePageToolStripMenuItem
            // 
            this.HomePageToolStripMenuItem.Image = global::CS_16.Properties.Resources.Homepage;
            this.HomePageToolStripMenuItem.Name = "HomePageToolStripMenuItem";
            this.HomePageToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.HomePageToolStripMenuItem.Text = "ホームページ(&H)...";
            this.HomePageToolStripMenuItem.Click += new System.EventHandler(this.HomePageToolStripMenuItem_Click);
            // 
            // VersionToolStripMenuItem
            // 
            this.VersionToolStripMenuItem.Image = global::CS_16.Properties.Resources.Versions;
            this.VersionToolStripMenuItem.Name = "VersionToolStripMenuItem";
            this.VersionToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.VersionToolStripMenuItem.Text = "バージョン情報(&V)...";
            this.VersionToolStripMenuItem.Click += new System.EventHandler(this.VersionToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 65);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(800, 445);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CMCutToolStripMenuItem,
            this.CMCopyToolStripMenuItem,
            this.CMPasteToolStripMenuItem,
            this.CMClearToolStripMenuItem,
            this.CMUndoToolStripMenuItem,
            this.CMRedoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(172, 136);
            // 
            // CMCutToolStripMenuItem
            // 
            this.CMCutToolStripMenuItem.Image = global::CS_16.Properties.Resources.Cut;
            this.CMCutToolStripMenuItem.Name = "CMCutToolStripMenuItem";
            this.CMCutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.CMCutToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.CMCutToolStripMenuItem.Text = "切り取り";
            this.CMCutToolStripMenuItem.Click += new System.EventHandler(this.CMCutToolStripMenuItem_Click);
            // 
            // CMCopyToolStripMenuItem
            // 
            this.CMCopyToolStripMenuItem.Image = global::CS_16.Properties.Resources.Copy;
            this.CMCopyToolStripMenuItem.Name = "CMCopyToolStripMenuItem";
            this.CMCopyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.CMCopyToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.CMCopyToolStripMenuItem.Text = "コピー";
            this.CMCopyToolStripMenuItem.Click += new System.EventHandler(this.CMCopyToolStripMenuItem_Click);
            // 
            // CMPasteToolStripMenuItem
            // 
            this.CMPasteToolStripMenuItem.Image = global::CS_16.Properties.Resources.Paste;
            this.CMPasteToolStripMenuItem.Name = "CMPasteToolStripMenuItem";
            this.CMPasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.CMPasteToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.CMPasteToolStripMenuItem.Text = "貼り付け";
            this.CMPasteToolStripMenuItem.Click += new System.EventHandler(this.CMPasteToolStripMenuItem_Click);
            // 
            // CMClearToolStripMenuItem
            // 
            this.CMClearToolStripMenuItem.Image = global::CS_16.Properties.Resources.Clear;
            this.CMClearToolStripMenuItem.Name = "CMClearToolStripMenuItem";
            this.CMClearToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.CMClearToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.CMClearToolStripMenuItem.Text = "クリア";
            this.CMClearToolStripMenuItem.Click += new System.EventHandler(this.CMClearToolStripMenuItem_Click);
            // 
            // CMUndoToolStripMenuItem
            // 
            this.CMUndoToolStripMenuItem.Image = global::CS_16.Properties.Resources.Undo;
            this.CMUndoToolStripMenuItem.Name = "CMUndoToolStripMenuItem";
            this.CMUndoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.CMUndoToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.CMUndoToolStripMenuItem.Text = "元に戻す";
            this.CMUndoToolStripMenuItem.Click += new System.EventHandler(this.CMUndoToolStripMenuItem_Click);
            // 
            // CMRedoToolStripMenuItem
            // 
            this.CMRedoToolStripMenuItem.Image = global::CS_16.Properties.Resources.Redo;
            this.CMRedoToolStripMenuItem.Name = "CMRedoToolStripMenuItem";
            this.CMRedoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.CMRedoToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.CMRedoToolStripMenuItem.Text = "やり直し";
            this.CMRedoToolStripMenuItem.Click += new System.EventHandler(this.CMRedoToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Rich Text(*.rtf)|*.rtf";
            this.openFileDialog1.Title = "リッチテキストファイルを開く";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Rich Text(*.rtf)|*.rtf";
            this.saveFileDialog1.Title = "リッチテキストファイルに保存";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.AliceBlue;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpentoolStripButton,
            this.SavetoolStripButton,
            this.CuttoolStripButton,
            this.CopytoolStripButton,
            this.PastetoolStripButton,
            this.toolStripButton1,
            this.toolStripSeparator4,
            this.UndotoolStripButton,
            this.RedotoolStripButton,
            this.toolStripSeparator5,
            this.FontNametoolStripComboBox,
            this.FontSizetoolStripComboBox});
            this.toolStrip1.Location = new System.Drawing.Point(0, 26);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 39);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // OpentoolStripButton
            // 
            this.OpentoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpentoolStripButton.Image = global::CS_16.Properties.Resources.File_Open;
            this.OpentoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpentoolStripButton.Name = "OpentoolStripButton";
            this.OpentoolStripButton.Size = new System.Drawing.Size(36, 36);
            this.OpentoolStripButton.Text = "開く";
            this.OpentoolStripButton.Click += new System.EventHandler(this.OpentoolStripButton_Click);
            // 
            // SavetoolStripButton
            // 
            this.SavetoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SavetoolStripButton.Image = global::CS_16.Properties.Resources.File_Save;
            this.SavetoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SavetoolStripButton.Name = "SavetoolStripButton";
            this.SavetoolStripButton.Size = new System.Drawing.Size(36, 36);
            this.SavetoolStripButton.Text = "保存";
            this.SavetoolStripButton.Click += new System.EventHandler(this.SavetoolStripButton_Click);
            // 
            // CuttoolStripButton
            // 
            this.CuttoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CuttoolStripButton.Image = global::CS_16.Properties.Resources.Cut;
            this.CuttoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CuttoolStripButton.Name = "CuttoolStripButton";
            this.CuttoolStripButton.Size = new System.Drawing.Size(36, 36);
            this.CuttoolStripButton.Text = "切り取り";
            this.CuttoolStripButton.Click += new System.EventHandler(this.CuttoolStripButton_Click);
            // 
            // CopytoolStripButton
            // 
            this.CopytoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CopytoolStripButton.Image = global::CS_16.Properties.Resources.Copy;
            this.CopytoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CopytoolStripButton.Name = "CopytoolStripButton";
            this.CopytoolStripButton.Size = new System.Drawing.Size(36, 36);
            this.CopytoolStripButton.Text = "コピー";
            this.CopytoolStripButton.Click += new System.EventHandler(this.CopytoolStripButton_Click);
            // 
            // PastetoolStripButton
            // 
            this.PastetoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PastetoolStripButton.Image = global::CS_16.Properties.Resources.Paste;
            this.PastetoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PastetoolStripButton.Name = "PastetoolStripButton";
            this.PastetoolStripButton.Size = new System.Drawing.Size(36, 36);
            this.PastetoolStripButton.Text = "貼り付け";
            this.PastetoolStripButton.Click += new System.EventHandler(this.PastetoolStripButton_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.CleartoolStripButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 39);
            // 
            // UndotoolStripButton
            // 
            this.UndotoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UndotoolStripButton.Image = global::CS_16.Properties.Resources.Undo;
            this.UndotoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UndotoolStripButton.Name = "UndotoolStripButton";
            this.UndotoolStripButton.Size = new System.Drawing.Size(36, 36);
            this.UndotoolStripButton.Text = "やり直し";
            this.UndotoolStripButton.Click += new System.EventHandler(this.UndotoolStripButton_Click);
            // 
            // RedotoolStripButton
            // 
            this.RedotoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RedotoolStripButton.Image = global::CS_16.Properties.Resources.Redo;
            this.RedotoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RedotoolStripButton.Name = "RedotoolStripButton";
            this.RedotoolStripButton.Size = new System.Drawing.Size(36, 36);
            this.RedotoolStripButton.Text = "やり直し";
            this.RedotoolStripButton.Click += new System.EventHandler(this.RedotoolStripButton_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 39);
            // 
            // FontNametoolStripComboBox
            // 
            this.FontNametoolStripComboBox.Name = "FontNametoolStripComboBox";
            this.FontNametoolStripComboBox.Size = new System.Drawing.Size(121, 39);
            this.FontNametoolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.FontNametoolStripComboBox_SelectedIndexChanged);
            // 
            // FontSizetoolStripComboBox
            // 
            this.FontSizetoolStripComboBox.AutoSize = false;
            this.FontSizetoolStripComboBox.Name = "FontSizetoolStripComboBox";
            this.FontSizetoolStripComboBox.Size = new System.Drawing.Size(45, 26);
            this.FontSizetoolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.FontSizetoolStripComboBox_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 510);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 23);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(56, 18);
            this.toolStripStatusLabel1.Text = "文字数：";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(35, 18);
            this.toolStripStatusLabel2.Text = "0";
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(800, 533);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MyEditer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem EndToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ClearToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem UndoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RedoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DispToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BackColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HomePageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VersionToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CMCutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CMCopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CMPasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CMClearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CMUndoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CMRedoToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton OpentoolStripButton;
        private System.Windows.Forms.ToolStripButton SavetoolStripButton;
        private System.Windows.Forms.ToolStripButton CuttoolStripButton;
        private System.Windows.Forms.ToolStripButton CopytoolStripButton;
        private System.Windows.Forms.ToolStripButton PastetoolStripButton;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton UndotoolStripButton;
        private System.Windows.Forms.ToolStripButton RedotoolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripComboBox FontNametoolStripComboBox;
        private System.Windows.Forms.ToolStripComboBox FontSizetoolStripComboBox;
    }
}

