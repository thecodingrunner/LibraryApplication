using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication
{
    internal class AddBookState : State
    {
        public AddBookState(Application application) : base(application)
        {
        }

        public override void Run()
        {
            try
            {
                Console.WriteLine("Please enter the book title");
                string title = Console.ReadLine();
                Console.WriteLine("Please enter the book description");
                string description = Console.ReadLine();
                Console.WriteLine("Please enter the book author");
                string author = Console.ReadLine();
                Console.WriteLine("Please enter the book publication date");
                DateOnly publicationDate = DateOnly.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the number of pages in the book");
                int pages = Int32.Parse(Console.ReadLine());
                _application.BookManager.AddBook(title, description, author, publicationDate, pages);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // loads of logic goes here
            _application.CurrentState = new MenuState(_application);
        }
    }
}
