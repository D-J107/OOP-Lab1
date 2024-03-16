using System;
using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Environments.NitrinParticleNebulae;

public sealed class NitrinParticleNebulae : IEnvironment
{
    public NitrinParticleNebulae(int distance, IReadOnlyCollection<ObstacleInNitrinParticleNebulae> obstacles)
    {
        if (distance <= 0) throw new ArgumentException("distance value must be positive", nameof(distance));
        Distance = distance;
        Obstacles = new List<Obstacle>(obstacles);
    }

    public IReadOnlyCollection<Obstacle> Obstacles { get; }
    public int Distance { get; }
}