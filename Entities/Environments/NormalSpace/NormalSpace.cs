using System;
using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Environments.NormalSpace;

public sealed class NormalSpace : IEnvironment
{
    public NormalSpace(int distance, IReadOnlyCollection<ObstacleInNormalSpace> obstacles)
    {
        if (distance <= 0) throw new ArgumentException("distance value must be positive", nameof(distance));
        Distance = distance;
        Obstacles = new List<Obstacle>(obstacles);
    }

    public IReadOnlyCollection<Obstacle> Obstacles { get; }
    public int Distance { get; }
}