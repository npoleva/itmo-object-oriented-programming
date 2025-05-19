using Infrastructure.Repositories;

namespace Presentation.Commands;

public class AdministratorAutotentificationCommand : ICommand
{
    private readonly string? _identificator;
    public AdministratorAutotentificationCommand(string? identifier)
    {
        _identificator = identifier;
    }

    public void Execute()
    {
        var repository = new AdminRepository("Host=localhost;Port=6432;Database=postgres;User Id=postgres;Password=postgres;");
        repository.GetAdminId();
    }
}