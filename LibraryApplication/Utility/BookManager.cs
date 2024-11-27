using LibraryApplication.Data;

namespace LibraryApplication.Utility
{
    public class BookManager
    {
        private List<Book> _books;

        private IFileHandler _fileHandler { get; set; } 

        public BookManager(IFileHandler fileHandler)
        {
            _fileHandler = fileHandler;
            _books = _fileHandler.ReadBooksFromFile();
        }

        public void AddBook(string title, string description, string author, DateOnly publicationDate, int pages)
        {
            Book book = new Book(title, description, author, publicationDate, pages);
            _books.Add(book);
        }

        public void DeleteBook(int bookId)
        {
            Book book = _books.Find(book => book.BookId == bookId);
            if (book != null)
            {
                _books.Remove(book);
            }
        }

        public void EditBook(int bookId, string field, string value)
        {
            Book book = _books.Find(book => book.BookId == bookId);

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
        public List<string> GetAllBookInfo()
        {
            List<string> bookInfo = new List<string>();
            foreach (Book book in _books)
            {
                bookInfo.Add(book.ToString());
            }
            return bookInfo;
        }

        public void SaveBooks()
        {
            _fileHandler.WriteBooksToFile(_books);
        }

        public List<string> SearchByAuthor(string author)
        {
            return _books
                .Where(book => book.Author == author)
                .Select(book => book.ToString())
                .ToList();
        }

        public List<string> SearchByDescription(string? descriptionQuery)
        {
            return _books
                .Where(book => book.Description.ToLower().Contains(descriptionQuery.ToLower()))
                .Select(book => book.ToString())
                .ToList();
        }

        public List<string> SearchByTitle(string title)
        {
            return _books
                .Where(book => book.Title == title)
                .Select(book => book.ToString())
                .ToList();
        }
    }
}
