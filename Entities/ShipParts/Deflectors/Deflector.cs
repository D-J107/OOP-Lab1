using System;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Environments;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.ShipParts.Deflectors;

public abstract class Deflector : IDamagable
{
    private Capability _capability;

    protected Deflector(int physCap = 0, int photonCap = 0, int enormCap = 0)
    {
        _capability = new Capability(
            physicalCapability: physCap,
            photonCapability: photonCap,
            enormousCapability: enormCap);
    }

    public bool TryCrashWithObstacle(Obstacle obstacle) => obstacle.DamageType() switch
    {
        CapabilityType.Physical => _capability.TryCrashWithPhysicalObject(obstacle.Capability),
        CapabilityType.Photon => _capability.TryCrashWithPhotonObject(obstacle.Capability),
        CapabilityType.Enormous => _capability.TryCrashWithEnormousObject(obstacle.Capability),
        CapabilityType.None => throw new ArgumentException("Obstacle type cant be none!"),
        _ => throw new ArgumentException("Obstacle type must be known!"),
    };
}