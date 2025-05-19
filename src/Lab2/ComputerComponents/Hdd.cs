namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerComponents;

public class Hdd : Drive
{
    public Hdd(
        string hddName,
        double capacity,
        int spindleSpeed,
        double powerConsumption)
    : base(
        "HDD",
        hddName,
        capacity,
        powerConsumption)
    {
        SpindleSpeed = spindleSpeed;
    }

    public int SpindleSpeed { get; private set; }
}