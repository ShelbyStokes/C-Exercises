using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise117
{
    class Calculator
    {
        public static void MethodOne(int numberOne, out int numberTwo)
        {
            int numberOneDivid = numberOne / 2;
            Console.WriteLine("You first number will not be divided by 2. {0} is now {1}", numberOne, numberOneDivid);
            numberTwo = numberOneDivid;
            Console.WriteLine(numberTwo);
        }
        public static void MethodOne(int numberOne, int numberThree)
        {
            Console.WriteLine("This is an example of an Overload.");
        }

    }

    static class noClass
    {
        //This class is used as an example of a static class. This designation makes it a sealed class that cannot be instantiated.
    }

}
