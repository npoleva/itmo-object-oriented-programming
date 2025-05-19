namespace Itmo.ObjectOrientedProgramming.Lab1.Obstacles;

public interface IObstacle
{
    public string ObstacleTypeName { get; set; }
    public IObstacle DefectDamage();
}