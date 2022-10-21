using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Dex.Services
{
    internal class FileManagerService
    {
        public static void selectFile(String fileName)
        {
            TreeView Sidepanel = (TreeView)Globals.form.Controls["Sidepanel"];

            Globals.OpenedFile = fileName;
            Globals.form.Text = Globals.OpenedFile + " (Dex Editor)";

            UpdateFileInfo();
        }

        public static void UpdateFileInfo()
        {
            TreeView Sidepanel = (TreeView)Globals.form.Controls["Sidepanel"];

            FileInfo fi = new FileInfo(Globals.OpenedFile);

            Sidepanel.Nodes[0].Text = "Name: " + fi.Name;

            TreeNode tn;

            if (Sidepanel.Nodes.Count == 1)
            {
                for (int i = 0; i < 7; i++)
                {
                    tn = new TreeNode("");
                    Sidepanel.Nodes.Add(tn);
                }
            }

            Sidepanel.Nodes[1].Text = "Extension: " + fi.Extension;
            Sidepanel.Nodes[2].Text = "Attributes: " + fi.Attributes;
            Sidepanel.Nodes[3].Text = "Length: " + fi.Length + " bytes";
            Sidepanel.Nodes[4].Text = "Directory: " + fi.Directory;
            Sidepanel.Nodes[5].Text = "Read-Only: " + fi.IsReadOnly;
            Sidepanel.Nodes[6].Text = "Last Access: " + fi.LastAccessTime;
            Sidepanel.Nodes[7].Text = "Last Write: " + fi.LastWriteTime;
        }

        public static string GetFileNameNoExtension(string fileName)
        {
            int lastSlash = -1;
            int lastDot = -1;

            for (int i = 0; i < fileName.Length; i++)
            {
                if (fileName[i] == '\\')
                    lastSlash = i;
                if (fileName[i] == '.')
                    lastDot = i;
            }

            string result = fileName.Substring(lastSlash+1, lastDot-lastSlash-1);
            return result;
        }

        public static string GetFilePath(string fileName)
        {
            int lastSlash = -1;

            for (int i = 0; i < fileName.Length; i++)
            {
                if (fileName[i] == '\\')
                    lastSlash = i;
            }

            string result = fileName.Substring(0, lastSlash);
            return result;
        }

        public static void NewFile() {
            RichTextBox CodeBox = (RichTextBox)Globals.form.Controls["CodeBox"];
            TreeView Sidepanel = (TreeView)Globals.form.Controls["Sidepanel"];
            
            int count = Sidepanel.Nodes.Count;

            for (int i = 0; i<count; i++)
                Sidepanel.Nodes.RemoveAt(0);

            Globals.OpenedFile = null;

            TreeNode node = new TreeNode();
            node.Text = "No file opened";
            Sidepanel.Nodes.Add(node);

            Globals.form.Text = "Dex Editor";
            CodeBox.Text = "";
        }

        public static void open()
        {
            RichTextBox codeBox = (RichTextBox)Globals.form.Controls["CodeBox"];
            TreeView Sidepanel = (TreeView)Globals.form.Controls["Sidepanel"];

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string data = File.ReadAllText(openFileDialog.FileName);
                codeBox.Text = data;
                selectFile(openFileDialog.FileName);
            }
        }
        public static void save(string fileName, string text)
        {
            TreeView Sidepanel = (TreeView)Globals.form.Controls["Sidepanel"];

            File.WriteAllText(fileName, text);
            UpdateFileInfo();
        }

        public static void saveAs(string text, TreeView Sidepanel)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Save as";
            saveFileDialog1.Filter = "Text documents|*.txt|" +
                                     "All files|*.*";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                System.IO.FileStream fs =
                    (System.IO.FileStream)saveFileDialog1.OpenFile();

                byte[] data = new UTF8Encoding(true).GetBytes(text);
                fs.Write(data, 0, data.Length);
                fs.Close();

                selectFile(saveFileDialog1.FileName);
            }
        }

    }
}
