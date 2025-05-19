using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Builder;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerComponentRecords;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerComponents;
using Itmo.ObjectOrientedProgramming.Lab2.Configurator;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab2.Tests;

public class Test4
{
    [Fact]
    public void TryBuildComputerShouldReturnSuccessfulResultWithWarningMessage()
    {
        ComputerComponentRecord motherBoard = new MotherBoardRecord(
            "GIGABYTE B550 AORUS ELITE V2.2",
            "AM4",
            4,
            4,
            4,
            "AMD B550",
            3200,
            true,
            "DDR4",
            4,
            "Standard-ATX",
            "UEFI BIOS",
            true);

        var motherBoardBuilder = new ComputerComponentBuilder(motherBoard);
        BaseConfigurator baseConfigurator = new ComputerComponentBaseConfigurator(motherBoardBuilder);

        baseConfigurator.Construct();

        var motherboard = motherBoardBuilder.GetComputerComponentResult as MotherBoard;

        ComputerComponentRecord cpuRecord = new CpuRecord(
            "AMD Ryzen 5 5600X OEM",
            6,
            new List<double> { 1.5, 1.5, 1.5, 1.5, 1.5, 1.5 },
            "AM4",
            false,
            3200,
            65,
            100);

        var cpuBuilder = new ComputerComponentBuilder(cpuRecord);
        baseConfigurator = new ComputerComponentBaseConfigurator(cpuBuilder);

        baseConfigurator.Construct();

        var cpu = cpuBuilder.GetComputerComponentResult as Cpu;

        ComputerComponentRecord biosRecord = new BiosRecord(
            "UEFI BIOS",
            "2.5.0",
            new List<string> { "AMD Ryzen 5000 Series", "3rd Gen Ryzen", "AMD Ryzen 5 5600X OEM" });

        var biosBuilder = new ComputerComponentBuilder(biosRecord);
        baseConfigurator = new ComputerComponentBaseConfigurator(biosBuilder);

        baseConfigurator.Construct();

        var bios = biosBuilder.GetComputerComponentResult as Bios;

        ComputerComponentRecord ramRecord = new RamRecord(
            "KINGSTON",
            16,
            new List<double>
            {
                3200,
            },
            new List<double>
            {
                1.35,
            },
            "DIMM",
            "DDR4",
            new List<string>
            {
                "XMP 3000",
                "XMP 3200",
            },
            3);
        var ramBuilder = new ComputerComponentBuilder(ramRecord);
        baseConfigurator = new ComputerComponentBaseConfigurator(ramBuilder);

        baseConfigurator.Construct();

        var ram = ramBuilder.GetComputerComponentResult as Ram;

        ComputerComponentRecord cpuCoolingSystemRecord = new CpuCoolingSystemRecord(
            "ID-COOLING SE-226-XT ARGB",
            120.0,
            120.0,
            120.0,
            250,
            new List<string>
            {
                "AM4", "AM5", "LGA 1150", "LGA 1151", "LGA 1151-v2", "LGA 1155", "LGA 1156", "LGA 1200",
                "LGA 1700", "LGA 2066", "LGA 2011",
            });

        var cpuCoolingSystemBuilder = new ComputerComponentBuilder(cpuCoolingSystemRecord);
        baseConfigurator = new ComputerComponentBaseConfigurator(cpuCoolingSystemBuilder);

        baseConfigurator.Construct();

        var cpuCoolingSystem = cpuCoolingSystemBuilder.GetComputerComponentResult as CpuCoolingSystem;

        ComputerComponentRecord frameRecord = new FrameRecord(
            "Cougar Duoface Pro RGB White",
            new List<string>
            {
                "E-ATX", "Micro-ATX", "Mini-ITX", "SSI-CEB", "Standard-ATX",
            },
            390,
            300);

        var frameBuilder = new ComputerComponentBuilder(frameRecord);
        baseConfigurator = new ComputerComponentBaseConfigurator(frameBuilder);

        baseConfigurator.Construct();

        var frame = frameBuilder.GetComputerComponentResult as Frame;

        ComputerComponentRecord hddRecord = new HddRecord(
            "Toshiba DT01",
            1000,
            7200,
            6.4);

        var hddBuilder = new ComputerComponentBuilder(hddRecord);
        baseConfigurator = new ComputerComponentBaseConfigurator(hddBuilder);

        baseConfigurator.Construct();

        var hdd = hddBuilder.GetComputerComponentResult as Hdd;

        ComputerComponentRecord memoryOverlookProfileRecord = new MemoryOverlookProfileRecord(
            "XMP 3200",
            16,
            18,
            18,
            3200,
            1.35);

        var memoryOverlookProfileBuilder = new ComputerComponentBuilder(memoryOverlookProfileRecord);
        baseConfigurator = new ComputerComponentBaseConfigurator(memoryOverlookProfileBuilder);

        baseConfigurator.Construct();

        var memoryOverlookProfile = memoryOverlookProfileBuilder.GetComputerComponentResult as MemoryOverlookProfile;

        ComputerComponentRecord powerUnitRecord = new PowerUnitRecord(
            "DEEPCOOL PF600",
            630);

        var powerUnitBuilder = new ComputerComponentBuilder(powerUnitRecord);
        baseConfigurator = new ComputerComponentBaseConfigurator(powerUnitBuilder);

        baseConfigurator.Construct();

        var powerUnit = powerUnitBuilder.GetComputerComponentResult as PowerUnit;

        ComputerComponentRecord videoCardRecord = new VideoCardRecord(
            "GeForce RTX 3090 Ti",
            325,
            140,
            24,
            4,
            1920,
            450);

        var videoCardBuilder = new ComputerComponentBuilder(videoCardRecord);
        baseConfigurator = new ComputerComponentBaseConfigurator(videoCardBuilder);

        baseConfigurator.Construct();

        var videoCard = videoCardBuilder.GetComputerComponentResult as VideoCard;

        ComputerComponentRecord wifiAdapterRecord = new WifiAdapterRecord(
            "TP-LINK TL-WN781ND",
            4,
            true,
            4,
            4);

        var wifiAdapterBuilder = new ComputerComponentBuilder(wifiAdapterRecord);

        baseConfigurator = new ComputerComponentBaseConfigurator(wifiAdapterBuilder);

        baseConfigurator.Construct();

        var wifiAdapter = wifiAdapterBuilder.GetComputerComponentResult as WifiAdapter;

        if (motherboard == null ||
            cpu == null ||
            hdd == null ||
            cpuCoolingSystem == null ||
            frame == null ||
            ram == null ||
            powerUnit == null ||
            videoCard == null ||
            wifiAdapter == null) return;

        var trialComputer = new ComputerRecord(
            "Computer 1",
            motherboard,
            cpu,
            bios,
            cpuCoolingSystem,
            frame,
            ram,
            hdd,
            null,
            powerUnit,
            videoCard,
            memoryOverlookProfile,
            wifiAdapter);

        ComputerBuilder computerBuilder = new NewComputerBuilder(trialComputer);

        BaseConfigurator computerBaseConfigurator = new ComputerBaseConfigurator(computerBuilder);

        computerBaseConfigurator.Construct();

        ComputerBuilderResult result = computerBuilder.GetComputerResult();

        Assert.Equal(Outcome.NonValid, result.BuildingOutcome);

        Assert.Contains(MessagesEnumeration.MotherBoardHasBuiltInWifiModule, result.Messages);
    }
}