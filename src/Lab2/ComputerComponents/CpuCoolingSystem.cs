using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerComponents;

public class CpuCoolingSystem : ComputerComponent
{
    private readonly List<string> _supportedSockets;

    public CpuCoolingSystem(
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

    public string CpuCoolingSystemName { get; private set; }
    public double LengthGabariteParameter { get; private set; }
    public double HeightGabariteParameter { get; private set; }
    public double WidthGabariteParameter { get; private set; }
    public int Tdp { get; private set; }

    public IEnumerable<string> GetSupportedSocketsList => _supportedSockets;
}