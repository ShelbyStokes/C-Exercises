using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise129
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

        public static bool operator ==(Employee anyName, Employee anyName1)
        {
            if (anyName.employeeID == anyName1.employeeID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator != (Employee anyName, Employee anyName1)
        {
            if (anyName.employeeID != anyName1.employeeID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }



    }
}
