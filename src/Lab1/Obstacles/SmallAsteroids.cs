namespace Itmo.ObjectOrientedProgramming.Lab1.Obstacles;

public class SmallAsteroids : INormalSpaceObstacle
{
    public string ObstacleTypeName { get; set; } = "Small Asteroid";

    public IObstacle DefectDamage()
    {
        return new SmallAsteroids();
    }
}
