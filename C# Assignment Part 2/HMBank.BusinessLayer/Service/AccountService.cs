using HMBank.BusinessLayer.Repository;
using HMBank.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMBank.BusinessLayer.Service
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository accountRepository;

        public AccountService(IAccountRepository accountRepo)
        {
            accountRepository = accountRepo;
        }

        public void CreateAccount(Account account)
        {
            accountRepository.AddAccount(account);
        }

        public Account GetAccount(int accountId)
        {
            return accountRepository.GetAccountById(accountId);
        }

        public IEnumerable<Account> GetAllAccounts()
        {
            return accountRepository.GetAllAccounts();
        }
    }
}
