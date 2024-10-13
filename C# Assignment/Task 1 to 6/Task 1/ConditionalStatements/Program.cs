using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input data
            Console.Write("Enter your credit score: ");
            int creditScore = int.Parse(Console.ReadLine());

            Console.Write("Enter your annual income: $");
            double annualIncome = double.Parse(Console.ReadLine());

            // Check loan eligibility
            if (creditScore > 700 && annualIncome >= 50000)
            {
                Console.WriteLine("You are eligible for a loan.");
            }
            else
            {
                Console.WriteLine("You are not eligible for a loan.");
            }
        }
    }
}
