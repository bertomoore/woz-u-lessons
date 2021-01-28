using System;
using System.Linq;

namespace Lesson3
{
    class Program
    {
        static void Main()
        {
            SumTenInts();
            CountYourVowels();
        }

        static void SumTenInts()
        {
            Console.WriteLine("Please Enter 10 integers:");

            int total = Console.ReadLine().Split(" ").Select(n => int.Parse(n)).Sum();

            Console.WriteLine($"\nTotal:\n{total}\n");
        }

        static void CountYourVowels()
        {
            char[] vowels = { 'A', 'E', 'I', 'O', 'U', 'a', 'e', 'i', 'o', 'u' };

            Console.WriteLine("Please enter a phrase:");

            int vowelCount = Console.ReadLine().Count(c => vowels.Contains(c));

            Console.WriteLine($"Total vowels: {vowelCount}");
        }
    }
}