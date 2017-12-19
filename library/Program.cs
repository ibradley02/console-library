using System;

namespace library
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Library myLibrary = new Library("My Library");

            Book headfirst = new Book("HeadFirst with C#");
            Book mastering = new Book("Mastering the Console App");
            Book game = new Book("C# Game Programming: For Serious Game Creation");
            Book pro = new Book("Pro C# 5.0 and the .NET 4.5 Framework");

            myLibrary.AddBook(headfirst);
            myLibrary.AddBook(mastering);
            myLibrary.AddBook(game);
            myLibrary.AddBook(pro);   

            Console.WriteLine("Welcome to the Library. You may check out any one of the following books:");
            myLibrary.PrintDirectory();


        }
    }
}
