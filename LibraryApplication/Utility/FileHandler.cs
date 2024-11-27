using LibraryApplication.Data;
using System.Text.Json;

namespace LibraryApplication.Utility
{
    public class FileHandler : IFileHandler
    {

        // bad practice - eventually change this to be set outside this class
        // ideally would use some sort of configuration file
        public string Path { get; } = "./library.json";

        public List<Book> ReadBooksFromFile()
        {
            if (!File.Exists(Path))
            {
                return new List<Book>();
            }
            string fileContents = File.ReadAllText(Path);
            var json = JsonSerializer.Deserialize<List<Book>>(fileContents);
            return json;
        }

        public void WriteBooksToFile(List<Book> books)
        {
            string jsonString = JsonSerializer.Serialize(books);
            File.WriteAllText(Path, jsonString);
        }
    }
}
