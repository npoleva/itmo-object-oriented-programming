namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerComponents;

public class VideoCard : ComputerComponent
{
    public VideoCard(
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

    public string VideoCardName { get; private set; }
    public double LengthGabarite { get; private set; }
    public double WidthGabarite { get; private set; }
    public int VideoMemoryCapacity { get; private set; }
    public int PciEVersion { get; private set; }
    public int VideoChipFrequency { get; private set; }
    public double PowerConsumption { get; private set; }
}