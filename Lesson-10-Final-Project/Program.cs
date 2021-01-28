using EmployeePayroll;
using System.Collections.Generic;

using static Demos.ContractorPayroll;

namespace Program
{
    class Program
    {
        static void Main()
        {
            List<Employee> employees = ContractorPayrollDemo();
            ContractorPayrollDemo2(employees);
        }

    }
}