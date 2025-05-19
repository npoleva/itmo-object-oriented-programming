using Infrastructure.Repositories;

namespace Presentation.Commands;

public class CreateAnAccountCommand : ICommand
{
    private readonly int _id;

    public CreateAnAccountCommand(int id)
    {
        _id = id;
    }

    public void Execute()
    {
        var repository = new AdminRepository("Host=localhost;Port=6432;Database=postgres;User Id=postgres;Password=postgres;");
        repository.GetAdminId();
    }
}