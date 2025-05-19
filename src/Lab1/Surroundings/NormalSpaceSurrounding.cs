using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Surroundings;

public class NormalSpaceSurrounding : Surrounding
{
    public NormalSpaceSurrounding(
        IEnumerable<INormalSpaceObstacle>? obstaclesList)
        : base(obstaclesList)
    {
    }
}