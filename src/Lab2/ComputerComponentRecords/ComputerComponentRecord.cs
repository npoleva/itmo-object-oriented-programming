namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerComponentRecords;

public abstract record ComputerComponentRecord
{
    protected ComputerComponentRecord(string computerComponentTypeName)
    {
        ComputerComponentTypeName = computerComponentTypeName;
    }

    public string ComputerComponentTypeName { get; protected set; }
}