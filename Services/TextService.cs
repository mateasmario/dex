using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dex.Services
{
    internal class TextService
    {
        public static void AddClosingCharacter(string character)
        {
            RichTextBox codeBox = (RichTextBox)Globals.form.Controls["CodeBox"];

            string data = codeBox.Text;
            string oppositeCharacter = null;

            if (character == "(")
                oppositeCharacter = ")";
            else if (character == "[")
                oppositeCharacter = "]";
            else if (character == "{")
                oppositeCharacter = "}";
            else if (character == "\"")
                oppositeCharacter = "\"";
            else if (character == "'")
                oppositeCharacter = "'";
           
            int selectionStart = codeBox.SelectionStart;
            codeBox.Text = data.Substring(0, codeBox.SelectionStart) + character + oppositeCharacter + data.Substring(codeBox.SelectionStart);
            codeBox.SelectionStart = selectionStart + 1;

            Globals.openParanthesis.Add(character);
        }
    }
}
