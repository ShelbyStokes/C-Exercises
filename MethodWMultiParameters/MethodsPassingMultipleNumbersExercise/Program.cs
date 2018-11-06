using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPassingMultipleNumbersExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Class1 class1 = new Class1();
            //class1.numOneCrunchNumTwoDis(numberOne: 7, numberTwo: 8);
            //Console.ReadLine();

            Calculator calculator = new Calculator();
            calculator.numOneCrunchNumTwoDis(numberOne: 7, numberTwo: 8);
            Console.ReadLine();
        }
    }
}
