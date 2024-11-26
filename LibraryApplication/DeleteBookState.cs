using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication
{
    internal class DeleteBookState : State
    {
        public DeleteBookState(Application application) : base(application)
        {
        }

        public override void Run()
        {
            Console.WriteLine("Please input the book id of the book you would like to delete");

            try
            {
                int bookId = Int32.Parse(Console.ReadLine());
                _application.BookManager.DeleteBook(bookId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            _application.CurrentState = new MenuState(_application);
        }
    }
}
