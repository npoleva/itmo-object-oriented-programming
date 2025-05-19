using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Deflectors;

public class DeflectorClassThird : Deflector
{
    public DeflectorClassThird()
        : base(new List<StrengthResourceRecord>()
            {
                new StrengthResourceRecord(
                    "SmallAsteroids",
                    DeflectorDefaultValues.DeflectorClassFirstSmallAsteroidsStrengthResistance),
                new StrengthResourceRecord(
                    "Meteorite",
                    DeflectorDefaultValues.DeflectorClassThirdMeteoriteStrengthResistance),
                new StrengthResourceRecord(
                    "SpaceWhale",
                    DeflectorDefaultValues.DeflectorClassThirdSpaceWhaleStrengthResistance),
                new StrengthResourceRecord(
                    "AntimatterFlares",
                    DeflectorDefaultValues.DeflectorClassThirdAntimatterFlaresStrengthResistance),
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
                tmp.StrengthResource == DeflectorDefaultValues.DeflectorClassThirdMeteoriteStrengthResistance) &&
            StrengthResourceRecords.Any(tmp => tmp.ObstacleType == "SpaceWhales" &&
                tmp.StrengthResource == DeflectorDefaultValues.DeflectorClassThirdSpaceWhaleStrengthResistance))
        {
            StrengthResourceChanging("SmallAsteroids");
        }
        else if (obstacle is Meteorite &&
                 StrengthResourceRecords.Any(tmp => tmp.ObstacleType == "SmallAsteroids" &&
                     tmp.StrengthResource == DeflectorDefaultValues.DeflectorClassThirdSmallAsteroidsStrengthResistance) &&
                 StrengthResourceRecords.Any(tmp => tmp is { ObstacleType: "Meteorite",
                     StrengthResource: > 0 }) &&
                 StrengthResourceRecords.Any(tmp =>
                     tmp.ObstacleType == "SpaceWhales" &&
                     tmp.StrengthResource == DeflectorDefaultValues.DeflectorClassThirdSpaceWhaleStrengthResistance))
        {
            StrengthResourceChanging("Meteorite");
        }
        else if (obstacle is SpaceWhales &&
                 StrengthResourceRecords.Any(tmp =>
                     tmp.ObstacleType == "SmallAsteroids" &&
                     tmp.StrengthResource == DeflectorDefaultValues.DeflectorClassThirdSmallAsteroidsStrengthResistance) &&
                 StrengthResourceRecords.Any(tmp => tmp is { ObstacleType: "Meteorite",
                     StrengthResource: > 0 }) &&
                 StrengthResourceRecords.Any(tmp =>
                     tmp.ObstacleType == "SpaceWhales" &&
                     tmp.StrengthResource == DeflectorDefaultValues.DeflectorClassThirdSpaceWhaleStrengthResistance))
        {
            StrengthResourceChanging("SpaceWhales");

            IsWorking = false;
        }
        else
        {
            IsWorking = false;
        }
    }
}