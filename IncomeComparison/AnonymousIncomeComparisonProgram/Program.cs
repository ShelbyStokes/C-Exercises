using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousIncomeComparisonProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine();
            Console.WriteLine("Person 1");
            Console.WriteLine("What is the Hourly Rate of Person 1?");
            string pOneWage = Console.ReadLine();
            decimal pOneWageNum = Convert.ToDecimal(pOneWage);

            Console.WriteLine("How many hours does Person 1 work in a week?");
            string pOneHrs = Console.ReadLine();
            decimal pOneHrsNum = Convert.ToDecimal(pOneHrs);

            Console.WriteLine("Person 2");
            Console.WriteLine("What is the Hourly Rate of Person 2?");
            string pTwoWage = Console.ReadLine();
            decimal pTwoWageNum = Convert.ToDecimal(pTwoWage);

            Console.WriteLine("How many hours does Person 2 work in a week?");
            string pTwoHrs = Console.ReadLine();
            decimal pTwoHrsNum = Convert.ToDecimal(pTwoHrs);

            decimal pOneWkSalary = pOneWageNum * pOneHrsNum;
            decimal pOneAnnSalary = pOneWkSalary * 52;
            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine(pOneAnnSalary);

            decimal pTwoWkSalary = pTwoWageNum * pTwoHrsNum;
            decimal pTwoAnnSalary = pTwoWkSalary * 52;
            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine(pTwoAnnSalary);

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool pOnePTwo = pOneAnnSalary > pTwoAnnSalary;
            Console.WriteLine(pOnePTwo);

            Console.ReadLine();


        }
    }
}
