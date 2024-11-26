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
    }
}
