using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Deflectors;

public class DeflectorClassFirst : Deflector
{
    public DeflectorClassFirst()
        : base(new List<StrengthResourceRecord>()
            {
                new StrengthResourceRecord(
                    "Small Asteroid",
                    DeflectorDefaultValues.DeflectorClassFirstSmallAsteroidsStrengthResistance),
                new StrengthResourceRecord(
                    "Meteorite",
                    DeflectorDefaultValues.DeflectorClassFirstMeteoriteStrengthResistance),
                new StrengthResourceRecord(
                    "Space Whale",
                    DeflectorDefaultValues.DeflectorClassFirstSpaceWhaleStrengthResistance),
                new StrengthResourceRecord(
                    "Antimatter Flares",
                    DeflectorDefaultValues.DeflectorClassFirstAntimatterFlaresStrengthResistance),
            })
    {
    }

    public override bool IsWorking { get; protected set; } = true;

    public override void ReceiveDamage(IObstacle obstacle)
    {
        if (obstacle is SmallAsteroids &&
            StrengthResourceRecords.Any(tmp => tmp.ObstacleType == obstacle.ObstacleTypeName &&
                                               tmp.StrengthResource > 0) &&
            StrengthResourceRecords.Any(tmp => tmp.ObstacleType == "Meteorite" &&
                tmp.StrengthResource == DeflectorDefaultValues.DeflectorClassFirstMeteoriteStrengthResistance))
        {
            StrengthResourceChanging(obstacle.ObstacleTypeName);
        }
        else if (obstacle is Meteorite &&
                 StrengthResourceRecords.Any(tmp => tmp.ObstacleType == obstacle.ObstacleTypeName &&
                     tmp.StrengthResource > 0) &&
                 StrengthResourceRecords.Any(tmp => tmp.ObstacleType == "SmallAsteroids" &&
                     tmp.StrengthResource == DeflectorDefaultValues.DeflectorClassFirstSmallAsteroidsStrengthResistance))
        {
            StrengthResourceChanging(obstacle.ObstacleTypeName);

            IsWorking = false;
        }
        else
        {
            IsWorking = false;
        }
    }
}