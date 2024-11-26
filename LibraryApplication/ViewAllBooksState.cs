﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication
{
    internal class ViewAllBooksState : State
    {
        public ViewAllBooksState(Application application) : base(application)
        {
        }

        public override void Run()
        {
            List<string> books = _application.BookManager.GetAllBookInfo();
            books.ForEach(Console.WriteLine);
            _application.CurrentState = new MenuState(_application);
        }
    }
}
