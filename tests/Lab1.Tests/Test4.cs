using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Ships;
using Itmo.ObjectOrientedProgramming.Lab1.SpaceRoutes;
using Itmo.ObjectOrientedProgramming.Lab1.Surroundings;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;

public class Test4
{
    [Fact]
    public void ShipSuitabilityCompareShuttleAndVaklasResultr()
    {
        var ship1 = new Vaklas(false);
        var ship2 = new Shuttle();

        var spaceRoute = new SpaceRoute(
            new List<RouteSegment>
            {
                new RouteSegment(
                        new NormalSpaceSurrounding(
                            new List<INormalSpaceObstacle>()
                            {
                                new Meteorite(),
                            }),
                        1.0),
            });

        double fuelVaklasResult = ShipChecker.ShipSuitability(ship1, spaceRoute).FuelResult;

        double fuelShuttleResult = ShipChecker.ShipSuitability(ship2, spaceRoute).FuelResult;

        Assert.True(fuelVaklasResult > fuelShuttleResult);
    }
}