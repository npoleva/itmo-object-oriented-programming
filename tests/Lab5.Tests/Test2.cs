using Infrastructure.Repositories;
using NSubstitute;
using Presentation.Commands;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab5.Tests;

public class Test2
{
    [Fact]
    public void WithdrawBalance()
    {
        AccountRepository repository = Substitute.For<AccountRepository>("Host=localhost;Port=6432;Database=postgres;User Id=postgres;Password=postgres;");
        int accountId = 1;
        decimal amount = 50.0m;
        ICommand command = Substitute.For<WithDrawMoneyFromTheAccountCommand>(accountId, amount);

        command.Received();

        repository.Received();
    }
}