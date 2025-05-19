namespace Presentation.Commands;

public class CheckAccountBalanceCommand : ICommand
{
    private readonly int _accountId;

    public CheckAccountBalanceCommand(int accountId)
    {
        _accountId = accountId;
    }

    public void Execute()
    {
        throw new NotImplementedException();
    }
}