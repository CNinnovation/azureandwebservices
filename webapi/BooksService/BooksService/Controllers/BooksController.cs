using BooksService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BooksService.Controllers
{
    public class BooksController : ApiController
    {
        private static List<Book> s_books = new List<Book>
        {
            new Book { BookId = 1, Title = "Professional C# 6", Publisher = "Wrox Press"},
            new Book { BookId = 2, Title = "Professional C# 7", Publisher = "Wrox Press"},

        };
        public IEnumerable<Book> GetBooks() => s_books;

        // GET api/values/5
        public Book GetBook(int id) => s_books.SingleOrDefault(b => b.BookId == id);


        // POST api/values
        public void Post([FromBody]Book value)
        {
            s_books.Add(value);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]Book value)
        {
            if (id != value.BookId)
            {
                throw new Exception("invalid parameter");
            }
            s_books.Remove(s_books.Single(b => b.BookId == id));
            s_books.Add(value);

        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            s_books.Remove(s_books.Single(b => b.BookId == id));
        }
    }
}
