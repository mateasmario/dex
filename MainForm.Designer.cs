﻿namespace Dex
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
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("No file opened");
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem("Flat White");
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem("Flat White + Red");
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem("Deep Dark");
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem("Vim Blue");
            System.Windows.Forms.ListViewItem listViewItem17 = new System.Windows.Forms.ListViewItem("Vim Blue + Yellow");
            System.Windows.Forms.ListViewItem listViewItem18 = new System.Windows.Forms.ListViewItem("Crimson Red");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Sidepanel = new System.Windows.Forms.TreeView();
            this.CodeBox = new System.Windows.Forms.RichTextBox();
            this.Themepanel = new System.Windows.Forms.Panel();
            this.Themelabel = new System.Windows.Forms.Label();
            this.Themelist = new System.Windows.Forms.ListView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.javaFilejavaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.pythonScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perlScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.Themepanel.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.dexToolStripMenuItem});
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
            // Sidepanel
            // 
            this.Sidepanel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Sidepanel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Sidepanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sidepanel.Location = new System.Drawing.Point(0, 32);
            this.Sidepanel.Name = "Sidepanel";
            treeNode3.Name = "No file opened";
            treeNode3.Text = "No file opened";
            this.Sidepanel.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.Sidepanel.ShowLines = false;
            this.Sidepanel.ShowRootLines = false;
            this.Sidepanel.Size = new System.Drawing.Size(200, 609);
            this.Sidepanel.TabIndex = 1;
            this.Sidepanel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Global_KeyDown);
            // 
            // CodeBox
            // 
            this.CodeBox.AcceptsTab = true;
            this.CodeBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CodeBox.DetectUrls = false;
            this.CodeBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CodeBox.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeBox.Location = new System.Drawing.Point(200, 32);
            this.CodeBox.Name = "CodeBox";
            this.CodeBox.Size = new System.Drawing.Size(822, 609);
            this.CodeBox.TabIndex = 2;
            this.CodeBox.Text = "";
            this.CodeBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Global_KeyDown);
            this.CodeBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CodeBox_KeyPress);
            // 
            // Themepanel
            // 
            this.Themepanel.BackColor = System.Drawing.SystemColors.InactiveBorder;
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
            this.Themelabel.Location = new System.Drawing.Point(6, 7);
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
            listViewItem13.StateImageIndex = 0;
            listViewItem15.StateImageIndex = 0;
            listViewItem16.StateImageIndex = 0;
            this.Themelist.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem13,
            listViewItem14,
            listViewItem15,
            listViewItem16,
            listViewItem17,
            listViewItem18});
            this.Themelist.Location = new System.Drawing.Point(12, 42);
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
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(200, 435);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 206);
            this.panel1.TabIndex = 5;
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
            this.javaClassFileclassToolStripMenuItem.Size = new System.Drawing.Size(188, 30);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 671);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CodeBox);
            this.Controls.Add(this.Themepanel);
            this.Controls.Add(this.Sidepanel);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.TreeView Sidepanel;
        private System.Windows.Forms.RichTextBox CodeBox;
        private System.Windows.Forms.ToolStripMenuItem dexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Panel Themepanel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ListView Themelist;
        private System.Windows.Forms.Panel panel1;
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
    }
}
