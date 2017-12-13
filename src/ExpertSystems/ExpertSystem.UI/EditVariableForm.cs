using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FuzzyLogic.Mamdani;

namespace Forms
{
    public partial class EditVariableForm : Form
    {
        private List<Term> _terms = new List<Term>();
        public EditVariableForm()
        {
            InitializeComponent();
        }

        public EditVariableForm(FuzzyVariable variable)
            : this()
        {
            this.Text = "Редактирование нечеткой переменной";
            this.variableName.Text = variable.Name;
            //this.variableName.Enabled = false;
            this.variableLingName.Text = variable.LingName;
            this.isResult.Checked = variable.IsResult;
            _terms = variable.Terms;
            RefreshFormListView();
        }

        private void RefreshFormListView()
        {
            var values = _terms.Select(x => x.ToStringArray());
            RefreshListView(listView1, values);
        }

        public void RefreshListView(ListView listView, IEnumerable<string[]> values)
        {
            var listViewItems = values.Select(x => new ListViewItem(x)).ToArray();
            listView.Items.Clear();
            listView.Items.AddRange(listViewItems);
        }



        private void addValue_Click(object sender, System.EventArgs e)
        {
            var addVariableValueForm = new EditVariableValueForm();
            addVariableValueForm.OnSaveVariableValue += (name, a, b, c, d) =>
            {
                if (_terms.Any(x => x.Name == name))
                    return false;
                _terms.Add(new Term(name, a, b, c, d));
                return true;
            };
            addVariableValueForm.ShowDialog();

            RefreshFormListView();
        }

        private void editValue_Click(object sender, System.EventArgs e)
        {
            var termViewItem = listView1.SelectedItems[0];
            var term = _terms[termViewItem.Index];
            var editVariableValueForm = new EditVariableValueForm(term);
            editVariableValueForm.OnSaveVariableValue += (name, a, b, c, d) =>
            {
                var trapFunc = term.AccessoryFunc as TrapFunc;
                if (trapFunc == null)
                    return false;

                if (trapFunc.A != a || trapFunc.B != b || trapFunc.C != c || trapFunc.D != d)
                {
                    term.AccessoryFunc = new TrapFunc(a, b, c, d);
                }
                return true;
            };

            editVariableValueForm.ShowDialog();

            RefreshFormListView();
        }

        private void deleteValue_Click(object sender, System.EventArgs e)
        {
            var values = _terms.Select(x => x.Name).ToArray();
            var deleteValueForm = new DeleteValueForm(values);
            deleteValueForm.OnDeleteItem += (name) =>
            {
                var value = _terms.FirstOrDefault(x => x.Name == name);
                if (value != null)
                    _terms.Remove(value);
            };
            deleteValueForm.ShowDialog();

            RefreshFormListView();
        }

        public delegate bool SaveVariableDelegate(string name, string lingName, bool isResult, List<Term> terms);

        public event SaveVariableDelegate OnSaveVariable;

        private void addVariable_Click(object sender, System.EventArgs e)
        {
            var closeWindow = true;
            if (string.IsNullOrEmpty(variableName.Text))
            {
                MessageBox.Show("Нужно задать имя переменной", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_terms.Count == 0)
            {
                MessageBox.Show("Нужно задать значения переменной", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var name = variableName.Text;
            if (OnSaveVariable != null)
            {
                var result = OnSaveVariable(name, variableLingName.Text, isResult.Checked, _terms);
                if (!result)
                {
                    closeWindow = false;
                }
            }

            if (closeWindow)
                Close();
        }
    }
}
