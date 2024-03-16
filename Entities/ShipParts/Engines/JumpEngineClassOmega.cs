using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.ShipParts.Engines;

public class JumpEngineClassOmega : JumpEngine
{
    public JumpEngineClassOmega()
        : base(jumpLen: 500)
    { }

    public override bool TryJumpInSubspaceChannel(int subspaceChannelLen)
    {
        if (subspaceChannelLen <= 0) throw new ArgumentException("Distance len must be positive!");

        int currentWastedTime = subspaceChannelLen / Speed;
        WastedTime += currentWastedTime;
        WastedGravityMatter += (int)Math.Round(currentWastedTime * Math.Log2(currentWastedTime), MidpointRounding.AwayFromZero);
        return JumpLen >= subspaceChannelLen;
    }
}