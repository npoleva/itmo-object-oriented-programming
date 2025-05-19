namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerComponents;

public class PowerUnit : ComputerComponent
{
    public PowerUnit(
        string powerUnitName,
        double peakLoad)
    : base("Power Unit")
    {
        PowerUnitName = powerUnitName;
        PeakLoad = peakLoad;
    }

    public string PowerUnitName { get; private set; }
    public double PeakLoad { get; private set; }
}