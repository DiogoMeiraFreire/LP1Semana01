using System;

namespace AskForInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write an integer");
            string input = Console.ReadLine();

            int i = int.Parse(input);
            Console.WriteLine($"this is in i:-> {i}");
            
            Console.WriteLine("Write a floating-point number");
            string input2 = Console.ReadLine();

            float f = float.Parse(input2);

            var result = i + f;
            Console.WriteLine($"Here's the result->{result}");

        }
    }
}
