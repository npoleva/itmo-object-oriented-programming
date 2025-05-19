namespace Itmo.ObjectOrientedProgramming.Lab1.Ships;

public record ShipResultRecord
{
    public ShipResultRecord(
        ShipOutcome outcome,
        double fuelResult,
        double timeResult)
    {
        Outcome = outcome;
        FuelResult = fuelResult;
        TimeResult = timeResult;
    }

    public ShipOutcome Outcome { get; init; }
    public double FuelResult { get; init; }
    public double TimeResult { get; init; }
}