using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerComponents;

namespace Itmo.ObjectOrientedProgramming.Lab2.Builder;

public class BasedOnAnotherBuildComputerBuilder : ComputerBuilder
{
    internal BasedOnAnotherBuildComputerBuilder(
        Computer inputComputer,
        ComputerComponent newComputerComponent)
    {
        BuilderResult = new ComputerBuilderResult();
        InputComputer = inputComputer;
        NewComputerComponent = newComputerComponent;
    }

    private IEnumerable<ComputerComponent> InputTrialComputer => AddOrReplaceComputerComponent();
    private ComputerComponent NewComputerComponent { get; set; }
    private Computer InputComputer { get; set; }
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

    private IEnumerable<ComputerComponent> AddOrReplaceComputerComponent()
    {
        var temporaryComputerComponentsList = new List<ComputerComponent?>
        {
            InputComputer.ComputerMotherBoard, InputComputer.ComputerCpu, InputComputer.ComputerBios,
            InputComputer.ComputerCpuCoolingSystem, InputComputer.ComputerFrame, InputComputer.ComputerRam,
            InputComputer.ComputerDrive, InputComputer.ComputerAdditionalDrive, InputComputer.ComputerPowerUnit,
            InputComputer.ComputerVideoCard, InputComputer.ComputerMemoryOverlookProfile,
            InputComputer.ComputerWifiAdapter,
        };

        ComputerComponent? existingComponent = temporaryComputerComponentsList.FirstOrDefault(item =>
            item?.ComputerComponentTypeName == NewComputerComponent.ComputerComponentTypeName);

        if (existingComponent != null)
        {
            int index = temporaryComputerComponentsList.IndexOf(existingComponent);
            temporaryComputerComponentsList[index] = NewComputerComponent;
        }
        else
        {
            temporaryComputerComponentsList.Add(NewComputerComponent);
        }

        return temporaryComputerComponentsList.Where(item => item != null).Cast<ComputerComponent>();
    }
}