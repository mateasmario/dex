using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dex.Services
{
    internal class ObjectInitializerService
    {
        public static void InitializeGlobals()
        {
            Globals.openParanthesis = new List<string>();
            Globals.ChosenProcess = "powershell.exe";
            Globals.baseBackColor = SystemColors.InactiveBorder;
            Globals.baseForeColor = SystemColors.WindowText;
            Globals.codeBoxBackColor = SystemColors.Window;
            Globals.codeBoxForeColor = SystemColors.WindowText;
            Globals.codeBoxFont = new Font("Cascadia Code", 10, FontStyle.Regular);
            Globals.terminalColor = Color.Black;
        }
    }
}
