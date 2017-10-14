using System;
using System.Windows.Forms;
using FuzzyLogic.Mamdani;

namespace Forms
{
    public partial class EditVariableValueForm : Form
    {
        private bool _closeWindow;
        public EditVariableValueForm()
        {
            InitializeComponent();
            pictureBox1.Image = Resources.TrapFuncDescription;
        }

        public EditVariableValueForm(Term term)
            : this()
        {
            this.Text = "Редактирование значение переменной";
            this.name.Text = term.Name;
            this.name.Enabled = false;

            var trap = term.AccessoryFunc as TrapFunc;
            if (trap == null)
                return;

            this.a.Text = trap.A.ToString();
            this.b.Text = trap.B.ToString();
            this.c.Text = trap.C.ToString();
            this.d.Text = trap.D.ToString();
        }

        public delegate bool SaveVariableValueDelegate(string name, double a, double b, double c, double d);

        public event SaveVariableValueDelegate OnSaveVariableValue;

        private void saveButton_Click(object sender, EventArgs e)
        {
            _closeWindow = true;

            if (GetDoubleValue(a) > GetDoubleValue(b) || GetDoubleValue(b) > GetDoubleValue(c) ||
                GetDoubleValue(c) > GetDoubleValue(d))
            {
                MessageBox.Show(
                    "Должно выполняться условие a <= b <= c <= d. Измените значения в соответствии с условием", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (OnSaveVariableValue != null)
            {
                try
                {
                    var result = OnSaveVariableValue(name.Text, GetDoubleValue(a), GetDoubleValue(b), GetDoubleValue(c), GetDoubleValue(d));
                    if (!result)
                    {
                        MessageBox.Show("Такое текстовое значение уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        _closeWindow = false;
                    }
                }
                catch (ArgumentException exc)
                {
                    MessageBox.Show(exc.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _closeWindow = false;
                }
            }

            if (_closeWindow)
                this.Close();
        }

        private double GetDoubleValue(TextBox textBox)
        {
            var text = textBox.Text;
            double value;
            if (!double.TryParse(text.Replace(".", ","), out value))
            {
                _closeWindow = false;
                throw new ArgumentException($"Не корректное значение в поле {textBox.Name}");
            }
            return value;
        }
    }
}
