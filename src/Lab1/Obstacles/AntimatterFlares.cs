namespace Itmo.ObjectOrientedProgramming.Lab1.Obstacles;

public class AntimatterFlares : IHighDensityNebulaObstacle
{
    public string ObstacleTypeName { get; set; } = "Antimatter Flares";

    public IObstacle DefectDamage()
    {
        return new AntimatterFlares();
    }
}