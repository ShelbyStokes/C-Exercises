using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Shelby";
            string age = "31";
            string from = "Federal Way";

            name = name.ToUpper();

            Console.WriteLine("Hi " + name + "! You are from " + from + " and are " + age + " years old.");
            Console.ReadLine();

            StringBuilder para = new StringBuilder();

            para.Append("My name is Shelby. ");
            para.Append("I am using String Building. ");
            para.Append("By using .append I can build a paragraph. ");
            para.Append("That is pretty neat, hu?");



            Console.WriteLine(para);
            Console.ReadLine();
        }
    }
}
