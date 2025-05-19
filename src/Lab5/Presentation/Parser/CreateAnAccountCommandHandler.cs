using Presentation.Commands;

namespace Presentation.Parser;

public class CreateAnAccountCommandHandler : BaseCommandHandler
{
    public override void HandleRequest(string selection)
    {
        if (string.Equals(selection, "Administrator", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Enter the system password:");
            string? password = Console.ReadLine();

            var administratorAutentificationCommand = new AdministratorAutotentificationCommand(password);
            administratorAutentificationCommand.Execute();
            Console.WriteLine("Enter the Account Id:");

            string? userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int accountId))
            {
                ICommand command = new CreateAnAccountCommand(accountId);
                command.Execute();
            }
        }
    }
}