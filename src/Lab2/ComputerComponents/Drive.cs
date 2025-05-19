namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerComponents;

public abstract class Drive : ComputerComponent
{
    protected Drive(
        string computerComponentTypeName,
        string driveName,
        double capacity,
        double powerConsumption)
    : base(computerComponentTypeName)
    {
        DriveName = driveName;
        Capacity = capacity;
        PowerConsumption = powerConsumption;
    }

    public string DriveName { get; private set; }
    public double Capacity { get; private set; }
    public double PowerConsumption { get; private set; }
}