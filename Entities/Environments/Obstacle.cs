namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Environments;

public abstract class Obstacle
{
    protected Obstacle(int physCap = 0, int photonCap = 0, int enormCap = 0)
    {
        Capability = new Capability(
            physicalCapability: physCap,
            photonCapability: photonCap,
            enormousCapability: enormCap);
    }

    public Capability Capability { get; }
    public CapabilityType DamageType() => Capability.Type;

    public bool IsPhysicalPartDestroyed() => Capability.IsPhysicalPartDestroyed;
    public bool IsPhotonPartDestroyed() => Capability.IsPhotonPartDestroyed;
    public bool IsEnormousPartDestroyed() => Capability.IsEnormousPartDestroyed;
}