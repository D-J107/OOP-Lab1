using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Services;

public static class FuelsExchangeService
{
    public static int CountPriceForActivePlasma(ActivePlasma activePlasmaAmount)
    {
        return activePlasmaAmount.Amount * 2;
    }

    public static int CountPriceForGravityMatter(GravityMatter gravityMatterAmount)
    {
        return gravityMatterAmount.Amount * 3;
    }

    public static int CountAllPrice(ActivePlasma plasma, GravityMatter matter)
    {
        return (plasma.Amount * 2) + (matter.Amount * 3);
    }
}