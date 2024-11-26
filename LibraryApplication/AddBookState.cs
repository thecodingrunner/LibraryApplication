using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication
{
    internal class AddBookState : State
    {
        public AddBookState(Application application) : base(application)
        {
        }

        public override void Run()
        {
            Console.WriteLine("Adding a new book... [not implemented yet]");
            // loads of logic goes here
            _application.CurrentState = new MenuState(_application);
        }
    }
}
