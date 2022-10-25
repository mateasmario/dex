using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dex.Services
{
    internal class ThemeService
    {
        public static void ChangeTheme(ListView Themelist, Label Themelabel, ConsoleControl.ConsoleControl terminal, TreeView Filelist)
        {
            //ListView Themelist = (ListView)Globals.form.Controls["Themelist"];
            Panel Filepanel = (Panel)Globals.form.Controls["Filepanel"];
            RichTextBox CodeBox = (RichTextBox)Globals.form.Controls["CodeBox"];
            MenuStrip menuStrip1 = (MenuStrip)Globals.form.Controls["menuStrip1"];
            StatusStrip statusStrip1 = (StatusStrip)Globals.form.Controls["statusStrip1"];
            Panel Themepanel = (Panel)Globals.form.Controls["Themepanel"];
            //Label Themelabel = (Label)Globals.form.Controls["Themelabel"];
            //ConsoleControl.ConsoleControl terminal = (ConsoleControl.ConsoleControl)Globals.form.Controls["Terminal"];

            switch (Themelist.SelectedItems[0].Text)
            {
                case "Flat White":
                    Globals.baseBackColor = SystemColors.InactiveBorder;
                    Globals.baseForeColor = SystemColors.WindowText;
                    Globals.codeBoxBackColor = SystemColors.Window;
                    Globals.codeBoxForeColor = SystemColors.WindowText;
                    Globals.codeBoxFont = new Font("Cascadia Code", 10, FontStyle.Regular);
                    Globals.terminalColor = Color.Black;
                    break;
                case "Flat White + Red":
                    Globals.baseBackColor = SystemColors.InactiveBorder;
                    Globals.baseForeColor = SystemColors.WindowText;
                    Globals.codeBoxBackColor = SystemColors.Window;
                    Globals.codeBoxForeColor = Color.FromArgb(175, 0, 0);
                    Globals.codeBoxFont = new Font("Cascadia Code", 10, FontStyle.Regular);
                    Globals.terminalColor = Color.Black;
                    break;
                case "Deep Dark":
                    Globals.baseBackColor = Color.FromArgb(30, 30, 30);
                    Globals.baseForeColor = Color.White;
                    Globals.codeBoxBackColor = Color.FromArgb(35, 35, 35);
                    Globals.codeBoxForeColor = Color.White;
                    Globals.codeBoxFont = new Font("Cascadia Mono", 10, FontStyle.Regular);
                    Globals.terminalColor = Color.FromArgb(30, 30, 30);
                    break;
                case "Vim Blue":
                    Globals.baseBackColor = Color.FromArgb(0, 0, 150);
                    Globals.baseForeColor = Color.White;
                    Globals.codeBoxBackColor = Color.FromArgb(0, 0, 175);
                    Globals.codeBoxForeColor = Color.White;
                    Globals.codeBoxFont = new Font("Cascadia Mono", 10, FontStyle.Regular);
                    Globals.terminalColor = Color.FromArgb(0, 0, 150);
                    break;
                case "Vim Blue + Yellow":
                    Globals.baseBackColor = Color.FromArgb(0, 0, 150);
                    Globals.baseForeColor = Color.White;
                    Globals.codeBoxBackColor = Color.FromArgb(0, 0, 175);
                    Globals.codeBoxForeColor = Color.FromArgb(250, 250, 0);
                    Globals.codeBoxFont = new Font("Cascadia Mono", 10, FontStyle.Regular);
                    Globals.terminalColor = Color.FromArgb(0, 0, 150);
                    break;
                case "Crimson Red":
                    Globals.baseBackColor = Color.FromArgb(150, 0, 50);
                    Globals.baseForeColor = Color.White;
                    Globals.codeBoxBackColor = Color.Crimson;
                    Globals.codeBoxForeColor = Color.White;
                    Globals.codeBoxFont = new Font("Cascadia Mono", 10, FontStyle.Regular);
                    Globals.terminalColor = Color.FromArgb(150, 0, 50);
                    break;
                default:
                    MessageBox.Show(Themelist.SelectedItems[0].Text);
                    break;
            }

            Filepanel.BackColor = Globals.baseBackColor;
            Filepanel.ForeColor = Globals.baseForeColor;
            Filelist.BackColor = Globals.baseBackColor;
            Filelist.ForeColor = Globals.baseForeColor;
            Themelist.BackColor = Globals.baseBackColor;
            Themelist.ForeColor = Globals.baseForeColor;
            Themepanel.BackColor = Globals.baseBackColor;
            Themelabel.ForeColor = Globals.baseForeColor;
            CodeBox.BackColor = Globals.codeBoxBackColor;
            CodeBox.ForeColor = Globals.codeBoxForeColor;
            CodeBox.Font = Globals.codeBoxFont;
            terminal.BackColor = Globals.terminalColor;
        }
    }
}
