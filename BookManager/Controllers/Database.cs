using System.Collections.Generic;

namespace BookManager.Controllers
{
    public  class Database
    {
        /// <summary>
        /// Относительный путь до файла с книгами.
        /// </summary>
        public static string LibraryFilePath = @"";
               
        /// <summary>
        /// Список, который хранит все книги.
        /// </summary>
        public static readonly List<Book> Library = new List<Book>();


        /// <summary>
        /// Относительный путь до файла с учебниками.
        /// </summary>
        public static string LibraryFilePathSB = @"";
        public static readonly List<SBook> Studentbooks= new List<SBook>();
    }
}