using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SmirnovIA.Sprint6.Task6.V13.Lib;

namespace Tyuiu.SmirnovIA.Sprint6.Task6.V13
{
    public partial class FormMain_SIA : Form
    {
        public FormMain_SIA()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();
        private void buttonOpenFile_SIA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_SIA.ShowDialog(this);
            openFilePath = openFileDialogTask_SIA.FileName;
            textBoxInput_SIA.Text = File.ReadAllText(openFilePath);
            groupBoxInput_SIA.Text = groupBoxInput_SIA.Text + " " + openFileDialogTask_SIA.FileName;
            buttonDone_SIA.Enabled = true;
        }

        private void buttonDone_SIA_Click(object sender, EventArgs e)
        {
            string str = "**";
            textBoxOutput_SIA.Text = ds.CollectTextFromFile(str, openFilePath);
        }

        private void buttonHelp_SIA_Click(object sender, EventArgs e)
        {
            FormAbout_SIA formAbout = new FormAbout_SIA();
            formAbout.ShowDialog();
        }
    }
}
