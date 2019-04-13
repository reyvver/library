using System;
using System.Windows.Forms;
using BookManager.Controllers;

namespace BookManager
{
    public partial class FormView : Form
    {
        public FormView()
        {
            InitializeComponent();
        }
        /// Выводит библиотеку в ListView
        private void UpdateBooksInListView()
        {
            listViewBooks.Items.Clear();
            
            int i = 0, j = 0;

            foreach (Book book in Database.Library)
            {
                ListViewItem lvi = new ListViewItem(Convert.ToString(++i));

                foreach (string info in book.GetBookInfo())
                {
                    lvi.SubItems.Add(info);
                }

                listViewBooks.Items.Add(lvi);
            }

            listViewSBooks.Items.Clear();

            foreach (SBook student_book in Database.Studentbooks)
            {
                ListViewItem lvi = new ListViewItem(Convert.ToString(++j));

                foreach (string info in student_book.GetStudentBookInfo())
                {
                    lvi.SubItems.Add(info);
                }

                listViewSBooks.Items.Add(lvi);
            }

        }
        /// Событие, запускающееся после загрузки формы
        private void form_OnViewLoad(object sender, EventArgs e)
        {
            UpdateBooksInListView();
        }
        /// Обработчик кнопки, открывающей окно добавления книги
        private void button_AddNewBook(object sender, EventArgs e)
        {
            new FormAddition().ShowDialog();
        }
        /// Обработчик кнопки закрытия библиотеки
        private void button_CloseLibrary(object sender, EventArgs e)
        {
            Close();
        }
        /// Обработчик кнопки удаления книги из библиотеки
        private void button_DeleteBook(object sender, EventArgs e)
        {
            try
            {
                if (tabControl1.SelectedIndex == 0 && listViewBooks.SelectedItems != null)
                {
                    Database.Library[listViewBooks.SelectedIndices[0]].RemoveBook();
                }
                else 
                if (tabControl1.SelectedIndex == 1 && listViewSBooks.SelectedItems != null)
                {
                    Database.Studentbooks[listViewSBooks.SelectedIndices[0]].RemoveBook();
                }

                UpdateBooksInListView();
            }
            catch
            {
                MessageBox.Show(@"Выберите книгу!");
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            UpdateBooksInListView();
        }

        //Изменяется название книги
        private void buttonEditName_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabControl1.SelectedIndex == 0 && listViewBooks.SelectedItems != null)
                {
                    Database.Library[listViewBooks.SelectedIndices[0]].ChangeAttribute("title");
                }
                if (tabControl1.SelectedIndex == 1 && listViewSBooks.SelectedItems != null)
                {
                   Database.Studentbooks[listViewSBooks.SelectedIndices[0]].ChangeAttribute("title");
                }
            }
            catch
            {
                MessageBox.Show(@"Выберите книгу!");
            }
        }

        //Изменяется автор книги
        private void buttonEditAuthor_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabControl1.SelectedIndex == 0 && listViewBooks.SelectedItems != null)
                {
                    Database.Library[listViewBooks.SelectedIndices[0]].ChangeAttribute("author");
                }
                if (tabControl1.SelectedIndex == 1 && listViewSBooks.SelectedItems != null)
                {
                    Database.Studentbooks[listViewSBooks.SelectedIndices[0]].ChangeAttribute("author");
                }
            }
            catch
            {
                MessageBox.Show(@"Выберите книгу!");
            }
        }

        //Изменяется издательство книги
        private void buttonEditPublish_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabControl1.SelectedIndex == 0 && listViewBooks.SelectedItems != null)
                {
                    Database.Library[listViewBooks.SelectedIndices[0]].ChangeAttribute("publisher");
                }
                if (tabControl1.SelectedIndex == 1 && listViewSBooks.SelectedItems != null)
                {
                    Database.Studentbooks[listViewSBooks.SelectedIndices[0]].ChangeAttribute("publisher");
                }
            }
            catch
            {
                MessageBox.Show(@"Выберите книгу!");
            }
        }
    }
}