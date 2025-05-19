using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.HullStrengthClasses;

public class HullStrengthClassFirst : HullStrengthClass
{
    public HullStrengthClassFirst(int shipSize)
        : base(
            shipSize,
            new List<StrengthResourceRecord>()
            {
                new StrengthResourceRecord("SmallAsteroids", 1),
                new StrengthResourceRecord("Meteorite", 0),
            })
    {
    }

    public override bool IsAnyStrengthReserve { get; protected set; } = true;

    public override void ReceiveDamage(IObstacle obstacle)
    {
        if (obstacle is SmallAsteroids &&
            StrengthResourceRecords.Any(tmp => tmp is { ObstacleType: "SmallAsteroids",
                StrengthResource: 1 }))
        {
            StrengthResourceChanging("SmallAsteroids");

            IsAnyStrengthReserve = false;
        }
        else
        {
            IsAnyStrengthReserve = false;
        }
    }
}