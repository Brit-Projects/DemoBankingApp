using DemoBankingApp.Core.Models;


namespace DemoBankingApp.Core.Services
{
    public class TransactionsService
    {

        private ManageAccountService accountService;
        public TransactionsService()
        {
            ManageAccountService accountService= new ManageAccountService();
        }

        
        //Deposit

        public void DepositMoney(decimal amount, int accountId)
        {
            bool IsCreditAllowed = false;
         
            foreach (KeyValuePair<int, BankAccount> pair in accountService.existingAccount.BankAccounts)
            {
                if (pair.Key == accountId)
                {
                    pair.Value.Balance += amount;
                    IsCreditAllowed = true;
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

            foreach (KeyValuePair<int, BankAccount> pair in accountService.existingAccount.BankAccounts)
                if (pair.Key == accountId)
                {
                    pair.Value.Balance -= amount;
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

            foreach (KeyValuePair<int, BankAccount> pair in accountService.existingAccount.BankAccounts)
                if (pair.Key == accountId)
                {

                    Console.WriteLine($"Current Balance: {pair.Value.Balance}");
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
