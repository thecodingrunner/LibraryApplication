namespace LibraryApplication
{
    public class Application
    {
        private bool _isRunning = false;
        public State CurrentState { get; set; }
        public BookManager BookManager { get; set; }

        public Application()
        {
            CurrentState = new MenuState(this);
            BookManager = new BookManager();
        }

        public void Run()
        {
            _isRunning = true;
            while(_isRunning)
            {
                // do stuff our program needs to do
                CurrentState.Run();
            }
        }

        public void Stop()
        {
            _isRunning = false;
        }
    }
}
