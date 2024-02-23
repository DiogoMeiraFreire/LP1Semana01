using System;

namespace ManyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            // string variables
            string unicode = "\u03A9";
            string escape = "this is a tab \t a tab has occurred";
            string conc = "ab " + 2;
            string inter = $"The unicode variable is {unicode}";

            double xx = 1.23456;
            int ii = 19;


            // prints
            Console.WriteLine(unicode);
            Console.WriteLine(escape);
            Console.WriteLine(conc);
            Console.WriteLine(inter);

            Console.WriteLine(xx.ToString("F2"));
            Console.WriteLine($"{xx:p1}");
            Console.WriteLine(ii.ToString("X"));
            Console.WriteLine(ii.ToString("C"));
        }
    }
}
