using HMBank.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMBank.BusinessLayer.Repository
{
    public class TransactionRepository : ITransactionRepository
    {
        private List<Transaction> transactions = new List<Transaction>();

        public void AddTransaction(Transaction transaction)
        {
            transactions.Add(transaction);
        }

        public IEnumerable<Transaction> GetTransactionsByAccountId(int accountId)
        {
            return transactions.Where(t => t.AccountId == accountId);
        }
    }
}
