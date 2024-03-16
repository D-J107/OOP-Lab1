using System;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Environments;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.ShipParts.OtherDevices;

public class AntiNitrinEmitter : IDamagable
{
    public bool TryCrashWithObstacle(Obstacle obstacle) => obstacle.DamageType() switch
    {
        CapabilityType.Physical => false,
        CapabilityType.Photon => false,
        CapabilityType.Enormous => true,
        CapabilityType.None => throw new ArgumentException("Obstacle type cant be none!"),
        _ => throw new ArgumentException("Obstacle type must be known!"),
    };
}