using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.ShipParts.Engines;

public abstract class ImpulseEngine
{
    protected ImpulseEngine(ActivePlasma activePlasmaUsagePerSecond)
    {
        ActivePlasmaUsagePerSecond = activePlasmaUsagePerSecond;
        WastedTime = 0;
    }

    public int WastedTime { get; protected set; }
    public ActivePlasma WastedActivePlasma { get; protected set; }
    protected ActivePlasma ActivePlasmaUsagePerSecond { get; init; }

    public abstract void OvercomeDistanceInNormalSpace(int distance);

    public abstract void OvercomeDistanceInNitrinParticleNebulae(int distance);
}