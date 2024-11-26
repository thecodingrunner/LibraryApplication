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
            Console.WriteLine("0 - Quit Application, 1 - Add New Book, 2 - Edit Book, 3 - Delete Book, 4 - View All Books");
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
                    Console.WriteLine("edit book...");
                    break;
                case "3":
                    Console.WriteLine("delete book...");
                    break;
                case "4":
                    Console.WriteLine("view all books...");
                    break;
            }


        }
    }
}
