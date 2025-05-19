using Itmo.ObjectOrientedProgramming.Lab1.Engines;
using Itmo.ObjectOrientedProgramming.Lab1.SpaceRoutes;
using Itmo.ObjectOrientedProgramming.Lab1.Surroundings;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships;

public static class ShipChecker
{
    internal static ShipSuitabilityRecord ShipSuitability(Ship ship, SpaceRoute? spaceRoute)
    {
        int shipTotal = 0;

        double shipFuelResult = 0;
        double shipTimeResult = 0;

        for (int i = 0; i < spaceRoute?.GetSegmentsCount; i++)
        {
            Surrounding surrounding =
                spaceRoute.GetCurrentSegment(i).SurroundingsType;

            double length = spaceRoute.GetCurrentSegment(i).Length;

            if (surrounding is NormalSpaceSurrounding)
            {
                foreach (Engine item in ship.Engines)
                {
                    shipFuelResult += item.GetCurrentFuelConsumption(length);

                    shipTimeResult += item.GetTime(length);

                    if (item is PulseEngineClassC or PulseEngineClassE)
                        shipTotal += 1;
                }
            }
            else if (surrounding is NebulaNitrineParticlesSurrounding)
            {
                foreach (Engine item in ship.Engines)
                {
                    shipFuelResult += item.GetCurrentFuelConsumption(length);

                    shipTimeResult += item.GetTime(length);

                    if (item is PulseEngineClassE)
                        shipTotal += 1;
                }

                shipTotal += ship.HasPhotonDeflectors ? 1 : 0;
            }
            else
            {
                foreach (Engine item in ship.Engines)
                {
                    shipFuelResult += item.GetCurrentFuelConsumption(length);

                    shipTimeResult += item.GetTime(length);

                    if (item is JumpEngineAlpha)
                        shipTotal += 1;
                    else if (item is JumpEngineOmega)
                        shipTotal += 2;
                    else if (item is JumpEngineGamma)
                        shipTotal += 3;
                }
            }
        }

        return new ShipSuitabilityRecord(shipTotal, shipFuelResult, shipTimeResult);
    }

    internal static ShipResultRecord TryRoute(Ship ship, SpaceRoute spaceRoute)
    {
        double timeResult = 0, fuelResult = 0;

        for (int i = 0; i < spaceRoute.GetSegmentsCount; i++)
        {
            RouteSegment temporarySegment = spaceRoute.GetCurrentSegment(i);

            double length = temporarySegment.Length;

            Surrounding surrounding = temporarySegment.SurroundingsType;

            if (surrounding is NormalSpaceSurrounding)
            {
                ShipResultRecord temporaryShipResultRecord
                    = NormalSpaceTryRoute(ship, length, surrounding);

                timeResult += temporaryShipResultRecord.TimeResult;
                fuelResult += temporaryShipResultRecord.FuelResult;

                if (temporaryShipResultRecord.Outcome != ShipOutcome.Success)
                    return new ShipResultRecord(temporaryShipResultRecord.Outcome, fuelResult, timeResult);
            }
            else if (surrounding is NebulaNitrineParticlesSurrounding)
            {
                ShipResultRecord temporaryShipResultRecord
                    = NebulaNitrineParticlesTryRoute(ship, length, surrounding);

                timeResult += temporaryShipResultRecord.TimeResult;
                fuelResult += temporaryShipResultRecord.FuelResult;

                if (temporaryShipResultRecord.Outcome != ShipOutcome.Success)
                    return new ShipResultRecord(temporaryShipResultRecord.Outcome, fuelResult, timeResult);
            }
            else if (surrounding is HighDensityNebulaSurrounding)
            {
                ShipResultRecord temporaryShipResultRecord
                    = HighDensityNebulaSurroundingTryRoute(ship, length, surrounding);

                timeResult += temporaryShipResultRecord.TimeResult;
                fuelResult += temporaryShipResultRecord.FuelResult;

                if (temporaryShipResultRecord.Outcome != ShipOutcome.Success)
                    return new ShipResultRecord(temporaryShipResultRecord.Outcome, fuelResult, timeResult);
            }
        }

        return new ShipResultRecord(ShipOutcome.Success, fuelResult, timeResult);
    }

    private static ShipResultRecord NormalSpaceTryRoute(
        Ship ship,
        double length,
        Surrounding inputSurrounding)
    {
        Surrounding surrounding = inputSurrounding;
        ship.Damaging(surrounding);

        if (ship.IsDestroyed)
            return new ShipResultRecord(ShipOutcome.ShipDestroyed, -1, -1);

        foreach (Engine item in ship.Engines)
        {
            if (item is PulseEngineClassC or PulseEngineClassE)
            {
                return new ShipResultRecord(
                    ShipOutcome.None,
                    item.GetCurrentFuelConsumption(length),
                    item.GetTime(length));
            }
        }

        return new ShipResultRecord(ShipOutcome.Success, -1, -1);
    }

    private static ShipResultRecord NebulaNitrineParticlesTryRoute(
        Ship ship,
        double length,
        Surrounding inputSurrounding)
    {
        Surrounding surrounding = inputSurrounding;
        ship.Damaging(surrounding);

        if (ship.IsDestroyed)
            return new ShipResultRecord(ShipOutcome.ShipDestroyed, -1, -1);

        double fuelResult = 0, timeResult = 0;

        foreach (Engine item in ship.Engines)
        {
            if (item is PulseEngineClassC)
            {
                fuelResult += item.GetCurrentFuelConsumption(length)
                              * EngineDefaultValues.PulseEngineCLassCNebulaNitrineParticlesSurroundingResistanceConstant;

                timeResult += item.GetTime(length)
                              * EngineDefaultValues.PulseEngineCLassCNebulaNitrineParticlesSurroundingResistanceConstant;
            }
            else if (item is PulseEngineClassE)
            {
                fuelResult += item.GetCurrentFuelConsumption(length);
                timeResult += item.GetTime(length);
            }
        }

        return new ShipResultRecord(ShipOutcome.Success, fuelResult, timeResult);
    }

    private static ShipResultRecord HighDensityNebulaSurroundingTryRoute(
        Ship ship, double length, Surrounding inputSurrounding)
    {
        Surrounding surrounding = inputSurrounding;

        ship.Damaging(surrounding);

        double timeResult = 0, fuelResult = 0;

        if (ship.CrewCasuality)
        {
            return new ShipResultRecord(ShipOutcome.CrewCasualty, -1, -1);
        }

        foreach (Engine item in ship.Engines)
        {
            double temporaryFuelResult = item.GetCurrentFuelConsumption(length);
            double temporaryTimeResult = item.GetTime(length);

            if (item is not (JumpEngineAlpha or JumpEngineGamma or JumpEngineOmega)) continue;

            if (item.TravelRangeViaSubspaceChannels < length)
            {
                return new ShipResultRecord(ShipOutcome.Lost, -1, -1);
            }

            fuelResult += item.GetCurrentFuelConsumption(length) - temporaryFuelResult;
            timeResult += item.GetTime(length) - temporaryTimeResult;
        }

        return new ShipResultRecord(ShipOutcome.Success, fuelResult, timeResult);
    }
}