using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.ShipParts.Engines;

public class JumpEngineClassAlpha : JumpEngine
{
    public JumpEngineClassAlpha()
        : base(jumpLen: 200)
    { }

    public override bool TryJumpInSubspaceChannel(int subspaceChannelLen)
    {
        if (subspaceChannelLen <= 0) throw new ArgumentException("Distance len must be positive!");

        int currentWastedTime = subspaceChannelLen / Speed;
        WastedTime += currentWastedTime;
        WastedGravityMatter += GravityMatterUsagePerSecond * currentWastedTime;
        return JumpLen >= subspaceChannelLen;
    }
}