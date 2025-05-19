using Itmo.ObjectOrientedProgramming.Lab2.ComputerComponentRecords;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerComponents;

namespace Itmo.ObjectOrientedProgramming.Lab2.Builder;

public class ComputerComponentBuilder : Builder
{
    public ComputerComponentBuilder(ComputerComponentRecord computerComponentRecord)
    {
        InputComputerComponentRecord = computerComponentRecord;
    }

    public ComputerComponent? GetComputerComponentResult => OutputComputerComponent;
    public ComputerComponentRecord InputComputerComponentRecord { get; set; }
    private ComputerComponent? OutputComputerComponent { get; set; }
    public void TryBuildMotherBoard()
    {
        var motherBoard = (MotherBoardRecord)InputComputerComponentRecord;

        OutputComputerComponent = new MotherBoard(
            motherBoard.MotherBoardName,
            motherBoard.ProcessorSocket,
            motherBoard.PciEVersion,
            motherBoard.PciEPortsCount,
            motherBoard.SataPortsCount,
            motherBoard.ChipsetName,
            motherBoard.ChipsetFrequency,
            motherBoard.ChipsetMemoryOverlookProfileSupport,
            motherBoard.DdrStandard,
            motherBoard.MemorySlots,
            motherBoard.FormFactor,
            motherBoard.MotherBoardBios,
            motherBoard.HasBuiltInWifiModule);
    }

    public void TryBuildCpu()
    {
        CpuRecord cpu;

        cpu = (CpuRecord)InputComputerComponentRecord;

        OutputComputerComponent = new Cpu(
            cpu.CpuName,
            cpu.CoreCount,
            cpu.GetCoreFrequencesList,
            cpu.Socket,
            cpu.HasIntegratedGraphicsCore,
            cpu.MemoryFrequency,
            cpu.HeatGeneration,
            cpu.PowerConsumption);
    }

    public void TryBuildBios()
    {
        BiosRecord bios;

        bios = (BiosRecord)InputComputerComponentRecord;

        OutputComputerComponent = new Bios(
            bios.BiosName,
            bios.BiosVersion,
            bios.GetSupportedCpuList);
    }

    public void TryBuildRam()
    {
        RamRecord ram;

        ram = (RamRecord)InputComputerComponentRecord;

        OutputComputerComponent = new Ram(
            ram.RamName,
            ram.MemoryCapacity,
            ram.GetSupportedFrequencyList,
            ram.GetVoltageList,
            ram.FormFactor,
            ram.VersionDdrStandart,
            ram.GetMemoryOverlookProfilesList,
            ram.PowerConsumption);
    }

    public void TryBuildCpuCoolingSystem()
    {
        CpuCoolingSystemRecord cpuCoolingSystem;

        cpuCoolingSystem = (CpuCoolingSystemRecord)InputComputerComponentRecord;

        OutputComputerComponent = new CpuCoolingSystem(
            cpuCoolingSystem.CpuCoolingSystemName,
            cpuCoolingSystem.LengthGabariteParameter,
            cpuCoolingSystem.HeightGabariteParameter,
            cpuCoolingSystem.WidthGabariteParameter,
            cpuCoolingSystem.Tdp,
            cpuCoolingSystem.GetSupportedSocketsList);
    }

    public void TryBuildVideoCard()
    {
        VideoCardRecord videoCard;

        videoCard = (VideoCardRecord)InputComputerComponentRecord;

        OutputComputerComponent = new VideoCard(
            videoCard.VideoCardName,
            videoCard.LengthGabarite,
            videoCard.WidthGabarite,
            videoCard.VideoMemoryCapacity,
            videoCard.PciEVersion,
            videoCard.VideoChipFrequency,
            videoCard.PowerConsumption);
    }

    public void TryBuildSsd()
    {
        SsdRecord ssd;

        ssd = (SsdRecord)InputComputerComponentRecord;

        OutputComputerComponent = new SsdDrive(
            ssd.SsdDriveName,
            ssd.ConnectionOption,
            ssd.Capacity,
            ssd.MaximumReadingSpeed,
            ssd.MaximumWritingSpeed,
            ssd.PowerConsumption);
    }

    public void TryBuildHdd()
    {
        HddRecord hdd;

        hdd = (HddRecord)InputComputerComponentRecord;

        OutputComputerComponent = new Hdd(
            hdd.HddName,
            hdd.Capacity,
            hdd.SpindleSpeed,
            hdd.PowerConsumption);
    }

    public void TryBuildFrame()
    {
        FrameRecord frame;

        frame = (FrameRecord)InputComputerComponentRecord;

        OutputComputerComponent = new Frame(
            frame.FrameName,
            frame.GetSupportedMotherBoardsPhormPhactorsList,
            frame.MaximumVideoCardLength,
            frame.MaximumVideoCardWidth);
    }

    public void TryBuildMemoryOverlookProfile()
    {
        MemoryOverlookProfileRecord memoryOverlookProfile;

        memoryOverlookProfile = (MemoryOverlookProfileRecord)InputComputerComponentRecord;

        OutputComputerComponent = new MemoryOverlookProfile(
            memoryOverlookProfile.MemoryOverlookProfileType,
            memoryOverlookProfile.TimingCasLatency,
            memoryOverlookProfile.TimingTrp,
            memoryOverlookProfile.TimingTrcd,
            memoryOverlookProfile.Frequency,
            memoryOverlookProfile.Voltage);
    }

    public void TryBuildWifiAdapter()
    {
        WifiAdapterRecord wifiAdapter;

        wifiAdapter = (WifiAdapterRecord)InputComputerComponentRecord;

        OutputComputerComponent = new WifiAdapter(
            wifiAdapter.WifiAdapterName,
            wifiAdapter.WifiAdapterVersionStandart,
            wifiAdapter.HasBluetoothModule,
            wifiAdapter.PciEVersion,
            wifiAdapter.PowerConsumption);
    }

    public void TryBuildPowerUnit()
    {
        PowerUnitRecord powerUnit;

        powerUnit = (PowerUnitRecord)InputComputerComponentRecord;

        OutputComputerComponent = new PowerUnit(
            powerUnit.PowerUnitName,
            powerUnit.PeakLoad);
    }
}