using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMBank.Entity
{
    internal class Transactions
    {
        public long TransactionId { get; set; }
        public long AccountNumber { get; set; }
        public string TransactionType { get; set; } 
        public float Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public float BalanceAfterTransaction { get; set; }
    }
}
