using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Dex.Services
{
    internal class ResourceManagerService
    {
        [DllImport("gdi32.dll")]
        static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);

        public static void InitializeFontCollection()
        {

            Globals.privateFontCollection = new PrivateFontCollection();

            int fontLength;
            byte[] fontdata;

            /* ShareTechMono */
            fontLength = Properties.Resources.ShareTechMono.Length;

            fontdata = Properties.Resources.ShareTechMono;

            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);

            Marshal.Copy(fontdata, 0, data, fontLength);

            Globals.privateFontCollection.AddMemoryFont(data, fontLength);
            /* End ShareTechMono */
        }
    }
}
