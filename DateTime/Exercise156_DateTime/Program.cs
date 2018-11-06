using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise156_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine("The current date and time is {0}. \nPlease enter a number:", currentDateTime);
            double userNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("If you add {0} hours to the current date and time it would be {1}", userNumber, currentDateTime.AddHours(userNumber));
            Console.ReadLine();
        }
    }

    //1. Prints the current date and time to the console.
    //2. Asks the user for a number.
    //3. Prints to the console the exact time it will be in X hours, X being the number the user entered in step 2.
}
