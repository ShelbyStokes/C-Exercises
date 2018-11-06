using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise140
{
    class Program
    {
        static void Main(string[] args)
        {

            // Scrapping this code because I need these different data types to be attached to one another....
            List<string> employeesFName = new List<string>() { "Joe", "Bob", "Sam", "Doug", "James", "Nick", "Ted", "Brian", "Joe", "Miles" };
            List<string> employeesLName = new List<string>() { "Jackson", "Peterson", "GamGee", "Funny", "Jonson", "Neilson", "Kennedy", "Broheim", "Joy", "Moralis" };
            List<int> employeeID = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };



            //this list goes though the already created lists and adds them to a new list called employeeList
            List<Employee> employeeList = new List<Employee>();
            for (int i = 0; i < employeesFName.Count; i++)
            {
                employeeList.Add(new Employee()
                {
                    fName = employeesFName.ElementAt(i),
                    lName = employeesLName.ElementAt(i),
                    employeeID = employeeID.ElementAt(i)
                }
                );
            }

            //This foreach loop is used to add the joes to listOfJoes
            //List<Employee> listOfJoes = new List<Employee>();
            //foreach (Employee searchJoe in employeeList)
            //{
            //    if (searchJoe.fName == "Joe")
            //    {
            //        listOfJoes.Add(searchJoe);
            //    }
            //}

            //This linq/lambda function has the same functionality as the previous foreach loop
            List<Employee> listOfJoes = employeeList.Where(x => x.fName == "Joe").ToList();

            //This funciton will return only individuals who have an ID number greater than 5
            List<Employee> IDOverFive = employeeList.Where(x => x.employeeID > 5).ToList();

            //This Loop is used to print the names and IDs to console
            foreach (Employee printJoes in listOfJoes)
            {
                printJoes.printName();
            }

            foreach (Employee printIDOverFive in IDOverFive)
            {
                printIDOverFive.printName();
            }

            Console.ReadLine();
        }
    }
}
