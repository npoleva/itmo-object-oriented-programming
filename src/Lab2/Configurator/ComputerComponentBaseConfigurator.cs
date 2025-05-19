using Itmo.ObjectOrientedProgramming.Lab2.Builder;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerComponentRecords;

namespace Itmo.ObjectOrientedProgramming.Lab2.Configurator;

public class ComputerComponentBaseConfigurator : BaseConfigurator
{
    private readonly ComputerComponentBuilder _computerComponentBuilder;

    public ComputerComponentBaseConfigurator(ComputerComponentBuilder builder)
    {
        _computerComponentBuilder = builder;
    }

    public override void Construct()
    {
        if (_computerComponentBuilder.InputComputerComponentRecord is MotherBoardRecord)
        {
            _computerComponentBuilder.TryBuildMotherBoard();
        }
        else if (_computerComponentBuilder.InputComputerComponentRecord is CpuRecord)
        {
            _computerComponentBuilder.TryBuildCpu();
        }
        else if (_computerComponentBuilder.InputComputerComponentRecord is BiosRecord)
        {
            _computerComponentBuilder.TryBuildBios();
        }
        else if (_computerComponentBuilder.InputComputerComponentRecord is CpuCoolingSystemRecord)
        {
            _computerComponentBuilder.TryBuildCpuCoolingSystem();
        }
        else if (_computerComponentBuilder.InputComputerComponentRecord is RamRecord)
        {
            _computerComponentBuilder.TryBuildRam();
        }
        else if (_computerComponentBuilder.InputComputerComponentRecord is FrameRecord)
        {
            _computerComponentBuilder.TryBuildFrame();
        }
        else if (_computerComponentBuilder.InputComputerComponentRecord is HddRecord)
        {
            _computerComponentBuilder.TryBuildHdd();
        }
        else if (_computerComponentBuilder.InputComputerComponentRecord is SsdRecord)
        {
            _computerComponentBuilder.TryBuildSsd();
        }
        else if (_computerComponentBuilder.InputComputerComponentRecord is PowerUnitRecord)
        {
            _computerComponentBuilder.TryBuildPowerUnit();
        }
        else if (_computerComponentBuilder.InputComputerComponentRecord is VideoCardRecord)
        {
            _computerComponentBuilder.TryBuildVideoCard();
        }
        else if (_computerComponentBuilder.InputComputerComponentRecord is WifiAdapterRecord)
        {
            _computerComponentBuilder.TryBuildWifiAdapter();
        }
        else if (_computerComponentBuilder.InputComputerComponentRecord is MemoryOverlookProfileRecord)
        {
            _computerComponentBuilder.TryBuildMemoryOverlookProfile();
        }
    }
}