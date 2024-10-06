using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMBank.Entity
{
    internal class Accounts
    {
        public long AccountNumber { get; set; }
        public string AccountType { get; set; }  
        public float Balance { get; set; }
        public Customers Customers { get; set; }
    }
}
