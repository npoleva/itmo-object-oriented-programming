namespace Itmo.ObjectOrientedProgramming.Lab1;

public record StrengthResourceRecord
{
    public StrengthResourceRecord(string obstacleType, int strengthResource)
    {
        ObstacleType = obstacleType;
        StrengthResource = strengthResource;
    }

    public string ObstacleType { get; init; }
    public int StrengthResource { get; init; }
}