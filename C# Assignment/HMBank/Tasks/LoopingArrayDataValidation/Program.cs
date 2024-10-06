using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopingArrayDataValidation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> accounts = new Dictionary<string, double>
        {
            { "1001", 1500.50 },
            { "1002", 2500.75 },
            { "1003", 3200.30 }
        };

            while (true)
            {
                Console.Write("\nEnter your account number (or 'exit' to quit): ");
                string accountNumber = Console.ReadLine();

                if (accountNumber.ToLower() == "exit")
                {
                    Console.WriteLine("Exiting... Goodbye!");
                    break;
                }

                if (accounts.ContainsKey(accountNumber))
                {
                    Console.WriteLine($"Account balance: ${accounts[accountNumber]:F2}");
                }
                else
                {
                    Console.WriteLine("Invalid account number! Please try again.");
                }
            }
        }
    }
}
