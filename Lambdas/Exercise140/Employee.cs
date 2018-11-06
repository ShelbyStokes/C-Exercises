using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise140
{
    class Employee
    {
        public string fName { get; set; }
        public string lName { get; set; }
        public int employeeID { get; set; }

        public void printName()
        {
            Console.WriteLine("{0} {1} {2}", fName, lName, employeeID);
        }
    }
}
