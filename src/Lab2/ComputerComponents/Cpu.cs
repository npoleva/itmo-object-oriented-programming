using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerComponents;

public class Cpu : ComputerComponent
{
    private readonly List<double> _coreFrequences;

    public Cpu(
        string? cpuName,
        int coreCount,
        IEnumerable<double> coreFrequences,
        string? socket,
        bool hasIntegratedGraphicsCore,
        double memoryFrequency,
        double heatGeneration,
        double powerConsumption)
    : base("CPU")
    {
        CpuName = cpuName;
        CoreCount = coreCount;
        _coreFrequences = new List<double>(coreFrequences);
        Socket = socket;
        HasIntegratedGraphicsCore = hasIntegratedGraphicsCore;
        MemoryFrequency = memoryFrequency;
        HeatGeneration = heatGeneration;
        PowerConsumption = powerConsumption;
    }

    public string? CpuName { get; private set; }
    public int CoreCount { get; private set; }

    public IEnumerable<double> GetCoreFrequencesList => _coreFrequences;
    public string? Socket { get; private set; }
    public bool HasIntegratedGraphicsCore { get; private set; }
    public double MemoryFrequency { get; private set; }
    public double HeatGeneration { get; private set; }
    public double PowerConsumption { get; private set; }
}