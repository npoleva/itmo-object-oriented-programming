using System.Collections.Generic;
namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerComponentRecords;

public record CpuCoolingSystemRecord : ComputerComponentRecord
{
    private readonly List<string> _supportedSockets;

    public CpuCoolingSystemRecord(
        string cpuCoolingSystemName,
        double lengthGabariteParameter,
        double heightGabariteParameter,
        double widthGabariteParameter,
        int tdp,
        IEnumerable<string> supportedSockets)
    : base("CPU Cooling System")
    {
        CpuCoolingSystemName = cpuCoolingSystemName;
        LengthGabariteParameter = lengthGabariteParameter;
        HeightGabariteParameter = heightGabariteParameter;
        WidthGabariteParameter = widthGabariteParameter;
        Tdp = tdp;
        _supportedSockets = new List<string>(supportedSockets);
    }

    public string CpuCoolingSystemName { get; init; }
    public double LengthGabariteParameter { get; init; }
    public double HeightGabariteParameter { get; init; }
    public double WidthGabariteParameter { get; init; }
    public int Tdp { get; init; }

    public IEnumerable<string> GetSupportedSocketsList => _supportedSockets;
}