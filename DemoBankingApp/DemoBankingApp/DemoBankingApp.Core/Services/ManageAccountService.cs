﻿using DemoBankingApp.Core.Models;
using DemoBankingApp.Core.Repositories;

namespace DemoBankingApp.Core.Services
{
    public class ManageAccountService : IManageAccountService
    {
        public ExistingAccounts existingAccount = new ExistingAccounts();
        public IDictionary<int, BankAccount>? CreateNewAccount(int userID, int id, string name, decimal initialBalance)
        {
            Random random = new Random();
           
            BankAccount bankAccount = new BankAccount
            {
                UserId = userID,
                AccountId = id,
                AccountName = name,
                Balance = initialBalance,
                SortCode = random.Next(100000, 900000),
                AccountNumber = random.Next(100000,900000),
                SecurityCode = random.Next(100,900)
            };

            var account = existingAccount.BankAccounts;
            account?.Add(id, bankAccount);

            return account;
        }

    }
}
