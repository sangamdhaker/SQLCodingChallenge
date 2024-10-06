using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMBank.Entity;

namespace HMBank.BusinessLayer
{
    public class BankServiceProviderImpl : CustomerServiceProviderImpl, IBankServiceProvider
    {
        private const int MaxAccounts = 100;
        private Account[] accountList = new Account[MaxAccounts];
        private int accountCount = 0;

        public long CreateAccount(Customers customer, string accountType, float initialBalance)
        {
            Account newAccount = null;

            switch (accountType)
            {
                case "Savings":
                    newAccount = new SavingsAccounts(customer, initialBalance);
                    break;
                case "Current":
                    newAccount = new CurrentAccount(initialBalance, customer);
                    break;
                case "Zero Balance":
                    newAccount = new ZeroBalanceAccount(customer);
                    break;
                default:
                    Console.WriteLine("Invalid account type.");
                    return 0;
            }

            accountDictionary[newAccount.AccountNumber] = newAccount;
            if (accountCount < MaxAccounts)
            {
                accountList[accountCount++] = newAccount;
            }
            return newAccount.AccountNumber;
        }

        public Account[] ListAccounts()
        {
            return accountList;
        }
    }
}
