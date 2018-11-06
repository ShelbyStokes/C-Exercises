using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseBoolLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic Approval for Car Insurance");
            Console.WriteLine();

            Console.WriteLine("What is your age?");
            string driverAge = Console.ReadLine();
            int driverAgeInt = Convert.ToInt16(driverAge);

            Console.WriteLine("You have been charged with a DUI? True or False.");
            string driverDUI = Console.ReadLine();
            bool driverDUIBool = Convert.ToBoolean(driverDUI);

            Console.WriteLine("How many speeding tickets do you have?");
            string driverSpeedTicks = Console.ReadLine();
            int driverSpeedTicksInt = Convert.ToInt16(driverSpeedTicks);

            Console.WriteLine("Driver is Qualified");
            Console.WriteLine(driverAgeInt);
            Console.WriteLine(driverDUIBool);
            Console.WriteLine(driverSpeedTicksInt);
            Console.WriteLine((driverAgeInt > 15) && (driverDUIBool == false) && (driverSpeedTicksInt < 4));
 
            Console.ReadLine();
        }
    }
}
