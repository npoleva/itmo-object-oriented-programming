using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerComponents;

public class Bios : ComputerComponent
{
    private readonly List<string> _supportedCpuList;

    public Bios(
    string biosName,
    string biosVersion,
    IEnumerable<string> supportedCpu)
    : base("BIOS")
    {
        BiosName = biosName;
        BiosVersion = biosVersion;
        _supportedCpuList = new List<string>(supportedCpu);
    }

    public string BiosName { get; private set; }
    public string BiosVersion { get; private set; }

    public IEnumerable<string> GetSupportedCpuList => _supportedCpuList;
}