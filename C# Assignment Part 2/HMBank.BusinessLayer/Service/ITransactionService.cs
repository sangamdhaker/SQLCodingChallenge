using HMBank.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMBank.BusinessLayer.Service
{
    public interface ITransactionService
    {
        void RecordTransaction(Transaction transaction);
        IEnumerable<Transaction> RetrieveTransactions(int accountId);
    }
}
