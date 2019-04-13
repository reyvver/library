using System.IO;

namespace BookManager
{
    interface ILibraryController
    {
        string PathFile { get; }
        void ExractFromFile(StreamReader reader);
        void WriteToFile(StreamWriter writer);
        void ChangeAttribute(string attribute);
        void RemoveBook();
    }
}
