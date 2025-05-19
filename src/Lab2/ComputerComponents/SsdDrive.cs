namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerComponents;

public class SsdDrive : Drive
{
    public SsdDrive(
        string ssdDriveName,
        string connectionOption,
        double capacity,
        int maximumReadingSpeed,
        int maximumWritingSpeed,
        double powerConsumption)
    : base(
        "SSD",
        ssdDriveName,
        capacity,
        powerConsumption)
    {
        ConnectionOption = connectionOption;
        MaximumReadingSpeed = maximumReadingSpeed;
        MaximumWritingSpeed = maximumWritingSpeed;
    }

    public string ConnectionOption { get; private set; }
    public int MaximumReadingSpeed { get; private set; }
    public int MaximumWritingSpeed { get; private set; }
}