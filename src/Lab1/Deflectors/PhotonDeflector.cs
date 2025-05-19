using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Deflectors;

public class PhotonDeflector : Deflector
{
    public PhotonDeflector()
        : base(new List<StrengthResourceRecord>()
            {
                new StrengthResourceRecord(
                    "SmallAsteroids",
                    DeflectorDefaultValues.PhotonDeflectorSmallAsteroidsStrengthResistance),
                new StrengthResourceRecord(
                    "Meteorite",
                    DeflectorDefaultValues.PhotonDeflectorMeteoriteStrengthResistance),
                new StrengthResourceRecord(
                    "SpaceWhale",
                    DeflectorDefaultValues.PhotonDeflectorSpaceWhaleStrengthResistance),
                new StrengthResourceRecord(
                    "AntimatterFlares",
                    DeflectorDefaultValues.PhotonDeflectorAntimatterFlaresStrengthResistance),
            })
    {
    }

    public override bool IsWorking { get; protected set; } = true;

    public override void ReceiveDamage(IObstacle obstacle)
    {
        if (obstacle is AntimatterFlares &&
            StrengthResourceRecords.Any(tmp => tmp is { ObstacleType: "AntimatterFlares",
                StrengthResource: > 0 }))
        {
            StrengthResourceChanging("AntiMatterFlares");
        }
        else
        {
            IsWorking = false;
        }
    }
}