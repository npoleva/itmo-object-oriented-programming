using Itmo.ObjectOrientedProgramming.Lab1.Surroundings;

namespace Itmo.ObjectOrientedProgramming.Lab1.SpaceRoutes;

public class RouteSegment
{
    public RouteSegment(Surrounding surroundingType, double length)
    {
        SurroundingsType = surroundingType;
        Length = length;
    }

    public Surrounding SurroundingsType { get; }
    public double Length { get; }
}