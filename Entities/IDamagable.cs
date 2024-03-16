using Itmo.ObjectOrientedProgramming.Lab1.Entities.Environments;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;

public interface IDamagable
{
    public bool TryCrashWithObstacle(Obstacle obstacle);
}