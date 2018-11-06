using System;

namespace Exercise165_ExceptionTry.Catch
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validAnswer = false;
            int userAge = 0;
            while (!validAnswer)
            {
                Console.WriteLine("Hello! Please enter how old you are:");
                validAnswer = int.TryParse(Console.ReadLine(), out userAge);
                if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals.");
            }


            try
            {


                if (userAge > 0)
                {
                    var today = DateTime.Today;
                    var age = today.Year - userAge;
                    Console.WriteLine("Based on the age you provided. You were probably born in {0}", age);
                }
                else
                {
                    throw new NegativeOrZero();
                }

            }

            catch (NegativeOrZero)
            {
                
                Console.WriteLine("Your input should be a possitve number");
                Console.ReadLine();
                return;

            }
            catch (Exception)
            {
                Console.WriteLine("The program experienced an error. Please contact the System Administrator.");
                Console.ReadLine();
                return;
            }

            Console.ReadLine();
        }
    }


    //The below is a number of code written and scralpped due to it not working... Come back and clean up if passed.  

    //if (userAge <= 0)
    //{
    //    Console.WriteLine("Your input should be a possitive number");
    //    Console.ReadLine();
    //    return;
    //}


    //catch (FormatException)
    //{
    //    Console.Write("Zero is not a valid age");
    //    Console.ReadLine();
    //    return;
    //}










    //1. Ask the user for his age.
    //2. Display the year user born.
    //3. Exceptions must be handled using "try .. catch".
    //4. Display appropriate error messages if user enters zero or negative numbers.
    //5. Display a general message if exception caused by anything else.
}
