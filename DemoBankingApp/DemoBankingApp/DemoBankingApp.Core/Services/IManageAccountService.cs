using DemoBankingApp.Core.Models;

namespace DemoBankingApp.Core.Services
{
    public interface IManageAccountService
    {
        IDictionary<int, BankAccount>? CreateNewAccount(int userId,int id, string name, decimal initialBalance);
    }
}
