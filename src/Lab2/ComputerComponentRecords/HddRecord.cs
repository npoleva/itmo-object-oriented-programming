namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerComponentRecords;

public record HddRecord : ComputerComponentRecord
{
    public HddRecord(
        string hddName,
        int capacity,
        int spindleSpeed,
        double powerConsumption)
    : base("HDD")
    {
        HddName = hddName;
        Capacity = capacity;
        SpindleSpeed = spindleSpeed;
        PowerConsumption = powerConsumption;
    }

    public string HddName { get; init; }
    public int Capacity { get; init; }
    public int SpindleSpeed { get; init; }
    public double PowerConsumption { get; init; }
}