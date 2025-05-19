using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Ships;
using Itmo.ObjectOrientedProgramming.Lab1.SpaceRoutes;
using Itmo.ObjectOrientedProgramming.Lab1.Surroundings;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;

public class Test6
{
    [Fact]
    public void CompareAvgurAndStellaResults()
    {
        var ship1 = new Shuttle();
        var ship2 = new Vaklas(false);

        var spaceRoute = new SpaceRoute(
            new List<RouteSegment>
            {
                new RouteSegment(
                    new NebulaNitrineParticlesSurrounding(
                        new List<INebulaNitrineObstacle>
                        {
                            new SpaceWhales(),
                        }),
                    1.0),
            });

        Assert.True(ShipChecker.ShipSuitability(ship1, spaceRoute).TotalResult
                    < ShipChecker.ShipSuitability(ship2, spaceRoute).TotalResult);
    }
}