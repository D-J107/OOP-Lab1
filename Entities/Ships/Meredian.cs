using Itmo.ObjectOrientedProgramming.Lab1.Entities.ShipParts.Corpus;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.ShipParts.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.ShipParts.Engines;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.ShipParts.OtherDevices;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;

public class Meredian : Ship
{
    public Meredian()
        : base(
            impulseEngine: new ImpulseEngineClassE(),
            jumpEngine: null,
            corpus: new CorpusClassII(),
            deflector: new DeflectorClassII(),
            antiNitrinEmitter: new AntiNitrinEmitter())
    { }
}