using DemoBankingApp.Core.Models;

namespace DemoBankingApp.Core.Services
{
    public class ManageAccountService : IManageAccountService
    {
        ExistingAccounts existingAccount = new ExistingAccounts();
        public IDictionary<string, BankAccount>? CreateNewAccount(int id, string name, decimal initialBalance)
        {
            Random random = new Random();
            BankAccount bankAccount = new BankAccount
            {
                AccountId = id,
                AccountName = name,
                Balance = initialBalance,
                SortCode = random.Next(100000, 900000),
                AccountNumber = random.Next(100000,900000),
                SecruityCode = random.Next(100,900)
            };

            var account = existingAccount.BankAccounts;
            account?.Add(name, bankAccount);

            return account;
        }

    }
}
