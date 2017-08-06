using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace GameOfLife
{
    public class UniformGridDisplay_ContextMenu : ContextMenu
    {
        public static int[,] clipboard;
        private UniformGridDisplay parent;
        public UniformGridDisplay_ContextMenu(UniformGridDisplay ParentControl)
        {
            this.MenuItems.Add("Copy to clipboard", new EventHandler(CopyToClipboardClick));
            this.MenuItems.Add("Import grid state...", new EventHandler(Import_Click));
            this.MenuItems.Add("Export grid state...", new EventHandler(Export_Click));
            this.MenuItems.Add("Clear grid state...", new EventHandler(Clear_ParentGrid));
            parent = ParentControl;
        }

        private void CopyToClipboardClick(object sender, EventArgs e)
        {
            clipboard = parent.GetGridState;
        }

        private void Clear_ParentGrid(object sender, EventArgs e)
        {
            parent.ClearGridState();
        }

        private void Export_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            DialogResult dlg = sfd.ShowDialog();
            if (dlg == DialogResult.OK)
            {
                string filePath = sfd.FileName;
                using (Stream stream = File.Open(filePath, FileMode.OpenOrCreate))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(stream, parent.GetGridState);
                }
            }
        }

        private void Import_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult dlg = ofd.ShowDialog();
            if (dlg == DialogResult.OK)
            {
                string filePath = ofd.FileName;
                using (Stream stream = File.Open(filePath, FileMode.Open))
                {
                    BinaryFormatter bformatter = new BinaryFormatter();
                    parent.UpdateGridState((int[,])bformatter.Deserialize(stream));
                }
            }
        }
    }
}
