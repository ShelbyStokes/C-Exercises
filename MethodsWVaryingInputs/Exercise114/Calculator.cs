using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise114
{
    class Calculator
    {
        public int MethodOne(int numberOne)
        {
            int newNumberOne = numberOne + 15;
            Console.WriteLine("The original number was {0}. Add 15 and the new number is {1}", numberOne, newNumberOne);
            return newNumberOne;
        }

        public int MethodTwo(decimal numberTwo)
        {
            decimal newNumberTwo = numberTwo + 30.05m;
            Console.WriteLine("The original number was {0}. Add 30.05 and the new number is {1}", numberTwo, newNumberTwo);
            return Convert.ToInt32(newNumberTwo);
        }

        public int MethodThree(string numberThree)
        {
            int newNumberThree = Convert.ToInt32(numberThree) + 50;
            Console.WriteLine("The original number was {0}. Add 50 and the new number is {1}", numberThree, newNumberThree);
            return newNumberThree;
        }

    }
}
