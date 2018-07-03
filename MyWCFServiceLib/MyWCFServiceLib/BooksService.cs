using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MyWCFServiceLib
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class BooksService : IBooksService
    {
        public Book GetBook(int bookId)
        {
            return new Book { BookId = 1, Title = "Professional C# 7", Publisher = "Wrox Press" };
        }
    }
}
