namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerComponents;

public abstract class ComputerComponent
{
    protected ComputerComponent(string computerComponentTypeName)
    {
        ComputerComponentTypeName = computerComponentTypeName;
    }

    public string ComputerComponentTypeName { get; private set; }
}