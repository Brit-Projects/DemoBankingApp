using DemoBankingApp.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBankingApp.Core
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TransactionsService accountTransactionsService = new TransactionsService();
            accountTransactionsService.DepositMoney(50, 1);
            accountTransactionsService.GetBalance(1);

        }
    }
}
