using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise137
{
    class Program
    {
        static void Main(string[] args)
        {
            Number numberOne = new Number();
            numberOne.Amount = 300m;

            Console.WriteLine(numberOne.Amount);
            Console.ReadLine();

        }
    }
}
