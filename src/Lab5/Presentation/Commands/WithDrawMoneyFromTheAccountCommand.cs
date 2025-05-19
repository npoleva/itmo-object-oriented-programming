using Infrastructure.Repositories;

namespace Presentation.Commands;

public class WithDrawMoneyFromTheAccountCommand : ICommand
{
    private readonly decimal _amount;
    private readonly int _accountId;
    public WithDrawMoneyFromTheAccountCommand(int accountId, decimal amount)
    {
        _accountId = accountId;
        _amount = amount;
    }

    public void Execute()
    {
        var repository = new AccountRepository("Host=localhost;Port=6432;Database=postgres;User Id=postgres;Password=postgres;");
        repository.WithDrawBalance(_accountId, _amount);
    }
}