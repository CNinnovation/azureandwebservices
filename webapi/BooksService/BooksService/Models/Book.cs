using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BooksService.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
    }
}