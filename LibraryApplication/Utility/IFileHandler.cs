using LibraryApplication.Data;

namespace LibraryApplication.Utility
{
    public interface IFileHandler
    {
        string Path { get; }

        List<Book> ReadBooksFromFile();
        void WriteBooksToFile(List<Book> books);
    }
}