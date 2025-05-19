using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Ships;
using Itmo.ObjectOrientedProgramming.Lab1.SpaceRoutes;
using Itmo.ObjectOrientedProgramming.Lab1.Surroundings;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;
public class Test1
{
    public static IEnumerable<object[]> UnsuccessfulTestData1()
    {
        yield return new object[]
        {
            new Shuttle(), new SpaceRoute(new List<RouteSegment>
            {
                new RouteSegment(
                    new HighDensityNebulaSurrounding(new List<IHighDensityNebulaObstacle>()
                    {
                        new AntimatterFlares(),
                    }),
                    1.0),

                new RouteSegment(
                    new HighDensityNebulaSurrounding(new List<IHighDensityNebulaObstacle>()
                    {
                        new AntimatterFlares(),
                    }),
                    1.0),
            }),
        };
    }

    public static IEnumerable<object[]> UnsuccessfulTestData2()
    {
        yield return new object[]
        {
            new Avgur(false), new SpaceRoute(new List<RouteSegment>
            {
                new RouteSegment(
                    new HighDensityNebulaSurrounding(new List<IHighDensityNebulaObstacle>()
                    {
                        new AntimatterFlares(),
                    }),
                    1.0),

                new RouteSegment(
                    new HighDensityNebulaSurrounding(new List<IHighDensityNebulaObstacle>()
                    {
                        new AntimatterFlares(),
                    }),
                    1.0),
            }),
        };
    }

    [Theory]
    [MemberData(nameof(UnsuccessfulTestData1))]
    public void TryRouteShouldReturnUnsuccessfulShuttleOutcome(Ship? ship, SpaceRoute spaceRoute)
    {
        if (ship == null) return;

        ShipOutcome shipResult = ShipChecker.TryRoute(ship, spaceRoute).Outcome;

        ShipOutcome expectedResult1 = ShipOutcome.Success;

        Assert.NotEqual(shipResult, expectedResult1);
    }

    [Theory]
    [MemberData(nameof(UnsuccessfulTestData2))]
    public void TryRouteShouldReturnUnsuccessfulAvgurOutcome(Ship? ship, SpaceRoute spaceRoute)
    {
        if (ship == null) return;

        ShipOutcome shipResult = ShipChecker.TryRoute(ship, spaceRoute).Outcome;

        ShipOutcome expectedResult1 = ShipOutcome.Success;

        Assert.NotEqual(shipResult, expectedResult1);
    }
}
