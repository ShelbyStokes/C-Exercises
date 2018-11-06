using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise115
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a second number: \n (Note: A second number is not required)");
            string numberTwoString = Console.ReadLine();
            int NumberTwoInt;
            if (int.TryParse(numberTwoString, out NumberTwoInt)) //This int.TryParse method is used to see if the input it an int. If not it returns not a number. 
            {
                Console.WriteLine("The number you wrote is " + NumberTwoInt);
            }
            else
            {
                Console.WriteLine("Not a number");
            }

            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.MethodOne(numberOne, NumberTwoInt));
            Console.ReadLine();

        }
    }
}
