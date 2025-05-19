using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab1.Obstacles;

public static class ObstacleTypeNames
{
    private static readonly List<string> ObstaclesTypeNamesList = new()
    {
        "Small Asteroid",
        "Meteorite",
        "Antimatter Flares",
        "Space Whale",
    };

    public static IEnumerable<string> ObstaclesTypeNames => ObstaclesTypeNamesList;

    public static void AddNewObstacleTypeName(string obstacleName)
    {
        ObstaclesTypeNamesList.Add(obstacleName);
    }
}