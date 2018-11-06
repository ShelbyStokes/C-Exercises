using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercise154_FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number that will be written to a log.");
            //int userNumber = Convert.ToInt32(Console.ReadLine());
            string userNumber = Console.ReadLine();
            File.WriteAllText(@"C:\Users\shelb\source\repos\Exercise154_FileIO\Logs\log.txt", userNumber);
            Console.WriteLine("Then number that you entered will no be printed to the console from the text log. \n Logged number:");
            string textLog = File.ReadAllText("C:\\Users\\shelb\\source\\repos\\Exercise154_FileIO\\Logs\\log.txt");
            Console.WriteLine(textLog);
            Console.ReadLine();
        }
    }
}

//1. Ask a user for a number.
//2. Log that number to a text file.
//3. Print the text file back to the user.
