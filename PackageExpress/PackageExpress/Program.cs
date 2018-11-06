using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine();
            Console.WriteLine("What is the weight of the package you wish to ship?");
            int packageWeight = Convert.ToInt32(Console.ReadLine());
            
            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else
            {
            Console.WriteLine("What is the packages width?");
            int packageWidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the packages height?");
            int packageHeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the packages lenght?");
            int packageLenght = Convert.ToInt32(Console.ReadLine());

                decimal totalDemensions = (packageWidth * packageHeight * packageLenght);
                //Console.WriteLine(totalDemensions); - used to check math while building program

                if (totalDemensions > 50)
                {
                    Console.WriteLine("package too big to be shipped via package express.");
                }
                else
                {
                    decimal shipquote = (totalDemensions * packageWeight)/100;
                    Console.WriteLine("Your estimated total for shipping this package is: $"+ shipquote +".00");
                    Console.WriteLine("Thank you.");
                }
            }

            Console.ReadLine();
        }
    }
}
