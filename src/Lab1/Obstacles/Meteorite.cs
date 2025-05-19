namespace Itmo.ObjectOrientedProgramming.Lab1.Obstacles;

public class Meteorite : INormalSpaceObstacle
{
    public string ObstacleTypeName { get; set; } = "Meteorite";
    public IObstacle DefectDamage()
    {
        return new Meteorite();
    }
}