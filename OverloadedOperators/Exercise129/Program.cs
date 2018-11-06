using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise129
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee anyName = new Employee() { fName = "Joe", lName = "Jackson", employeeID = 1 };
            Employee anyName1 = new Employee() { fName = "Bob", lName = "Peterson", employeeID = 2 };
            Employee anyName2 = new Employee() { fName = "Sam", lName = "GamGee", employeeID = 1 };


            Console.WriteLine(anyName == anyName2);
            Console.WriteLine(anyName == anyName1);
            Console.WriteLine(anyName != anyName1);

            Console.ReadLine();
        }

           
    }
}
