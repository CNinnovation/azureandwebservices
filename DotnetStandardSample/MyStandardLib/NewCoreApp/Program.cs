using MyStandardLib;
using System;

namespace NewCoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = new Demo();
            Console.WriteLine(d.Greeting("Stephanie"));

            d.Show("Hello, Matthias");
        }
    }
}
