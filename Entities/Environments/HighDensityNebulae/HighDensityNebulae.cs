using System;
using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Environments.HighDensityNebulae;

public sealed class HighDensityNebulae : IEnvironment
{
    public HighDensityNebulae(int distance, IReadOnlyCollection<ObstacleInHighDensityNebulae> obstacles)
    {
        if (distance <= 0) throw new ArgumentException("distance value must be positive", nameof(distance));
        Distance = distance;
        Obstacles = new List<Obstacle>(obstacles);
    }

    public IReadOnlyCollection<Obstacle> Obstacles { get; }
    public int Distance { get; }
}