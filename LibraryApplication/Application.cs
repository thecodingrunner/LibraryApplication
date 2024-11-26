using LibraryApplication.States;
using LibraryApplication.Utility;

namespace LibraryApplication
{
    public class Application
    {
        private bool _isRunning = false;
        public State CurrentState { get; set; }
        public BookManager BookManager { get; }

        public Application()
        {
            CurrentState = new MenuState(this);
            BookManager = new BookManager();
        }

        public void Run()
        {
            _isRunning = true;
            Console.WriteLine("--- Library Manager Application ---");
            while(_isRunning)
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
