using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication
{
    public class Book
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public string Author { get; private set; }
        public DateOnly PublicationDate { get; private set; }
        public int Pages { get; private set; }
        public int BookId { get; private set; }
        static int NumberOfBooks = 0;

        public Book(string title, string description, string author, DateOnly publicationDate, int pages)
        {
            Title = title;
            Description = description;
            Author = author;
            PublicationDate = publicationDate;
            Pages = pages;
            NumberOfBooks++;
            BookId = NumberOfBooks;
        }
    }
}
