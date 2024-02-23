using System;

namespace VariousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Integer Variables with literals
            byte    a = 6;
            sbyte   b = 5;
            short   c = 1;
            ushort  d = 2;
            int     e = 3;
            uint    f = 4U;
            long    g = 5L;
            ulong   h = 6UL;

            // Char variables with unicodes
            char star = '\u2605';
            char arrow = '\u2794';
            char spades = '\u2660';

            // Floating-point variables with literals
            double  i = 3.14;
            float   j = 3.15f;
            decimal k = 3.16m;

            // Prints
            Console.WriteLine("Byte = "   + a);
            Console.WriteLine("Sbyte = "  + b);
            Console.WriteLine("Short = "  + c);
            Console.WriteLine("Ushort = " + d);
            Console.WriteLine("Int = "    + e);
            Console.WriteLine("Uint = "   + f);
            Console.WriteLine("Long = "   + g);
            Console.WriteLine("Ulong = "  + h);

            // Char prints
            Console.WriteLine(star);
            Console.WriteLine(arrow);
            Console.WriteLine(spades);

            //Floating-point prints
            Console.WriteLine("Double = " + i);
            Console.WriteLine("Float = " + j);
            Console.WriteLine("Decimal = " + k);
        }
    }
}