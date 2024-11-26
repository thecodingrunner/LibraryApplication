using System.Text.Json;

namespace LibraryApplication
{
    public static class FileHandler
    {

        public const string Path = "./library.json";

        public static void WriteBooksToFile(List<Book> books)
        {
            string jsonString = JsonSerializer.Serialize(books);
            File.WriteAllText(Path, jsonString);
        }

    }
}
