using System;
using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerComponents;

namespace Itmo.ObjectOrientedProgramming.Lab2.Builder;

public static class BuilderCheckMethods
{
    internal static ComputerComponentCompatibilityResult IsCompatible(
        ComputerComponent? component, IEnumerable<ComputerComponent> inputComponentsList)
    {
        if (component is Bios)
            return BiosCompatibility(component, inputComponentsList);

        if (component is Cpu)
            return CpuCompatibility(component, inputComponentsList);

        if (component is Ram)
            return RamCompatibility(component, inputComponentsList);

        if (component is MemoryOverlookProfile)
            return MemoryOverlookProfileCompatibility(component, inputComponentsList);

        if (component is CpuCoolingSystem)
            return CpuCoolingSystemCompatibility(component, inputComponentsList);

        if (component is WifiAdapter)
            return WifiAdapterCompatibility(inputComponentsList);

        if (component is Frame)
            return FrameCompatibility(component, inputComponentsList);

        if (component is PowerUnit)
            return PowerUnitCompatibility(component, inputComponentsList);

        return new(Outcome.Valid, MessagesEnumeration.None);
    }

    private static ComputerComponentCompatibilityResult BiosCompatibility(
        ComputerComponent component, IEnumerable<ComputerComponent> inputComponentsList)
    {
        var bios = (Bios)component;

        foreach (ComputerComponent item in inputComponentsList)
        {
            if (item is MotherBoard motherBoard)
            {
                if (motherBoard.MotherBoardBios != bios.BiosName)
                    return new(Outcome.NonValid, MessagesEnumeration.NotCompatibleBios);
            }
        }

        return new(Outcome.Valid, MessagesEnumeration.None);
    }

    private static ComputerComponentCompatibilityResult CpuCompatibility(
        ComputerComponent component, IEnumerable<ComputerComponent> inputComponentsList)
    {
        var cpu = (Cpu)component;

        foreach (ComputerComponent item in inputComponentsList)
        {
            if (item is MotherBoard motherBoard)
            {
                if (motherBoard.ProcessorSocket != cpu.Socket)
                    return new(Outcome.NonValid, MessagesEnumeration.NotCompatibleCpu);
            }

            if (item is Bios bios)
            {
                if (bios.GetSupportedCpuList.All(cpuName => cpuName != cpu.CpuName))
                    return new(Outcome.NonValid, MessagesEnumeration.NotCompatibleCpu);
            }
        }

        return new(Outcome.Valid, MessagesEnumeration.None);
    }

    private static ComputerComponentCompatibilityResult RamCompatibility(
        ComputerComponent component, IEnumerable<ComputerComponent> inputComponentsList)
    {
        var ram = (Ram)component;

        foreach (ComputerComponent item in inputComponentsList)
        {
            if (item is MotherBoard motherBoard)
            {
                if (ram.GetSupportedFrequencyList.All(frequency => frequency > motherBoard.ChipsetFrequency))
                    return new(Outcome.NonValid, MessagesEnumeration.NotCompatibleRam);
            }
        }

        return new(Outcome.Valid, MessagesEnumeration.None);
    }

    private static ComputerComponentCompatibilityResult MemoryOverlookProfileCompatibility(
        ComputerComponent component, IEnumerable<ComputerComponent> inputComponentsList)
    {
        var memoryOverLookProfile = (MemoryOverlookProfile)component;

        foreach (ComputerComponent item in inputComponentsList)
        {
            if (item is MotherBoard { ChipsetMemoryOverlookProfileSupport: false })
                return new(Outcome.NonValid, MessagesEnumeration.NotCompatibleMemoryOverlookProfile);

            if (item is Cpu cpu)
            {
                if (Math.Abs(cpu.MemoryFrequency - memoryOverLookProfile.Frequency) > 0)
                    return new(Outcome.NonValid, MessagesEnumeration.NotCompatibleMemoryOverlookProfile);
            }

            if (item is Ram ram)
            {
                if (ram.GetMemoryOverlookProfilesList.All(
                        temporaryMemoryOverlookProfile
                            => temporaryMemoryOverlookProfile != memoryOverLookProfile.MemoryOverlookProfileType))
                    return new(Outcome.NonValid, MessagesEnumeration.NotCompatibleMemoryOverlookProfile);
            }
        }

        return new(Outcome.Valid, MessagesEnumeration.None);
    }

