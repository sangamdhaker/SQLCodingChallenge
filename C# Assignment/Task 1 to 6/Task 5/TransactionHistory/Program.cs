using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionHistory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> transactionHistory = new List<string>();

            while (true)
            {
                Console.WriteLine("\nEnter a transaction (type 'exit' to stop): ");
                string transaction = Console.ReadLine();

                if (transaction.ToLower() == "exit")
                {
                    Console.WriteLine("\nTransaction History:");
                    foreach (var entry in transactionHistory)
                    {
                        Console.WriteLine(entry);
                    }
                    break;
                }
                else
                {
                    transactionHistory.Add(transaction);
                    Console.WriteLine("Transaction added.");
                }
            }
        }
    }
}
