using System;
using System.Collections.Generic;

namespace library
{
    public class Library
    {
        public string Name;
        public int Num = 0;
        private Dictionary<string, List<Book>> _books;
        public void AddBook(Book book)
        {
            _books[book.Title] = new List<Book>();
        }
        public void Checkout()
        {
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
                if(Num == _books.Count){
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