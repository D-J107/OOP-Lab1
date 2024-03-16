using System;
using Itmo.ObjectOrientedProgramming.Lab1.Services;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.PassResults;

public class Success : IPassageInformative
{
    public Success(int timeWasted, ActivePlasma activePlasmaWasted, GravityMatter gravityMatterWasted)
    {
        TimeWasted = timeWasted;
        ActivePlasmaWasted = activePlasmaWasted;
        GravityMatterWasted = gravityMatterWasted;
    }

    public Success()
    {
        TimeWasted = int.MaxValue;
        ActivePlasmaWasted = new ActivePlasma(int.MaxValue);
        GravityMatterWasted = new GravityMatter(int.MaxValue);
    }

    public int TimeWasted { get; init; }
    public ActivePlasma ActivePlasmaWasted { get; init; }
    public GravityMatter GravityMatterWasted { get; init; }

    public string GetInformation()
    {
        return $"""
                Ship successfully completed the route!
                Wasted time: {TimeWasted}
                Wasted active plasma: {ActivePlasmaWasted}
                Wasted gravity matter: {GravityMatterWasted}
                """ + '\n';
    }

    public bool BetterThan(Success other)
    {
        ArgumentNullException.ThrowIfNull(other);
        if (FuelsExchangeService.CountAllPrice(other.ActivePlasmaWasted, other.GravityMatterWasted)
            > FuelsExchangeService.CountAllPrice(ActivePlasmaWasted, GravityMatterWasted)) return true;
        return other.TimeWasted > TimeWasted;
    }
}