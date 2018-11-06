using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise114
{
    class Program
    {
        static void Main(string[] args)
        {

            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.MethodOne(12));

            Calculator calculator1 = new Calculator();
            Console.WriteLine(calculator1.MethodTwo(12.05m));

            Calculator calculator2 = new Calculator();
            Console.WriteLine(calculator2.MethodThree("25"));

            Console.ReadLine(); 

        }
    }
}
