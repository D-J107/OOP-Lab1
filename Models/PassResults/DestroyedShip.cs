namespace Itmo.ObjectOrientedProgramming.Lab1.Models.PassResults;

public class DestroyedShip : IPassageInformative
{
    public string GetInformation()
    {
        return "Ship is destroyed!" + '\n';
    }
}