using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.ShipParts.Engines;

public abstract class JumpEngine
{
    protected JumpEngine(int jumpLen)
    {
        JumpLen = jumpLen;
        WastedTime = 0;
        Speed = 20;
        GravityMatterUsagePerSecond = new GravityMatter(50);
    }

    public int WastedTime { get; protected set; }
    public GravityMatter WastedGravityMatter { get; protected set; }
    protected GravityMatter GravityMatterUsagePerSecond { get; init; }

    protected int JumpLen { get; init; }

    protected int Speed { get; private init; }
    public abstract bool TryJumpInSubspaceChannel(int subspaceChannelLen);
}