using System;
using System.Collections.Generic;

namespace library
{
    public class Library
    {
        public string Name;
        private Dictionary<string, List<Book>> _books;
        public void AddBook(Book book)
        {
            _books[book.Title] = new List<Book>();
        }
        public void PrintDirectory()
        {
            foreach (var book in _books)
            {
                Console.WriteLine(book.Key);
            }
        }
        public Library(string name)
        {
            Name = name;
            _books = new Dictionary<string, List<Book>>();
        }
    }
}