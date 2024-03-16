using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.ShipParts.Engines;

public class JumpEngineClassGamma : JumpEngine
{
    public JumpEngineClassGamma()
        : base(jumpLen: 1000)
    { }

    public override bool TryJumpInSubspaceChannel(int subspaceChannelLen)
    {
        if (subspaceChannelLen <= 0) throw new ArgumentException("Distance len must be positive!");

        int currentWastedTime = subspaceChannelLen / Speed;
        WastedTime += currentWastedTime;
        WastedGravityMatter += GravityMatterUsagePerSecond * GravityMatterUsagePerSecond;
        return JumpLen >= subspaceChannelLen;
    }
}