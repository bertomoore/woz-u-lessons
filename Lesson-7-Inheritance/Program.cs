using System;

namespace Lesson7
{

    class Program
    {
        public static void Main()
        {
            Engineer eng = new Engineer("Rupert Scott", "42000", "11/22/12", "MIT");
            eng.getName();
            eng.getSalary();
            eng.hiredDate();

            SoftwareEngineer swe = new SoftwareEngineer("Shea Rovington", "50000", "02/02/2020", "Harvard");
            swe.getName();
            swe.getSalary();
            swe.hiredDate();
        }
    }
    class Employee
    {
        string name;
        string salary;
        string hireDate;

        public Employee()
        {
            name = "";
            salary = "";
            hireDate = "";
        }

        public Employee(string name, string salary, string hireDate)
        {
            this.name = name;
            this.salary = salary;
            this.hireDate = hireDate;
        }

        public virtual void getName()
        {
            Console.WriteLine($"Employee name: {name}");
        }

        public virtual void getSalary()
        {
            Console.WriteLine($"Salary: {salary}");
        }

        public virtual void hiredDate()
        {
            Console.WriteLine($"Hire Date: {hireDate}");
        }
    }

    class Engineer : Employee
    {
        string schoolAttended;

        public Engineer(string name, string salary, string hireDate, string schoolAttended)
            :base(name, salary, hireDate)
        {
            this.schoolAttended = schoolAttended;
        }
    }

    class SoftwareEngineer : Engineer
    {
        public SoftwareEngineer(string name, string salary, string hireDate, string schoolAttended)
            : base(name, salary, hireDate, schoolAttended) { }

        public override void getSalary()
        {
            Console.WriteLine("Sorry, this employee's salary is private.");
        }
    }
}
