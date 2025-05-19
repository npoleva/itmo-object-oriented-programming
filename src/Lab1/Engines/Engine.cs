namespace Itmo.ObjectOrientedProgramming.Lab1.Engines;

public abstract class Engine
{
    protected Engine(double fuelConsumption)
    {
        FuelConsumption = fuelConsumption;
    }

    public double TravelRangeViaSubspaceChannels { get; protected init; }
    protected double StartSpeed { get; init; }
    protected double FuelConsumption { get; }

    public abstract double GetCurrentFuelConsumption(double distance);

    public double GetTime(double distance)
    {
        double time = 0;
        while (distance > 0)
        {
            distance -= GetCurrentSpeed(distance);
            time += 1;
        }

        return time;
    }

    protected abstract double GetCurrentSpeed(double distance);
}
