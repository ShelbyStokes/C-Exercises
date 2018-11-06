using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise131
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee<string> thingString = new Employee<string>();
            thingString.things = new List<string>();
            thingString.things.Add("Tom");
            thingString.things.Add("Bill");
            thingString.things.Add("Tony");
            thingString.things.Add("Sam");

            Employee<int> thingInt = new Employee<int>();
            thingInt.things = new List<int>();
            thingInt.things.Add(0);
            thingInt.things.Add(1);
            thingInt.things.Add(2);
            thingInt.things.Add(3);

            Console.WriteLine("\nList 1 : ");
            for (int i = 0; i < thingString.things.Count; i++)
            {
                Console.WriteLine(thingString.things[i]);
            }
            Console.WriteLine("\nList 2 : ");
            for (int j = 0; j < thingInt.things.Count; j++)
            {
                Console.WriteLine(thingInt.things[j]);
            }
            Console.ReadLine();


            //1.Make the Employee class take a generic type parameter.

            //2. Add a property to the Employee class called "things" and have its data type be a generic list matching the generic type of the class.

            //3. Instantiate an Employee object with type "string" as its generic parameter.Assign a list of strings as the property value of Things.

            //4. Instantiate an Employee object with type "int" as its generic parameter.Assign a list of integers as the property value of Things.

            //5. Create a loop that prints all of the Things to the Console.


        }
    }
}
