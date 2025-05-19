namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerComponents;

public class WifiAdapter : ComputerComponent
{
    public WifiAdapter(
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

    public string WifiAdapterName { get; private set; }
    public int WifiAdapterVersionStandart { get; private set; }
    public bool HasBluetoothModule { get; private set; }
    public int PciEVersion { get; private set; }
    public double PowerConsumption { get; private set; }
}