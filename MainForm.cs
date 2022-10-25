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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Globals.form = this;
            Globals.filePanelOpened = false;
            Globals.themePanelOpened = false;
            Globals.terminalOpened = false;
            Globals.terminalStarted = false;
            Globals.findReplaceOpened = false;

            Globals.searched = false;

            Themepanel.Hide();
            Filepanel.Hide();
            Terminalpanel.Hide();
            FindReplacePanel.Hide();
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
                FileManagerService.save(Globals.OpenedFile, CodeBox.Text, Filelist);
            else
                FileManagerService.saveAs(CodeBox.Text, Filelist);
        }

        private void SaveAs(object sender, EventArgs e)
        {
            FileManagerService.saveAs(CodeBox.Text, Filelist);
        }

        private void Global_KeyDown(object sender, KeyEventArgs e)
        {
            // save item
            if (e.KeyCode == Keys.S && e.Modifiers == Keys.Control)
                Save(sender, e);

            // undo code
            else if (e.KeyCode == Keys.Z && e.Modifiers == Keys.Control)
                CodeBox.Undo();

            // redo code
            else if (e.KeyCode == Keys.Y && e.Modifiers == Keys.Control)
                CodeBox.Redo();

            // duplicate line
            else if (e.KeyCode == Keys.D && e.Modifiers == Keys.Control)
            {
                string data = CodeBox.Text;
                int selectionStart = CodeBox.SelectionStart;

                int leftBound = -1, rightBound = -1;
                for (leftBound = CodeBox.SelectionStart; leftBound != 0 && data[leftBound - 1] != '\n'; leftBound--) ;
                for (rightBound = CodeBox.SelectionStart; rightBound != CodeBox.Text.Length && data[rightBound] != '\n' && data[rightBound] != '\0'; rightBound++) ;

                // duplicate slides
                CodeBox.Text = data.Substring(0, rightBound) + "\n" + data.Substring(leftBound, rightBound - leftBound) + data.Substring(rightBound);

                // move back to the previous selection
                CodeBox.SelectionStart = selectionStart;
            }

            // copy selected line
            else if (e.KeyCode == Keys.C && e.Modifiers == Keys.Control)
            {
                string data = CodeBox.Text;
                int selectionStart = CodeBox.SelectionStart;

                int leftBound = -1, rightBound = -1;
                for (leftBound = CodeBox.SelectionStart; leftBound != 0 && data[leftBound - 1] != '\n'; leftBound--) ;
                for (rightBound = CodeBox.SelectionStart; rightBound != CodeBox.Text.Length && data[rightBound] != '\n' && data[rightBound] != '\0'; rightBound++) ;

                // copy selected line into clipboard
                if (leftBound != rightBound)
                    System.Windows.Forms.Clipboard.SetText(data.Substring(leftBound, rightBound - leftBound));
            }

            // cut selected line
            else if (e.KeyCode == Keys.X && e.Modifiers == Keys.Control)
            {
                string data = CodeBox.Text;
                int selectionStart = CodeBox.SelectionStart;

                int leftBound = -1, rightBound = -1;
                for (leftBound = CodeBox.SelectionStart; leftBound != 0 && data[leftBound - 1] != '\n'; leftBound--) ;
                for (rightBound = CodeBox.SelectionStart; rightBound != CodeBox.Text.Length && data[rightBound] != '\n' && data[rightBound] != '\0'; rightBound++) ;

                // copy selected line into clipboard
                if (leftBound != rightBound)
                    System.Windows.Forms.Clipboard.SetText(data.Substring(leftBound, rightBound - leftBound));

                // cut selected line
                int updatedLb = leftBound - 1;
                if (leftBound == 0) updatedLb = leftBound;
                CodeBox.Text = data.Substring(0, updatedLb) + data.Substring(rightBound);

                // move back to the previous selection
                CodeBox.SelectionStart = leftBound;
            }

            // open/close file panel
            else if (e.KeyCode == Keys.Q && e.Modifiers == Keys.Control)
            {
                if (Globals.filePanelOpened == true)
                {
                    Filepanel.Hide();
                    Globals.filePanelOpened = false;
                }
                else
                {
                    Filepanel.Show();
                    Globals.filePanelOpened = true;
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

            // open/close find/replace panel
            else if (e.KeyCode == Keys.F && e.Modifiers == Keys.Control)
            {
                if (Globals.findReplaceOpened == true)
                {
                    FindReplacePanel.Hide();
                    Globals.findReplaceOpened = false;
                    CodeBox.Focus();
                    Globals.searched = false;
                }
                else
                {
                    FindReplacePanel.Show();
                    Globals.findReplaceOpened = true;
                    FindTextBox.Focus();
                }
            }

            // find/replace if textbox selected
            else if (sender is TextBox && e.KeyCode == Keys.Enter)
            {
                FindInCodeBox();
            }

            // find further
            else if (sender is RichTextBox && e.KeyCode == Keys.Enter)
            {
                if (Globals.searched)
                {
                    e.Handled = true;
                    FindInCodeBox();
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileManagerService.open(Filelist);
        }

        private void CodeBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            String keyChar = e.KeyChar.ToString();

            if (
                (Globals.openParanthesis.Count > 0) && (CodeBox.Text.Length >= CodeBox.SelectionStart + 1) && (
                e.KeyChar == ')' && Globals.openParanthesis.Last() == "(" && CodeBox.Text[CodeBox.SelectionStart] == ')'
                || e.KeyChar == ']' && Globals.openParanthesis.Last() == "[" && CodeBox.Text[CodeBox.SelectionStart] == ']'
                || e.KeyChar == '}' && Globals.openParanthesis.Last() == "{" && CodeBox.Text[CodeBox.SelectionStart] == '}'
                || e.KeyChar == '"' && Globals.openParanthesis.Last() == "\"" && CodeBox.Text[CodeBox.SelectionStart] == '"'
                || e.KeyChar == '\'' && Globals.openParanthesis.Last() == "'" && CodeBox.Text[CodeBox.SelectionStart] == '\''))
            {
                e.Handled = true;
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
            if (Themelist.SelectedItems.Count == 1)
                ThemeService.ChangeTheme(Themelist, Themelabel, Globals.Terminal, Filelist);
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
            FileManagerService.NewFile(Filelist);
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
                TerminalService.OpenProcessInNewTerminal("javac.exe", "--version " + Globals.OpenedFile);
            else
                MessageBox.Show("Save your current file or open an existing one before building it.", "Dex Editor");
        }

        private void javaClassFileclassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globals.OpenedFile != null)
                TerminalService.OpenProcessInNewTerminal("java.exe", "-showversion -cp " + FileManagerService.GetFilePath(Globals.OpenedFile) + " " + FileManagerService.GetFileNameNoExtension(Globals.OpenedFile));
            else
                MessageBox.Show("Save your current file or open an existing one before building it.", "Dex Editor");
        }

        private void toolStripSplitButton2_ButtonClick(object sender, EventArgs e)
        {
            MessageBox.Show("Select one of the options from the dropdown.", "Dex Editor");
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            if (Globals.terminalOpened == true)
            {
                Terminalpanel.Hide();
                Globals.terminalOpened = false;
            }
            else
                TerminalService.OpenDefaultTerminal();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.StartPosition = FormStartPosition.CenterParent;
            aboutForm.ShowDialog();
        }

        private void pythonScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globals.OpenedFile != null)
                TerminalService.OpenProcessInNewTerminal("python", Globals.OpenedFile);
            else
                MessageBox.Show("Save your current file or open an existing one before building it.", "Dex Editor");
        }

        private void perlScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globals.OpenedFile != null)
                TerminalService.OpenProcessInNewTerminal("perl", Globals.OpenedFile);
            else
                MessageBox.Show("Save your current file or open an existing one before building it.", "Dex Editor");
        }

        private void toolStripSplitButton3_ButtonClick(object sender, EventArgs e)
        {
            MessageBox.Show("Select one of the options from the dropdown.", "Dex Editor");
        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globals.findReplaceOpened = true;
            FindReplacePanel.Show();
            FindTextBox.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Globals.findReplaceOpened = false;
            FindReplacePanel.Hide();
            CodeBox.Focus();
            Globals.searched = false;
        }

        public void FindInCodeBox()
        {
            if (ReplaceTextBox.Text == "")
            {
                string data = FindTextBox.Text;
                int location = CodeBox.Find(data, CodeBox.SelectionStart + CodeBox.SelectionLength, RichTextBoxFinds.None);

                if (location >= 0)
                {
                    CodeBox.Focus();
                    CodeBox.SelectionStart = location;
                    CodeBox.SelectionLength = data.Length;
                }

                Globals.searched = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FindInCodeBox();
        }

        private void CodeBox_SelectionChanged(object sender, EventArgs e)
        {
            Globals.searched = false;
        }
    }

}
