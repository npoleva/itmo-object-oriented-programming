using Itmo.ObjectOrientedProgramming.Lab1.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Engines;
using Itmo.ObjectOrientedProgramming.Lab1.HullStrengthClasses;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships;

public class Avgur : Ship
{
    public Avgur(bool hasPhotonDeflectors)
        : base(new HullStrengthClassThird(ShipDefaultValues.BigShipCoefficient))
    {
        var pulseEngineCLassE = new PulseEngineClassE();
        AddEngine(pulseEngineCLassE);
        var jumpEngineAlpha = new JumpEngineAlpha();
        AddEngine(jumpEngineAlpha);
        var deflectorClass3 = new DeflectorClassThird();
        AddDeflector(deflectorClass3);
        HasPhotonDeflectors = hasPhotonDeflectors;
        TryAddPhotonDeflector();
    }

    public override bool HasAntinitrineEmitter => false;

    protected override void ReceiveDamage(IObstacle obstacle)
    {
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