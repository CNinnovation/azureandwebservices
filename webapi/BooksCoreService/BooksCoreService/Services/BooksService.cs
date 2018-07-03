using BooksCoreService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksCoreService.Services
{
    public class BooksService : IBooksService
    {
        private List<Book> _books = new List<Book>
        {
            new Book { BookId = 1, Title = "Professional C# 6", Publisher = "Wrox Press"},
            new Book { BookId = 2, Title = "Professional C# 7", Publisher = "Wrox Press"},

        };

        public IEnumerable<Book> GetBooks() => _books;

        public Book GetBook(int id) => _books.SingleOrDefault(b => b.BookId == id);

        public void AddBook(Book book) => _books.Add(book);

        // PUT api/values/5
        public void UpdateBook(Book book)
        {
            _books.Remove(_books.Single(b => b.BookId == book.BookId));
            _books.Add(book);

        }

        public void DeleteBook(int id)
        {
            _books.Remove(_books.Single(b => b.BookId == id));
        }
    }
}
