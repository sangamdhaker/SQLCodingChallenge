using HMBank.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMBank.BusinessLayer.Service
{
    public interface IAccountService
    {
        void CreateAccount(Account account);
        Account GetAccount(int accountId);
        IEnumerable<Account> GetAllAccounts();
    }
}
