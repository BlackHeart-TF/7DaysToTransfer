using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _7DllsToDie;

namespace _7DaysToTransfer
{
    public partial class export : Form
    {
        public WorldSaveItem Save;
        public string path;
        public CharacterSave index;
        public export()
        {
            InitializeComponent();
        }

        private void export_Load(object sender, EventArgs e)
        {
            FromLabel.Text = "From: " + Save.World + "/" + Save.GameName;
            foreach (var player in Save.Players)
                characterSaveBindingSource.Add(player);
        }

        private void browse_Click(object sender, EventArgs e)
        {
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.DefaultExt = ".ttp";
            saveFileDialog1.Filter = "7Days Character | .ttp";
            var save = (CharacterSave)dataGridView1.CurrentRow.DataBoundItem;
            saveFileDialog1.FileName = save.ID + ".ttp";
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                exporttextBox.Text = saveFileDialog1.FileName;
        }

        private void ExportBtn_Click(object sender, EventArgs e)
        {
            path = exporttextBox.Text;
            index = (CharacterSave)dataGridView1.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ExportBtn.Enabled = (dataGridView1.SelectedRows.Count > 0 & exporttextBox.Text != "");
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
