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

            // prints
            Console.WriteLine(unicode);
            Console.WriteLine(escape);
        }
    }
}
