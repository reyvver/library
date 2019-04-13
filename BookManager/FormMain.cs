using BookManager.Controllers;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace BookManager
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            Check();
        }

        private void button_AddNewBook(object sender, EventArgs e)
        {
            new FormAddition().ShowDialog();
        }

        private void button_OpenLibrary(object sender, EventArgs e)
        {
            new FormView().ShowDialog();
        }

        private void button_ExitApplication(object sender, EventArgs e)
        {
            if (Database.LibraryFilePath != "" && Database.LibraryFilePathSB != "")
            {
                // B O O K
                StreamWriter writer = new StreamWriter(Database.LibraryFilePath, false, Encoding.Default);
                writer.WriteLine(Database.Library.Count);

                foreach (Book this_book in Database.Library)
                {
                    this_book.WriteToFile(writer);
                }

                writer.Close();

                // S T U D E N T B O O K
                StreamWriter writer1 = new StreamWriter(Database.LibraryFilePathSB, false, Encoding.Default);
                writer1.WriteLine(Database.Studentbooks.Count);

                foreach (SBook this_book in Database.Studentbooks)
                {
                    this_book.WriteToFile(writer1);
                }

                writer1.Close();
            }
            Close();
        }

        private void buttonFilePathBooks_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Text files (*.txt;)|*.txt;|All files (*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Database.LibraryFilePath = @ofd.FileName;
                }
            }
            catch
            {
                MessageBox.Show("Некорректный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Check();
            }
        }

        private void buttonFilePathSbooks_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Text files (*.txt;)|*.txt;|All files (*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Database.LibraryFilePathSB = ofd.FileName;
                }

            }
            catch
            {
                MessageBox.Show("Некорректный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Check();
            }
        }

        public void Check()
        {
            if (Database.LibraryFilePath != "" && Database.LibraryFilePathSB != "")
            {
                // B O O K
                StreamReader reader = new StreamReader(Database.LibraryFilePath);
                int librarySize = Convert.ToInt32(reader.ReadLine());

                for (int i = 0; i < librarySize; i++)
                {
                    Book new_book = new Book("", "", "", "");
                    new_book.ExractFromFile(reader);
                }
                reader.Close();

                //  S T U D E N T B O O K
                StreamReader reader1 = new StreamReader(Database.LibraryFilePathSB);

                int studentsbookSize = Convert.ToInt32(reader1.ReadLine());
                
                for (int i = 0; i < studentsbookSize; i++)
                {
                    SBook new_studentbook = new SBook("", "", "", "", "" , "");
                    new_studentbook.ExractFromFile(reader1);
                }
                reader1.Close();

                button_AddBook.Enabled = true;
                buttonLibrary.Enabled = true;
            }
        }
    }
}