using DemoBankingApp.Core.Services;
using FluentAssertions;
using Xunit;

namespace DemoBankingApp.Core.Tests.Services
{
    public class ManageAccountServiceTests
    {
        [Theory]
        [InlineData(12, "EveryDay Saver", 100)]
        public void CreateAnNewAccount(int id, string name, decimal balance)
        {
            //Arrange
            var manageAccountService = new ManageAccountService();

            //Act
            var SUT = manageAccountService.CreateNewAccount(id, name, balance);

            //Assert
            SUT.Should().NotBeNull();
            SUT.Values.Select(x => x.AccountId).Should().Equal(id); 
            SUT.Values.Select(x => x.AccountName).Should().Equal(name); 
            SUT.Values.Select(x => x.Balance).Should().Equal(balance);
        }

        [Theory]
        [InlineData(12, "EveryDay Saver", 100)]
        [InlineData(13, "EveryDay Saver", 200)]
        [InlineData(14, "EveryDay Saver", 500)]
        public void CreateMultipleAccounts(int id, string name, decimal balance)
        {
            //Arrange
            var manageAccountService = new ManageAccountService();

            //Act
            var SUT = manageAccountService.CreateNewAccount(id, name, balance);

            //Assert
            SUT.Should().NotBeNull();
            SUT.Values.Select(x => x.AccountId).Should().Equal(id);
            SUT.Values.Select(x => x.AccountName).Should().Equal(name);
            SUT.Values.Select(x => x.Balance).Should().Equal(balance);
        }
    }
}
