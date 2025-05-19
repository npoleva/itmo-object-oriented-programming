namespace Presentation.Commands;

public class RemoveUserAccountCommand : ICommand
{
    private readonly int _accountId;

    public RemoveUserAccountCommand(int accountId)
    {
        _accountId = accountId;
    }

    public void Execute()
    {
        throw new NotImplementedException();
    }
}