using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerComponentRecords;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerComponents;

namespace Itmo.ObjectOrientedProgramming.Lab2.Builder;

public class NewComputerBuilder : ComputerBuilder
{
    internal NewComputerBuilder(ComputerRecord inputComputer)
    {
        InputTrialComputer = inputComputer.ComputerComponentsList;
        BuilderResult = new ComputerBuilderResult();
        InputComputer = inputComputer;
    }

    private IEnumerable<ComputerComponent> InputTrialComputer { get; set; }
    private ComputerRecord InputComputer { get; set; }
    private ComputerBuilderResult BuilderResult { get; set; }

    public override void TryBuildComputer()
    {
        ArrangeComponentsAccordingToCheckList(InputTrialComputer);

        foreach (ComputerComponent item in InputTrialComputer)
        {
            ComputerComponentCompatibilityResult itemResult =
                BuilderCheckMethods.IsCompatible(item, InputTrialComputer);

            BuilderResult.AddMessage(itemResult.Message);

            if (itemResult.BuildingOutcome == Outcome.NonValid)
                BuilderResult.BuildingOutcome = Outcome.NonValid;
        }

        if (BuilderResult.BuildingOutcome != Outcome.NonValid) BuilderResult.BuildingOutcome = Outcome.Valid;
    }

    public override ComputerBuilderResult GetComputerResult()
    {
        if (BuilderResult.BuildingOutcome == Outcome.Valid)
        {
            BuilderResult.BuildedComputer = new Computer(
                InputComputer.ComputerName,
                InputComputer.ComputerMotherBoard,
                InputComputer.ComputerCpu,
                InputComputer.ComputerBios,
                InputComputer.ComputerCpuCoolingSystem,
                InputComputer.ComputerFrame,
                InputComputer.ComputerRam,
                InputComputer.ComputerDrive,
                InputComputer.ComputerAdditionalDrive,
                InputComputer.ComputerPowerUnit,
                InputComputer.ComputerVideoCard,
                InputComputer.ComputerMemoryOverlookProfile,
                InputComputer.ComputerWifiAdapter);
        }

        return BuilderResult;
    }
}