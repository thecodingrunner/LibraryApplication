using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication
{
    public class BookManager
    {
        public List<Book> books = new List<Book>();


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
                    book.Pages = Int32.Parse(value);
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
                bookInfo.Add($"\n\nTitle: {book.Title} \nDescription: {book.Description} \nAuthor: {book.Author} \nPublication Date: {book.PublicationDate.ToShortDateString()} \nPages: {book.Pages}\n\n");
            }
            return bookInfo;
        }
    }
}
