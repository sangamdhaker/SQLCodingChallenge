using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMBank.Entity;

namespace HMBank.BusinessLayer
{
    public class Transaction
    {
        public long TransactionId { get; set; }
        public long AccountNumber { get; set; }
        public string TransactionType { get; set; }
        public float Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public float BalanceAfterTransaction { get; set; }

        public Transaction() { }

        public Transaction(long transactionId, long accountNumber, string transactionType, float amount, DateTime transactionDate, float balanceAfterTransaction)
        {
            TransactionId = transactionId;
            AccountNumber = accountNumber;
            TransactionType = transactionType;
            Amount = amount;
            TransactionDate = transactionDate;
            BalanceAfterTransaction = balanceAfterTransaction;
        }

        public void PrintTransactionDetails()
        {
            Console.WriteLine($"Transaction ID: {TransactionId}");
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Transaction Type: {TransactionType}");
            Console.WriteLine($"Amount: {Amount}");
            Console.WriteLine($"Balance After Transaction: {BalanceAfterTransaction}");
            Console.WriteLine($"Transaction Date: {TransactionDate}");
        }
    }
}
