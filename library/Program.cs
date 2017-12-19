using System;

namespace library
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            string Input = "";
            int Result;
            Library myLibrary = new Library("My Library");

            Book headfirst = new Book("HeadFirst with C#", true);
            Book mastering = new Book("Mastering the Console App", true);
            Book game = new Book("C# Game Programming: For Serious Game Creation", true);
            Book pro = new Book("Pro C# 5.0 and the .NET 4.5 Framework", true);

            myLibrary.AddBook(headfirst);
            myLibrary.AddBook(mastering);
            myLibrary.AddBook(game);
            myLibrary.AddBook(pro);

            while (Input != "q")
            {
                Console.WriteLine("Welcome to the Library. Type q to leave the library. You may check out any one of the following books:");
                myLibrary.PrintDirectory();
                Input = Console.ReadLine();
                if (int.TryParse(Input, out Result))
                {
                    myLibrary.SelectBook(Result);
                }
                else
                {
                    Console.WriteLine("Please enter a valid input.");
                }
            }


        }
    }
}
