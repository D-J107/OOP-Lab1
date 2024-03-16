using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public struct GravityMatter : IEquatable<GravityMatter>
{
    public GravityMatter(int value)
    {
        if (value < 0) throw new ArgumentException("Gravity matter value cant be negative!");
        Amount = value;
    }

    public int Amount { get; private set; }

    public static GravityMatter operator +(GravityMatter left, int right)
    {
        var output = new GravityMatter(0);
        output.Amount += left.Amount + right;
        return output;
    }

    public static GravityMatter operator +(GravityMatter left, GravityMatter right)
    {
        var output = new GravityMatter(0);
        output.Amount += left.Amount + right.Amount;
        return output;
    }

    public static GravityMatter operator *(GravityMatter left, int right)
    {
        var output = new GravityMatter(1);
        output.Amount *= left.Amount * right;
        return output;
    }

    public static GravityMatter operator *(GravityMatter left, GravityMatter right)
    {
        var output = new GravityMatter(1);
        output.Amount *= left.Amount * right.Amount;
        return output;
    }

    public static bool operator ==(GravityMatter left, GravityMatter right)
    {
        return left.Amount == right.Amount;
    }

    public static bool operator !=(GravityMatter left, GravityMatter right)
    {
        return !(left == right);
    }

    public static GravityMatter Multiply(GravityMatter left, GravityMatter right)
    {
        return left * right;
    }

    public static GravityMatter Add(GravityMatter left, GravityMatter right)
    {
        return left + right;
    }

    public bool Equals(GravityMatter other)
    {
        return Amount == other.Amount;
    }

    public override bool Equals(object? obj)
    {
        return obj is GravityMatter gm && Equals(gm);
    }

    public override int GetHashCode()
    {
        return Amount.GetHashCode() * 9;
    }

    public override string ToString() => $"{Amount}";
}
