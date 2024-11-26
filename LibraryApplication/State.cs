namespace LibraryApplication
{
    public abstract class State
    {
        protected Application _application;

        protected State(Application application)
        {
            _application = application;
        }

        public abstract void Run();
       
    }
}
