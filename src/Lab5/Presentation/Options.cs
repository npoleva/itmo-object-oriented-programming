namespace Presentation;

public static class Options
{
    private static readonly List<string> _optionList = new List<string>
    {
        "Check account balance",
        "Create an account",
        "Withdraw money from the account",
        "Top up account balance",
    };

    public static IEnumerable<string> OptionList => _optionList;

    public static void AddOption(string newOption)
    {
        _optionList.Add(newOption);
    }
}