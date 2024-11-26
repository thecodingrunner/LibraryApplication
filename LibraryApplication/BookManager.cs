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

        public void EditBook<T>(int bookId, string field, T value)
        {
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
                bookInfo.Add($"Title: {book.Title} Description: {book.Description} Author: {book.Author} Publication Date: {book.PublicationDate.ToShortDateString()} Pages: {book.Pages}");
            }
            return bookInfo;
        }
    }
}
