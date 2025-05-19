namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerComponents;

public class MemoryOverlookProfile : ComputerComponent
{
    public MemoryOverlookProfile(
        string memoryOverlookProfileType,
        int timingCasLatency,
        int timingTrp,
        int timingTrcd,
        double frequency,
        double voltage)
    : base("Memory Overlook Profile")
    {
        MemoryOverlookProfileType = memoryOverlookProfileType;
        TimingCasLatency = timingCasLatency;
        TimingTrp = timingTrp;
        TimingTrcd = timingTrcd;
        Frequency = frequency;
        Voltage = voltage;
    }

    public string MemoryOverlookProfileType { get; private set; }
    public int TimingCasLatency { get; private set; }
    public int TimingTrcd { get; private set; }
    public int TimingTrp { get; private set; }
    public double Frequency { get; private set; }
    public double Voltage { get; private set; }
}