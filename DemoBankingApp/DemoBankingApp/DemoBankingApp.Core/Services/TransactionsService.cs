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
        bool IsAccountFound = false;
        
        //Deposit

        public void DepositMoney(decimal amount, int accountId)
        {
            foreach (KeyValuePair<int, BankAccount> pair in accountService.existingAccount.BankAccounts)
            {
                if (pair.Key == accountId)
                {
                    pair.Value.Balance += amount;
                    IsAccountFound = true;
                    break;
                }

            }


        }

        //Withdraw

        public void WithdrawMoney(decimal amount, int accountId)
        {
            foreach (KeyValuePair<int, BankAccount> pair in accountService.existingAccount.BankAccounts)
                if (pair.Key == accountId)
                {
                    pair.Value.Balance -= amount;
                    IsAccountFound = true;
                    break;

                }

            if (IsAccountFound == false)
            {
                Console.WriteLine("Account not found. Please create a new Bank Account");

            }


        }

        //See Balance

        public void GetBalance(int accountId)
        {
            foreach (KeyValuePair<int, BankAccount> pair in accountService.existingAccount.BankAccounts)
                if (pair.Key == accountId)
                {

                    Console.WriteLine($"Current Balance: {pair.Value.Balance}");
                    IsAccountFound = true;
                    break;
                }


            if (IsAccountFound == false)
            {
                Console.WriteLine("Account not found. Please create a new Bank Account");

            }


        }
    }
}