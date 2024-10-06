using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMBank.Entity;

namespace HMBank.BusinessLayer
{
    public class Account
    {
        private static long lastAccNo = 1000;
        public long AccountNumber { get; set; }
        public string AccountType { get; set; }
        public float Balance { get; set; }
        public Customers Customer { get; set; }

        // Default constructor
        public Account() { }

        // Constructor with parameters
        public Account(long accountNumber, string accountType, float balance)
        {
            AccountNumber = accountNumber;
            AccountType = accountType;
            Balance = balance;
        }

        // Deposit methods
        public void Deposit(float amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited {amount}. New balance: {Balance}");
        }

        public void Deposit(int amount)
        {
            Deposit((float)amount);
        }

        public void Deposit(double amount)
        {
            Deposit((float)amount);
        }

        // Withdraw methods
        public bool Withdraw(float amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrew {amount}. New balance: {Balance}");
                return true;
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
                return false;
            }
        }

        public bool Withdraw(int amount)
        {
            return Withdraw((float)amount);
        }

        public bool Withdraw(double amount)
        {
            return Withdraw((float)amount);
        }

        // Calculate interest method
        public virtual void CalculateInterest()
        {
            // Default implementation (if any)
        }

        // Print account details
        public void PrintAccountDetails()
        {
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Account Type: {AccountType}");
            Console.WriteLine($"Balance: {Balance}");
            Console.WriteLine($"Customer: {Customer.FirstName} {Customer.LastName}");
        }
        public Account(string accountType, float initialBalance, Customers customer)
        {
            AccountNumber = ++lastAccNo; // Increment and assign account number
            AccountType = accountType;
            Balance = initialBalance;
            Customer = customer;
        }

       
        
        }

       
    }




