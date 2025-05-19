namespace Itmo.ObjectOrientedProgramming.Lab1.Ships;

public record ShipSuitabilityRecord
{
    public ShipSuitabilityRecord(
        int totalResult,
        double fuelResult,
        double timeResult)
    {
        TotalResult = totalResult;
        FuelResult = fuelResult;
        TimeResult = timeResult;
    }

    public int TotalResult { get; init; }
    public double FuelResult { get; init; }
    public double TimeResult { get; init; }
}