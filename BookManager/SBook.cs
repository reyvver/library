using System.Collections;
using System.Collections.Generic;
using System.IO;
using BookManager.Controllers;


namespace BookManager
{
    public class SBook : Book, ILibraryController
    {
        public string CoAthor, Kategory;

        public SBook(string title, string author,string pages, string publisher, string coathors, string sphere) : base (title, author, pages, publisher)
        {
            CoAthor = coathors;
            Kategory = sphere;
        }

        public IList GetStudentBookInfo() 
        {
            return new List<string> { title, author, publisher, pages.ToString(), CoAthor, Kategory };
        }

        public new string PathFile
        {
            get
            {
                return Database.LibraryFilePathSB;
            }
        }


        public new void ExractFromFile(StreamReader reader)
        {
            title = reader.ReadLine();
            author = reader.ReadLine();
            int.TryParse(reader.ReadLine(), out pages);
            publisher = reader.ReadLine();
            CoAthor = reader.ReadLine();
            Kategory = reader.ReadLine();

            reader.ReadLine();

            Database.Studentbooks.Add(this);
        }

        public new void WriteToFile(StreamWriter writer)
        {
            writer.WriteLine(title);
            writer.WriteLine(author);
            writer.WriteLine(pages);
            writer.WriteLine(publisher);
            writer.WriteLine(CoAthor);
            writer.WriteLine(publisher);

            writer.WriteLine();
        }

        public new void RemoveBook()
        {
            Database.Studentbooks.Remove(this);
        }
    }
}
