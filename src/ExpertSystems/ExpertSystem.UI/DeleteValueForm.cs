using System;
using System.Windows.Forms;

namespace Forms
{
    public partial class DeleteValueForm : Form
    {
        public DeleteValueForm(string[] values)
        {
            InitializeComponent();
            comboBox1.Items.AddRange(values);
        }

        public delegate void DeleteItemDelegate(string value);

        public event DeleteItemDelegate OnDeleteItem;

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var closeWindow = true;
            if (string.IsNullOrEmpty(comboBox1.SelectedItem.ToString()))
            {
                MessageBox.Show("Выберите элемент для удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                closeWindow = false;
            }

            if (OnDeleteItem != null)
                OnDeleteItem(comboBox1.SelectedItem.ToString());

            if(closeWindow)
                Close();
        }
    }
}
