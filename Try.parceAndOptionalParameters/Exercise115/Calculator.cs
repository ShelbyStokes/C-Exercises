using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise115
{
    class Calculator
    {
        public int MethodOne(int numberOne, int numberTwo)
        {
            int numberOneAdd = numberOne + 5;
            Console.WriteLine("You first number will not be increased by 5. {0} is now {1}", numberOne, numberOneAdd);
            Console.WriteLine("The second number is " + numberTwo);

            return numberOneAdd;
        }
    }
}
