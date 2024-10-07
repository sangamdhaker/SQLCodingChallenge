using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMBank.Entity
{
 
        public class Account
        {
            public int AccountId { get; set; }
            public int CustomerId { get; set; }
            public string AccountType { get; set; }
            public decimal Balance { get; set; }
        }
    
}
