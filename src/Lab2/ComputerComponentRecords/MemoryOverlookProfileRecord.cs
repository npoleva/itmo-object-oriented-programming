namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerComponentRecords;

public record MemoryOverlookProfileRecord : ComputerComponentRecord
{
    public MemoryOverlookProfileRecord(
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
        Frequency = frequency;
        Voltage = voltage;
    }

    public string MemoryOverlookProfileType { get; init; }
    public int TimingCasLatency { get; private set; }
    public int TimingTrcd { get; private set; }
    public int TimingTrp { get; private set; }
    public double Frequency { get; init; }
    public double Voltage { get; init; }
}