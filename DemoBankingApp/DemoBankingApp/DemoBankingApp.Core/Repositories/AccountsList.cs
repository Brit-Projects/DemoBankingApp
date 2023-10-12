using DemoBankingApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBankingApp.Core.Repositories
{
    public class AccountsList
    {
        List<BankAccount> bankAccounts = new List<BankAccount>

        {
            new BankAccount{ UserId= 1, AccountName = "Linda Belcher", AccountId = 1, AccountNumber = 01012563, Balance = 0 },
            new BankAccount{ UserId= 1, AccountName = "Linda Belcher", AccountId = 2, AccountNumber = 01018596, Balance = 50},

            new BankAccount{ UserId = 2,AccountName = "Bob Belcher", AccountId = 3, AccountNumber = 02028596, Balance = 100 }
        };

        public List<BankAccount> GetBankAccounts()
        {
            return bankAccounts;
        }
    }

    
}
