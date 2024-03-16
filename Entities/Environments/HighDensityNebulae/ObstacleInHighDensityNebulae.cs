namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Environments.HighDensityNebulae;

public abstract class ObstacleInHighDensityNebulae : Obstacle
{
    protected ObstacleInHighDensityNebulae(int physCap = 0, int photonCap = 0, int enormCap = 0)
        : base(physCap: physCap, photonCap: photonCap, enormCap: enormCap)
    { }
}