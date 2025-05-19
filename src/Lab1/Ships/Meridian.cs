using Itmo.ObjectOrientedProgramming.Lab1.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Engines;
using Itmo.ObjectOrientedProgramming.Lab1.HullStrengthClasses;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships;

public class Meridian : Ship
{
    public Meridian(bool hasPhotonDeflector)
        : base(new HullStrengthClassSecond(ShipDefaultValues.MiddleShipCoefficient))
    {
        var pulseEngineCLassE = new PulseEngineClassE();
        AddEngine(pulseEngineCLassE);
        var deflectorClass2 = new DeflectorClassSecond();
        AddDeflector(deflectorClass2);
        HasPhotonDeflectors = hasPhotonDeflector;
        TryAddPhotonDeflector();
    }

    public override bool HasAntinitrineEmitter => true;

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