using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerComponentRecords;

public record RamRecord : ComputerComponentRecord
{
    private readonly List<double> _frequencesList;
    private readonly List<double> _voltageList;
    private readonly List<string> _memoryOverlookProfilesList;

    public RamRecord(
        string ramName,
        int memoryCapacity,
        IEnumerable<double> frequencyList,
        IEnumerable<double> voltageList,
        string formFactor,
        string versionDdrStandart,
        IEnumerable<string> memoryOverlookProfiles,
        int powerConsumption)
    : base("RAM")
    {
        RamName = ramName;
        MemoryCapacity = memoryCapacity;
        _frequencesList = new List<double>(frequencyList);
        _voltageList = new List<double>(voltageList);
        FormFactor = formFactor;
        VersionDdrStandart = versionDdrStandart;
        _memoryOverlookProfilesList =
            new List<string>(memoryOverlookProfiles);
        PowerConsumption = powerConsumption;
    }

    public string RamName { get; init; }
    public int MemoryCapacity { get; init; }
    public string FormFactor { get; init; }
    public string VersionDdrStandart { get; init; }

    public IEnumerable<double> GetSupportedFrequencyList
        => _frequencesList;
    public IEnumerable<double> GetVoltageList
        => _voltageList;

    public IEnumerable<string> GetMemoryOverlookProfilesList
        => _memoryOverlookProfilesList;
    public int PowerConsumption { get; init; }
}