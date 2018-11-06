using System;

namespace Exercise162_ChainConstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            var tenure = 5;
            Employee emp1 = new Employee("Shelby");
            emp1.PrintEmployee();
            Employee emp2 = new Employee("Shelby", "Stokes");
            emp2.PrintEmployee();
            Console.WriteLine("This employee has been with the company for {0} years", tenure);
            Console.ReadLine();
        }
    }
}
