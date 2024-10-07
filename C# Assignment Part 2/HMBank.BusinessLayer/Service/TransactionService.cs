using HMBank.BusinessLayer.Repository;
using HMBank.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMBank.BusinessLayer.Service
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository transactionRepository;

        public TransactionService(ITransactionRepository transactionRepo)
        {
            transactionRepository = transactionRepo;
        }

        public void RecordTransaction(Transaction transaction)
        {
            transactionRepository.AddTransaction(transaction);
        }

        public IEnumerable<Transaction> RetrieveTransactions(int accountId)
        {
            return transactionRepository.GetTransactionsByAccountId(accountId);
        }
    }
}
