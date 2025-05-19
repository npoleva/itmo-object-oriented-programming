namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerComponents;

public sealed class MotherBoard : ComputerComponent
{
    public MotherBoard(
        string? motherBoardName,
        string? processorSocket,
        int pciEVersion,
        int pciEPortsCount,
        int sataPortsCount,
        string chipsetName,
        double chipsetFrequency,
        bool chipsetMemoryOverlookProfileSupport,
        string? ddrStandard,
        int memorySlots,
        string? formFactor,
        string? motherBoardBios,
        bool hasBuiltInWifiModule)
    : base("Motherboard")
    {
        MotherBoardName = motherBoardName;
        ProcessorSocket = processorSocket;
        PciEVersion = pciEVersion;
        PciEPortsCount = pciEPortsCount;
        SataPortsCount = sataPortsCount;
        ChipsetName = chipsetName;
        ChipsetFrequency = chipsetFrequency;
        ChipsetMemoryOverlookProfileSupport = chipsetMemoryOverlookProfileSupport;
        DdrStandard = ddrStandard;
        MemorySlots = memorySlots;
        FormFactor = formFactor;
        MotherBoardBios = motherBoardBios;
        HasBuiltInWifiModule = hasBuiltInWifiModule;
    }

    public string? MotherBoardName { get; private set; }
    public string? ProcessorSocket { get; private set; }
    public int SataPortsCount { get; private set; }
    public string ChipsetName { get; private set; }
    public double ChipsetFrequency { get; private set; }
    public bool ChipsetMemoryOverlookProfileSupport { get; private set; }
    public int PciEVersion { get; private set; }
    public int PciEPortsCount { get; private set; }
    public string? DdrStandard { get; private set; }
    public int MemorySlots { get; private set; }
    public string? FormFactor { get; private set; }
    public string? MotherBoardBios { get; private set; }

    public bool HasBuiltInWifiModule { get; private set; }
}
