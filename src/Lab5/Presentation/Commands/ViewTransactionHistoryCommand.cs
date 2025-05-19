using Infrastructure.Repositories;

namespace Presentation.Commands;

public class ViewTransactionHistoryCommand : ICommand
{
    private readonly int _accountId;

    public ViewTransactionHistoryCommand(int accountId)
    {
        _accountId = accountId;
    }

    public void Execute()
    {
        var repository = new TransactionRepository("Host=localhost;Port=6432;Database=postgres;User Id=postgres;Password=postgres;");
        repository.GetAccountId();
    }
}