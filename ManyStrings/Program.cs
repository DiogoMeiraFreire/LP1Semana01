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


            // prints
            Console.WriteLine(unicode);
            Console.WriteLine(escape);
            Console.WriteLine(conc);
            Console.WriteLine(inter);
        }
    }
}
