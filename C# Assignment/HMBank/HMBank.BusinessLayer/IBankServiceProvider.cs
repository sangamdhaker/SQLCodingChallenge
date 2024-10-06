using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMBank.Entity;

namespace HMBank.BusinessLayer
{
    public interface IBankServiceProvider : ICustomerServiceProvider
    {
        long CreateAccount(Customers customer, string accountType, float initialBalance);
        Account[] ListAccounts();
    }
}
