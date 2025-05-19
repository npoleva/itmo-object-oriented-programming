namespace Itmo.ObjectOrientedProgramming.Lab1.Engines;

public class JumpEngineAlpha : Engine
{
    public JumpEngineAlpha()
        : base(EngineDefaultValues.JumpEngineAlphaFuelConsumptionConstant)
    {
        TravelRangeViaSubspaceChannels
            = EngineDefaultValues.JumpEngineAlphaTravelRangeViaSubspaceChannelsConstant;
    }

    public override double GetCurrentFuelConsumption(double distance)
    {
        return distance * EngineDefaultValues.JumpEngineAlphaFuelConsumptionConstant;
    }

    protected override double GetCurrentSpeed(double distance)
    {
        return distance / EngineDefaultValues.JumpEngineAlphaSubspaceChannelSpeedConstant;
    }
}