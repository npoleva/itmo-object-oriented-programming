using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Deflectors;

public class DeflectorClassSecond : Deflector
{
    public DeflectorClassSecond()
        : base(new List<StrengthResourceRecord>()
            {
                new StrengthResourceRecord(
                    "SmallAsteroids",
                    DeflectorDefaultValues.DeflectorClassSecondSmallAsteroidsStrengthResistance),
                new StrengthResourceRecord(
                    "Meteorite",
                    DeflectorDefaultValues.DeflectorClassSecondMeteoriteStrengthResistance),
                new StrengthResourceRecord(
                    "SpaceWhale",
                    DeflectorDefaultValues.DeflectorClassSecondSpaceWhaleStrengthResistance),
                new StrengthResourceRecord(
                    "AntimatterFlares",
                    DeflectorDefaultValues.DeflectorClassSecondAntimatterFlaresStrengthResistance),
            })
    {
    }

    public override bool IsWorking { get; protected set; } = true;

    public override void ReceiveDamage(IObstacle obstacle)
    {
        if (obstacle is SmallAsteroids &&
            StrengthResourceRecords.Any(tmp => tmp is { ObstacleType: "SmallAsteroids",
                StrengthResource: > 0 }) &&
            StrengthResourceRecords.Any(tmp => tmp.ObstacleType == "Meteorite" &&
                tmp.StrengthResource == DeflectorDefaultValues.DeflectorClassSecondMeteoriteStrengthResistance))
        {
            StrengthResourceChanging("SmallAsteroids");
        }
        else if (obstacle is Meteorite &&
                 StrengthResourceRecords.Any(tmp => tmp is { ObstacleType: "Meteorite",
                     StrengthResource: > 0 }) &&
                 StrengthResourceRecords.Any(tmp => tmp.ObstacleType == "SmallAsteroids" &&
                     tmp.StrengthResource == DeflectorDefaultValues.DeflectorClassSecondSmallAsteroidsStrengthResistance))
        {
            StrengthResourceChanging("Meteorite");
        }
        else
        {
            IsWorking = false;
        }
    }
}