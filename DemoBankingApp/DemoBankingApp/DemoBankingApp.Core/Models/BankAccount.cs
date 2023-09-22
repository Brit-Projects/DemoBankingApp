
namespace DemoBankingApp.Core.Models
{
    public class BankAccount
    {
        public string? AccountName { get; set; }
        public int AccountId { get; set; }
        public int AccountNumber { get; set; }

        public int SortCode { get; set; }
        public int SecurityCode { get; set; }
        public decimal Balance { get; set; }

    }
}
