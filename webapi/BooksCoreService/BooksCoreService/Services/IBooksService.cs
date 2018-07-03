using System.Collections.Generic;
using BooksCoreService.Models;

namespace BooksCoreService.Services
{
    public interface IBooksService
    {
        void AddBook(Book book);
        void DeleteBook(int id);
        Book GetBook(int id);
        IEnumerable<Book> GetBooks();
        void UpdateBook(Book book);
    }
}