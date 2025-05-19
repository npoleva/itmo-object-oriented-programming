using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles;
using Itmo.ObjectOrientedProgramming.Lab1.SpaceRoutes;
using Itmo.ObjectOrientedProgramming.Lab1.Surroundings;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;

public class Test7
{
    [Fact]
    public void SpaceRouteShouldCreateCorrectSpaceRoutesWithSeveralSegmentsWithAndWithoutObstacles()
    {
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

                new RouteSegment(
                    new NormalSpaceSurrounding(
                        new List<INormalSpaceObstacle>
                        {
                            new Meteorite(),
                            new SmallAsteroids(),
                        }),
                    1.0),
                new RouteSegment(
                    new NebulaNitrineParticlesSurrounding(
                        new List<SpaceWhales>()),
                    1.0),
            });

        bool hasSegmentWithoutObstacles = false;

        bool hasSegmentWithObstacles = false;

        for (int i = 0; i < spaceRoute.GetSegmentsCount; i++)
        {
            if (!spaceRoute.GetCurrentSegment(i).SurroundingsType.Obstacles.Any())
            {
                hasSegmentWithoutObstacles = true;

                break;
            }

            hasSegmentWithObstacles = true;
        }

        Assert.True(hasSegmentWithObstacles);

        Assert.True(hasSegmentWithoutObstacles);
    }
}