using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace LibraryApplication
{
    internal class SearchBookState : State
    {
        public SearchBookState(Application application) : base(application)
        {
        }

        public override void Run()
        {
            Console.WriteLine("Welcome to the search page");
            Console.WriteLine("Select a method of searching:");
            Console.WriteLine("0 - Go back to main menu, 1 - Search by title, 2 - Search by author");
            string option = Console.ReadLine();
            switch (option)
            {
                case "0":
                    _application.CurrentState = new MenuState(_application);
                    break;
                case "1":
                    DisplayBooks(SearchByTitle());
                    break;
                case "2":
                    DisplayBooks(SearchByAuthor());
                    break;
            }
        }

        private List<Book> SearchByTitle()
        {
            Console.WriteLine("Please enter book title");
            string searchedTitle = Console.ReadLine();
            return _application.BookManager.SearchByTitle(searchedTitle);
        }

        private List<Book> SearchByAuthor()
        {
            Console.WriteLine("Please enter book author");
            string searchedAuthor = Console.ReadLine();
            return _application.BookManager.SearchByAuthor(searchedAuthor);
        }

        private void DisplayBooks(List<Book> books)
        {
            foreach (Book book in books)
            {
                Console.WriteLine($"\n\nTitle: {book.Title} \nDescription: {book.Description} \nAuthor: {book.Author} \nPublication Date: {book.PublicationDate.ToShortDateString()} \nPages: {book.Pages}\n\n");
            }
        }
    }
}
