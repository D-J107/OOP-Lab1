using System;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Environments;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;
using Itmo.ObjectOrientedProgramming.Lab1.Models.PassResults;

namespace Itmo.ObjectOrientedProgramming.Lab1.Services;

public static class ShipLaunchService
{
    public static IPassageInformative LaunchShipIntoCosmosPath(CosmicPath path, Ship ship)
    {
        ArgumentNullException.ThrowIfNull(path);
        ArgumentNullException.ThrowIfNull(ship);
        IPassageInformative lastEvent = new DestroyedShip();

        foreach (IEnvironment currentEnvironment in path.Environments)
        {
            lastEvent = ship.FlyThoughtEnvironment(currentEnvironment);
            if (lastEvent is not Success) return lastEvent;
        }

        return lastEvent;
    }

    public static Ship? FindOptimalShipInSomePath(CosmicPath path, Ship[] ships)
    {
        ArgumentNullException.ThrowIfNull(ships);
        var optimalSuccess = new Success();
        Ship? optimalShip = null;
        foreach (Ship currentShip in ships)
        {
            IPassageInformative currentSucceed = LaunchShipIntoCosmosPath(path, currentShip);
            if (currentSucceed is Success succeed && succeed.BetterThan(optimalSuccess))
            {
                optimalSuccess = succeed;
                optimalShip = currentShip;
            }
        }

        return optimalShip;
    }
}