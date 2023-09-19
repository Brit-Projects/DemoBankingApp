using DemoBankingApp.Core.Models;

namespace DemoBankingApp.Core.Services
{
    public interface IManageAccountService
    {
        IDictionary<string, BankAccount>? CreateNewAccount(int id, string name, decimal initialBalance);
    }
}
