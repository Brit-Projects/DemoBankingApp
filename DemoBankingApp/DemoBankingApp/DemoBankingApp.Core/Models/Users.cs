
namespace DemoBankingApp.Core.Models
{
    public class Users
    {
        public int UserId { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}
