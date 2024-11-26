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
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public DateOnly PublicationDate { get; set; }
        public int Pages { get; set; }
        public int BookId { get; set; }
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
