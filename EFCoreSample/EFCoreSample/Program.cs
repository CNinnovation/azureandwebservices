using System;

namespace EFCoreSample
{
    class Program
    {
        static void Main(string[] args)
        {
            AddBooks();
        }

        private static void AddBooks()
        {
            using (var context = new BooksContext())
            {
                //bool created = context.Database.EnsureCreated();
                //Console.WriteLine($"database created {created}");
                context.Books.Add(new Book() { Title = "Professional C# 6", Publisher = "Wrox Press" });
                int changed = context.SaveChanges();
                Console.WriteLine($"{changed} records changed");
            }
        }
    }
}
