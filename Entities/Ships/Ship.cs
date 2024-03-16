using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Environments;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Environments.HighDensityNebulae;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Environments.NitrinParticleNebulae;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Environments.NormalSpace;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.ShipParts.Corpus;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.ShipParts.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.ShipParts.Engines;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.ShipParts.OtherDevices;
using Itmo.ObjectOrientedProgramming.Lab1.Models;
using Itmo.ObjectOrientedProgramming.Lab1.Models.PassResults;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;

public abstract class Ship
{
    private ImpulseEngine _impulseEngine;
    private JumpEngine? _jumpEngine;

    private IList<IDamagable> _allDamagablesParts = new Collection<IDamagable>();
    protected Ship(
        ImpulseEngine impulseEngine,
        JumpEngine? jumpEngine,
        Corpus corpus,
        Deflector? deflector,
        AntiNitrinEmitter? antiNitrinEmitter)
    {
        _impulseEngine = impulseEngine;
        _jumpEngine = jumpEngine;
        if (antiNitrinEmitter is not null) _allDamagablesParts.Add(antiNitrinEmitter);
        if (deflector is not null) _allDamagablesParts.Add(deflector);
        _allDamagablesParts.Add(corpus);
    }

    public IPassageInformative FlyThoughtEnvironment(IEnvironment environment)
    {
        ArgumentNullException.ThrowIfNull(environment);

        foreach (Obstacle obstacle in environment.Obstacles)
        {
            bool survivedTheCrash = TryCrashWithObstacleByAllProtectiveParts(obstacle);
            if (survivedTheCrash) continue;
            return obstacle.DamageType() switch
            {
                CapabilityType.Physical => new DestroyedShip(),
                CapabilityType.Photon => new DeadCrew(),
                CapabilityType.Enormous => new DestroyedShip(),
                CapabilityType.None => throw new ArgumentException("Obstacle damage type cant be none"),
                _ => throw new ArgumentException("Obstacle damage type must be known!"),
            };
        }

        return ScanEnvironmentAndTryFlyItOptimally(environment);
    }

    public void AddPhotonModificationToDeflector()
    {
        _allDamagablesParts.Add(new PhotonDeflector());
    }

    private bool TryCrashWithObstacleByAllProtectiveParts(Obstacle obstacle)
    {
        bool lastSurvived = false;
        foreach (IDamagable damagable in _allDamagablesParts)
        {
            lastSurvived = damagable.TryCrashWithObstacle(obstacle);
            if (lastSurvived) return true;
        }

        return lastSurvived;
    }

    private IPassageInformative ScanEnvironmentAndTryFlyItOptimally(IEnvironment environment) => environment switch
    {
        NormalSpace space => FlyOverNormalSpace(space),
        HighDensityNebulae highDensityNebulae => FlyOverHighDensityNebulae(highDensityNebulae),
        NitrinParticleNebulae nitrinParticleNebulae => FlyOverNitrinParticleNebulae(nitrinParticleNebulae),
        _ => throw new ArgumentException("Error! unknown environment type!", nameof(environment)),
    };

    private IPassageInformative FlyOverNormalSpace(NormalSpace space)
    {
        _impulseEngine.OvercomeDistanceInNormalSpace(space.Distance);
        if (_jumpEngine == null)
        {
            return new Success(
                _impulseEngine.WastedTime,
                _impulseEngine.WastedActivePlasma,
                new GravityMatter(0));
        }

        return new Success(
            _impulseEngine.WastedTime + _jumpEngine.WastedTime,
            _impulseEngine.WastedActivePlasma,
            _jumpEngine.WastedGravityMatter);
    }

    private IPassageInformative FlyOverHighDensityNebulae(HighDensityNebulae nebulae)
    {
        if (_jumpEngine is null) return new LostInSubspaceChannel();
        bool successfullyJumped = _jumpEngine.TryJumpInSubspaceChannel(nebulae.Distance);
        if (!successfullyJumped) return new LostInSubspaceChannel();
        return new Success(
            _impulseEngine.WastedTime + _jumpEngine.WastedTime,
            _impulseEngine.WastedActivePlasma,
            _jumpEngine.WastedGravityMatter);
    }

    private IPassageInformative FlyOverNitrinParticleNebulae(NitrinParticleNebulae nebulae)
    {
        _impulseEngine.OvercomeDistanceInNitrinParticleNebulae(nebulae.Distance);

        if (_jumpEngine == null)
        {
            return new Success(
                _impulseEngine.WastedTime,
                _impulseEngine.WastedActivePlasma,
                new GravityMatter(0));
        }

        return new Success(
            _impulseEngine.WastedTime + _jumpEngine.WastedTime,
            _impulseEngine.WastedActivePlasma,
            _jumpEngine.WastedGravityMatter);
    }
}