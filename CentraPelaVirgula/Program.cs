using System;
using System.Globalization;

namespace CentraPelaVirgula
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture 
                                            = CultureInfo.InvariantCulture;

            Console.WriteLine("Insira 4 números reais:");
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            string input3 = Console.ReadLine();
            string input4 = Console.ReadLine();

            float a = float.Parse(input1);
            float b = float.Parse(input2);
            float c = float.Parse(input3);
            float d = float.Parse(input4);

            Console.WriteLine($"{a,6:F2}");
            Console.WriteLine($"{b,6:F2}");
            Console.WriteLine($"{c,6:F2}");
            Console.WriteLine($"{d,6:F2}");
        }
    }
}
