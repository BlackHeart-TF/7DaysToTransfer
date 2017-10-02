using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _7DllsToDie;

namespace _7DaysToTransfer
{
    public partial class MainForm : Form
    {
        public static List<WorldSaveItem> Saves = new List<WorldSaveItem>();
        public MainForm()
        {
            SaveManager.PlatformUpdate();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            if (!Directory.Exists(SaveManager.SaveFolder))
            {
                MessageBox.Show("7 Days To Die saves not found.", "Save Not Found", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Application.Exit();
                Environment.Exit(1);
            }
            Saves = SaveManager.ScanSaves();
            foreach (var save in Saves)
            {
                LeftlistView.Items.Add(save.World).SubItems.Add(save.GameName);
                RightlistView.Items.Add(save.World).SubItems.Add(save.GameName);
            }
        }

        private void copyRight_Click(object sender, EventArgs e)
        {
            if (LeftlistView.SelectedIndices.Count > 0 & RightlistView.SelectedIndices.Count > 0)
            {
                var FromSave = Saves[LeftlistView.SelectedIndices[0]];
                var ToSave = Saves[RightlistView.SelectedIndices[0]];
                SelectID(FromSave, ToSave);
            }
        }
        private void copyLeft_Click(object sender, EventArgs e)
        {
            if (LeftlistView.SelectedIndices.Count > 0 & RightlistView.SelectedIndices.Count > 0)
            {
                var FromSave = Saves[RightlistView.SelectedIndices[0]];
                var ToSave = Saves[LeftlistView.SelectedIndices[0]];
                SelectID(FromSave, ToSave);
            }
        }

        private void SelectID(WorldSaveItem FromSave, WorldSaveItem ToSave)
        {
            var form = new Id_Select()
            {
                FromSave = FromSave,
                ToSave = ToSave
            };
            if (form.ShowDialog() == DialogResult.OK)
                SaveManager.CopySave(form.fromPath, form.toPath);
        }

        private void ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LeftlistView.SelectedIndices.Count > 0 & RightlistView.SelectedIndices.Count > 0)
            {
                copyLeft.Enabled = true;
                copyRight.Enabled = true;
            }
            else
            {
                copyLeft.Enabled = false;
                copyRight.Enabled = false;
            }

                ImportLeft.Enabled = ExportLeft.Enabled = (LeftlistView.SelectedIndices.Count > 0);
            ImportRight.Enabled = ExportRight.Enabled = (RightlistView.SelectedIndices.Count > 0);

        }

        private void Import_Click(object sender, EventArgs e)
        {
            var Sender = (Button)sender;
            WorldSaveItem Save;
            if (Sender.Name == "ImportLeft")
                Save = Saves[LeftlistView.SelectedIndices[0]];
            else
                Save = Saves[RightlistView.SelectedIndices[0]];
            var importForm = new Import()
            {
                Save = Save
            };
            if (importForm.ShowDialog() == DialogResult.OK) 
                SaveManager.ImportSave(importForm.path, importForm.ImportTo.Path);
        }
        private void Export_Click(object sender, EventArgs e)
        {
            var Sender = (Button)sender;
            WorldSaveItem Save;
            if (Sender.Name == "ExportLeft")
                Save = Saves[LeftlistView.SelectedIndices[0]];
            else
                Save = Saves[RightlistView.SelectedIndices[0]];
            var exportForm = new export()
            {
                Save = Save
            };
            if (exportForm.ShowDialog() == DialogResult.OK)
                SaveManager.ExportSave(exportForm.index.Path,exportForm.path);
        }

        private void mainPanel_Layout(object sender, LayoutEventArgs e)
        {
            rightPanel.Width = mainPanel.Width / 2;
        }
    }
}
