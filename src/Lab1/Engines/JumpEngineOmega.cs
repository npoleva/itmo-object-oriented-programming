using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Engines;

public class JumpEngineOmega : Engine
{
    public JumpEngineOmega()
        : base(EngineDefaultValues.JumpEngineOmegaFuelConsumptionConstant)
    {
        TravelRangeViaSubspaceChannels
            = EngineDefaultValues.JumpEngineOmegaTravelRangeViaSubspaceChannelsConstant;
    }

    public override double GetCurrentFuelConsumption(double distance)
    {
        return EngineDefaultValues.JumpEngineOmegaFuelConsumptionConstant * Math.Log10(distance);
    }

    protected override double GetCurrentSpeed(double distance)
    {
        return distance / EngineDefaultValues.JumpEngineOmegaSubspaceChannelSpeedConstant;
    }
}