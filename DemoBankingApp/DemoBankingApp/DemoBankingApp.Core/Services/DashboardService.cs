using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoBankingApp.Core;
using DemoBankingApp.Core.Models;
using DemoBankingApp.Core.Repositories;
using Stripe;

namespace DemoBankingApp.Core.Services
{
    public class DashboardService
    {
        public TransactionsService transactionsService = new TransactionsService();
        //AccountsList account = new AccountsList();

        //public DashboardService(TransactionsService transactionsService)
        //{
        //    this.transactionsService = transactionsService;
        //}

        public void DisplayDashboard(User user)
        {
            Console.WriteLine("Welcome to the Dashboard");

            Console.WriteLine("1. View accounts and make a Transaction");
            Console.WriteLine("2. Exit");

            int choice = GetUserChoice();

            switch (choice)
            {

                case 1:
                    DisplayUserBankAccounts(user);

                    break;

                case 2:
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;

            }


        }

        private int GetUserChoice()
        {
            Console.Write("Enter your choice: ");
            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                return choice;
            }

            return -1;
        }

        //private void ViewAccounts(User user)
        //{
        //    var accountsList = new AccountsList();
        //    var bankAccounts = accountsList.GetBankAccounts();

        //    var ccUserId = user.UserId;
            

        //    foreach (var account in bankAccounts)
        //    {
        //        if (account.UserId == ccUserId)
        //        {
        //            Console.WriteLine(account);
        //        }
        //    }
        //}


        private int GetUserChoiceTransactions()
        {
            Console.Write("Enter your choice: ");
            if (int.TryParse(Console.ReadLine(), out int choiceTransactions))
            {
                return choiceTransactions;
            }

            return -1;
        }

        private void MakeTransaction(int accountID)
        {

            Console.WriteLine("Select type of transaction");
            Console.WriteLine("1. Deposit Funds");
            Console.WriteLine("2. Withdraw Funds");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit)");

            int choiceTransactions = GetUserChoiceTransactions();
            int amount;
            


            switch (choiceTransactions)
            {
                case 1:
                    
                    Console.WriteLine("Please enter amount to deposit: ");
                    amount = Convert.ToInt32(Console.ReadLine());
                    transactionsService.DepositMoney(amount, accountID);
                    break;

                case 2:
                    Console.WriteLine("Please enter account number: ");
                    accountID = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter amount to withdraw: ");
                    amount = Convert.ToInt32(Console.ReadLine());
                    transactionsService.WithdrawMoney(5, 01);
                    break;

                case 3:
                    Console.WriteLine("Please enter account number: ");
                    accountID = Convert.ToInt32(Console.ReadLine());
                    transactionsService.GetBalance(accountID);
                    break;

                case 4:
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }

        private void DisplayUserBankAccounts(User user)
        {
            var accountsList = new AccountsList();
            var bankAccounts = accountsList.GetBankAccounts();

            var ccUserId = user.UserId;


            foreach (var account in bankAccounts)
            {
                if (account.UserId == ccUserId)
                {

                    Console.WriteLine("Select account to use, insert account ID");
                    int selectedID =Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(account.AccountId);
                    MakeTransaction(selectedID);


                }
            }
        }


    }
}

