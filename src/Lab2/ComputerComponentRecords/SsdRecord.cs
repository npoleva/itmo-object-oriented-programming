namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerComponentRecords;

public record SsdRecord : ComputerComponentRecord
{
    public SsdRecord(
        string ssdDriveName,
        string connectionOption,
        int capacity,
        int maximumReadingSpeed,
        int maximumWritingSpeed,
        double powerConsumption)
    : base("SSD")
    {
        ConnectionOption = connectionOption;
        SsdDriveName = ssdDriveName;
        Capacity = capacity;
        MaximumReadingSpeed = maximumReadingSpeed;
        MaximumWritingSpeed = maximumWritingSpeed;
        PowerConsumption = powerConsumption;
    }

    public string SsdDriveName { get; init; }
    public string ConnectionOption { get; init; }
    public int Capacity { get; init; }
    public int MaximumWritingSpeed { get; init; }
    public int MaximumReadingSpeed { get; init; }
    public double PowerConsumption { get; init; }
}