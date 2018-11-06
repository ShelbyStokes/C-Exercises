using System;
using System.Collections.Generic;


namespace IndexExercise
{
    class Program
    {
        static void Main()
        {
            //Howdy program
            string[] stringArray = { "Hello", "Howdy", "Hola", "Chello you" };
            Console.WriteLine("Enter a number 0 - 3 to generate a greeting.");
            int greeting = Convert.ToInt32(Console.ReadLine());

            if (greeting < 4)
            {

                Console.WriteLine(stringArray[greeting]);
            }
            else
            {
                Console.WriteLine("The submitted number does not fall between  0 and 3");
            }


            //Integer index 
            int[] intArray = { 0, 10, 100, 1000, 10000, 100000 };
            Console.WriteLine("\n Enter a number 0 - 5 to generate a number.");
            int numberdis = Convert.ToInt32(Console.ReadLine());

            if (numberdis < 6)
            {

                Console.WriteLine(intArray[numberdis]);
            }
            else
            {
                Console.WriteLine("The submitted number does not fall between  0 and 5");
            }

            //List of Strings
            Console.WriteLine("\n List of words on display \n 0. Banana \n 1. Hot air balloon \n 2. dynamite \n 3. Spiderman \n \n Pick you favorite word in this list using 1 - 4:");
            string[] listArray = { "Banana", "Hot air balloon", "dynamite", "Spiderman" };
            int wordIn = Convert.ToInt32(Console.ReadLine());

            if (wordIn < 4)
            {

                Console.WriteLine(listArray[wordIn]);
            }
            else
            {
                Console.WriteLine("The submitted number is not listed. Goodbye");
            }

            Console.ReadLine();

        }
    }
}
