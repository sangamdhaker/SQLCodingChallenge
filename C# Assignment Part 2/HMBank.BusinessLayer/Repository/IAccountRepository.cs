using HMBank.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMBank.BusinessLayer.Repository
{
    public interface IAccountRepository
    {
        void AddAccount(Account account);
        Account GetAccountById(int accountId);
        IEnumerable<Account> GetAllAccounts();
    }
}
