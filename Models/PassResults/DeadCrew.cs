namespace Itmo.ObjectOrientedProgramming.Lab1.Models.PassResults;

public class DeadCrew : IPassageInformative
{
    public string GetInformation()
    {
        return "The crew is dead, but ship is not harmed!" + '\n';
    }
}