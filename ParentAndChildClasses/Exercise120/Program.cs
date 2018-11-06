using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise120
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee anyName = new Employee();
            anyName.FirstName = "Sample";
            anyName.LastName = "Student";
            anyName.SayName();
            Console.ReadLine();

        }
    }
}
