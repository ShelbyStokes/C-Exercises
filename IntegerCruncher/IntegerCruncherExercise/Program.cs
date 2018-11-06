using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerCruncherExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a number:");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            int results = integerManipulation.Multiply(userNumber);
            int results2 = integerManipulation.Add(results);
            int results3 = integerManipulation.Divid(results2);
            
            //Console.WriteLine(results);
            //Console.WriteLine(results2);
            //Console.WriteLine(results3);
            Console.ReadLine();
        }
    }
}