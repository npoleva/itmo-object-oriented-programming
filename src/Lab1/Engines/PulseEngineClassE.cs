using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Engines;

public class PulseEngineClassE : Engine
{
    private readonly double _acceleration = EngineDefaultValues.PulseEngineClassEAccelerationConstant;
    public PulseEngineClassE()
        : base(EngineDefaultValues.PulseEngineClassEFuelConsumptionConstant)
    {
        StartSpeed = EngineDefaultValues.PulseEngineClassEStartSpeedConstant;
    }

    public override double GetCurrentFuelConsumption(double distance)
    {
        double constantFuelConsumption =
            EngineDefaultValues.PulseEngineClassEFuelConsumptionConstant;
        double startingFuelConsumption =
            EngineDefaultValues.PulseEngineClassEStartingFuelConsumption;
        double speed = GetCurrentSpeed(distance);

        return startingFuelConsumption + (speed * constantFuelConsumption * distance);
    }

    protected override double GetCurrentSpeed(double distance)
    {
        return StartSpeed * Math.Exp(_acceleration * distance);
    }
}