namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerComponentRecords;

public record VideoCardRecord : ComputerComponentRecord
{
    public VideoCardRecord(
        string videoCardName,
        double lengthGabarite,
        double widthGabarite,
        int videoMemoryCapacity,
        int pciEVersion,
        int videoChipFrequency,
        double powerConsumption)
    : base("Video card")
    {
        VideoCardName = videoCardName;
        LengthGabarite = lengthGabarite;
        WidthGabarite = widthGabarite;
        VideoMemoryCapacity = videoMemoryCapacity;
        PciEVersion = pciEVersion;
        VideoChipFrequency = videoChipFrequency;
        PowerConsumption = powerConsumption;
    }

    public string VideoCardName { get; init; }
    public double LengthGabarite { get; private set; }
    public double WidthGabarite { get; private set; }
    public int VideoMemoryCapacity { get; init; }
    public int PciEVersion { get; init; }
    public int VideoChipFrequency { get; init; }
    public double PowerConsumption { get; init; }
}