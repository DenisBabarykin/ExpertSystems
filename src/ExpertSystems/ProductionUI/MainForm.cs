using IO;
using LogicSystem;
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
        public string RulesFileName { get; set; }

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
                    RulesFileName = openFileDialog.FileName;
                    txtbxRules.Text = File.ReadAllText(RulesFileName);
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
                var engine = new ProductionInferenceEngine(ProductionRulesConverter.ConvertToRules(txtbxRules.Text));
                var result = engine.ExecuteForwardChaining(txtbxFact.Text, txtbxGoal.Text);
                if (result.HasSolution)
                    txtbxSolution.Text = ProductionRulesConverter.ConvertForwardRulesToText(result.Explanation);
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
                if (rbProduction.Checked)
                {
                    var engine = new ProductionInferenceEngine(ProductionRulesConverter.ConvertToRules(txtbxRules.Text));
                    var result = engine.ExecuteBackwardChaining(txtbxFact.Text, txtbxGoal.Text);
                    if (result.HasSolution)
                        txtbxSolution.Text = ProductionRulesConverter.ConvertBackwardRulesToText(result.Explanation);
                    else
                        txtbxSolution.Text = "Нет решений";
                }
                else if (rbLogic.Checked)
                {
                    var engine = new LogicInferenceEngine(LogicRulesLoader.LoadFromFile(txtbxRules.Text));
                    var rule = LogicRulesLoader.ParseRule(txtbxGoal.Text); 
                    var result = engine.ExecuteBackwardChaining(rule);
                    if (result.HasSolution)
                    {
                        txtbxSolution.Text = LogicRulesConverter.ConvertToString(result.Explanation);
                    }
                    else
                        txtbxSolution.Text = "Доказываемое утверждение неверно";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbLogic_CheckedChanged(object sender, EventArgs e)
        {
            btnForwardChaining.Visible = false;
            lblFact.Visible = false;
            txtbxFact.Visible = false;
            txtbxRules.Text = String.Empty;
            txtbxSolution.Text = String.Empty;
            txtbxFact.Text = String.Empty;
            txtbxGoal.Text = String.Empty;
        }

        private void rbProduction_CheckedChanged(object sender, EventArgs e)
        {
            btnForwardChaining.Visible = true;
            lblFact.Visible = true;
            txtbxFact.Visible = true;
            txtbxRules.Text = String.Empty;
            txtbxSolution.Text = String.Empty;
            txtbxFact.Text = String.Empty;
            txtbxGoal.Text = String.Empty;
        }
    }
}
