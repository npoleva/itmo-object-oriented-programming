namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerComponents;

public class Computer
{
    public Computer(
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
    }

    public string ComputerName { get; private set; }

    public MotherBoard ComputerMotherBoard { get; private set; }
    public Cpu ComputerCpu { get; private set; }
    public Bios? ComputerBios { get; private set; }
    public CpuCoolingSystem ComputerCpuCoolingSystem { get; private set; }
    public Frame ComputerFrame { get; private set; }
    public Ram ComputerRam { get; private set; }
    public Drive ComputerDrive { get; private set; }
    public Drive? ComputerAdditionalDrive { get; private set; }
    public PowerUnit ComputerPowerUnit { get; private set; }
    public VideoCard ComputerVideoCard { get; private set; }
    public MemoryOverlookProfile? ComputerMemoryOverlookProfile { get; private set; }
    public WifiAdapter? ComputerWifiAdapter { get; private set; }
}