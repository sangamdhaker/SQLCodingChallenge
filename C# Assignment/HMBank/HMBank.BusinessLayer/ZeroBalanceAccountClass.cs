using HMBank.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMBank.BusinessLayer
{
        public class ZeroBalanceAccount : Account
        {
            public ZeroBalanceAccount(Customers customer): base("Zero Balance", 0, customer) { }
        }
    }
