using Infrastructure.Repositories;

namespace Presentation.Commands;

public class UserAutotentificationCommand : ICommand
{
    private readonly int _accountId;
    private readonly string? _pincode;

    public UserAutotentificationCommand(int accountId, string? pincode)
    {
        _accountId = accountId;
        _pincode = pincode;
    }

    public void Execute()
    {
        var repository = new UserRepository("Host=localhost;Port=6432;Database=postgres;User Id=postgres;Password=postgres;");
        if (_pincode == null) return;
        repository.GetAccount(_accountId, _pincode);
    }
}