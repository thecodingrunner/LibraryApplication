namespace LibraryApplication.States
{
    internal class AddBookState : State
    {
        public AddBookState(Application application) : base(application)
        {
        }

        public override void Run()
        {

            Console.WriteLine("--- Add Book ---");
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
                int pages = int.Parse(Console.ReadLine());

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
