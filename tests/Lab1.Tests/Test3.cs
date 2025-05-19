using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Ships;
using Itmo.ObjectOrientedProgramming.Lab1.SpaceRoutes;
using Itmo.ObjectOrientedProgramming.Lab1.Surroundings;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;
public class Test3
{
    public static IEnumerable<object[]> DamagedTestData()
    {
        yield return new object[]
        {
            new Vaklas(false), new SpaceRoute(new List<RouteSegment>
            {
                new RouteSegment(
                    new NebulaNitrineParticlesSurrounding(new List<INebulaNitrineObstacle>()
                        {
                            new SpaceWhales(),
                        }),
                    1.0),

                new RouteSegment(
                    new NebulaNitrineParticlesSurrounding(
                        null),
                    1.0),
            }),
        };
    }

    public static IEnumerable<object[]> LostDeflectorsTestData()
    {
        yield return new object[]
        {
            new Avgur(false), new SpaceRoute(new List<RouteSegment>
            {
                new RouteSegment(
                    new NebulaNitrineParticlesSurrounding(new List<INebulaNitrineObstacle>()
                    {
                        new SpaceWhales(),
                    }),
                    1.0),

                new RouteSegment(
                    new NebulaNitrineParticlesSurrounding(
                        null),
                    1.0),
            }),
        };
    }

    public static IEnumerable<object[]> SuccessfulOutcomeTestData()
    {
        yield return new object[]
        {
            new Meridian(false), new SpaceRoute(new List<RouteSegment>
            {
                new RouteSegment(
                    new NebulaNitrineParticlesSurrounding(new List<INebulaNitrineObstacle>()
                    {
                        new SpaceWhales(),
                    }),
                    1.0),

                new RouteSegment(
                    new NebulaNitrineParticlesSurrounding(
                        null),
                    1.0),
            }),
        };
    }

    [Theory]
    [MemberData(nameof(DamagedTestData))]
    public void TryRouteShouldReturnDestroyedVaklasOutcome(Ship? ship, SpaceRoute spaceRoute)
    {
        if (ship == null) return;

        ShipOutcome shipResult = ShipChecker.TryRoute(ship, spaceRoute).Outcome;

        ShipOutcome expectedResult = ShipOutcome.ShipDestroyed;

        Assert.Equal(expectedResult, shipResult);
    }

    [Theory]
    [MemberData(nameof(LostDeflectorsTestData))]
    public void TryRouteShouldReturnLostDeflectorsAvgurOutcome(Ship? ship, SpaceRoute spaceRoute)
    {
        if (ship == null) return;

        ShipOutcome shipResult = ShipChecker.TryRoute(ship, spaceRoute).Outcome;

        ShipOutcome expectedResult = ShipOutcome.Success;

        Assert.Equal(expectedResult, shipResult);

        Assert.False(ship.HasDeflectors);
    }

    [Theory]
    [MemberData(nameof(LostDeflectorsTestData))]
    public void TryRouteShouldReturnSuccessfulMeridianOutcome(Ship? ship, SpaceRoute spaceRoute)
    {
        if (ship == null) return;

        ShipOutcome shipResult = ShipChecker.TryRoute(ship, spaceRoute).Outcome;

        ShipOutcome expectedResult = ShipOutcome.Success;

        Assert.Equal(expectedResult, shipResult);
    }
}