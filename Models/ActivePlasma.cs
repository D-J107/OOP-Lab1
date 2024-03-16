using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public struct ActivePlasma : IEquatable<ActivePlasma>
{
    public ActivePlasma(int amount)
    {
        Amount = amount;
    }

    public int Amount { get; private set; }

    public static bool operator ==(ActivePlasma left, ActivePlasma right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(ActivePlasma left, ActivePlasma right)
    {
        return !(left == right);
    }

    public static ActivePlasma operator +(ActivePlasma left, ActivePlasma right)
    {
        var activePlasma = new ActivePlasma(0);
        activePlasma.Amount = left.Amount + right.Amount;
        return activePlasma;
    }

    public static ActivePlasma operator *(ActivePlasma left, ActivePlasma right)
    {
        var activePlasma = new ActivePlasma(0);
        activePlasma.Amount = left.Amount * right.Amount;
        return activePlasma;
    }

    public static ActivePlasma operator *(ActivePlasma left, int right)
    {
        if (right < 0) throw new ArgumentException("Cant multiple negative value with Active plasma!");

        var activePlasma = new ActivePlasma(0);
        activePlasma.Amount = left.Amount * right;
        return activePlasma;
    }

    public static ActivePlasma Multiply(ActivePlasma left, ActivePlasma right)
    {
        return left * right;
    }

    public static ActivePlasma Add(ActivePlasma left, ActivePlasma right)
    {
        return left + right;
    }

    public void Spend(int value)
    {
        if (value < 0) throw new ArgumentException("Cant spend negative amount of Active Plasma!");

        Amount -= value;
    }

    public bool Equals(ActivePlasma other)
    {
        return Amount == other.Amount;
    }

    public override bool Equals(object? obj)
    {
        if (obj == null) return false;
        if (obj.GetType() != typeof(ActivePlasma)) return false;
        return Equals((ActivePlasma)obj);
    }

    public override int GetHashCode()
    {
        return Amount.GetHashCode() * 5;
    }

    public override string ToString() => $"{Amount}";
}