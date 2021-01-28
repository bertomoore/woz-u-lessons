using System;

namespace OverdueInvoices
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0 || !int.TryParse(args[0], out int days))
            {
                do Console.WriteLine("Please enter valid number of days overdue:");
                while (!int.TryParse(Console.ReadLine(), out days));
            }

            Console.WriteLine($"{OverdueInvoices(days)}% fee will be applied");
        }

        static int OverdueInvoices(int days)
        {
            if (days <= 7) return days * 10;

            return (days - 7) * 50 + 70;
        }
    }
}
