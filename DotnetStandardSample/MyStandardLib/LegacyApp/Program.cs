using MyStandardLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegacyApp
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
