namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerComponentRecords;

public record PowerUnitRecord : ComputerComponentRecord
{
    public PowerUnitRecord(
        string powerUnitName,
        double peakLoad)
    : base("Power Unit")
    {
        PowerUnitName = powerUnitName;
        PeakLoad = peakLoad;
    }

    public string PowerUnitName { get; init; }
    public double PeakLoad { get; init; }
}