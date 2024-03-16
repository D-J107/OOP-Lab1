namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Environments.NormalSpace;

public sealed class Asteroid : ObstacleInNormalSpace
{
    public Asteroid()
        : base(physCap: 400)
    { }
}