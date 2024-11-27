using LibraryApplication.States;
using LibraryApplication.Utility;

namespace LibraryApplication
{
    public class Application
    {
        private bool _isRunning = false;

        public BookManager BookManager { get; }

        public State CurrentState { get; set; } 
        public IFileHandler FileHandler { get; set; }

        public Application()
        {
            CurrentState = new MenuState(this);
            FileHandler = new FileHandler();
            BookManager = new BookManager(FileHandler);
        }

        public void Run()
        {
            _isRunning = true;
            Console.WriteLine("--- Library Manager Application ---");
            while (_isRunning)
            {
                // do stuff our program needs to do
                CurrentState.Run();
                Console.WriteLine();
            }
        }

        public void Stop()
        {
            _isRunning = false;

            Console.WriteLine("Saving Data...");
            BookManager.SaveBooks();

            Console.WriteLine("Goodbye!");
        }
    }
}