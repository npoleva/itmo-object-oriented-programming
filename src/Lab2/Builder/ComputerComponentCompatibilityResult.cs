namespace Itmo.ObjectOrientedProgramming.Lab2.Builder;

public record ComputerComponentCompatibilityResult
{
    public ComputerComponentCompatibilityResult(Outcome outcome, MessagesEnumeration message)
    {
        BuildingOutcome = outcome;
        Message = message;
    }

    public MessagesEnumeration Message { get; init; }
    public Outcome BuildingOutcome { get; init; }
}
