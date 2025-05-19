using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerComponentRecords;

public record CpuRecord : ComputerComponentRecord
{
    private readonly List<double> _coreFrequences;

    public CpuRecord(
        string cpuName,
        int coreCount,
        IEnumerable<double> coreFrequences,
        string socket,
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

    public string? CpuName { get; init; }
    public int CoreCount { get; init; }

    public IEnumerable<double> GetCoreFrequencesList => _coreFrequences;
    public string? Socket { get; init; }
    public bool HasIntegratedGraphicsCore { get; init; }
    public double MemoryFrequency { get; init; }
    public double HeatGeneration { get; init; }
    public double PowerConsumption { get; init; }
}