namespace Itmo.ObjectOrientedProgramming.Lab1.Engines;

public class JumpEngineGamma : Engine
{
    public JumpEngineGamma()
        : base(EngineDefaultValues.JumpEngineGammaFuelConsumptionConstant)
    {
        TravelRangeViaSubspaceChannels = EngineDefaultValues.JumpEngineGammaTravelRangeViaSubspaceChannelsConstant;
    }

    public override double GetCurrentFuelConsumption(double distance)
    {
        return distance * distance * EngineDefaultValues.JumpEngineGammaFuelConsumptionConstant;
    }

    protected override double GetCurrentSpeed(double distance)
    {
        return distance / EngineDefaultValues.JumpEngineGammaSubspaceChannelSpeedConstant;
    }
}