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
    public partial class Id_Select : Form
    {
        public Id_Select()
        {
            InitializeComponent();
        }
        public GameSaveItem FromSave;
        public GameSaveItem ToSave;
        public string fromPath;
        public string toPath;
        private void Id_Select_Load(object sender, EventArgs e)
        {
            FromLabel.Text = FromSave.World + "/" + FromSave.GameName;
            ToLabel.Text = ToSave.World + "/" + ToSave.GameName;
            FromlistBox.DataSource = FromSave.PlayerIDs;
            TolistBox.DataSource = ToSave.PlayerIDs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fromPath =FromSave.GetPath(FromlistBox.SelectedIndex);
            toPath = ToSave.GetPath(TolistBox.SelectedIndex);
            this.DialogResult = DialogResult.OK;
        }
    }
}
