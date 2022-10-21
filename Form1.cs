using Dex.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Dex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Globals.form = this;
            Globals.sidePanelOpened = false;
            Sidepanel.Hide();
            Globals.themePanelOpened = false;
            Themepanel.Hide();
            Globals.terminalOpened = false;
            panel1.Hide();
            Globals.terminalStarted = false;
        }

        public void DesignFix()
        {
            this.SetStyle(System.Windows.Forms.ControlStyles.AllPaintingInWmPaint, true);
            Application.EnableVisualStyles();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DesignFix();
            ResourceManagerService.InitializeFontCollection();
            ObjectInitializerService.InitializeGlobals();

            Themelist.MultiSelect = false;

            TerminalService.NewTerminal();

            // CodeBox.Font = new Font(Globals.privateFontCollection.Families[0], 12);
        }

        private void Save(object sender, EventArgs e)
        {
            if (Globals.OpenedFile != null)
                FileManagerService.save(Globals.OpenedFile, CodeBox.Text);
            else
                FileManagerService.saveAs(CodeBox.Text, Sidepanel);
        }

        private void SaveAs(object sender, EventArgs e)
        {
            FileManagerService.saveAs(CodeBox.Text, Sidepanel);
        }

        private void Global_KeyDown(object sender, KeyEventArgs e)
        {
            // save item
            if (e.KeyCode == Keys.S && e.Modifiers == Keys.Control)
                Save(sender, e);

            // open/close side panel
            else if (e.KeyCode == Keys.Q && e.Modifiers == Keys.Control)
            {
                if (Globals.sidePanelOpened == true)
                {
                    Sidepanel.Hide();
                    Globals.sidePanelOpened = false;
                }
                else
                {
                    Sidepanel.Show();
                    Globals.sidePanelOpened = true;
                }
            }

            // open/close theme panel
            else if (e.KeyCode == Keys.T && e.Modifiers == Keys.Control)
            {
                if (Globals.themePanelOpened == true)
                {
                    Themepanel.Hide();
                    Globals.themePanelOpened = false;
                }
                else
                {
                    Themepanel.Show();
                    Globals.themePanelOpened = true;
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileManagerService.open();
        }

        private void CodeBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            String keyChar = e.KeyChar.ToString();

            if (
                Globals.openParanthesis.Count > 0 && (
                e.KeyChar == ')' && Globals.openParanthesis.Last() == "("
                || e.KeyChar == ']' && Globals.openParanthesis.Last() == "["
                || e.KeyChar == '}' && Globals.openParanthesis.Last() == "{"
                || e.KeyChar == '"' && Globals.openParanthesis.Last() == "\""
                || e.KeyChar == '\'' && Globals.openParanthesis.Last() == "'"))
            {
                e.Handled = true;
                Console.WriteLine("Handled");
                CodeBox.SelectionStart = CodeBox.SelectionStart + 1;
                Globals.openParanthesis.Remove(Globals.openParanthesis.Last());
            }

            else if (e.KeyChar == '(' || e.KeyChar == '[' || e.KeyChar == '{' || e.KeyChar == '"' || e.KeyChar == '\'')
            {
                e.Handled = true;


                if (CodeBox.SelectionLength > 1)
                {
                    int selStart = CodeBox.SelectionStart;
                    CodeBox.Text = CodeBox.Text.Substring(0, CodeBox.SelectionStart) + CodeBox.Text.Substring(CodeBox.SelectionStart + CodeBox.SelectionLength);
                    CodeBox.SelectionStart = selStart;
                }

                TextService.AddClosingCharacter(e.KeyChar.ToString());

            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Save(sender, e);
        }

        private void Themelist_DoubleClick(object sender, EventArgs e)
        {
            ThemeService.ChangeTheme(Themelist, Themelabel, Globals.Terminal);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Globals.Terminal.StopProcess();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Globals.Terminal.StopProcess();
        }

        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileManagerService.NewFile();
        }

        private void TerminalButton_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)sender;

            switch (toolStripMenuItem.Text)
            {
                case "Powershell":
                    Globals.ChosenProcess = "powershell.exe";
                    break;
                case "Command Prompt":
                    Globals.ChosenProcess = "cmd.exe";
                    break;
                case "Bash":
                    Globals.ChosenProcess = "bash.exe";
                    break;
            }

            TerminalService.OpenProcessInNewTerminal(Globals.ChosenProcess, "");
        }

        private void JavaButton_Click(object sender, EventArgs e)
        {
            if (Globals.OpenedFile != null)
            {
                TerminalService.OpenProcessInNewTerminal("javac.exe", "--version " + Globals.OpenedFile);
            }
            else
            {
                MessageBox.Show("Save your current file or open a an existing one before building it.");
            }
        }

        private void javaClassFileclassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globals.OpenedFile != null)
            {
                TerminalService.OpenProcessInNewTerminal("java.exe", "-showversion -cp " + FileManagerService.GetFilePath(Globals.OpenedFile) + " " + FileManagerService.GetFileNameNoExtension(Globals.OpenedFile));
            }
            else
            {
                MessageBox.Show("Save your current file or open a an existing one before building it.");
            }
        }

        private void toolStripSplitButton2_ButtonClick(object sender, EventArgs e)
        {
            MessageBox.Show("Select a building tool");
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            if (Globals.terminalOpened == true)
            {
                panel1.Hide();
                Globals.terminalOpened = false;
            }
            else
                TerminalService.OpenDefaultTerminal();
        }
    }

}
