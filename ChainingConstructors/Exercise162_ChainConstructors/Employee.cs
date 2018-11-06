using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise162_ChainConstructors
{
    public class Employee
    {
        public string fName;
        public string lName;
        public const string workPlace = "Roxxon";

        public Employee(string cfName) : this(cfName,"unkown")
        {
            fName = cfName;
        }

        public Employee(string cfName, string clName)
        {
            fName = cfName;
            lName = clName;
        }

        public void PrintEmployee()
        {
            Console.WriteLine("Name: {0} {1} Workplace: {2}", fName, lName, workPlace);
        }
    }
}
