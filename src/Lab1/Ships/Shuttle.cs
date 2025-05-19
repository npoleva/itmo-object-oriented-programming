using Itmo.ObjectOrientedProgramming.Lab1.Engines;
using Itmo.ObjectOrientedProgramming.Lab1.HullStrengthClasses;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships;

public class Shuttle : Ship
{
    public Shuttle()
        : base(new HullStrengthClassFirst(ShipDefaultValues.SmallShipCoefficient))
    {
        var pulseEngineClassC = new PulseEngineClassC();
        AddEngine(pulseEngineClassC);
        HasPhotonDeflectors = false;
    }

    public override bool HasAntinitrineEmitter => false;

    protected override void ReceiveDamage(IObstacle obstacle)
    {
        if (obstacle is SmallAsteroids && HullStrengthClass.IsAnyStrengthReserve)
        {
            HullStrengthClass.ReceiveDamage(obstacle);
        }
        else if (obstacle is AntimatterFlares)
        {
            CrewHasDied();
        }
        else
        {
            Destroy();
        }
    }
}