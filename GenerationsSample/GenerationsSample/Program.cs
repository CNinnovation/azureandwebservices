using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerationsSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Generations();
        }

        private static void Generations()
        {
            var o1 = new object();
            int g1 = GC.GetGeneration(o1);
            Console.WriteLine(g1);
            GC.Collect();
            g1 = GC.GetGeneration(o1);
            Console.WriteLine(g1);
            GC.Collect();
            g1 = GC.GetGeneration(o1);
            Console.WriteLine(g1);
            GC.Collect();
            g1 = GC.GetGeneration(o1);
            Console.WriteLine(g1);
            GC.Collect();
            g1 = GC.GetGeneration(o1);
            Console.WriteLine(g1);
        }
    }
}
