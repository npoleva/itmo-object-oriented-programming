using Itmo.ObjectOrientedProgramming.Lab1.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Engines;
using Itmo.ObjectOrientedProgramming.Lab1.HullStrengthClasses;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships;

public class Stella : Ship
{
    public Stella(bool hasPhotonDeflectors)
        : base(new HullStrengthClassFirst(ShipDefaultValues.SmallShipCoefficient))
    {
        var pulseEngineCLassC = new PulseEngineClassC();
        AddEngine(pulseEngineCLassC);
        var jumpEngineOmega = new JumpEngineOmega();
        AddEngine(jumpEngineOmega);
        var deflectorClass1 = new DeflectorClassFirst();
        AddDeflector(deflectorClass1);
        HasPhotonDeflectors = hasPhotonDeflectors;
        TryAddPhotonDeflector();
    }

    public override bool HasAntinitrineEmitter => false;

    protected override void ReceiveDamage(IObstacle obstacle)
    {
        if (obstacle is SpaceWhales) Destroy();

        bool damageHandled = false;

        if (obstacle is AntimatterFlares && HasPhotonDeflectors)
        {
            foreach (Deflector item in Deflectors)
            {
                if (item is PhotonDeflector && item.IsWorking)
                {
                    item.ReceiveDamage(obstacle);
                    return;
                }

                if (item is PhotonDeflector && !item.IsWorking) HasPhotonDeflectors = false;
            }
        }

        if (obstacle is AntimatterFlares && !HasPhotonDeflectors)
            CrewHasDied();

        foreach (Deflector item in Deflectors)
        {
            if (item.IsWorking)
            {
                item.ReceiveDamage(obstacle);
                damageHandled = true;
                break;
            }
        }

        if (!damageHandled && HullStrengthClass.IsAnyStrengthReserve)
            HullStrengthClass.ReceiveDamage(obstacle);

        if (!HullStrengthClass.IsAnyStrengthReserve) Destroy();
    }
}