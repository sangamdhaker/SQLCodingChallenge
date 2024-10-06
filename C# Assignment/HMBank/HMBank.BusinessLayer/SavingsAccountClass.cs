using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMBank.Entity;

namespace HMBank.BusinessLayer
{
    public class SavingsAccounts : Account
    {
        private const float InterestRate = 0.045f;

        public SavingsAccounts(long accountNumber, float balance)
            : base(accountNumber, "Savings", balance) { }

        public override void CalculateInterest()
        {
            float interest = Balance * InterestRate;
            Balance += interest;
            Console.WriteLine($"Interest added: {interest}. New balance: {Balance}");
        }
    }
    public class SavingsAccount : BankAccount
    {
        public float InterestRate { get; set; }

        public SavingsAccount(long accountNumber, Customers customer, float balance, float interestRate)
            : base(accountNumber, customer, balance)
        {
            InterestRate = interestRate;
        }

        public override void Deposit(float amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited {amount}. New balance: {Balance}");
        }

        public override void Withdraw(float amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrew {amount}. New balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }

        public override void CalculateInterest()
        {
            float interest = Balance * (InterestRate / 100);
            Balance += interest;
            Console.WriteLine($"Interest of {interest} added. New balance: {Balance}");
        }
    }
}
