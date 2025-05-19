namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerComponentRecords;

public record MotherBoardRecord : ComputerComponentRecord
{
    public MotherBoardRecord(
        string motherBoardName,
        string processorSocket,
        int pciEVersion,
        int pciEPortsCount,
        int sataPortsCount,
        string chipsetName,
        double chipsetFrequency,
        bool chipsetMemoryOverlookProfileSupport,
        string ddrStandard,
        int memorySlots,
        string formFactor,
        string motherBoardBios,
        bool hasBuiltInWifiModule)
    : base("Motherboard")
    {
        MotherBoardName = motherBoardName;
        ProcessorSocket = processorSocket;
        SataPortsCount = sataPortsCount;
        ChipsetName = chipsetName;
        ChipsetFrequency = chipsetFrequency;
        ChipsetMemoryOverlookProfileSupport = chipsetMemoryOverlookProfileSupport;
        PciEVersion = pciEVersion;
        PciEPortsCount = pciEPortsCount;
        DdrStandard = ddrStandard;
        MemorySlots = memorySlots;
        FormFactor = formFactor;
        MotherBoardBios = motherBoardBios;
        HasBuiltInWifiModule = hasBuiltInWifiModule;
    }

    public string? MotherBoardName { get; init; }
    public string? ProcessorSocket { get; init; }
    public int SataPortsCount { get; init; }
    public string ChipsetName { get; init; }
    public double ChipsetFrequency { get; init; }
    public bool ChipsetMemoryOverlookProfileSupport { get; init; }
    public int PciEVersion { get; init; }
    public int PciEPortsCount { get; init; }
    public string? DdrStandard { get; init; }
    public int MemorySlots { get; init; }
    public string? FormFactor { get; init; }
    public string? MotherBoardBios { get; init; }

    public bool HasBuiltInWifiModule { get; init; }
}