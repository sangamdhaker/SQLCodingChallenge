using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMBank.Entity;
using HMBank.BusinessLayer;
using Customers = HMBank.BusinessLayer.Customers;

namespace HMBank.UI
{
        class HMBank
        {
            static void Main(string[] args)
            {
                Bank bank = new Bank();
                bank.PerformBankingOperations();
                BankServiceProviderImpl bankService = new BankServiceProviderImpl();
                bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Get Balance");
                Console.WriteLine("5. Transfer");
                Console.WriteLine("6. Get Account Details");
                Console.WriteLine("7. List Accounts");
                Console.WriteLine("8. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        // Create account
                        Console.Write("Enter customer details (ID, First Name, Last Name, Email, Phone, Address): ");
                        var customerDetails = Console.ReadLine().Split(',');
                        var customer = new Customers(int.Parse(customerDetails[0].Trim()), customerDetails[1].Trim(), customerDetails[2].Trim(), customerDetails[3].Trim(), customerDetails[4].Trim(), customerDetails[5].Trim());

                        Console.Write("Enter account type (Savings, Current, Zero Balance): ");
                        string accountType = Console.ReadLine();
                        Console.Write("Enter initial balance: ");
                        float initialBalance = float.Parse(Console.ReadLine());

                        long accNo = bankService.CreateAccount(customer, accountType, initialBalance);
                        Console.WriteLine($"Account created with number: {accNo}");
                        break;

                    case "2":
                        Console.Write("Enter account number: ");
                        long depositAccNo = long.Parse(Console.ReadLine());
                        Console.Write("Enter amount to deposit: ");
                        float depositAmount = float.Parse(Console.ReadLine());
                        bankService.Deposit(depositAccNo, depositAmount);
                        break;
                    case "3":
                        Console.Write("Enter account number: ");
                        long withdrawAccNo = long.Parse(Console.ReadLine());
                        Console.Write("Enter amount to withdraw: ");
                        float withdrawAmount = float.Parse(Console.ReadLine());
                        bankService.Withdraw(withdrawAccNo, withdrawAmount);
                        break;

                    case "4":
                        Console.Write("Enter account number: ");
                        long balanceAccNo = long.Parse(Console.ReadLine());
                        float balance = bankService.GetAccountBalance(balanceAccNo);
                        Console.WriteLine($"Account Balance: {balance}");
                        break;

                    case "5":
                        Console.Write("Enter from account number: ");
                        long fromAccNo = long.Parse(Console.ReadLine());
                        Console.Write("Enter to account number: ");
                        long toAccNo = long.Parse(Console.ReadLine());
                        Console.Write("Enter amount to transfer: ");
                        float transferAmount = float.Parse(Console.ReadLine());
                        bankService.Transfer(fromAccNo, toAccNo, transferAmount);
                        break;

                    case "6":
                        Console.Write("Enter account number: ");
                        long detailsAccNo = long.Parse(Console.ReadLine());
                        Console.WriteLine(bankService.GetAccountDetails(detailsAccNo));
                        break;

                    case "7":
                        Console.WriteLine("Accounts List:");
                        var accounts = bankService.ListAccounts();
                        foreach (var account in accounts)
                        {
                            if (account != null)
                                account.PrintAccountDetails();
                        }
                        break;

                    case "8":
                        exit = true;
                        Console.WriteLine("Exiting the system. Thank you!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }
        }
    }
}


