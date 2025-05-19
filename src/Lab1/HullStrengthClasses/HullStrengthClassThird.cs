using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.HullStrengthClasses;

public class HullStrengthClassThird : HullStrengthClass
{
    public HullStrengthClassThird(int shipSize)
        : base(
            shipSize,
            new List<StrengthResourceRecord>()
            {
                new StrengthResourceRecord("SmallAsteroids", 20),
                new StrengthResourceRecord("Meteorite", 5),
            })
    {
    }

    public override bool IsAnyStrengthReserve { get; protected set; } = true;

    public override void ReceiveDamage(IObstacle obstacle)
    {
        if (obstacle is SmallAsteroids &&
            StrengthResourceRecords.Any(tmp => tmp is { ObstacleType: "SmallAsteroids",
                StrengthResource: > 0 }) &&
            StrengthResourceRecords.Any(tmp => tmp is { ObstacleType: "Meteorite",
                StrengthResource: 5 }))
        {
            StrengthResourceChanging("SmallAsteroids");
        }
        else if (obstacle is Meteorite &&
                 StrengthResourceRecords.Any(tmp => tmp is { ObstacleType: "Meteorite",
                     StrengthResource: > 0 }) &&
                 StrengthResourceRecords.Any(tmp => tmp is { ObstacleType: "SmallAsteroids",
                     StrengthResource: 20 }))
        {
            StrengthResourceChanging("Meteorite");
        }
        else
        {
            IsAnyStrengthReserve = false;
        }
    }
}