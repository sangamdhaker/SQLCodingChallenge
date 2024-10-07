using HMBank.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMBank.BusinessLayer.Repository
{
    public interface ITransactionRepository
    {
        void AddTransaction(Transaction transaction);
        IEnumerable<Transaction> GetTransactionsByAccountId(int accountId);
    }
}
