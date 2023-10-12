using DemoBankingApp.Core.Models;
using DemoBankingApp.Core.Repositories;

namespace DemoBankingApp.Core.Services
{
    public class TransactionsService
    {

        private AccountsList accountService = new AccountsList();
        public TransactionsService()
        {
            ManageAccountService accountService= new ManageAccountService();
        }

        
        //Deposit

        public void DepositMoney(decimal amount, int accountId)
        {
            bool IsCreditAllowed = false;
         
            foreach (var bankAccount in accountService.GetBankAccounts())
            {
                if (bankAccount.AccountId == accountId)
                {
                    bankAccount.Balance += amount;
                    IsCreditAllowed = true;
                    GetBalance(accountId);
                    break;
                }
            }
            if (!IsCreditAllowed)
            {
                Console.WriteLine("account is not found the Credit/Debit request is declined");

            }


        }

        //Withdraw

        public void WithdrawMoney(decimal amount, int accountId)
        {
            bool IsDebitAllowed = false;

            foreach (var bankAccount in accountService.GetBankAccounts())
                if (bankAccount.AccountId == accountId)
                {
                    bankAccount.Balance -= amount;
                    IsDebitAllowed = true;
                    break;

                }

                if (!IsDebitAllowed)
                {
                    Console.WriteLine("account is not found the Credit/Debit request is declined");
                }
         }

        //See Balance

        public void GetBalance(int accountId)
        {
            bool IsAccountFound = false;

            foreach (var bankAccount in accountService.GetBankAccounts())
                if (bankAccount.AccountId == accountId)
                {

                    Console.WriteLine($"Current Balance: {bankAccount.Balance}");
                    IsAccountFound = true;
                    break;
                }
            if (!IsAccountFound)
            {
                Console.WriteLine("account is not found the Credit/Debit request is declined");
            }
        }
    }
}