    private static ComputerComponentCompatibilityResult CpuCoolingSystemCompatibility(
        ComputerComponent component, IEnumerable<ComputerComponent> inputComponentsList)
    {
        var cpuCoolingSystem = (CpuCoolingSystem)component;

        foreach (ComputerComponent item in inputComponentsList)
        {
            if (item is Cpu cpu)
            {
                if (cpuCoolingSystem.Tdp < cpu.HeatGeneration)
                {
                    return new(
                        Outcome.Valid,
                        MessagesEnumeration.WaiverOfWarrantyDueToInsufficientPowerOfTheProcessorCoolingSystem);
                }
            }
        }

        return new(Outcome.Valid, MessagesEnumeration.None);
    }

    private static ComputerComponentCompatibilityResult WifiAdapterCompatibility(
         IEnumerable<ComputerComponent> inputComponentsList)
    {
        foreach (ComputerComponent item in inputComponentsList)
        {
            if (item is MotherBoard { HasBuiltInWifiModule: true })
                return new(Outcome.NonValid, MessagesEnumeration.MotherBoardHasBuiltInWifiModule);
        }

        return new(Outcome.Valid, MessagesEnumeration.None);
    }

    private static ComputerComponentCompatibilityResult FrameCompatibility(
        ComputerComponent component, IEnumerable<ComputerComponent> inputComponentsList)
    {
        var frame = (Frame)component;

        foreach (ComputerComponent item in inputComponentsList)
        {
            if (item is VideoCard videoCard)
            {
                if (videoCard.WidthGabarite > frame.MaximumVideoCardWidth ||
                    videoCard.LengthGabarite > frame.MaximumVideoCardLength)
                    return new(Outcome.NonValid, MessagesEnumeration.NotCompatibleVideoCard);
            }

            if (item is MotherBoard motherBoard)
            {
                if (frame.GetSupportedMotherBoardsPhormPhactorsList.All(formFactor =>
                        formFactor != motherBoard.FormFactor))
                    return new(Outcome.NonValid, MessagesEnumeration.NotCompatibleVideoCard);
            }
        }

        return new(Outcome.Valid, MessagesEnumeration.None);
    }

    private static ComputerComponentCompatibilityResult PowerUnitCompatibility(
        ComputerComponent component, IEnumerable<ComputerComponent> inputComponentsList)
    {
        var powerUnit = (PowerUnit)component;

        double totalPowerConsumption = 0;

        foreach (ComputerComponent item in inputComponentsList)
        {
            if (item is Cpu cpu)
            {
                totalPowerConsumption += cpu.PowerConsumption;
            }

            if (item is Ram ram)
            {
                totalPowerConsumption += ram.PowerConsumption;
            }

            if (item is VideoCard videoCard)
            {
                totalPowerConsumption += videoCard.PowerConsumption;
            }

            if (item is Hdd hdd)
            {
                totalPowerConsumption += hdd.PowerConsumption;
            }

            if (item is SsdDrive ssd)
            {
                totalPowerConsumption += ssd.PowerConsumption;
            }

            if (item is WifiAdapter wifiAdapter)
            {
                totalPowerConsumption += wifiAdapter.PowerConsumption;
            }

            if (powerUnit.PeakLoad < totalPowerConsumption)
            {
                return new(
                    Outcome.Valid,
                    MessagesEnumeration.WarningInsufficientPowerSupplyPower);
            }
        }

        return new(Outcome.Valid, MessagesEnumeration.None);
    }
}