using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dex
{
    internal class Globals
    {
        // singletons
        public static Form form;
        public static PrivateFontCollection privateFontCollection;

        // file details
        public static string OpenedFile { get; set; }

        // terminal details
        public static string ChosenProcess { get; set; }
        public static ConsoleControl.ConsoleControl Terminal { get; set; }

        // design details
        public static bool sidePanelOpened { get; set; }
        public static bool themePanelOpened { get; set; }
        public static bool terminalOpened { get; set; }
        public static bool terminalStarted { get; set; }
        public static List<string> openParanthesis { get; set; }

        // for themes
        public static Color terminalColor { get; set; }
        public static Color codeBoxBackColor { get; set; }
        public static Color codeBoxForeColor { get; set; }
        public static Font codeBoxFont { get; set; }
        public static Color baseBackColor { get; set; }
        public static Color baseForeColor { get; set; }


    }
}
