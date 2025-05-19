using Presentation.Parser;
using Spectre.Console;
namespace Presentation;

public static class Runner
{
    public static void Run()
    {
        string selection = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("Pick an operation mode")
                .PageSize(10)
                .AddChoices("User", "Administrator"));

        ICommandHandler firstHandler = new CreateAnAccountCommandHandler();
        firstHandler.HandleRequest(selection);
    }
}