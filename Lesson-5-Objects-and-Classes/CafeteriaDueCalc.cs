using System;
using System.Linq;

namespace EmployeeCafeteriaDue
{
    class Program
    {
        static void Main()
        {
            string[] employeeTypes = { "full", "part", "temp" };
            string employeeType;
            int mealCount;

            do
            {
                Console.WriteLine("Enter valid type of employee:");
                employeeType = Console.ReadLine();
            }
            while (!employeeTypes.Contains(employeeType));

            do Console.WriteLine("Enter number of meals:");
            while (int.TryParse(Console.ReadLine(), out mealCount));

            Employee employee = new Employee(employeeType, mealCount);
            Console.WriteLine($"Employee owes ${employee.CafeteriaDues}");
        }
    }

    class Employee
    {
        decimal cafeteriaDues;

        public decimal CafeteriaDues
        {
            get { return cafeteriaDues; }
        }

        public Employee(string employeeType, decimal mealCount)
        {
            cafeteriaDues = employeeType == "full" ? 0 :
                    mealCount * (employeeType == "part" ? 1.5M : 2.75M);
        }
    }
}
