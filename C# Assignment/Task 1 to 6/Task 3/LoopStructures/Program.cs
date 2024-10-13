using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopStructures
{
    internal class Program
    {
        static double CalculateFutureBalance(double initialBalance, double annualInterestRate, int years)
        {
            return initialBalance * Math.Pow(1 + (annualInterestRate / 100), years);
        }

        static void Main()
        {
            Console.Write("Enter number of customers: ");
            int numCustomers = int.Parse(Console.ReadLine());

            for (int i = 0; i < numCustomers; i++)
            {
                Console.Write("\nEnter initial balance: $");
                double initialBalance = double.Parse(Console.ReadLine());

                Console.Write("Enter annual interest rate (%): ");
                double annualInterestRate = double.Parse(Console.ReadLine());

                Console.Write("Enter number of years: ");
                int years = int.Parse(Console.ReadLine());

                double futureBalance = CalculateFutureBalance(initialBalance, annualInterestRate, years);
                Console.WriteLine($"Future balance after {years} years: ${futureBalance:F2}");
            }
        }
    }
}
