using System.Collections.Generic;
namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerComponentRecords;

public record BiosRecord : ComputerComponentRecord
{
    private readonly List<string> _supportedCpuList;

    public BiosRecord(
        string biosName,
        string biosVersion,
        IEnumerable<string> supportedCpu)
    : base("BIOS")
    {
        BiosName = biosName;
        BiosVersion = biosVersion;
        _supportedCpuList = new List<string>(supportedCpu);
    }

    public string BiosName { get; init; }
    public string BiosVersion { get; init; }

    public IEnumerable<string> GetSupportedCpuList => _supportedCpuList;
}