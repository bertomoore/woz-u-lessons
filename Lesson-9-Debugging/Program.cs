using System;

namespace lesson9HandsOn
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] {4, 7, 29, 43, 12, 20, 88, 121};
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            
            Console.WriteLine(sum);

        }
    }
}

/*
 Correction 1: Initial array construct must use braces, not brackets
 Correction 2: Sum must be initialized with a value to use unary operators
 Correction 3: For loop must confirm i is UNDER number length, not OVER
 Correction 4: Typo of numbers in for loop
 Correction 5: For loop must use postfix increment operator to avoid infinite loop
 Correction 6: Missing WriteLine method to output result
*/