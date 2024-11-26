namespace LibraryApplication
{
    internal class MenuState : State
    {
        public MenuState(Application application) : base(application)
        {
        }

        public override void Run()
        {
            Console.WriteLine("Please enter a command:");
            Console.WriteLine("Possible commands:");
            Console.WriteLine("0 - Quit Application, 1 - Add New Book, 2 - Edit Book, 3 - Delete Book, 4 - View All Books, 5 - Search for Books");
            var commandInput = Console.ReadLine();

            switch (commandInput)
            {
                case "0":
                    _application.Stop();
                    break;
                case "1":
                    _application.CurrentState = new AddBookState(_application);
                    break;
                case "2":
                    _application.CurrentState = new EditBookState(_application);
                    break;
                case "3":
                    _application.CurrentState = new DeleteBookState(_application);
                    break;
                case "4":
                    _application.CurrentState = new ViewAllBooksState(_application);
                    break;
                case "5":
                    _application.CurrentState = new SearchBookState(_application);
                    break;
            }


        }
    }
}
