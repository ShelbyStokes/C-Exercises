using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerCruncherExercise
{
    public class integerManipulation
    {
        public static int Multiply(int userNumber)
            //Above class asked for return "int multiply" Then input into method "int userNumber". userNumber is delcared and only relevant within the below context. 
        {
            Console.WriteLine("Your number will now be multipied by 100");
            int usernumMult = userNumber * 100;
            Console.WriteLine("The results is " + usernumMult + "\n");
            return usernumMult;
        }
        public static int Add(int UserNumberTwo)
        {
            Console.WriteLine("Your number will now have 50 added to it");
            int usernumAdd = UserNumberTwo + 50;
            Console.WriteLine("The results is " + usernumAdd + "\n");
            return usernumAdd;
        }
        public static int Divid(int UserNumberThree)
        {
            Console.WriteLine("Your number will now be divided by 5");
            int usernumDivid = UserNumberThree / 5;
            Console.WriteLine("The results is " + usernumDivid + "\n");
            return usernumDivid;
        }



    }

}
