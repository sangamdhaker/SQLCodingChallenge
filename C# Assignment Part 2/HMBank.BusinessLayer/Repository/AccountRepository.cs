using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMBank.Entity;


namespace HMBank.BusinessLayer.Repository
{
        public class AccountRepository : IAccountRepository
        {
            private List<Account> accounts = new List<Account>();

            public void AddAccount(Account account)
            {
                accounts.Add(account);
            }

            public Account GetAccountById(int accountId)
            {
                return accounts.FirstOrDefault(a => a.AccountId == accountId);
            }

            public IEnumerable<Account> GetAllAccounts()
            {
                return accounts;
            }
        }
    
}
