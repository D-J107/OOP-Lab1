namespace Itmo.ObjectOrientedProgramming.Lab1.Models.PassResults;

public class LostInSubspaceChannel : IPassageInformative
{
    public string GetInformation()
    {
        return $"Ship had lost in subspace channel of high density nebulae!" + '\n';
    }
}