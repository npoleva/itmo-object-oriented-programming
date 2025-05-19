using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerComponents;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerComponentRecords;

public record ComputerRecord
{
    private List<ComputerComponent> _computerComponentsList;

    public ComputerRecord(
        string computerName,
        MotherBoard motherBoard,
        Cpu cpu,
        Bios? bios,
        CpuCoolingSystem cpuCoolingSystem,
        Frame frame,
        Ram ram,
        Drive computerDrive,
        Drive? computerAdditionalDrive,
        PowerUnit powerUnit,
        VideoCard computerVideoCard,
        MemoryOverlookProfile? computerMemoryOverlookProfile,
        WifiAdapter? computerWifiAdapter)
    {
        ComputerName = computerName;
        ComputerMotherBoard = motherBoard;
        ComputerCpu = cpu;
        ComputerBios = bios;
        ComputerCpuCoolingSystem = cpuCoolingSystem;
        ComputerFrame = frame;
        ComputerRam = ram;
        ComputerDrive = computerDrive;
        ComputerAdditionalDrive = computerAdditionalDrive;
        ComputerPowerUnit = powerUnit;
        ComputerVideoCard = computerVideoCard;
        ComputerMemoryOverlookProfile = computerMemoryOverlookProfile;
        ComputerWifiAdapter = computerWifiAdapter;
        _computerComponentsList = new List<ComputerComponent>();
    }

    public IEnumerable<ComputerComponent> ComputerComponentsList => FillComputerComponentsList();

    public string ComputerName { get; init; }

    public MotherBoard ComputerMotherBoard { get; init; }
    public Cpu ComputerCpu { get; init; }
    public Bios? ComputerBios { get; init; }
    public CpuCoolingSystem ComputerCpuCoolingSystem { get; init; }
    public Frame ComputerFrame { get; init; }
    public Ram ComputerRam { get; init; }
    public Drive ComputerDrive { get; init; }
    public Drive? ComputerAdditionalDrive { get; init; }
    public PowerUnit ComputerPowerUnit { get; init; }
    public VideoCard ComputerVideoCard { get; init; }
    public MemoryOverlookProfile? ComputerMemoryOverlookProfile { get; init; }
    public WifiAdapter? ComputerWifiAdapter { get; init; }

    private IEnumerable<ComputerComponent> FillComputerComponentsList()
    {
        _computerComponentsList.Add(ComputerMotherBoard);
        _computerComponentsList.Add(ComputerCpu);
        _computerComponentsList.Add(ComputerCpuCoolingSystem);
        _computerComponentsList.Add(ComputerRam);
        _computerComponentsList.Add(ComputerVideoCard);
        _computerComponentsList.Add(ComputerPowerUnit);
        _computerComponentsList.Add(ComputerFrame);
        _computerComponentsList.Add(ComputerDrive);

        if (ComputerBios != null) _computerComponentsList.Add(ComputerBios);

        if (ComputerAdditionalDrive != null) _computerComponentsList.Add(ComputerAdditionalDrive);

        if (ComputerWifiAdapter != null) _computerComponentsList.Add(ComputerWifiAdapter);

        if (ComputerMemoryOverlookProfile != null) _computerComponentsList.Add(ComputerMemoryOverlookProfile);

        return _computerComponentsList;
    }
}