// See https://aka.ms/new-console-template for more information

using DemoBankingApp.Core.Repositories;
using DemoBankingApp.Core.Services;

namespace DemoBankingApp.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Authentication authentication = new Authentication();
            authentication.WelcomeUser();


            //TransactionsService accountTransactionsService = new TransactionsService();
            //accountTransactionsService.DepositMoney(50, 1);
            //accountTransactionsService.GetBalance(1);

 


        }
    }
}
