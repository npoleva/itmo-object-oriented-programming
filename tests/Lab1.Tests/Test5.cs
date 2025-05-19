using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Ships;
using Itmo.ObjectOrientedProgramming.Lab1.SpaceRoutes;
using Itmo.ObjectOrientedProgramming.Lab1.Surroundings;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;

public class Test5
{
    [Fact]
    public void ShipSuitabilityCompareAvgurAndStellResults()
    {
        var ship1 = new Avgur(false);

        var ship2 = new Stella(false);

        var spaceRoute = new SpaceRoute(
            new List<RouteSegment>
            {
                new RouteSegment(
                    new HighDensityNebulaSurrounding(
                        new List<IHighDensityNebulaObstacle>
                        {
                            new AntimatterFlares(),
                        }),
                    1.0),
            });

        Assert.True(ShipChecker.ShipSuitability(ship1, spaceRoute).TotalResult
                    < ShipChecker.ShipSuitability(ship2, spaceRoute).TotalResult);
    }
}