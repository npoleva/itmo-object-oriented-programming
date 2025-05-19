using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab1.SpaceRoutes;
public class SpaceRoute
{
    private readonly List<RouteSegment> _segments;

    public SpaceRoute(IEnumerable<RouteSegment> segments)
    {
        _segments = new List<RouteSegment>(segments);
    }

    public int GetSegmentsCount => _segments.Count;

    public RouteSegment GetCurrentSegment(int index)
    {
        return _segments[index];
    }
}