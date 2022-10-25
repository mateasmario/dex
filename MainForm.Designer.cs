namespace Dex
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("No file opened");
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Flat White");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Flat White + Red");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Deep Dark");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Vim Blue");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Vim Blue + Yellow");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Crimson Red");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Filelist = new System.Windows.Forms.TreeView();
            this.CodeBox = new System.Windows.Forms.RichTextBox();
            this.Themepanel = new System.Windows.Forms.Panel();
            this.Themelabel = new System.Windows.Forms.Label();
            this.Themelist = new System.Windows.Forms.ListView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Terminalpanel = new System.Windows.Forms.Panel();
            this.Filepanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.contentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FindReplacePanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.FindTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ReplaceTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.javaFilejavaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pythonScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perlScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton3 = new System.Windows.Forms.ToolStripSplitButton();
            this.javaClassFileclassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.powershellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdexeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.Themepanel.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.Filepanel.SuspendLayout();
            this.FindReplacePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.dexToolStripMenuItem,
            this.contentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1222, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dexToolStripMenuItem
            // 
            this.dexToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem1,
            this.saveToolStripMenuItem});
            this.dexToolStripMenuItem.Name = "dexToolStripMenuItem";
            this.dexToolStripMenuItem.Size = new System.Drawing.Size(37, 28);
            this.dexToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.saveToolStripMenuItem.Text = "Save as...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveAs);
            // 
            // Filelist
            // 
            this.Filelist.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Filelist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Filelist.Location = new System.Drawing.Point(6, 45);
            this.Filelist.Name = "Filelist";
            treeNode1.Name = "No file opened";
            treeNode1.Text = "No file opened";
            this.Filelist.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.Filelist.ShowLines = false;
            this.Filelist.ShowRootLines = false;
            this.Filelist.Size = new System.Drawing.Size(200, 609);
            this.Filelist.TabIndex = 1;
            this.Filelist.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Global_KeyDown);
            // 
            // CodeBox
            // 
            this.CodeBox.AcceptsTab = true;
            this.CodeBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CodeBox.DetectUrls = false;
            this.CodeBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CodeBox.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeBox.Location = new System.Drawing.Point(200, 77);
            this.CodeBox.Name = "CodeBox";
            this.CodeBox.Size = new System.Drawing.Size(822, 564);
            this.CodeBox.TabIndex = 2;
            this.CodeBox.Text = "";
            this.CodeBox.SelectionChanged += new System.EventHandler(this.CodeBox_SelectionChanged);
            this.CodeBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Global_KeyDown);
            this.CodeBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CodeBox_KeyPress);
            // 
            // Themepanel
            // 
            this.Themepanel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Themepanel.Controls.Add(this.pictureBox2);
            this.Themepanel.Controls.Add(this.Themelabel);
            this.Themepanel.Controls.Add(this.Themelist);
            this.Themepanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.Themepanel.Location = new System.Drawing.Point(1022, 32);
            this.Themepanel.Name = "Themepanel";
            this.Themepanel.Size = new System.Drawing.Size(200, 609);
            this.Themepanel.TabIndex = 3;
            // 
            // Themelabel
            // 
            this.Themelabel.AutoSize = true;
            this.Themelabel.BackColor = System.Drawing.Color.Transparent;
            this.Themelabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Themelabel.Location = new System.Drawing.Point(40, 7);
            this.Themelabel.Name = "Themelabel";
            this.Themelabel.Size = new System.Drawing.Size(98, 32);
            this.Themelabel.TabIndex = 3;
            this.Themelabel.Text = "Themes";
            // 
            // Themelist
            // 
            this.Themelist.AllowDrop = true;
            this.Themelist.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Themelist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Themelist.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            listViewItem3.StateImageIndex = 0;
            listViewItem4.StateImageIndex = 0;
            this.Themelist.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.Themelist.Location = new System.Drawing.Point(6, 45);
            this.Themelist.Name = "Themelist";
            this.Themelist.Size = new System.Drawing.Size(188, 583);
            this.Themelist.TabIndex = 2;
            this.Themelist.UseCompatibleStateImageBehavior = false;
            this.Themelist.View = System.Windows.Forms.View.List;
            this.Themelist.DoubleClick += new System.EventHandler(this.Themelist_DoubleClick);
            this.Themelist.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Global_KeyDown);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton2,
            this.toolStripSplitButton3,
            this.toolStripSplitButton1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 641);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1222, 30);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Terminalpanel
            // 
            this.Terminalpanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Terminalpanel.Location = new System.Drawing.Point(200, 435);
            this.Terminalpanel.Name = "Terminalpanel";
            this.Terminalpanel.Size = new System.Drawing.Size(822, 206);
            this.Terminalpanel.TabIndex = 5;
            // 
            // Filepanel
            // 
            this.Filepanel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Filepanel.Controls.Add(this.pictureBox1);
            this.Filepanel.Controls.Add(this.Filelist);
            this.Filepanel.Controls.Add(this.label1);
            this.Filepanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Filepanel.Location = new System.Drawing.Point(0, 32);
            this.Filepanel.Name = "Filepanel";
            this.Filepanel.Size = new System.Drawing.Size(200, 609);
            this.Filepanel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(40, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "File Info";
            // 
            // contentToolStripMenuItem
            // 
            this.contentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dToolStripMenuItem});
            this.contentToolStripMenuItem.Name = "contentToolStripMenuItem";
            this.contentToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.contentToolStripMenuItem.Text = "Content";
            // 
            // FindReplacePanel
            // 
            this.FindReplacePanel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.FindReplacePanel.Controls.Add(this.button2);
            this.FindReplacePanel.Controls.Add(this.ReplaceTextBox);
            this.FindReplacePanel.Controls.Add(this.label3);
            this.FindReplacePanel.Controls.Add(this.FindTextBox);
            this.FindReplacePanel.Controls.Add(this.button1);
            this.FindReplacePanel.Controls.Add(this.label2);
            this.FindReplacePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FindReplacePanel.Location = new System.Drawing.Point(200, 32);
            this.FindReplacePanel.Name = "FindReplacePanel";
            this.FindReplacePanel.Size = new System.Drawing.Size(822, 45);
            this.FindReplacePanel.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Find";
            // 
            // FindTextBox
            // 
            this.FindTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FindTextBox.Location = new System.Drawing.Point(50, 12);
            this.FindTextBox.Name = "FindTextBox";
            this.FindTextBox.Size = new System.Drawing.Size(224, 20);
            this.FindTextBox.TabIndex = 8;
            this.FindTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Global_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(301, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Replace with";
            // 
            // ReplaceTextBox
            // 
            this.ReplaceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReplaceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReplaceTextBox.Enabled = false;
            this.ReplaceTextBox.Location = new System.Drawing.Point(401, 12);
            this.ReplaceTextBox.Name = "ReplaceTextBox";
            this.ReplaceTextBox.Size = new System.Drawing.Size(224, 20);
            this.ReplaceTextBox.TabIndex = 10;
            this.ReplaceTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Global_KeyDown);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(664, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 27);
            this.button2.TabIndex = 11;
            this.button2.Text = "Find/Replace";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImage = global::Dex.Properties.Resources.close__1_;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(799, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(16, 16);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Dex.Properties.Resources.sticky_notes;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(8, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Dex.Properties.Resources.color_circle;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(8, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.javaFilejavaToolStripMenuItem,
            this.pythonScriptToolStripMenuItem,
            this.perlScriptToolStripMenuItem,
            this.cFileToolStripMenuItem});
            this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(74, 28);
            this.toolStripSplitButton2.Text = "Build";
            this.toolStripSplitButton2.ButtonClick += new System.EventHandler(this.toolStripSplitButton2_ButtonClick);
            // 
            // javaFilejavaToolStripMenuItem
            // 
            this.javaFilejavaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("javaFilejavaToolStripMenuItem.Image")));
            this.javaFilejavaToolStripMenuItem.Name = "javaFilejavaToolStripMenuItem";
            this.javaFilejavaToolStripMenuItem.Size = new System.Drawing.Size(193, 30);
            this.javaFilejavaToolStripMenuItem.Text = "Java File";
            this.javaFilejavaToolStripMenuItem.Click += new System.EventHandler(this.JavaButton_Click);
            // 
            // pythonScriptToolStripMenuItem
            // 
            this.pythonScriptToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pythonScriptToolStripMenuItem.Image")));
            this.pythonScriptToolStripMenuItem.Name = "pythonScriptToolStripMenuItem";
            this.pythonScriptToolStripMenuItem.Size = new System.Drawing.Size(193, 30);
            this.pythonScriptToolStripMenuItem.Text = "Python Script";
            this.pythonScriptToolStripMenuItem.Click += new System.EventHandler(this.pythonScriptToolStripMenuItem_Click);
            // 
            // perlScriptToolStripMenuItem
            // 
            this.perlScriptToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("perlScriptToolStripMenuItem.Image")));
            this.perlScriptToolStripMenuItem.Name = "perlScriptToolStripMenuItem";
            this.perlScriptToolStripMenuItem.Size = new System.Drawing.Size(193, 30);
            this.perlScriptToolStripMenuItem.Text = "Perl Script";
            this.perlScriptToolStripMenuItem.Click += new System.EventHandler(this.perlScriptToolStripMenuItem_Click);
            // 
            // cFileToolStripMenuItem
            // 
            this.cFileToolStripMenuItem.Enabled = false;
            this.cFileToolStripMenuItem.Image = global::Dex.Properties.Resources.c_;
            this.cFileToolStripMenuItem.Name = "cFileToolStripMenuItem";
            this.cFileToolStripMenuItem.Size = new System.Drawing.Size(193, 30);
            this.cFileToolStripMenuItem.Text = "C/C++ File with GCC";
            // 
            // toolStripSplitButton3
            // 
            this.toolStripSplitButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.javaClassFileclassToolStripMenuItem});
            this.toolStripSplitButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton3.Image")));
            this.toolStripSplitButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton3.Name = "toolStripSplitButton3";
            this.toolStripSplitButton3.Size = new System.Drawing.Size(68, 28);
            this.toolStripSplitButton3.Text = "Run";
            this.toolStripSplitButton3.ButtonClick += new System.EventHandler(this.toolStripSplitButton3_ButtonClick);
            // 
            // javaClassFileclassToolStripMenuItem
            // 
            this.javaClassFileclassToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("javaClassFileclassToolStripMenuItem.Image")));
            this.javaClassFileclassToolStripMenuItem.Name = "javaClassFileclassToolStripMenuItem";
            this.javaClassFileclassToolStripMenuItem.Size = new System.Drawing.Size(155, 30);
            this.javaClassFileclassToolStripMenuItem.Text = "Java Class File";
            this.javaClassFileclassToolStripMenuItem.Click += new System.EventHandler(this.javaClassFileclassToolStripMenuItem_Click);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.powershellToolStripMenuItem,
            this.cmdexeToolStripMenuItem,
            this.bashToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(92, 28);
            this.toolStripSplitButton1.Text = "Terminal";
            this.toolStripSplitButton1.ButtonClick += new System.EventHandler(this.toolStripSplitButton1_ButtonClick);
            // 
            // powershellToolStripMenuItem
            // 
            this.powershellToolStripMenuItem.Image = global::Dex.Properties.Resources.powershell;
            this.powershellToolStripMenuItem.Name = "powershellToolStripMenuItem";
            this.powershellToolStripMenuItem.Size = new System.Drawing.Size(182, 30);
            this.powershellToolStripMenuItem.Text = "Powershell";
            this.powershellToolStripMenuItem.Click += new System.EventHandler(this.TerminalButton_Click);
            // 
            // cmdexeToolStripMenuItem
            // 
            this.cmdexeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cmdexeToolStripMenuItem.Image")));
            this.cmdexeToolStripMenuItem.Name = "cmdexeToolStripMenuItem";
            this.cmdexeToolStripMenuItem.Size = new System.Drawing.Size(182, 30);
            this.cmdexeToolStripMenuItem.Text = "Command Prompt";
            this.cmdexeToolStripMenuItem.Click += new System.EventHandler(this.TerminalButton_Click);
            // 
            // bashToolStripMenuItem
            // 
            this.bashToolStripMenuItem.Enabled = false;
            this.bashToolStripMenuItem.Image = global::Dex.Properties.Resources.linux;
            this.bashToolStripMenuItem.Name = "bashToolStripMenuItem";
            this.bashToolStripMenuItem.Size = new System.Drawing.Size(182, 30);
            this.bashToolStripMenuItem.Text = "Bash";
            this.bashToolStripMenuItem.Click += new System.EventHandler(this.TerminalButton_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.toolStripMenuItem1});
            this.fileToolStripMenuItem.Image = global::Dex.Properties.Resources.DexBlack;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(36, 28);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.toolStripMenuItem1.Text = "Exit";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // newFileToolStripMenuItem
            // 
            this.newFileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newFileToolStripMenuItem.Image")));
            this.newFileToolStripMenuItem.Name = "newFileToolStripMenuItem";
            this.newFileToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.newFileToolStripMenuItem.Text = "New";
            this.newFileToolStripMenuItem.Click += new System.EventHandler(this.newFileToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::Dex.Properties.Resources.folder__4_;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Image = global::Dex.Properties.Resources.diskette;
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.saveToolStripMenuItem1.Text = "Save...";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.Image = global::Dex.Properties.Resources.search;
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.Size = new System.Drawing.Size(188, 30);
            this.dToolStripMenuItem.Text = "Find/Replace";
            this.dToolStripMenuItem.Click += new System.EventHandler(this.dToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 671);
            this.Controls.Add(this.Terminalpanel);
            this.Controls.Add(this.CodeBox);
            this.Controls.Add(this.FindReplacePanel);
            this.Controls.Add(this.Filepanel);
            this.Controls.Add(this.Themepanel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Dex Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Global_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Themepanel.ResumeLayout(false);
            this.Themepanel.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.Filepanel.ResumeLayout(false);
            this.Filepanel.PerformLayout();
            this.FindReplacePanel.ResumeLayout(false);
            this.FindReplacePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.TreeView Filelist;
        private System.Windows.Forms.RichTextBox CodeBox;
        private System.Windows.Forms.ToolStripMenuItem dexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Panel Themepanel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ListView Themelist;
        private System.Windows.Forms.Panel Terminalpanel;
        private System.Windows.Forms.ToolStripMenuItem newFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem powershellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmdexeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bashToolStripMenuItem;
        private System.Windows.Forms.Label Themelabel;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripMenuItem javaFilejavaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton3;
        private System.Windows.Forms.ToolStripMenuItem javaClassFileclassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pythonScriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perlScriptToolStripMenuItem;
        private System.Windows.Forms.Panel Filepanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem contentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem;
        private System.Windows.Forms.Panel FindReplacePanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FindTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox ReplaceTextBox;
    }
}

