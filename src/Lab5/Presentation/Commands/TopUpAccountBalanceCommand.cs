using Infrastructure.Repositories;

namespace Presentation.Commands;

public class TopUpAccountBalanceCommand : ICommand
{
    private readonly int _accountId;
    private readonly decimal _amount;
    public TopUpAccountBalanceCommand(int accountId, decimal amount)
    {
        _accountId = accountId;
        _amount = amount;
    }

    public void Execute()
    {
        var repository = new AccountRepository("Host=localhost;Port=6432;Database=postgres;User Id=postgres;Password=postgres;");
        repository.TopUpAccountBalance(_accountId, _amount);
    }
}