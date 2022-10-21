using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dex.Services
{
    internal class TerminalService
    {
        public static void OpenProcessInNewTerminal(string process, string args)
        {
            Panel panel1 = (Panel)Globals.form.Controls["panel1"];

            panel1.Controls.Remove(Globals.Terminal);
            TerminalService.NewTerminal();

            Globals.Terminal.StartProcess(process, args);
            Globals.terminalStarted = true;

            panel1.Show();
            Globals.terminalOpened = true;
            Globals.Terminal.Focus();
        }

        public static void OpenDefaultTerminal()
        {
            Panel panel1 = (Panel)Globals.form.Controls["panel1"];

            if (Globals.terminalStarted == false)
            {
                panel1.Controls.Remove(Globals.Terminal);
                TerminalService.NewTerminal();

                Globals.Terminal.StartProcess(Globals.ChosenProcess, "");
                Globals.terminalStarted = true;
            }

            panel1.Show();
            Globals.terminalOpened = true;
            Globals.Terminal.Focus();
        }

        public static void NewTerminal()
        {
            Panel panel1 = (Panel)Globals.form.Controls["panel1"];

            ConsoleControl.ConsoleControl Terminal = new ConsoleControl.ConsoleControl();
            Globals.Terminal = Terminal;
            Terminal.Parent = panel1;
            Terminal.Dock = DockStyle.Fill;
            Terminal.IsInputEnabled = true;
            Terminal.InternalRichTextBox.BorderStyle = BorderStyle.None;
            Terminal.BackColor = Globals.terminalColor;
        }
    }
}
