using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Surroundings;
public class HighDensityNebulaSurrounding : Surrounding
{
    public HighDensityNebulaSurrounding(IEnumerable<IHighDensityNebulaObstacle>? obstaclesList)
        : base(obstaclesList)
    {
    }
}