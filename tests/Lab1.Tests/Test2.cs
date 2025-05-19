using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Ships;
using Itmo.ObjectOrientedProgramming.Lab1.SpaceRoutes;
using Itmo.ObjectOrientedProgramming.Lab1.Surroundings;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;
public class Test2
{
    public static IEnumerable<object[]> SuccessfulTestData()
    {
        yield return new object[]
        {
            new Vaklas(true), new SpaceRoute(new List<RouteSegment>
            {
                new RouteSegment(
                    new HighDensityNebulaSurrounding(
                        new List<IHighDensityNebulaObstacle>()
                        {
                            new AntimatterFlares(),
                        }),
                    1.0),

                new RouteSegment(
                    new HighDensityNebulaSurrounding(
                        new List<IHighDensityNebulaObstacle>()
                        {
                            new AntimatterFlares(),
                        }),
                    1.0),

                new RouteSegment(
                    new HighDensityNebulaSurrounding(
                        new List<IHighDensityNebulaObstacle>()
                        {
                            new AntimatterFlares(),
                        }),
                    1.0),
            }),
        };
    }

    public static IEnumerable<object[]> UnsuccessfulTestData()
    {
        yield return new object[]
        {
            new Vaklas(false), new SpaceRoute(new List<RouteSegment>
            {
                new RouteSegment(
                    new HighDensityNebulaSurrounding(
                        new List<IHighDensityNebulaObstacle>()
                        {
                            new AntimatterFlares(),
                        }),
                    1.0),

                new RouteSegment(
                    new HighDensityNebulaSurrounding(
                        new List<IHighDensityNebulaObstacle>()
                        {
                            new AntimatterFlares(),
                        }),
                    1.0),

                new RouteSegment(
                    new HighDensityNebulaSurrounding(
                        new List<IHighDensityNebulaObstacle>()
                        {
                            new AntimatterFlares(),
                        }),
                    1.0),
            }),
        };
    }

    [Theory]
    [MemberData(nameof(UnsuccessfulTestData))]
    public void TryRouteShouldReturnUnsuccessfulVaklasOutcome(Ship? ship, SpaceRoute spaceRoute)
    {
        if (ship == null) return;

        ShipOutcome shipResult = ShipChecker.TryRoute(ship, spaceRoute).Outcome;

        ShipOutcome expectedResult = ShipOutcome.CrewCasualty;

        Assert.Equal(expectedResult, shipResult);
    }

    [Theory]
    [MemberData(nameof(SuccessfulTestData))]
    public void TryRouteShouldReturnSuccessfulVaklasOutcome(Ship? ship, SpaceRoute spaceRoute)
    {
        if (ship == null) return;

        ShipOutcome shipResult = ShipChecker.TryRoute(ship, spaceRoute).Outcome;

        ShipOutcome expectedResult = ShipOutcome.Success;

        Assert.Equal(expectedResult, shipResult);
    }
}