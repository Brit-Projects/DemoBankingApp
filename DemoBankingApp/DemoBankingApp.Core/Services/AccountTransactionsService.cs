using DemoBankingApp.Core.Models;


namespace DemoBankingApp.Core.Services
{
    public class AccountTransactionsService
    {

        BankAccount _bankAccount = new BankAccount();
        decimal Money;
        

        public AccountTransactionsService()
        {
            Money = (decimal)_bankAccount.Balance;
        }

        
        //Deposit

        public void DepositMoney(decimal amount)
        {
            
            Money += amount;
            

        }

        //Withdraw

        public void WithdrawMoney(decimal amount)
        {
            Money -= amount;
        }

        //See Balance

        public void GetBalance()
        {
            Console.WriteLine($"Current Balance: {Money}");
        }
    }
}