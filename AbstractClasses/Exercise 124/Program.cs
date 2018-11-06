using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_124
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee aName = new Employee();
            aName.firstName = "Sample";
            aName.lastName = "Student";
            aName.Quit();
            Console.ReadLine();

        }
    }
}
