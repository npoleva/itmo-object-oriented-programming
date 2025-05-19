namespace Itmo.ObjectOrientedProgramming.Lab1.Engines;

public class PulseEngineClassC : Engine
{
    public PulseEngineClassC()
        : base(EngineDefaultValues.PulseEngineClassCFuelConsumptionConstant)
    {
        StartSpeed = EngineDefaultValues.PulseEngineClassCConstantAverageSpeedConstant;
    }

    public override double GetCurrentFuelConsumption(double distance)
    {
        double constantFuelConsumption =
            EngineDefaultValues.PulseEngineClassCFuelConsumptionConstant;
        double startingFuelConsumption =
            EngineDefaultValues.PulseEngineClassCStartingFuelConsumption;
        double speed = GetCurrentSpeed(distance);

        return startingFuelConsumption + (speed * constantFuelConsumption * distance);
    }

    protected override double GetCurrentSpeed(double distance)
    {
        return StartSpeed;
    }
}