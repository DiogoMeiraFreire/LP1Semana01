﻿using System;

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

            // Prints
            Console.WriteLine("Byte = "   + a);
            Console.WriteLine("Sbyte = "  + b);
            Console.WriteLine("Short = "  + c);
            Console.WriteLine("Ushort = " + d);
            Console.WriteLine("Int = "    + e);
            Console.WriteLine("Uint = "   + f);
            Console.WriteLine("Long = "   + g);
            Console.WriteLine("Ulong = "  + h);
        }
    }
}