using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator
{
    internal class Operator3
    {
        //Develop a program to decide whether number is negative or positive using Ternary operator.
        static void Main()
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            string result = (number > 0) ? "The number is positive." :
                            (number < 0) ? "The number is negative." :
                            "The number is zero.";

            Console.WriteLine(result);
        }
    }
}
