namespace LibraryApplication.States
{
    internal class ViewAllBooksState : State
    {
        public ViewAllBooksState(Application application) : base(application)
        {
        }

        public override void Run()
        {
            Console.WriteLine("All Books in Database:");
            Console.WriteLine();
            List<string> books = _application.BookManager.GetAllBookInfo();
            books.ForEach(Console.WriteLine);
            _application.CurrentState = new MenuState(_application);
        }
    }
}
