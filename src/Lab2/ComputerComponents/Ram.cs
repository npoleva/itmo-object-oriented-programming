using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerComponents;

public class Ram : ComputerComponent
{
    private readonly List<double> _frequencesList;
    private readonly List<double> _voltageList;
    private readonly List<string> _memoryOverlookProfilesList;
    public Ram(
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

    public string RamName { get; private set; }
    public int MemoryCapacity { get; private set; }
    public string FormFactor { get; private set; }
    public string VersionDdrStandart { get; private set; }

    public IEnumerable<double> GetSupportedFrequencyList
        => _frequencesList;
    public IEnumerable<double> GetVoltageList
        => _voltageList;

    public IEnumerable<string> GetMemoryOverlookProfilesList
        => _memoryOverlookProfilesList;
    public int PowerConsumption { get; private set; }
}