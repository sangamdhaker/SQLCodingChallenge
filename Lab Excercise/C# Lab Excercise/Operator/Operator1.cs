using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator
{
    internal class Operator1
    {

        /*Develop a program to decide grade according by taking percentage as input from user using 
        If-else if-else. (70>"A" | 60>"B" | 50>"C" | 40>"D")*/

        static void Main()
        {
            Console.Write("Enter your percentage: ");
            float percentage = Convert.ToSingle(Console.ReadLine());

            if (percentage >= 70)
            {
                Console.WriteLine("Grade: A");
            }
            else if (percentage >= 60)
            {
                Console.WriteLine("Grade: B");
            }
            else if (percentage >= 50)
            {
                Console.WriteLine("Grade: C");
            }
            else if (percentage >= 40)
            {
                Console.WriteLine("Grade: D");
            }
            else
            {
                Console.WriteLine("Grade: F");
            }
        }
    }
}
