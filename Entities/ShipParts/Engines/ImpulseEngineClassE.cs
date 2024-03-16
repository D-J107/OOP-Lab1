using System;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.ShipParts.Engines;

public class ImpulseEngineClassE : ImpulseEngine
{
    public ImpulseEngineClassE()
        : base(activePlasmaUsagePerSecond: new ActivePlasma(150))
    { }
    public override void OvercomeDistanceInNormalSpace(int distance)
    {
        if (distance <= 0) throw new ArgumentException("Distance len must be positive!");
        int currentWastedTime = (int)Math.Round(Math.Log(distance), MidpointRounding.AwayFromZero);
        WastedActivePlasma += ActivePlasmaUsagePerSecond * currentWastedTime;
        WastedTime += currentWastedTime;
    }

    public override void OvercomeDistanceInNitrinParticleNebulae(int distance)
    {
        OvercomeDistanceInNormalSpace(distance);
    }
}