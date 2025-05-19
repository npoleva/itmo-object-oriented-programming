using Itmo.ObjectOrientedProgramming.Lab2.Builder;

namespace Itmo.ObjectOrientedProgramming.Lab2.Configurator;

public class ComputerBaseConfigurator : BaseConfigurator
{
    private readonly ComputerBuilder _computerBuilder;

    public ComputerBaseConfigurator(ComputerBuilder builder)
    {
        _computerBuilder = builder;
    }

    public override void Construct()
    {
        _computerBuilder.TryBuildComputer();
    }
}