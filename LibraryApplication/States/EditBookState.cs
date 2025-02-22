﻿namespace LibraryApplication.States
{
    internal class EditBookState : State
    {
        public EditBookState(Application application) : base(application)
        {
        }

        public override void Run()
        {
            Console.WriteLine("--- Edit Book ---");
            try
            {
                Console.WriteLine("Please input the book id of the book you would like to edit");
                int bookId = int.Parse(Console.ReadLine());

                Console.WriteLine("Please select the field that you would like to edit");
                Console.WriteLine("1 - Title, 2 - Description, 3 - Author, 4 - Publication Date, 5 - Pages");
                string field = Console.ReadLine();

                Console.WriteLine("Please input the new value");
                string value = Console.ReadLine();

                _application.BookManager.EditBook(bookId, field, value);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            // loads of logic goes here
            _application.CurrentState = new MenuState(_application);
        }
    }
}
