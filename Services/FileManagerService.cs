using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Dex.Services
{
    internal class FileManagerService
    {
        public static void selectFile(String fileName, TreeView Filelist)
        {
            Globals.OpenedFile = fileName;
            Globals.form.Text = Globals.OpenedFile + " (Dex Editor)";

            UpdateFileInfo(Filelist);
            System.Environment.CurrentDirectory = GetFileDirectory(Globals.OpenedFile);
        }

        public static void UpdateFileInfo(TreeView Filelist)
        {
            FileInfo fi = new FileInfo(Globals.OpenedFile);

            Filelist.Nodes[0].Text = "Name: " + fi.Name;

            TreeNode tn;

            if (Filelist.Nodes.Count == 1)
            {
                for (int i = 0; i < 7; i++)
                {
                    tn = new TreeNode("");
                    Filelist.Nodes.Add(tn);
                }
            }

            Filelist.Nodes[1].Text = "Extension: " + fi.Extension;
            Filelist.Nodes[2].Text = "Attributes: " + fi.Attributes;
            Filelist.Nodes[3].Text = "Length: " + fi.Length + " bytes";
            Filelist.Nodes[4].Text = "Directory: " + fi.Directory;
            Filelist.Nodes[5].Text = "Read-Only: " + fi.IsReadOnly;
            Filelist.Nodes[6].Text = "Last Access: " + fi.LastAccessTime;
            Filelist.Nodes[7].Text = "Last Write: " + fi.LastWriteTime;
        }

        public static string GetFileNameWithExtension(string fileName)
        {
            int lastSlash = -1;

            for (int i = 0; i < fileName.Length; i++)
            {
                if (fileName[i] == '\\')
                    lastSlash = i;
            }

            string result = fileName.Substring(lastSlash + 1);
            return result;
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

        public static string GetFileDirectory(string fileName)
        {
            int lastSlash = -1;

            for (int i = 0; i < fileName.Length; i++)
                if (fileName[i] == '\\')
                    lastSlash = i;

            string result = fileName.Substring(0, lastSlash+1);
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

        public static void NewFile(TreeView Filelist) {
            RichTextBox CodeBox = (RichTextBox)Globals.form.Controls["CodeBox"];
            
            int count = Filelist.Nodes.Count;

            for (int i = 0; i<count; i++)
                Filelist.Nodes.RemoveAt(0);

            Globals.OpenedFile = null;

            TreeNode node = new TreeNode();
            node.Text = "No file opened";
            Filelist.Nodes.Add(node);

            Globals.form.Text = "Dex Editor";
            CodeBox.Text = "";

            System.Environment.CurrentDirectory = @"C:\";
        }

        public static void open(TreeView Filelist)
        {
            RichTextBox codeBox = (RichTextBox)Globals.form.Controls["CodeBox"];

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string data = File.ReadAllText(openFileDialog.FileName);
                codeBox.Text = data;
                selectFile(openFileDialog.FileName, Filelist);
            }
        }
        public static void save(string fileName, string text, TreeView Filelist)
        {
            File.WriteAllText(fileName, text);
            UpdateFileInfo(Filelist);
        }

        public static void saveAs(string text, TreeView Filelist)
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

                selectFile(saveFileDialog1.FileName, Filelist);
            }
        }

    }
}
