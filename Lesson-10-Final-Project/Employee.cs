using TaxBrackets;
using TaxCalculator;

namespace EmployeePayroll
{
    public class Employee
    {
        private readonly string idNumber;
        private decimal hoursWorked;
        private decimal hourlyRate;
        private readonly string workState;

        public string IdNumber { get { return idNumber; } }

        public decimal HoursWorked { get { return hoursWorked; } set { hoursWorked = value; } }

        public decimal HourlyRate { get { return hourlyRate; } set { hourlyRate = value; } }

        public string WorkState { get { return workState; } }

        public Employee(string idNumber, decimal hoursWorked, decimal hourlyRate, string workState)
        {
            this.idNumber = idNumber;
            this.hoursWorked = hoursWorked;
            this.hourlyRate = hourlyRate;
            this.workState = workState;
        }

        public decimal GrossIncome()
        {
            return hoursWorked * hourlyRate;
        }

        public decimal IncomeTax()
        {
            return Tax.Calculate(GrossIncome(), Brackets.Table()[workState]);
        }

        public decimal NetIncome()
        {
            return GrossIncome() - IncomeTax();
        }
    }
}