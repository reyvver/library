using System;
using System.Windows.Forms;

namespace BookManager
{
    public partial class FormForChange : Form
    {
        public string result;

        public FormForChange()
        {
            InitializeComponent();
            FormView Main = this.Owner as FormView;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text != "")
            {
                result = textBoxResult.Text;
                this.Close();
            }
            else
                MessageBox.Show("Введите значение аттрибута!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
