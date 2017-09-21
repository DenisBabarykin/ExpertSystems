using ProductionSystem;
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
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtbxRules.Text = File.ReadAllText(openFileDialog.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnForwardChaining_Click(object sender, EventArgs e)
        {
            try
            {
                var engine = new ProductionInferenceEngine(RulesConverter.ConvertToRules(txtbxRules.Text));
                var result = engine.ExecuteForwardChaining(txtbxFact.Text, txtbxGoal.Text);
                if (result.HasSolution)
                    txtbxSolution.Text = RulesConverter.ConvertForwardRulesToText(result.Explanation);
                else
                    txtbxSolution.Text = "Нет решений";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBackwardChaining_Click(object sender, EventArgs e)
        {
            try
            {
                var engine = new ProductionInferenceEngine(RulesConverter.ConvertToRules(txtbxRules.Text));
                var result = engine.ExecuteBackwardChaining(txtbxFact.Text, txtbxGoal.Text);
                if (result.HasSolution)
                    txtbxSolution.Text = RulesConverter.ConvertBackwardRulesToText(result.Explanation);
                else
                    txtbxSolution.Text = "Нет решений";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
