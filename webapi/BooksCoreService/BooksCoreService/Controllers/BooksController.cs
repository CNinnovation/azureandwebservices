using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BooksCoreService.Models;
using BooksCoreService.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BooksCoreService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class BooksController : ControllerBase
    {
        private readonly IBooksService _booksService;

        public BooksController(IBooksService booksService)
        {
            _booksService = booksService ?? throw new ArgumentNullException(nameof(booksService));
        }

        // GET api/values
        [HttpGet]
        [AllowAnonymous]
        public ActionResult<IEnumerable<Book>> Get() => Ok(_booksService.GetBooks());


        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Book> Get(int id) => Ok(_booksService.GetBook(id));


        // POST api/values
        [HttpPost]
        public void Post([FromBody] Book value) => _booksService.AddBook(value);


        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Book value)
        {
            if (id != value.BookId)
                throw new Exception("invalid data");

            _booksService.UpdateBook(value);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _booksService.DeleteBook(id);
        }
    }
}