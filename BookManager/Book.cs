using BookManager.Controllers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace BookManager
{
    public class Book : ILibraryController
    {
        public string author, title, publisher;
        public int pages;

        public Book(string title, string author, string pages, string publisher)
        {
            this.title = title;
            this.author = author;
            this.publisher = publisher;
            int.TryParse(pages, out this.pages);
        }

        public IList GetBookInfo()
        {
            return new List<string> { title, author, publisher, pages.ToString()};
        }

        public string PathFile
        {
            get
            {
                return Database.LibraryFilePath;
            }
        }

        public void ChangeAttribute(string attribute)
        {
            FormForChange ChangeTitle = new FormForChange();
            FormView View = new FormView();
            ChangeTitle.Owner = View;
            ChangeTitle.ShowDialog();
            if (attribute == "title")
            {
               title = ChangeTitle.result;
            }
            else
            {
                if (attribute == "author")
                {
                    author = ChangeTitle.result;
                }
                else
                {
                    publisher = ChangeTitle.result;
                }
            }
        }

        public void ExractFromFile(StreamReader reader)
        {
            title = reader.ReadLine();
            author = reader.ReadLine();
            pages = Convert.ToInt32(reader.ReadLine());
            publisher = reader.ReadLine();

            reader.ReadLine();

            Database.Library.Add(this);
        }

        public void WriteToFile(StreamWriter writer)
        {
            writer.WriteLine(this.title);
            writer.WriteLine(this.author);
            writer.WriteLine(this.pages);
            writer.WriteLine(this.publisher);

            writer.WriteLine();
        }

        public void RemoveBook()
        {
            Database.Library.Remove(this);
        }
    }
}