using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Environments;

public sealed class CosmicPath : IEnumerable<IEnvironment>
{
    public CosmicPath(Collection<IEnvironment> environments)
    {
        Environments = environments;
    }

    public CosmicPath()
    {
        Environments = new Collection<IEnvironment>();
    }

    public Collection<IEnvironment> Environments { get; init; }

    public void Add(IEnvironment environment)
    {
        Environments.Add(environment);
    }

    public IEnumerator<IEnvironment> GetEnumerator()
    {
        return Environments.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}