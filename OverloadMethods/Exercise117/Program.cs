using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise117
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number that will divided by two.");
            int numberOne = Convert.ToInt32(Console.ReadLine());


            Calculator calculator = new Calculator();
            
            Calculator.MethodOne(numberOne, out numberOne);
            Calculator.MethodOne(numberOne, 10);
            
            Console.ReadLine();
        }
    }
}
