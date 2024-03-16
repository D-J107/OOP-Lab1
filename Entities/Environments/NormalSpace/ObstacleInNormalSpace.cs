namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Environments.NormalSpace;

public abstract class ObstacleInNormalSpace : Obstacle
{
    protected ObstacleInNormalSpace(int physCap = 0, int photonCap = 0, int enormCap = 0)
        : base(physCap: physCap, photonCap: photonCap, enormCap: enormCap)
    { }
}