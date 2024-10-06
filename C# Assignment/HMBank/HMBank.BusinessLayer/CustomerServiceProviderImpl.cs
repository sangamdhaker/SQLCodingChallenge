using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMBank.Entity;

namespace HMBank.BusinessLayer
{
    public class CustomerServiceProviderImpl : ICustomerServiceProvider
    {
        protected Dictionary<long, Account> accountDictionary = new Dictionary<long, Account>();

        public float GetAccountBalance(long accountNumber)
        {
            if (accountDictionary.ContainsKey(accountNumber))
            {
                return accountDictionary[accountNumber].Balance;
            }
            Console.WriteLine("Account number not found.");
            return 0;
        }

        public void Deposit(long accountNumber, float amount)
        {
            if (accountDictionary.ContainsKey(accountNumber))
            {
                accountDictionary[accountNumber].Deposit(amount);
            }
            else
            {
                Console.WriteLine("Account number not found.");
            }
        }

        public bool Withdraw(long accountNumber, float amount)
        {
            if (accountDictionary.ContainsKey(accountNumber))
            {
                return accountDictionary[accountNumber].Withdraw(amount);
            }
            Console.WriteLine("Account number not found.");
            return false;
        }

        public void Transfer(long fromAccountNumber, long toAccountNumber, float amount)
        {
            if (accountDictionary.ContainsKey(fromAccountNumber) && accountDictionary.ContainsKey(toAccountNumber))
            {
                if (Withdraw(fromAccountNumber, amount))
                {
                    Deposit(toAccountNumber, amount);
                    Console.WriteLine($"Transferred {amount} from account {fromAccountNumber} to {toAccountNumber}.");
                }
            }
            else
            {
                Console.WriteLine("One or both account numbers not found.");
            }
        }

        public string GetAccountDetails(long accountNumber)
        {
            if (accountDictionary.ContainsKey(accountNumber))
            {
                return $"Account Number: {accountDictionary[accountNumber].AccountNumber}, Balance: {accountDictionary[accountNumber].Balance}";
            }
            return "Account number not found.";
        }
    }
}
