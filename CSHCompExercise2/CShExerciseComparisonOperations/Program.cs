using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShExerciseComparisonOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            //test
            Console.WriteLine("Please enter a number");
            string multiplyByFifty = Console.ReadLine();
            ulong mulBFiveO = Convert.ToUInt64(multiplyByFifty) * 50;
            Console.WriteLine("Your number multiplied by 50 is " + mulBFiveO);

            Console.WriteLine("Enter another number");
            string addTwentyFive = Console.ReadLine();
            int plusAQuarter = Convert.ToInt16(addTwentyFive) + 25;
            Console.WriteLine("Your number plus 25 is " + plusAQuarter);

            Console.WriteLine("Enter a third number");
            string dividByTwelveAndAHalf = Console.ReadLine();
            double numbytwelevehalf = Convert.ToDouble(dividByTwelveAndAHalf)/12.5;
            Console.WriteLine("Your number divided by 12.5 is " + numbytwelevehalf);

            Console.WriteLine("Enter a fourth number.");
            string GreaterThanFifty = Console.ReadLine();
            long numbGreaterFifty = Convert.ToInt64(GreaterThanFifty);
            bool greaterThanFiftyMath = numbGreaterFifty > 50;
            Console.WriteLine("If your number is greater than 50 ~ True. If it is equal to or less than 50 ~ False. Results: " + greaterThanFiftyMath);

            Console.WriteLine("Enter a fifth number");
            string remainderBySeven = Console.ReadLine();
            int remainder = Convert.ToInt16(remainderBySeven) % 7;
            Console.WriteLine("Your number divided by 7 has a remainder of " + remainder);

            Console.ReadLine();



        }
    }
}
