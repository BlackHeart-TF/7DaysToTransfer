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
        public int index;
        public export()
        {
            InitializeComponent();
        }

        private void export_Load(object sender, EventArgs e)
        {
            FromLabel.Text = "From: " + Save.World + "/" + Save.GameName;
            listBox1.DataSource = Save.GetUserNames();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.DefaultExt = ".ttp";
            saveFileDialog1.Filter = "7Days Character | .ttp";
            saveFileDialog1.FileName = Save.Players[listBox1.SelectedIndex].ID + ".ttp";
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                textBox1.Text = saveFileDialog1.FileName;
        }

        private void ExportBtn_Click(object sender, EventArgs e)
        {
            path = textBox1.Text;
            index = listBox1.SelectedIndex;
            this.DialogResult = DialogResult.OK;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ExportBtn.Enabled = (listBox1.SelectedIndices.Count > 0 & textBox1.Text != "");
        }
    }
}
