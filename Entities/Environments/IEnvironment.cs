using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Environments;

public interface IEnvironment
{
    public IReadOnlyCollection<Obstacle> Obstacles { get; }
    public int Distance { get; }
}