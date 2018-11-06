using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopIterationListExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Create a one-dimensional Array of strings. Ask the user to input some text. Create a loop that goes 
            //through each string in the Array, adding the user’s text to the string. Then create a loop that prints 
            //off each string in the Array on a separate line.

            //string[] madLibs = { " is slimy.", " is shiny.", "s are everywhere.", " is what I live for!" };

            //Console.WriteLine("Enter a noun:");
            //string usrNoun = Console.ReadLine();

            //foreach (string statement in madLibs)
            //{
            //    Console.WriteLine(usrNoun + statement);
            //}
            //Console.ReadLine();






            //2.Create an infinite loop.

            //int i = 0;
            //bool loopExit = false;

            //while(loopExit = true)
            //{
            //    Console.WriteLine("While Statement " + i);
            //    i++;             
            //}

            //Console.ReadLine();





            //3.Fix the infinite loop so it will execute.

            //int i = 0;
            //bool loopExit = false;

            //while (i <11)
            //{
            //    Console.WriteLine("While Statement " + i);
            //    i++;
            //}

            //Console.ReadLine();



            //4.Create a loop where the comparison used to determine whether to continue iterating the loop is a “<” operator.

            //int j = 0;
            //while (j<22)
            //{
            //    Console.WriteLine("The number is currently " + j);
            //    j++;
            //}
            //Console.ReadLine();

            //5.Create a loop where the comparison used to determine whether to continue iterating the loop is a “<=” operator.

            //int j = 0;
            //while (j <= 21)
            //{
            //    Console.WriteLine("The number is currently " + j);
            //    j++;
            //}
            //Console.ReadLine();



            //6.Create a List of strings where each item in the list is unique.Ask the user to select text to search for in the List.
            //    Create a loop that iterates through the loop and then displays the index of the array that contains matching text on the screen.


            //List<string> uniqueStinglist = new List<string>() { "Tiger", "Lion", "Bear", "Oh my" };

            //Console.WriteLine("Enter Lion, Tiger, Bear, or Oh my");
            //string userString = Console.ReadLine();

            //for (int i = 0; i < uniqueStinglist.Count; i++)
            //{
            //    if (uniqueStinglist[i] == userString)
            //    {
            //        Console.WriteLine("The value {0} appears at index {1}", 
            //            userString,
            //            i);
            //    }
            //}

            //Or

            //foreach (var word in uniqueStinglist)
            //{
            //    if (userString == word)
            //    {
            //        Console.WriteLine("The value {0} appears at index {1}",
            //            userString,
            //            uniqueStinglist.IndexOf(word));
            //    }
            //}
            //Console.ReadLine();


            //7. Add code to that above loop that tells a user if they put in text that isn’t in the List.

            //List<string> uniqueStinglist = new List<string>() { "Tiger", "Lion", "Bear", "Oh my" };

            //Console.WriteLine("Enter Lion, Tiger, Bear, or Oh my");
            //string userString = Console.ReadLine();

            //if (!uniqueStinglist.Contains(userString))
            //{
            //    Console.WriteLine("The input you entered does not exist. Goodbye.");
            //}
            //else
            //{
            //    for (int i = 0; i < uniqueStinglist.Count; i++)
            //    {
            //        if (uniqueStinglist[i] == userString)
            //        {
            //            Console.WriteLine("The value {0} appears at index {1}",
            //                userString,
            //                i);
            //        }
            //    }
            //}
            //Console.ReadLine();

            //8. Add code to that above loop that stops it from executing once a match has been found.

            //List<string> uniqueStinglist = new List<string>() { "Tiger", "Lion", "Bear", "Oh my" };

            //Console.WriteLine("Enter Lion, Tiger, Bear, or Oh my");
            //string userString = Console.ReadLine();

            //if (!uniqueStinglist.Contains(userString))
            //{
            //    Console.WriteLine("The input you entered does not exist. Goodbye.");
            //}
            //else
            //{
            //    for (int i = 0; i < uniqueStinglist.Count; i++)
            //    {
            //        if (uniqueStinglist[i] == userString)
            //        {
            //            Console.WriteLine("The value {0} appears at index {1}",
            //                userString,
            //                i);
            //            break;
            //        }
            //    }
            //}
            //Console.ReadLine();

            //9. Create a List of strings that has at least two identical strings in the List. Ask the user to select text to search for in the List. 
            //Create a loop that iterates through the loop and then displays the indices of the array that contain matching text on the screen.

            //List<string> uniqueStinglist = new List<string>() { "Tiger", "Lion", "Bear", "Oh my", "Tiger" };

            //Console.WriteLine("Enter Lion, Tiger, Bear, or Oh my");
            //string userString = Console.ReadLine();

            //if (!uniqueStinglist.Contains(userString))
            //{
            //    Console.WriteLine("The input you entered does not exist. Goodbye.");
            //}
            //else
            //{
            //    for (int i = 0; i < uniqueStinglist.Count; i++)
            //    {
            //        if (uniqueStinglist[i] == userString)
            //        {
            //            Console.WriteLine("The value {0} appears at index {1}",
            //                userString,
            //                i);
            //        }
            //    }
            //}
            //Console.ReadLine();


            //10.Add code to that above loop that tells a user if they put in text that isn’t in the List.

            //List<string> uniqueStinglist = new List<string>() { "Tiger", "Lion", "Bear", "Oh my", "Tiger" };

            //Console.WriteLine("Enter Lion, Tiger, Bear, or Oh my");
            //string userString = Console.ReadLine();

            //if (!uniqueStinglist.Contains(userString))
            //{
            //    Console.WriteLine("The input you entered does not exist in the list. Goodbye.");
            //}
            //else
            //{
            //    for (int i = 0; i < uniqueStinglist.Count; i++)
            //    {
            //        if (uniqueStinglist[i] == userString)
            //        {
            //            Console.WriteLine("The value {0} appears at index {1}",
            //                userString,
            //                i);
            //        }
            //    }
            //}
            //Console.ReadLine();

            //11. Create a List of strings that has at least two identical strings in the List. 
            //Create a foreach loop that evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared in the list.


            List<string> dupStringList = new List<string>() { "Cat", "Dog", "Pig", "Bird","Cat" , "Bird"};
            List<string> dupStringListComp = new List<string>();

            foreach (var word in dupStringList)
            {
                if (!dupStringListComp.Contains(word)) //This is used to see if the second string list already contains the current word from first list
                {
                    Console.WriteLine("{0} is listed for the first time in the list", word);
                    dupStringListComp.Add(word);

                }
                else
                {
                    Console.WriteLine("{0} already exists within the list.", word);
                }
                

                //dupStringListComp.ForEach(i => Console.Write("{0}\t", i));

                
            }
            Console.ReadLine();
        }
    }
}
