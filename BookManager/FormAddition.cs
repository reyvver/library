using System;
using System.Windows.Forms;
using BookManager.Controllers;

namespace BookManager
{
    public partial class FormAddition : Form
    {
        public FormAddition()
        {
            InitializeComponent();
            TextClosed();
        }

        /// <summary>
        /// Обработчик нажатия кнопки закрытия
        /// </summary>
        private void button_CloseAdditionForm(object sender, EventArgs e)
        {
            Close();
        }

        //Делает невозможными для использования текстбоксы соавтора и направления, тк это только для учебников
        private void TextClosed()
        {
            textBoxCoAuthor.Enabled = false;
            textBoxSphere.Enabled = false;
        }

        //Чекбокс "Учебник"
        private void checkBoxStudybook_Click(object sender, EventArgs e)
        {
            checkBoxStudybook.Checked = true;
            checkBoxBook.Checked = false;

            textBoxCoAuthor.Enabled = true;
            textBoxSphere.Enabled = true;
        }

        //Чекбокс "Книга"
        private void checkBoxBook_Click(object sender, EventArgs e)
        {
            checkBoxStudybook.Checked = false;
            checkBoxBook.Checked = true;
            TextClosed();
        }

        //Создание новой книги
        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBoxBook.Checked == true)
                {
                    if (textboxTitle.Text != "" && textBoxAuthor.Text != "" && textBoxCount.Text != "" && textBoxPublishing.Text != "")
                    {
                        if (int.TryParse(textBoxCount.Text, out int check))
                        {

                            Book newBook = new Book(
                                      title: textboxTitle.Text,
                                      author: textBoxAuthor.Text,
                                      pages: textBoxCount.Text,
                                      publisher: textBoxPublishing.Text
                                      );
                            Database.Library.Add(newBook);

                            MessageBox.Show("Книга успешно добавлена!", "Добавление", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                            textboxTitle.Text = "";
                            textBoxAuthor.Text = "";
                            textBoxCount.Text = "";
                            textBoxPublishing.Text = "";
                        }
                        else throw new FormatException();
                    }
                }
                if (checkBoxStudybook.Checked == true)
                {
                    if (textboxTitle.Text != "" && textBoxAuthor.Text != "" && textBoxCount.Text != "" && textBoxPublishing.Text != "" && textBoxSphere.Text != "")
                    {
                        SBook newBook = new SBook(
                                      title: textboxTitle.Text,
                                      author: textBoxAuthor.Text,
                                      pages: textBoxCount.Text,
                                      publisher: textBoxPublishing.Text,
                                      coathors: textBoxCoAuthor.Text,
                                      sphere: textBoxSphere.Text
                                      );
                        Database.Studentbooks.Add(newBook);

                        MessageBox.Show("Учебник успешно добавлен!", "Добавление", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        textboxTitle.Text = "";
                        textBoxAuthor.Text = "";
                        textBoxCount.Text = "";
                        textBoxPublishing.Text = "";
                        textBoxCoAuthor.Text = "";
                        textBoxSphere.Text = "";
                    }
                    else throw new FormatException();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Количество страниц - не числовое значение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("Некорректные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}