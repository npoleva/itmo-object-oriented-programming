using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerComponents;

namespace Itmo.ObjectOrientedProgramming.Lab2.Builder;

public abstract class ComputerBuilder : Builder
{
    protected ComputerBuilderResult? BuildResult { get; set; }
    public abstract void TryBuildComputer();
    public abstract ComputerBuilderResult GetComputerResult();

    protected static IEnumerable<ComputerComponent> ArrangeComponentsAccordingToCheckList(
        IEnumerable<ComputerComponent> componentsList)
    {
        IEnumerable<string> componentOrderChecklist = CheckList.GetComponentOrderCheckList;

        IEnumerable<ComputerComponent> temporaryComponentsList = componentsList;

        IEnumerable<ComputerComponent> orderedComponents = componentOrderChecklist
            .SelectMany(componentType =>
                temporaryComponentsList.Where(comp => comp.ComputerComponentTypeName == componentType));

        return orderedComponents;
    }
}