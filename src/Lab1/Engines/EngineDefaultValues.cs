namespace Itmo.ObjectOrientedProgramming.Lab1.Engines;

public static class EngineDefaultValues
{
    public static double PulseEngineClassCConstantAverageSpeedConstant { get; } = 50;
    public static double PulseEngineClassEStartSpeedConstant { get; } = 300;
    public static double PulseEngineClassCFuelConsumptionConstant { get; } = 50;
    public static double PulseEngineClassEFuelConsumptionConstant { get; } = 1000;
    public static double JumpEngineAlphaFuelConsumptionConstant { get; } = 200;
    public static double JumpEngineOmegaFuelConsumptionConstant { get; } = 150;
    public static double JumpEngineGammaFuelConsumptionConstant { get; } = 100;
    public static double PulseEngineClassEAccelerationConstant { get; } = 30;
    public static double PulseEngineClassCStartingFuelConsumption { get; } = 30;
    public static double PulseEngineClassEStartingFuelConsumption { get; } = 30;

    public static double JumpEngineAlphaTravelRangeViaSubspaceChannelsConstant { get; } = 10;

    public static double JumpEngineOmegaTravelRangeViaSubspaceChannelsConstant { get; } = 20;

    public static double JumpEngineGammaTravelRangeViaSubspaceChannelsConstant { get; } = 30;

    public static double JumpEngineGammaSubspaceChannelSpeedConstant { get; } = 1;

    public static double JumpEngineAlphaSubspaceChannelSpeedConstant { get; } = 1;

    public static double JumpEngineOmegaSubspaceChannelSpeedConstant { get; } = 1;

    public static double PulseEngineCLassCNebulaNitrineParticlesSurroundingResistanceConstant { get; } = 7000;
}