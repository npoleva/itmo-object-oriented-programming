namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerComponentRecords;

public record WifiAdapterRecord : ComputerComponentRecord
{
    public WifiAdapterRecord(
        string wifiAdapterName,
        int wifiAdapterVersionStandart,
        bool hasBluetoothModule,
        int pciEVersion,
        double powerConsumption)
    : base("Wifi Adapter")
    {
        WifiAdapterName = wifiAdapterName;
        WifiAdapterVersionStandart = wifiAdapterVersionStandart;
        HasBluetoothModule = hasBluetoothModule;
        PciEVersion = pciEVersion;
        PowerConsumption = powerConsumption;
    }

    public string WifiAdapterName { get; init; }
    public int WifiAdapterVersionStandart { get; init; }
    public bool HasBluetoothModule { get; init; }
    public int PciEVersion { get;  init; }
    public double PowerConsumption { get; init; }
}