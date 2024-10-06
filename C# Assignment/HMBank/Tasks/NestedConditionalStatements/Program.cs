using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedConditionalStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balance = 1000.00;  
            Console.WriteLine("Welcome to the ATM!");

            while (true)
            {
                Console.WriteLine("\nOptions:");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Deposit");
                Console.WriteLine("4. Exit");

                Console.Write("Enter option number: ");
                int option = int.Parse(Console.ReadLine());

                if (option == 1)
                {
                    Console.WriteLine($"Your current balance is: ${balance:F2}");
                }
                else if (option == 2)
                {
                    Console.Write("Enter amount to withdraw: $");
                    double withdrawalAmount = double.Parse(Console.ReadLine());

                    if (withdrawalAmount > balance)
                    {
                        Console.WriteLine("Insufficient balance!");
                    }
                    else if (withdrawalAmount % 100 != 0 && withdrawalAmount % 500 != 0)
                    {
                        Console.WriteLine("Withdrawal amount must be in multiples of 100 or 500!");
                    }
                    else
                    {
                        balance -= withdrawalAmount;
                        Console.WriteLine($"Withdrawal successful! New balance: ${balance:F2}");
                    }
                }
                else if (option == 3)
                {
                    Console.Write("Enter amount to deposit: $");
                    double depositAmount = double.Parse(Console.ReadLine());
                    balance += depositAmount;
                    Console.WriteLine($"Deposit successful! New balance: ${balance:F2}");
                }
                else if (option == 4)
                {
                    Console.WriteLine("Exiting ATM. Thank you for using our service!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option, please try again.");
                }
            }
        }
    }
}
