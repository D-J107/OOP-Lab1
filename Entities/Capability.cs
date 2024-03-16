using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;

public enum CapabilityType
    {
        None = 0,
        Physical = 1,
        Photon = 2,
        Enormous = 3,
    }

public sealed class Capability
{
    private int _physicalCapability;
    private int _photonCapability;
    private int _enormousCapability;
    public Capability(int physicalCapability = 0, int photonCapability = 0, int enormousCapability = 0)
    {
        if (CheckArguments(physicalCapability, photonCapability, enormousCapability) is false)
        {
            throw new ArgumentException("Capability values cant be negative");
        }

        _physicalCapability += physicalCapability;
        _photonCapability += photonCapability;
        _enormousCapability += enormousCapability;

        if (physicalCapability > 0) Type = CapabilityType.Physical;
        if (photonCapability > 0) Type = CapabilityType.Photon;
        if (enormousCapability > 0) Type = CapabilityType.Enormous;
    }

    public CapabilityType Type { get; private set; }
    public bool IsPhysicalPartDestroyed { get; private set; }
    public bool IsPhotonPartDestroyed { get; private set; }
    public bool IsEnormousPartDestroyed { get; private set; }

    public void AddCapability(CapabilityType type, int value)
    {
        if (value < 0)
        {
            throw new ArgumentException("Capability value cant be negative!");
        }

        switch (type)
        {
            case CapabilityType.Physical:
                _physicalCapability += value;
                break;
            case CapabilityType.Photon:
                _photonCapability += value;
                break;
            case CapabilityType.Enormous:
                _enormousCapability += value;
                break;
            case CapabilityType.None:
                throw new ArgumentException("Capability type cant be none");
            default:
                throw new ArgumentException("Capability type must known");
        }
    }

    public bool TryCrashWithPhysicalObject(Capability other)
    {
        ArgumentNullException.ThrowIfNull(other);
        if (other._physicalCapability == 0)
            return true;

        int physicalDamageForBoth = Math.Min(other._physicalCapability, _physicalCapability);
        _physicalCapability -= physicalDamageForBoth;
        other._physicalCapability -= physicalDamageForBoth;

        if (_physicalCapability == 0)
        {
            IsPhysicalPartDestroyed = true;
            return false;
        }

        if (other._physicalCapability == 0)
            other.IsPhysicalPartDestroyed = true;
        return true;
    }

    public bool TryCrashWithPhotonObject(Capability other)
    {
        ArgumentNullException.ThrowIfNull(other);
        if (other._photonCapability == 0)
            return true;

        int photonDamageForBoth = Math.Min(other._photonCapability, _photonCapability);
        _photonCapability -= photonDamageForBoth;
        other._photonCapability -= photonDamageForBoth;

        if (_photonCapability == 0)
        {
            IsPhotonPartDestroyed = true;
            return false;
        }

        if (other._photonCapability == 0)
            other.IsPhotonPartDestroyed = true;
        return true;
    }

    public bool TryCrashWithEnormousObject(Capability other)
    {
        ArgumentNullException.ThrowIfNull(other);
        if (other._enormousCapability == 0)
            return true;

        int enormousDamageForBoth = Math.Min(other._enormousCapability, _enormousCapability);
        _enormousCapability -= enormousDamageForBoth;
        other._enormousCapability -= enormousDamageForBoth;

        if (_enormousCapability == 0)
        {
            IsEnormousPartDestroyed = true;
            return false;
        }

        if (other._enormousCapability == 0)
            other.IsEnormousPartDestroyed = true;
        return true;
    }

    private static bool CheckArguments(int physicalCapability, int photonCapability, int enormousCapability)
    {
        return physicalCapability >= 0 && photonCapability >= 0 && enormousCapability >= 0;
    }
}