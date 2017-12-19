using System;
using System.Collections.Generic;
using System.Linq;

namespace library
{
    public class Library
    {
        public string Name;
        public int Num = 0;
        int CheckedOut = 0;
        private Dictionary<string, List<Book>> _books;
        public void AddBook(Book book)
        {
            _books[book.Title] = new List<Book>();
        }
        public void Checkout(Book book)
        {
            if (CheckedOut == 0)
            {
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
                
            }
            else if ((_books.Count + 1) == Result)
            {
            }
            else
            {
                Console.WriteLine("Please enter a valid input.");
            }
        }
        public void ReturnBook(Book book)
        {

        }
        public void PrintDirectory()
        {
            foreach (var book in _books)
            {
                Num++;
                Console.WriteLine(Num + ". " + book.Key);
                if (Num == _books.Count)
                {
                    Num++;
                    Console.WriteLine(Num + ". Return Book");
                    Num = 0;
                }
            }
        }
        public Library(string name)
        {
            Name = name;
            _books = new Dictionary<string, List<Book>>();
        }
    }
}