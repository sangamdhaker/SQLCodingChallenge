using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMBank.Entity;
using System;

namespace HMBank.BusinessLayer
{
    public abstract class BankAccount
    {
        public long AccountNumber { get; set; }
        public Customers Customer { get; set; }
        public float Balance { get; set; }

        // Constructor
        public BankAccount(long accountNumber, Customers customer, float balance)
        {
            AccountNumber = accountNumber;
            Customer = customer;
            Balance = balance;
        }

        // Abstract methods
        public abstract void Deposit(float amount);
        public abstract void Withdraw(float amount);
        public abstract void CalculateInterest();

        // Method to print account details
        public void PrintAccountDetails()
        {
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Customer Name: {Customer.FirstName} {Customer.LastName}");
            Console.WriteLine($"Balance: {Balance}");
        }
    }
}

