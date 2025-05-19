using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Surroundings;

public abstract class Surrounding
{
    private readonly List<IObstacle> _obstaclesList;

    protected Surrounding(IEnumerable<IObstacle>? obstacles)
    {
        _obstaclesList = new List<IObstacle>(obstacles ?? Enumerable.Empty<IObstacle>());
    }

    public IEnumerable<IObstacle> Obstacles => _obstaclesList;

    public void AddNewAllowedObstaclesList(IEnumerable<IObstacle> newAllowedObstaclesList)
    {
        _obstaclesList.AddRange(newAllowedObstaclesList);
    }
}