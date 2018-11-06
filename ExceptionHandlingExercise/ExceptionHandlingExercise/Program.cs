using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Create a list of integers. Ask the user for a number to divide each number in the list by. 
            //Write a loop that takes each integer in the list, divides it by the number the user entered, and displays the result to the screen.

            //List<int> numbers = new List<int>() { 6, 5, 4, 9, 10, 11, 15 };
            //Console.WriteLine("Enter a number");
            //decimal userNum = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    decimal displayNumb = numbers[i] / userNum;
            //    Console.WriteLine("{0} divided by {1} is {2}", numbers[i], userNum, displayNumb);
            //}
            //Console.ReadLine();

            //2. Run that code, entering in non-zero numbers as the user. Look at the displayed results.
            //3.Run that code, entering in zero as the number to divide by. Note any error messages you get.
            //4.Run that code, entering in a string as the number to divide by. Note any error messages you get.

            //5.Now put the loop in a try/catch block. Below and outside of the try/catch block, make the program 
            //display a message to the display to let you know the program has emerged from the try/catch block
            //and continued on with program execution. In the catch block, display the error message to the screen. 
            //Then try various combinations of user input: valid numbers, zero and a string. Ensure the proper error 
            //messages display on the screen, and that the code after the try/catch block gets executed.

            try
            {

                List<int> numbers = new List<int>() { 6, 5, 4, 9, 10, 11, 15 };
                Console.WriteLine("Enter a number");
                decimal userNum = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < numbers.Count; i++)
                {
                    decimal displayNumb = numbers[i] / userNum;
                    Console.WriteLine("{0} divided by {1} is {2}", numbers[i], userNum, displayNumb);
                }
                Console.ReadLine();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("A number cannot be divided by zero");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please be sure to enter a number");
            }
            finally
            {
                Console.WriteLine("We are now in the finally.");
                Console.ReadLine();
            }
            Console.WriteLine("We are out of the finally.");
            Console.ReadLine();
        }
    }
}
