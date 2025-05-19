using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Surroundings;

public class NebulaNitrineParticlesSurrounding : Surrounding
{
    public NebulaNitrineParticlesSurrounding(IEnumerable<INebulaNitrineObstacle>? obstaclesList)
        : base(obstaclesList)
    {
    }
}