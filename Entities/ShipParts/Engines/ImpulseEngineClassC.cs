using System;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.ShipParts.Engines;

public class ImpulseEngineClassC : ImpulseEngine
{
    private readonly int _speed;

    public ImpulseEngineClassC()
        : base(activePlasmaUsagePerSecond: new ActivePlasma(50))
    {
        _speed = 100;
    }

    public override void OvercomeDistanceInNormalSpace(int distance)
    {
        if (distance <= 0) throw new ArgumentException("Distance len must be positive!");
        int currentWastedTime = distance / _speed;
        WastedActivePlasma += ActivePlasmaUsagePerSecond * currentWastedTime;
        WastedTime += currentWastedTime;
    }

    public override void OvercomeDistanceInNitrinParticleNebulae(int distance)
    {
        if (distance <= 0) throw new ArgumentException("Distance len must be positive!");
        int currentWastedTime = distance / (_speed / 3);
        WastedActivePlasma += ActivePlasmaUsagePerSecond * currentWastedTime;
        WastedTime += currentWastedTime;
    }
}