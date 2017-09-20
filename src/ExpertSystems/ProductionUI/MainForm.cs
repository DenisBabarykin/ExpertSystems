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

namespace ProductionUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            openFileDialog.InitialDirectory = Environment.CurrentDirectory;
        }

        private void OpenRulesFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtbxRules.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void btnForwardChaining_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
