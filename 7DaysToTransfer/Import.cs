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
    public partial class Import : Form
    {
        public Import()
        {
            InitializeComponent();
        }
        public WorldSaveItem Save;
        public CharacterSave ImportTo;
        public string path;
        private void button1_Click(object sender, EventArgs e)
        {
            var selected = (CharacterSave)dataGridView1.CurrentRow.DataBoundItem;
            openFileDialog1.AddExtension = true;
            openFileDialog1.DefaultExt = ".ttp";
            if (dataGridView1.SelectedRows.Count == 1)
                openFileDialog1.FileName = selected.ID + ".ttp";
            else
                openFileDialog1.FileName = "PlayerID.ttp";
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog1.Filter = "7Days Character | *.ttp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                textBox1.Text = openFileDialog1.FileName;
        }

        private void Import_Load(object sender, EventArgs e)
        {
            ToLabel.Text = "To: " + Save.World + "/" + Save.GameName;
            foreach (var player in Save.Players)
                characterSaveBindingSource.Add(player);
        }

        private void ImportBtn_Click(object sender, EventArgs e)
        {
            ImportTo = (CharacterSave)dataGridView1.CurrentRow.DataBoundItem;
            path = textBox1.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ImportBtn.Enabled = (dataGridView1.SelectedRows.Count > 0 & textBox1.Text != "");
        }
    }
}
