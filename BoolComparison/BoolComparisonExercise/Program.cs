using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoolComparisonExercise
{
    class Program
    {
        static void Main(string[] args)
        {


            //Guess that Letter start
            {
                Console.WriteLine("Try you luck.");
                Console.WriteLine();
                Console.WriteLine("Guess a letter");
                string Letter = Console.ReadLine();
                bool guessedLetter = Letter == "x";


                do
                {
                    switch (Letter)
                    {
                        case "a":
                            Console.WriteLine("A is for alligato but its not the right letter. Guess again.");
                            Letter = Console.ReadLine();
                            break;

                        case "x":
                            Console.WriteLine("X marks the spot! You are correct!!!!!!");
                            guessedLetter = true;
                            break;

                        default:
                            Console.WriteLine("That is not the right letter. Please guess again.");
                            Letter = Console.ReadLine();
                            break;
                    }
                }
                while (!guessedLetter);
                Console.ReadLine();
            }
            //Guess that Letter end


            {
                Console.WriteLine("Round two. Guess this two digit number");
                int number = Convert.ToInt32(Console.ReadLine());
                bool guessedNumber = number == 12;

                while (!guessedNumber)
                    {
                    switch(number)
                    {

                        case 19:
                            Console.WriteLine("Close. The number we are looking for is lower.");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;

                        case 5:
                            Console.WriteLine("The number you chose is too low. Try again. ");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;

                        case 12:
                            Console.WriteLine("That is it! Great Job.");
                            guessedNumber = true;
                            break;

                        default:
                            Console.WriteLine("That is not the right number. Please try again.");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;
                    }
                }


                Console.ReadLine();
            }

        }
    }
}
