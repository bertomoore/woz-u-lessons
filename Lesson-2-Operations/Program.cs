using System;

namespace lesson9HandsOn
{
    class Program
    {
        static void Main(string[] args)
        {
            int first, second;

            do Console.WriteLine("Enter first integer:");
            while (int.TryParse(Console.ReadLine(), out first));

            do Console.WriteLine("Enter second integer:");
            while (int.TryParse(Console.ReadLine(), out second));

            Console.WriteLine(first + second);
        }
    }
}
