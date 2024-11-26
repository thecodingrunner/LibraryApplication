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

        private List<string> SearchByTitle()
        {
            Console.WriteLine("Please enter book title");
            string searchedTitle = Console.ReadLine();
            return _application.BookManager.SearchByTitle(searchedTitle);
        }

        private List<string> SearchByAuthor()
        {
            Console.WriteLine("Please enter book author");
            string searchedAuthor = Console.ReadLine();
            return _application.BookManager.SearchByAuthor(searchedAuthor);
        }

        private void DisplayBooks(List<string> books)
        {
            books.ForEach(Console.WriteLine);
        }
    }
}
