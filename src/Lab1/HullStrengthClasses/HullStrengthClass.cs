using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.HullStrengthClasses;

public abstract class HullStrengthClass
{
    private readonly List<StrengthResourceRecord> _strengthResourceRecords;
    protected HullStrengthClass(
        int shipSize,
        IEnumerable<StrengthResourceRecord> certainStrengthResourceRecords)
    {
        _strengthResourceRecords = new List<StrengthResourceRecord>(
            certainStrengthResourceRecords.Select(record => new StrengthResourceRecord(
                record.ObstacleType, record.StrengthResource * shipSize)));
    }

    public abstract bool IsAnyStrengthReserve { get; protected set; }
    protected IEnumerable<StrengthResourceRecord> StrengthResourceRecords => _strengthResourceRecords;

    public abstract void ReceiveDamage(IObstacle obstacle);
    protected void StrengthResourceChanging(string obstacleType)
    {
        StrengthResourceRecord? record = _strengthResourceRecords.Find(tmp
            => tmp.ObstacleType == obstacleType);
        if (record == null) return;

        int indexOfRecord = _strengthResourceRecords.IndexOf(record);
        _strengthResourceRecords[indexOfRecord] = new StrengthResourceRecord(
            obstacleType,
            record.StrengthResource - 1);
    }

    protected void AddNewStrengthResourceItem(string obstacleType, int strengthResource)
    {
        _strengthResourceRecords.Add(new StrengthResourceRecord(obstacleType, strengthResource));
    }
}