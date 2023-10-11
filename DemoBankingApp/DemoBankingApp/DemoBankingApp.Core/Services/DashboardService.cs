using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoBankingApp.Core;

namespace DemoBankingApp.Core.Services
{
    internal class DashboardService
    {
        private TransactionsService transactionsService;

        public DashboardService(TransactionsService transactionsService)
        {
            this.transactionsService = transactionsService;
        }

        public void DisplayDashboard()
        {
            Console.WriteLine("Welcome to the Dashboard");
            Console.WriteLine("1. View Transactions");
            Console.WriteLine("2. Make a Transaction");
            Console.WriteLine("3. Exit");

            int choice = GetUserChoice();

            switch (choice)
            {
                case 1:
                    ViewAccounts();
                    break;

                case 2:
                    MakeTransaction();
                    break;

                case 3:
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

        private void ViewAccounts()
        {
            //var transactions = transactionService.GetTransactions();

            //Console.WriteLine("Transaction:");
            //foreach (var transaction in transactions)
            //{
            //    Console.WriteLine($"Transactoin ID: {transaction.TransactionId}");
            //    Console.WriteLine($"Description: {transaction.Description}");
            //    Console.WriteLine($"Amount: {transaction.Amount}");
            //    Console.WriteLine();
            
            Console.WriteLine("Feature under construction");
        }


        private int GetUserChoiceTransactions()
        {
            Console.Write("Enter your choice: ");
            if (int.TryParse(Console.ReadLine(), out int choiceTransactions))
            {
                return choiceTransactions;
            }

            return -1;
        }

        private void MakeTransaction()
        {

            Console.WriteLine("Select type of transaction");
            Console.WriteLine("1. Deposit Funds");
            Console.WriteLine("2. Withdraw Funds");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit)");

            int choiceTransactions = GetUserChoiceTransactions();

            switch (choiceTransactions)
            {
                case 1:
                    transactionsService.DepositMoney();
                    break;

                case 2:
                    transactionsService.WithdrawMoney();
                    break;

                case 3:
                    transactionsService.GetBalance();
                    break;

                case 4:
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
    }
}

