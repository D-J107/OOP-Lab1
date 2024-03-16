namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Environments.NitrinParticleNebulae;

public abstract class ObstacleInNitrinParticleNebulae : Obstacle
{
    protected ObstacleInNitrinParticleNebulae(int physCap = 0, int photonCap = 0, int enormCap = 0)
        : base(physCap: physCap, photonCap: photonCap, enormCap: enormCap)
    { }
}