using System;
using System.Collections.Generic;
using System.Linq;

namespace library
{
    public class Library
    {
        string Name;
        int Num = 0;
        int CheckedOut = 0;
        private List<Book> _books;
        public void AddBook(Book book)
        {
            _books.Add(book);
        }
        public void Checkout(Book book)
        {
            if (CheckedOut == 0)
            {
                book.Available = false;
                PrintDirectory();
            }
            else
            {
                Console.WriteLine("You already have a book checked out.");
            }
        }
        public void SelectBook(int Result)
        {
            if (_books.Count >= Result)
            {
                Checkout(_books[Result]);
            }
            else if ((_books.Count + 1) == Result && CheckedOut != 0)
            {
                ReturnBook(_books[Result]);
            }
            else
            {
                Console.WriteLine("Please enter a valid input.");
            }
        }
        public void ReturnBook(Book book)
        {
            if (CheckedOut != 0)
            {
                book.Available = true;
                PrintDirectory();
            }

        }
        public void PrintDirectory()
        {
            foreach (var book in _books)
            {
                if (book.Available == true)
                {
                    Num++;
                    Console.WriteLine(Num + ". " + book.Title);
                    if (Num == _books.Count)
                    {
                        Num++;
                        Console.WriteLine(Num + ". Return Book");
                        Num = 0;
                    }
                }
            }
        }
        public Library(string name)
        {
            Name = name;
            _books = new List<Book>();
        }
    }
}