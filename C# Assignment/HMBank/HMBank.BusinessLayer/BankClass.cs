using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMBank.Entity;

namespace HMBank.BusinessLayer
{
    public class Bank
    {
        private List<BankAccount> accounts = new List<BankAccount>();
        private long accountNumberCounter = 1001;
        private List<Transaction> transactions = new List<Transaction>();
        

        // Create account
        public void CreateAccount(Customers customer, string accountType, float initialBalance, float interestRate = 0)
        {
            BankAccount newAccount = null;

            if (accountType.ToLower() == "savings")
            {
                newAccount = new SavingsAccount(accountNumberCounter++, customer, initialBalance, interestRate);
            }
            else if (accountType.ToLower() == "current")
            {
                newAccount = new CurrentAccount(accountNumberCounter++, customer, initialBalance);
            }
            else
            {
                Console.WriteLine("Invalid account type.");
                return;
            }

            accounts.Add(newAccount);
            Console.WriteLine("Account created successfully!");
        }

        // Deposit money
        public void Deposit(long accountNumber, float amount)
        {
            var account = accounts.FirstOrDefault(a => a.AccountNumber == accountNumber);
            if (account != null)
            {
                account.Deposit(amount);
            }
            else
            {
                Console.WriteLine("Account not found.");
            }
        }

        // Withdraw money
        public void Withdraw(long accountNumber, float amount)
        {
            var account = accounts.FirstOrDefault(a => a.AccountNumber == accountNumber);
            if (account != null)
            {
                account.Withdraw(amount);
            }
            else
            {
                Console.WriteLine("Account not found.");
            }
        }

        // Transfer money between accounts
        public void Transfer(long fromAccountNumber, long toAccountNumber, float amount)
        {
            var fromAccount = accounts.FirstOrDefault(a => a.AccountNumber == fromAccountNumber);
            var toAccount = accounts.FirstOrDefault(a => a.AccountNumber == toAccountNumber);

            if (fromAccount != null && toAccount != null)
            {
                fromAccount.Withdraw(amount);
                toAccount.Deposit(amount);
                Console.WriteLine($"Transferred {amount} from account {fromAccount.AccountNumber} to account {toAccount.AccountNumber}");
            }
            else
            {
                Console.WriteLine("Account(s) not found.");
            }
        }

        // Get account details
        public void GetAccountDetails(long accountNumber)
        {
            var account = accounts.FirstOrDefault(a => a.AccountNumber == accountNumber);
            if (account != null)
            {
                account.PrintAccountDetails();
            }
            else
            {
                Console.WriteLine("Account not found.");
            }
        }

        public void PerformBankingOperations()
        {
            // Display menu for creating accounts
            Console.WriteLine("Choose account type:");
            Console.WriteLine("1. Savings Account");
            Console.WriteLine("2. Current Account");
            Console.Write("Enter choice: ");
            string choice = Console.ReadLine();

            Console.Write("Enter account number: ");
            long accountNumber = long.Parse(Console.ReadLine());
            Console.Write("Enter initial balance: ");
            float initialBalance = float.Parse(Console.ReadLine());

            Account account = null;

            switch (choice)
            {
                case "1":
                    account = new SavingsAccounts(accountNumber, initialBalance);
                    break;
         
                default:
                    Console.WriteLine("Invalid choice.");
                    return;
            }

            // Example operations
            account.PrintAccountDetails();

            Console.Write("Deposit amount: ");
            float depositAmount = float.Parse(Console.ReadLine());
            account.Deposit(depositAmount);

            Console.Write("Withdraw amount: ");
            float withdrawAmount = float.Parse(Console.ReadLine());
            account.Withdraw(withdrawAmount);

            if (account is SavingsAccounts savingsAccount)
            {
                savingsAccount.CalculateInterest();
            }
        }
    }

}


