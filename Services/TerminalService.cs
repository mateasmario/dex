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
            Panel Terminalpanel = (Panel)Globals.form.Controls["Terminalpanel"];

            Terminalpanel.Controls.Remove(Globals.Terminal);
            TerminalService.NewTerminal();

            Globals.Terminal.StartProcess(process, args);
            Globals.terminalStarted = true;

            Terminalpanel.Show();
            Globals.terminalOpened = true;
            Globals.Terminal.Focus();
        }

        public static void OpenDefaultTerminal()
        {
            Panel Terminalpanel = (Panel)Globals.form.Controls["Terminalpanel"];

            if (Globals.terminalStarted == false)
            {
                Terminalpanel.Controls.Remove(Globals.Terminal);
                TerminalService.NewTerminal();

                Globals.Terminal.StartProcess(Globals.ChosenProcess, "");
                Globals.terminalStarted = true;
            }

            Terminalpanel.Show();
            Globals.terminalOpened = true;
            Globals.Terminal.Focus();
        }

        public static void NewTerminal()
        {
            Panel Terminalpanel = (Panel)Globals.form.Controls["Terminalpanel"];

            ConsoleControl.ConsoleControl Terminal = new ConsoleControl.ConsoleControl();
            Globals.Terminal = Terminal;
            Terminal.Parent = Terminalpanel;
            Terminal.Dock = DockStyle.Fill;
            Terminal.IsInputEnabled = true;
            Terminal.InternalRichTextBox.BorderStyle = BorderStyle.None;
            Terminal.BackColor = Globals.terminalColor;
        }
    }
}
