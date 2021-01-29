using EmployeePayroll;
using System;
using System.Collections.Generic;
using System.Linq;
using TaxBrackets;

namespace Demos
{
    class ContractorPayroll
    {
        public static List<Employee> ContractorPayrollDemo()
        {
            Dictionary<string, decimal[]> taxBrackets = Brackets.Table();

            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < 10; i++)
            {
                string idNumber, state;
                decimal hoursWorked, hourlyRate;

                do
                {
                    Console.WriteLine("\nPlease enter ID:");
                    idNumber = Console.ReadLine();
                }
                while (!int.TryParse(idNumber, out _));

                do
                {
                    Console.WriteLine("\nPlease enter state:");
                    state = Console.ReadLine();
                }
                while (!taxBrackets.ContainsKey(state));

                do    Console.WriteLine("\nPlease enter number of hours worked:");
                while (!decimal.TryParse(Console.ReadLine(), out hoursWorked));

                do    Console.WriteLine("\nPlease enter hourly rate:");
                while (!decimal.TryParse(Console.ReadLine(), out hourlyRate));

                employees.Add(new Employee(idNumber, hoursWorked, hourlyRate, state));
            }

            return employees;
        }



        public static void ContractorPayrollDemo2(List<Employee> employees)
        {
            Console.WriteLine("\n Employees:");
            Display(employees);

            Console.WriteLine("\n Employees sorted by gross income:");
            Display(employees.OrderBy(employee => employee.GrossIncome()));

            Console.WriteLine("\n Employees sorted by income tax:");
            Display(employees.OrderBy(employee => employee.IncomeTax()));

            Console.WriteLine("\n Employees sorted by net income:");
            Display(employees.OrderBy(employee => employee.NetIncome()));
        }



        static void Display(IEnumerable<Employee> employees)
        {
            Console.WriteLine(" ".PadRight(77, '-'));
            Console.WriteLine($" | ID Number | {"State",-15} | {"Gross",-12} | {"Tax",-12} | {"Net",-12} |");
            Console.WriteLine(" ".PadRight(77, '-'));

            foreach (Employee e in employees)
            {
                string s = $" | {e.IdNumber,9} | {e.WorkState,-15} | {e.GrossIncome(),12:N} | {e.IncomeTax(),12:N} | {e.GrossIncome(),12:N} |";
                Console.WriteLine(s);
            }

            Console.WriteLine(" ".PadRight(77, '-'));
        }
    }
}
