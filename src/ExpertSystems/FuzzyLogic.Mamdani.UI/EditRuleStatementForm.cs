using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FuzzyLogic.Mamdani;

namespace Forms
{
    public partial class EditRuleStatementForm : Form
    {
        private readonly List<FuzzyVariable> _variables;
        public EditRuleStatementForm(List<FuzzyVariable> variables)
        {
            _variables = variables;
            InitializeComponent();

            variablesCombo.Items.AddRange(_variables.Select(x => (object)x.Name).ToArray());
        }

        public delegate void AddStatementDelegate(string variableName, string termName);

        public event AddStatementDelegate OnAddStatement;

        private void addStatement_Click(object sender, System.EventArgs e)
        {
            var closeWindow = true;
            var variableName = variablesCombo.SelectedItem.ToString();
            var termName = termsCombo.SelectedItem.ToString();

            if (OnAddStatement != null)
            {
                if (!string.IsNullOrEmpty(variableName) && !string.IsNullOrEmpty(termName))
                {
                    OnAddStatement(variableName, termName);
                }
                else
                {
                    MessageBox.Show("Нужно выбрать переменную и значение для нее", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    closeWindow = false;
                }
            }

            if (closeWindow)
                Close();
        }

        private void variablesCombo_SelectedValueChanged(object sender, System.EventArgs e)
        {
            var variableName = variablesCombo.SelectedItem.ToString();
            var variable = _variables.FirstOrDefault(x => x.Name == variableName);

            termsCombo.Items.Clear();
            termsCombo.Items.AddRange(variable.Terms.Select(x => (object)x.Name).ToArray());
        }
    }
}
