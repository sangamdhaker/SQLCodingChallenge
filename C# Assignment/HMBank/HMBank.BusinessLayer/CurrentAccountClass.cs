using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMBank.Entity;

namespace HMBank.BusinessLayer
{
    public class CurrentAccount : BankAccount
    {
        public const float OverdraftLimit = 1000f;

        public CurrentAccount(long accountNumber, Customers customer, float balance)
            : base(accountNumber, customer, balance)
        {
        }

        public override void Deposit(float amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited {amount}. New balance: {Balance}");
        }

        public override void Withdraw(float amount)
        {
            if (Balance + OverdraftLimit >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrew {amount}. New balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Overdraft limit exceeded.");
            }
        }

        public override void CalculateInterest()
        {
            // No interest for current accounts
        }
        public class CurrentAccounts : Account
        {
            private const float OverdraftLimit = 500; // Example limit

            public CurrentAccounts(long accountNumber, float balance)
                : base(accountNumber, "Current", balance) { }

            public new bool Withdraw(float amount)
            {
                if (Balance + OverdraftLimit >= amount)
                {
                    Balance -= amount;
                    Console.WriteLine($"Withdrew {amount}. New balance: {Balance}");
                    return true;
                }
                else
                {
                    Console.WriteLine("Overdraft limit exceeded.");
                    return false;
                }
            }
        }
    }
}

