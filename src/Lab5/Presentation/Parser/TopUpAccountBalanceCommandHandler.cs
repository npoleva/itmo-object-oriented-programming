using Presentation.Commands;

namespace Presentation.Parser;

public class TopUpAccountBalanceCommandHandler : BaseCommandHandler
{
    public override void HandleRequest(string selection)
    {
        if (string.Equals(selection, "Administrator", StringComparison.OrdinalIgnoreCase) ||
            string.Equals(selection, "User", StringComparison.Ordinal))
        {
            if (string.Equals(selection, "Administrator", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Enter the system password:");
                string? password = Console.ReadLine();

                var administratorAutentificationCommand = new AdministratorAutotentificationCommand(password);
                administratorAutentificationCommand.Execute();
            }
            else
            {
                Console.WriteLine("Enter the account id:");
                string? userInput = Console.ReadLine();

                Console.WriteLine("Enter the pincode:");
                string? pincode = Console.ReadLine();

                if (int.TryParse(userInput, out int accountId))
                {
                    ICommand userAutotentificationCommand = new UserAutotentificationCommand(accountId, pincode);
                    userAutotentificationCommand.Execute();

                    decimal amount = 0;
                    ICommand command = new TopUpAccountBalanceCommand(accountId, amount);
                    command.Execute();
                }
            }
        }
    }
}