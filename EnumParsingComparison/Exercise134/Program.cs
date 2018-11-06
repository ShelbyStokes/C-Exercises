using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise134
{
    class Program
    {
        static void Main(string[] args)
        {

        Console.WriteLine("Please enter current day of the week");
            string userDay = Console.ReadLine();


            try
            {

                dayoftheweek day = (dayoftheweek)Enum.Parse(typeof(dayoftheweek), userDay);
                Console.WriteLine("You successfully entered a day of the week. It is {0}", userDay);

            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }

            Console.ReadLine();

        }
        public enum dayoftheweek
        {

            monday,
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday,
            sunday
        }
    }
}
