namespace Itmo.ObjectOrientedProgramming.Lab1.Obstacles;

public class SpaceWhales : INebulaNitrineObstacle
{
    public string ObstacleTypeName { get; set; } = "Space Whale";
    public IObstacle DefectDamage()
    {
        return new SpaceWhales();
    }
}