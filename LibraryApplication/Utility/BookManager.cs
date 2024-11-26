using LibraryApplication.Data;

namespace LibraryApplication.Utility
{
    public class BookManager
    {
        public List<Book> books = FileHandler.ReadBooksFromFile();

        public void AddBook(string title, string description, string author, DateOnly publicationDate, int pages)
        {
            Book book = new Book(title, description, author, publicationDate, pages);

            books.Add(book);
        }

        public void EditBook(int bookId, string field, string value)
        {
            Book book = books.Find(book => book.BookId == bookId);

            switch (field)
            {
                case "1":
                    book.Title = value;
                    break;
                case "2":
                    book.Description = value;
                    break;
                case "3":
                    book.Author = value;
                    break;
                case "4":
                    book.PublicationDate = DateOnly.Parse(value);
                    break;
                case "5":
                    book.Pages = int.Parse(value);
                    break;
            }
        }

        public void DeleteBook(int bookId)
        {
            Book book = books.Find(book => book.BookId == bookId);
            if (book != null)
            {
                books.Remove(book);
            }
        }

        public List<string> GetAllBookInfo()
        {
            List<string> bookInfo = new List<string>();
            foreach (Book book in books)
            {
                bookInfo.Add(book.ToString());
            }
            return bookInfo;
        }

        public void SaveBooks()
        {
            FileHandler.WriteBooksToFile(books);
        }

        public List<string> SearchByTitle(string title)
        {
            return books
                .Where(book => book.Title == title)
                .Select(book => book.ToString())
                .ToList();
        }

        public List<string> SearchByAuthor(string author)
        {
            return books
                .Where(book => book.Author == author)
                .Select(book => book.ToString())
                .ToList();
        }

        public List<string> SearchByDescription(string? descriptionQuery)
        {
            return books
                .Where(book => book.Description.ToLower().Contains(descriptionQuery.ToLower()))
                .Select(book => book.ToString())
                .ToList();
        }
    }
}
